using Microsoft.Extensions.DependencyInjection;
using Microsoft.Reporting.WinForms;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.SalesOrder;

namespace QLCHWF.Presenters
{
    public class SalesOrderPresenter : PaginationPresenter<SalesOrder>
    {
        private readonly IViewSalesOrder _viewSalesOrder;
        private readonly IAddSalesOrder _addSalesOrder;
        private readonly IReportSalesOrder _report;
        private readonly IDetailSalesOrder _detailSales;
        private readonly IUnitOfWork _unitOfWork;

        public SalesOrderPresenter(IViewSalesOrder viewSalesOrder, IAddSalesOrder addSalesOrder,
            IReportSalesOrder report, IDetailSalesOrder detailSales, IUnitOfWork unitOfWork) : base(viewSalesOrder,
            unitOfWork.SalesOrders, 18)
        {
            _viewSalesOrder = viewSalesOrder;
            _addSalesOrder = addSalesOrder;
            _report = report;
            _detailSales = detailSales;
            _unitOfWork = unitOfWork;

            #region Handler Event for ViewSalesOrder
            _viewSalesOrder.ShowAdd += delegate { ShowAddFrom(); };
            _viewSalesOrder.RemoveSalesOrder += delegate { Remove(); };
            _viewSalesOrder.LoadSalesOrder += delegate { RenewItems(); };
            _viewSalesOrder.SearchSalesOrder += delegate { Search(); };
            _viewSalesOrder.ShowReport += delegate { ShowReport(); };
            _viewSalesOrder.ShowDetail += delegate { ShowDetail(); };
            #endregion

            #region Handler Event for Report

            _report.LoadReport += delegate { LoadReport(); };

            #endregion
        }

        void ShowDetail()
        {
            if (_viewSalesOrder.OrderBindingSource.Current == null)
            {
                _viewSalesOrder.ShowMessage(@"Chưa bản ghi nào được chọn");
                return;
            }
            SalesOrder? curentOrder = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            if (curentOrder == null)
            {
                _viewSalesOrder.ShowMessage("Không tìm thấy đơn hàng được chọn");
                return;
            }
            SalesOrder? order = _unitOfWork.SalesOrders.GetOrderWithDetail(curentOrder.OrderID);
            if (order == null)
            {
                _viewSalesOrder.ShowMessage("Đơn hàng đã chọn không tồn tại");
                return;
            }
            _detailSales.DetailOrderBindingSource.DataSource = order.DetailSalesOrders.ToList();
            Form form = (Form)_detailSales;
            form.ShowDialog();
        }
        void LoadReport()
        {
            AppInfo? info = _unitOfWork.AppInfos.GetAll().FirstOrDefault();
            if (info == null) { return; }
            SalesOrder? current = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            if (current == null)
            {
                _viewSalesOrder.ShowMessage("Không tìm thấy đơn hàng được chọn");
                return;
            }
            OrderData? orderData = _unitOfWork.SalesOrders.GetOrderData(current.OrderID);
            List<OrderDetailData> detailData = _unitOfWork.SalesOrders.GetOrderDetailData(current.OrderID);
            if (orderData == null)
            {
                _viewSalesOrder.ShowMessage("Đơn hàng đã chọn không tồn tại");
                return;
            }

            var orderFullData = new
            {
                DateCreated = orderData.DateCreated.ToString("dd/MM/yyyy"),
                info.AppName,
                AppAddress = info.Address,
                AppPhone = info.Phone,
                orderData.OrderID,
                orderData.CustomerName,
                orderData.CustomerPhone,
                orderData.CustomerAddress,
                TotalPrice = orderData.TotalPrice.ToString("C0"),
                PurchasePrice = orderData.PurchasePrice.ToString("C0"),
                ChangePrice = orderData.ChangePrice.ToString("C0")
            };
            _report.ReportViewer.LocalReport.ReportPath = "./Reports/ReportSalesOrder.rdlc";
            ReportDataSource detailDataSource = new ReportDataSource();
            detailDataSource.Name = "DataSetDetailSalesOrder";
            detailDataSource.Value = detailData;
            _report.ReportViewer.LocalReport.DataSources.Add(detailDataSource);
            foreach (var propertyInfo in orderFullData.GetType().GetProperties())
            {
                _report.ReportViewer.LocalReport.SetParameters(new ReportParameter(propertyInfo.Name,
                    propertyInfo.GetValue(orderFullData)?.ToString()));
            }
            _report.ReportViewer.RefreshReport();

        }
        void ShowReport()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanPrintSalesOrder == false)
            {
                _viewSalesOrder.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            if (_viewSalesOrder.OrderBindingSource.Current == null)
            {
                _viewSalesOrder.ShowMessage(@"Chưa bản ghi nào được chọn");
                return;
            }
            var form = _report as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowAddFrom()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateSalesOrder == false)
            {
                _viewSalesOrder.ShowMessage(@"Bạn không có quyền này");
                return;
            }

            Program.MyHost.Services.GetRequiredService<AddSalesOrderPresenter>();
            var addSalesOrderForm = _addSalesOrder as Form;
            if (addSalesOrderForm != null)
            {
                addSalesOrderForm.ShowDialog();
            }
        }

        public void Remove()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteSalesOrder == false)
            {
                _viewSalesOrder.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            var deleted = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            if (deleted == null)
            {
                _viewSalesOrder.ShowMessage(@"Chưa có đơn hàng nào được chọn");
                return;
            }

            if (_unitOfWork.SalesOrders.Remove(deleted))
            {
                _viewSalesOrder.ShowMessage("Xóa thành công");
            }
            else
            {
                _viewSalesOrder.ShowMessage("Xóa thất bại");
            }
        }

        public void Search()
        {
            switch (_viewSalesOrder.OptionIndex)
            {
                case 0:
                    if (_viewSalesOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(x =>
                            x.OrderDate >= _viewSalesOrder.DateStart && x.OrderDate <= _viewSalesOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x=>true);
                    }
                    break;
                case 1:
                    if (_viewSalesOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(x =>
                            x.OrderID.ToString() == (_viewSalesOrder.SearchText) &&
                            x.OrderDate >= _viewSalesOrder.DateStart && x.OrderDate <= _viewSalesOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(x => x.OrderID.ToString() == (_viewSalesOrder.SearchText));
                    }
                    break;
                case 2:
                    if (_viewSalesOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(s =>
                            s.Employee != null && s.Employee.EmployeeName.Contains(_viewSalesOrder.SearchText) &&
                            s.OrderDate >= _viewSalesOrder.DateStart && s.OrderDate <= _viewSalesOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(s =>
                            s.Employee != null && s.Employee.EmployeeName.Contains(_viewSalesOrder.SearchText));
                    }
                    break;
                case 3:
                    if (_viewSalesOrder.DateStart != DateTime.MinValue)
                    {
                        SearchItems(s =>
                            s.Customer != null && s.Customer.CustomerName.Contains(_viewSalesOrder.SearchText) &&
                            s.OrderDate >= _viewSalesOrder.DateStart && s.OrderDate <= _viewSalesOrder.DateEnd);
                    }
                    else
                    {
                        SearchItems(s =>
                            s.Customer != null && s.Customer.CustomerName.Contains(_viewSalesOrder.SearchText));
                    }
                    
                    break;
            }
        }

        protected override void Load(List<SalesOrder> items)
        {
            _viewSalesOrder.OrderBindingSource.ResetBindings(true);
            _viewSalesOrder.OrderBindingSource.DataSource = items;
        }
    }
}
