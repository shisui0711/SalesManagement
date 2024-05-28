using Microsoft.Reporting.WinForms;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Product;

namespace QLCHWF.Presenters;

public class ImportOrderPresenter : PaginationPresenter<Product>
{
    private readonly Dictionary<Product, int> _productOrdered = new Dictionary<Product, int>();
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IAddImportOrder _addImportOrder;
    private readonly IReportImportOrder _report;
    private readonly IDetailImportOrder _detailImport;
    private readonly IUnitOfWork _unitOfWork;
    public ImportOrderPresenter(IViewImportOrder viewImportOrder, IAddImportOrder addImportOrder, IReportImportOrder report, 
        IDetailImportOrder detailImport,IUnitOfWork unitOfWork):base(addImportOrder, unitOfWork.Products, 6)
    {
        _viewImportOrder = viewImportOrder;
        _addImportOrder = addImportOrder;
        _report = report;
        _detailImport = detailImport;
        _unitOfWork = unitOfWork;

        _viewImportOrder.ShowAdd += delegate { ShowAddForm(); };
        _viewImportOrder.LoadImportOrder += delegate { Load(); };
        _viewImportOrder.RemoveImportOrder += delegate { Remove(); };
        _viewImportOrder.SearchImportOrder += delegate { Search(); };
        _viewImportOrder.ShowReport += delegate { ShowReport(); };
        _viewImportOrder.ShowDetail += delegate { ShowDetail(); };

        _addImportOrder.LoadProduct += delegate{RenewItems();};
        _addImportOrder.LoadProvider += delegate { LoadProvider(); };
        _addImportOrder.RemoveProduct += RemoveProduct!;
        _addImportOrder.SearchProvider += delegate { SearchProvider(); };
        _addImportOrder.SearchProduct += delegate { SearchProduct(); };
        _addImportOrder.AddImportOrder += delegate { Add(); };

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
            List<OrderDetailData?> detailData = _unitOfWork.ImportOrders.GetOrderDetailData(current.OrderID);
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
        var form = _addImportOrder as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }
    public void Add()
    {
        try
        {
            if (_addImportOrder.OrderedGridView.RowCount == 0)
            {
                _addImportOrder.ShowMessage("Đơn hàng chưa có sản phẩm nào");
                return;
            }
            ImportOrder importOrder = new ImportOrder();
            importOrder.EmployeeID = _addImportOrder.EmployeeID;
            importOrder.ProviderID = _addImportOrder.ProviderID;
            importOrder.TotalPrice = _addImportOrder.TotalPrice;
            List<DetailImportOrder> detailImportOrders = new List<DetailImportOrder>();
            foreach (DataGridViewRow row in _addImportOrder.OrderedGridView.Rows)
            {
                Product product = _unitOfWork.Products.GetById(row.Cells["ProductIDColumn"].Value)!;
                DetailImportOrder detail = new DetailImportOrder();
                detail.Product = product;
                detail.ImportOrder = importOrder;
                detail.UnitPrice = decimal.Parse(row.Cells["UnitPriceColumn"].Value.ToString()!);
                detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString()!);
                detail.OrderID = importOrder.OrderID;
                detailImportOrders.Add(detail);
            }

            if (_unitOfWork.ImportOrders.AddOrder(importOrder, detailImportOrders))
            {
                _addImportOrder.ShowMessage(@"Đặt hàng thành công");
                _viewImportOrder.OrderBindingSource.EndEdit();
            }
            else
            {
                _addImportOrder.ShowMessage(@"Đặt hàng thất bại");
            }

        }
        catch
        {
            _addImportOrder.ShowMessage(@"Lỗi không xác địnhh: Đặt hàng thất bại");
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
            List<ImportOrder>? importOrders = null;
            switch (_viewImportOrder.OptionIndex)
            {
                case 0:
                    importOrders = _unitOfWork.ImportOrders.GetAll().ToList();
                    break;
                case 1:
                    importOrders = _unitOfWork.ImportOrders
                        .GetSome(x => x.OrderID.ToString().Equals(_viewImportOrder.SearchText)).ToList();
                    break;
                case 2:
                    importOrders = _unitOfWork.ImportOrders.GetOrdersInclue(o => o.Provider,
                            x => x.Provider != null && x.Provider.ProviderName.Contains(_viewImportOrder.SearchText))
                        .ToList();
                    break;
                case 3:
                    importOrders = _unitOfWork.ImportOrders.GetOrdersInclue(o => o.Employee,
                            x => x.Employee != null && x.Employee.EmployeeName.Contains(_viewImportOrder.SearchText))
                        .ToList();
                    break;
            }

            if (importOrders is { Count: > 0 })
            {
                if (_viewImportOrder.DateStart != DateTime.MinValue)
                {
                    importOrders = importOrders.FindAll(x =>
                        x.OrderDate >= _viewImportOrder.DateStart && x.OrderDate <= _viewImportOrder.DateEnd);
                }
                _viewImportOrder.OrderBindingSource.ResetBindings(true);
                _viewImportOrder.OrderBindingSource.DataSource = importOrders;
            }
            else
            {
                _viewImportOrder.ShowMessage("Không tìm thấy bản ghi nào hợp lệ");
            }
        }
        catch (Exception e)
        {
            _viewImportOrder.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Load()
    {
        _viewImportOrder.OrderBindingSource.ResetBindings(true);
        _viewImportOrder.OrderBindingSource.DataSource = _unitOfWork.ImportOrders.GetAll().ToList();
    }

    public void LoadProvider()
    {
        _addImportOrder.ProviderBindingSource.DataSource = _unitOfWork.Providers.GetAll().ToList();
    }

    public void SearchProduct(string? name = null)
    {
        ResetPage();
        _addImportOrder.CurrentPage = 0;
        TargetSource = _unitOfWork.Products.GetSome(x => x.ProductName == _addImportOrder.ProductSearchText).ToList();
        NextPage();
    }
    //public void LoadProduct(List<Product> products)
    //{
    //    _addImportOrder.ClearControl();
    //    foreach (var product in products)
    //    {
    //        frmProduct form = new frmProduct(product);
    //        form.Clicked += OrderProduct!;
    //        form.TopLevel = false;
    //        _addImportOrder.AddControl(form);
    //        form.Show();
    //    }
    //}
    public void OrderProduct(object? sender, EventArgs e)
    {
        var formProduct = (frmProduct)sender!;
        var product = formProduct.Product;
        if (_productOrdered.TryGetValue(product, out var value))
        {
            var cells = _addImportOrder.OrderedGridView.Rows[value].Cells;
            cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()!) + 1;
            cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * int.Parse(cells["QuantityColumn"].Value.ToString()!);
        }
        else
        {
            _addImportOrder.OrderedGridView.Rows.Add(product.ProductName, product.ImportUnitPrice, 1, product.ImportUnitPrice, product.ProductID);
            _productOrdered.Add(product, _addImportOrder.OrderedGridView.Rows.Count - 1);
        }
    }
    public void RemoveProduct(object sender, DataGridViewCellEventArgs e)
    {
        var product = _productOrdered.Keys.ToList().Find(p => p.ProductID.ToString() == _addImportOrder.OrderedGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value.ToString());
        if (product != null) _productOrdered.Remove(product);
        _addImportOrder.OrderedGridView.Rows.RemoveAt(e.RowIndex);
    }
    public void SearchProvider()
    {
        List<Provider> providers;
        providers = _unitOfWork.Providers.GetSome(p => p.ProviderName.Contains(_addImportOrder.ProviderSearchText))
            .ToList();
        _addImportOrder.ProviderBindingSource.DataSource = providers;
    }

