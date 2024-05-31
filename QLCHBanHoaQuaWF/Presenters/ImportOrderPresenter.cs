using Microsoft.Extensions.DependencyInjection;
using Microsoft.Reporting.WinForms;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.ImportOrder;

namespace QLCHWF.Presenters;

public class ImportOrderPresenter : PaginationPresenter<ImportOrder>
{
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IAddImportOrder _addImportOrder;
    private readonly IReportImportOrder _report;
    private readonly IDetailImportOrder _detailImport;
    private readonly IUnitOfWork _unitOfWork;
    public ImportOrderPresenter(IViewImportOrder viewImportOrder, IAddImportOrder addImportOrder, IReportImportOrder report, 
        IDetailImportOrder detailImport,IUnitOfWork unitOfWork) : base(viewImportOrder,unitOfWork.ImportOrders,18)
    {
        _viewImportOrder = viewImportOrder;
        _addImportOrder = addImportOrder;
        _report = report;
        _detailImport = detailImport;
        _unitOfWork = unitOfWork;

        _viewImportOrder.ShowAdd += delegate { ShowAddForm(); };
        _viewImportOrder.LoadImportOrder += delegate { RenewItems(); };
        _viewImportOrder.RemoveImportOrder += delegate { Remove(); };
        _viewImportOrder.SearchImportOrder += delegate { Search(); };
        _viewImportOrder.ShowReport += delegate { ShowReport(); };
        _viewImportOrder.ShowDetail += delegate { ShowDetail(); };

        _report.LoadReport += delegate { LoadReport(); };

    }

    void ShowDetail()
    {
        if (_viewImportOrder.OrderBindingSource.Current == null)
        {
            _viewImportOrder.ShowMessage(@"Chưa bản ghi nào được chọn");
            return;
        }
        ImportOrder curentOrder = (_viewImportOrder.OrderBindingSource.Current as ImportOrder)!;
        ImportOrder? order = _unitOfWork.ImportOrders.GetOrderWithDetail(curentOrder.OrderID);
        if (order == null)
        {
            _viewImportOrder.ShowMessage("Đơn hàng đã chọn không tồn tại");
            return;
        }
        _detailImport.DetailOrderBindingSource.DataSource = order.DetailImportOrders.ToList();
        Form form = (Form)_detailImport;
        form.ShowDialog();
    }
    void LoadReport()
    {
        try
        {
            AppInfo? info = _unitOfWork.AppInfos.GetAll().FirstOrDefault();
            if (info == null)
            {
                return;
            }

            ImportOrder? current = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
            if (current == null)
            {
                _viewImportOrder.ShowMessage("Không tìm thấy đơn hàng nhập được chọn");
                return;
            }
            OrderImportData? orderData = _unitOfWork.ImportOrders.GetOrderData(current.OrderID);
            List<OrderDetailData> detailData = _unitOfWork.ImportOrders.GetOrderDetailData(current.OrderID);
            if (orderData == null)
            {
                _viewImportOrder.ShowMessage("Đơn hàng đã chọn không còn tồn tại");
                return;
            }
            var orderFullData = new
            {
                orderData.DateCreated,
                info.AppName,
                AppAddress = info.Address,
                AppPhone = info.Phone,
                orderData.OrderID,
                TotalPrice = orderData.TotalPrice.ToString("C0"),
                orderData.ProviderName
            };
            _report.ReportViewer.LocalReport.ReportPath = "./Reports/ReportImportOrder.rdlc";
            ReportDataSource detailDataSource = new ReportDataSource();
            detailDataSource.Name = "DataSetDetailImportOrder";
            detailDataSource.Value = detailData;
            _report.ReportViewer.LocalReport.DataSources.Add(detailDataSource);
            foreach (var propertyInfo in orderFullData.GetType().GetProperties())
            {
                _report.ReportViewer.LocalReport.SetParameters(new ReportParameter(propertyInfo.Name,
                    propertyInfo.GetValue(orderFullData)?.ToString()));
            }
            _report.ReportViewer.RefreshReport();
        }
        catch (Exception e)
        {
            _viewImportOrder.ShowMessage($"Lỗi: {e.Message}");
        }
    }
    void ShowReport()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanPrintImportOrder == false)
        {
            _viewImportOrder.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        if (_viewImportOrder.OrderBindingSource.Current == null)
        {
            _viewImportOrder.ShowMessage(@"Chưa bản ghi nào được chọn");
            return;
        }
        Form form = (Form)_report;
        form.ShowDialog();
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateImportOrder == false)
        {
            _viewImportOrder.ShowMessage(@"Bạn không có quyền này");
            return;
        }

        Program.MyHost.Services.GetRequiredService<AddImportOrderPresenter>();
        var form = _addImportOrder as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    public void Remove()
    {
        try
        {
            ImportOrder? deleted = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
            if (deleted == null)
            {
                _viewImportOrder.ShowMessage("Không tìm thầy bàn ghi đã chọn");
                return;
            }

            if (_unitOfWork.ImportOrders.Remove(deleted))
            {
                _viewImportOrder.OrderBindingSource.Remove(deleted);
                _viewImportOrder.ShowMessage("Xóa thành công");
            }
            else
            {
                _viewImportOrder.ShowMessage($"Xóa thất bại");
            }
        }
        catch (Exception e)
        {
            _viewImportOrder.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Search()
    {
        try
        {
            switch (_viewImportOrder.OptionIndex)
            {
                case 0:
                    if (_viewImportOrder.DateStart != DateTime.MinValue)
                    {
                       SearchItems(x =>
                            x.OrderDate >= _viewImportOrder.DateStart && x.OrderDate <= _viewImportOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x=>true);
                    }
                    break;
                case 1:
                    if (_viewImportOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(x =>
                            x.OrderID.ToString().Equals(_viewImportOrder.SearchText) &&
                            x.OrderDate >= _viewImportOrder.DateEnd && x.OrderDate <= _viewImportOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x => x.OrderID.ToString().Equals(_viewImportOrder.SearchText));
                    }
                   
                    break;
                case 2:
                    if (_viewImportOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(x =>
                            x.Provider != null && x.Provider.ProviderName.Contains(_viewImportOrder.SearchText) &&
                            x.OrderDate >= _viewImportOrder.DateEnd && x.OrderDate <= _viewImportOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x => x.Provider != null && x.Provider.ProviderName.Contains(_viewImportOrder.SearchText));
                    }
                    
                    break;
                case 3:
                    if (_viewImportOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(x =>
                            x.Employee != null && x.Employee.EmployeeName.Contains(_viewImportOrder.SearchText) &&
                            x.OrderDate >= _viewImportOrder.DateEnd && x.OrderDate <= _viewImportOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x => x.Employee != null && x.Employee.EmployeeName.Contains(_viewImportOrder.SearchText));
                    }
                    
                    break;
            }
        }
        catch (Exception e)
        {
            _viewImportOrder.ShowMessage($"Lỗi: {e.Message}");
        }
    }


    protected override void Load(List<ImportOrder> items)
    {
        _viewImportOrder.OrderBindingSource.ResetBindings(true);
        _viewImportOrder.OrderBindingSource.DataSource = items;
    }
}