    protected override void Load(List<Product> items)
    {
        _addImportOrder.ClearControl();
        foreach (var product in items)
        {
            frmProduct form = new frmProduct(product);
            form.Clicked += OrderProduct;
            form.TopLevel = false;
            _addImportOrder.AddControl(form);
            form.Show();
        }
    }

    //void NextPage()
    //{
    //    int totalItems = targetSource.Count;
    //    int totalPages = (int)Math.Ceiling((double)totalItems / 6);
    //    int currentPage = _addImportOrder.CurrentPage;
    //    List<Product> products = targetSource.Skip((currentPage) * 6).Take(6).ToList();
    //    LoadProduct(products);
    //    _addImportOrder.CurrentPage += 1;
    //    if (_addImportOrder.CurrentPage > 1)
    //    {
    //        _addImportOrder.EnablePreviousPage();
    //    }

    //    if (_addImportOrder.CurrentPage >= totalPages)
    //    {
    //        _addImportOrder.DisableNextPage();
    //    }
    //}

    //void PreviousPage()
    //{
    //    _addImportOrder.CurrentPage -= 1;
    //    int totalItems = targetSource.Count;
    //    int totalPages = (int)Math.Ceiling((double)totalItems / 6);
    //    int currentPage = _addImportOrder.CurrentPage;
    //    List<Product> products =targetSource.Skip((currentPage-1) * 6).Take(6).ToList();
    //    LoadProduct(products);
    //    if (_addImportOrder.CurrentPage <= 1)
    //    {
    //        _addImportOrder.DisablePreviousPage();
    //    }

    //    if (_addImportOrder.CurrentPage < totalPages)
    //    {
    //        _addImportOrder.EnableNextPage();
    //    }
        
    //}
}