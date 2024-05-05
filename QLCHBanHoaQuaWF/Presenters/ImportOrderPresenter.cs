
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.ImportOrder;
using QLCHBanHoaQuaWF.Views.Product;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class ImportOrderPresenter : PresenterCRUD
{
    private Dictionary<Product, int> productOrdered = new Dictionary<Product, int>();
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IAddImportOrder _addImportOrder;
    private readonly IReportImportOrder _report;
    private readonly IDetailImportOrder _detailImport;
    private readonly MyAppContext _context;
    public ImportOrderPresenter(IViewImportOrder viewImportOrder, IAddImportOrder addImportOrder, IReportImportOrder report, IDetailImportOrder detailImport, MyAppContext context)
    {
        _viewImportOrder = viewImportOrder;
        _addImportOrder = addImportOrder;
        _report = report;
        _detailImport = detailImport;
        _context = context;
        _context.ImportOrders.Load();

        _viewImportOrder.ShowAdd += delegate { ShowAddForm(); };
        _viewImportOrder.LoadImportOrder += delegate { Load(); };
        _viewImportOrder.RemoveImportOrder += delegate { Remove(); };
        _viewImportOrder.SearchImportOrder += delegate { Search(); };
        _viewImportOrder.ShowReport += delegate { ShowReport(); };
        _viewImportOrder.ShowDetail += delegate { ShowDetail(); };

        _addImportOrder.LoadProduct += delegate { LoadProduct(); };
        _addImportOrder.LoadProvider += delegate { LoadProvider(); };
        _addImportOrder.RemoveProduct += RemoveProduct;
        _addImportOrder.SearchProvider += delegate { SearchProvider(); };
        _addImportOrder.SearchProduct += delegate { LoadProduct(_addImportOrder.ProductSearchText); };
        _addImportOrder.AddImportOrder += delegate { Add(); };

        _report.LoadReport += delegate { LoadReport(); };

    }

    void ShowDetail()
    {
        if (_viewImportOrder.OrderBindingSource.Current == null)
        {
            MessageBox.Show("Chưa bản ghi nào được chọn");
            return;
        }
        ImportOrder curentOrder = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
        ImportOrder order = _context.ImportOrders.Include(o => o.DetailImportOrders).First(o => o.OrderID == curentOrder.OrderID);
        _detailImport.DetailOrderBindingSource.DataSource = order.DetailImportOrders.ToList();
        Form form = (Form)_detailImport;
        form.ShowDialog();
    }
    void LoadReport()
    {
        
        AppInfo info = _context.AppInfos.FirstOrDefault();
        if (info == null) { return; }
        ImportOrder current = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
        ImportOrder order = _context.ImportOrders.Find(current.OrderID);
        var orderData = (from s in _context.ImportOrders
                         join p in _context.Providers on s.ProviderID equals p.ProviderID
                         where s.OrderID == order.OrderID
                         select new
                         {
                             DateCreated = s.OrderDate,
                             OrderID = s.OrderID,
                             ProviderName = p.ProviderName,
                             TotalPrice = s.TotalPrice
                         }).FirstOrDefault();
        var orderFullData = new
        {
            DateCreated = orderData.DateCreated,
            AppName = info.AppName,
            AppAddress = info.Address,
            AppPhone = info.Phone,
            OrderID = orderData.OrderID,
            TotalPrice = orderData.TotalPrice.ToString("C0"),
            ProviderName = orderData.ProviderName
        };

        var detailData = from d in _context.DetailImportOrders
                         join p in _context.Products
                             on d.ProductID equals p.ProductID
                         where d.OrderID == order.OrderID
                         select new
                         {
                             ProductName = p.ProductName,
                             Quantity = d.Quantity,
                             UnitPrice = d.UnitPrice.ToString("C0"),
                             TotalPrice = d.TotalPrice.ToString("C0")
                         };
        _report.ReportViewer.LocalReport.ReportPath = "./Reports/ReportImportOrder.rdlc";
        ReportDataSource detailDataSource = new ReportDataSource();
        detailDataSource.Name = "DataSetDetailImportOrder";
        detailDataSource.Value = detailData;
        _report.ReportViewer.LocalReport.DataSources.Add(detailDataSource);
        foreach (var propertyInfo in orderFullData.GetType().GetProperties())
        {
            _report.ReportViewer.LocalReport.SetParameters(new ReportParameter(propertyInfo.Name, propertyInfo.GetValue(orderFullData).ToString()));
        }
        _report.ReportViewer.RefreshReport();
    }
    void ShowReport()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanPrintImportOrder == false)
        {
            MessageBox.Show("Bạn không có quyền này");
            return;
        }
        if (_viewImportOrder.OrderBindingSource.Current == null)
        {
            MessageBox.Show("Chưa bản ghi nào được chọn");
            return;
        }
        Form form = (Form)_report;
        if (form != null)
        {
            form.ShowDialog();
        }
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateImportOrder == false)
        {
            MessageBox.Show("Bạn không có quyền này");
            return;
        }
        var form = _addImportOrder as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }
    public override void Add()
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                ImportOrder importOrder = new ImportOrder();
                importOrder.Employee = _context.Employees.Where(e => e.Email == AuthPresenter.User.Email).FirstOrDefault();
                importOrder.Provider = _context.Providers.Find(_addImportOrder.ProviderID);
                importOrder.TotalPrice = _addImportOrder.TotalPrice;
                _context.ImportOrders.Add(importOrder);
                _context.SaveChanges();

                foreach (DataGridViewRow row in _addImportOrder.OrderedGridView.Rows)
                {
                    Product product = _context.Products.Find(row.Cells["ProductIDColumn"].Value)!;
                    DetailImportOrder detail = new DetailImportOrder();
                    detail.Product = product;
                    detail.ImportOrder = importOrder;
                    detail.UnitPrice = decimal.Parse(row.Cells["UnitPriceColumn"].Value.ToString());
                    detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString()!);
                    detail.OrderID = importOrder.OrderID;
                    _context.DetailImportOrders.Add(detail);
                    product.Inventory += detail.Quantity;
                }

                _context.SaveChanges();
                transaction.Commit();
                MessageBox.Show("Đặt hàng thành công");
                _viewImportOrder.OrderBindingSource.EndEdit();
            }
            catch (SqlException e)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi cơ sở dữ liệu. Đặt hàng thất bại");
            }
        }
    }

    public override void Update()
    {

    }

    public override void Remove()
    {
        ImportOrder? deleted = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
        if (deleted == null)
        {
            return;
        }
        var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Cancel)
        {
            return;
        }
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.ImportOrders.Remove(deleted);
                _context.SaveChanges();
                _viewImportOrder.OrderBindingSource.Remove(deleted);
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Search()
    {
        List<ImportOrder?>? importOrders = null;
        switch (_viewImportOrder.OptionIndex)
        {
            case 1:
                importOrders = _context.ImportOrders.Where(x => x != null && x.OrderID.ToString().Contains(_viewImportOrder.SearchText)).ToList();
                break;
            case 2:
                importOrders = _context.ImportOrders.Include(s => s!.Employee)
                    .Where(s => s.Employee.EmployeeName.Contains(_viewImportOrder.SearchText)).ToList()!;
                break;
            case 3:
                importOrders = _context.ImportOrders.Include(s => s.Provider)
                    .Where(s => s.Provider.ProviderName.Contains(_viewImportOrder.SearchText)).ToList();
                break;
        }

        if (importOrders != null)
        {
            importOrders = importOrders.FindAll(x =>
                x.OrderDate >= _viewImportOrder.DateStart && x.OrderDate <= _viewImportOrder.DateEnd);
            _viewImportOrder.OrderBindingSource.ResetBindings(true);
            _viewImportOrder.OrderBindingSource.DataSource = importOrders;
        }
        else
        {
            MessageBox.Show("Không tìm thấy bản ghi nào hợp lệ", "Thông báo");
        }
    }

    public override void Load()
    {
        _viewImportOrder.OrderBindingSource.ResetBindings(true);
        _viewImportOrder.OrderBindingSource.DataSource = _context.ImportOrders.Local.ToBindingList();
    }

    public void LoadProvider()
    {
        _addImportOrder.ProviderBindingSource.DataSource = _context.Providers.ToList();
    }

    public void LoadProduct(string? name = null)
    {
        _addImportOrder.ClearControl();
        if (name != null)
        {
            foreach (var product in _context.Products.Where(p => p.ProductName.Contains(name)).ToList())
            {
                frmProduct form = new frmProduct(product);
                form.Clicked += OrderProduct;
                form.TopLevel = false;
                _addImportOrder.AddControl(form);
                form.Show();
            }
        }
        else
        {
            foreach (var product in _context.Products.ToList())
            {
                frmProduct form = new frmProduct(product);
                form.Clicked += OrderProduct!;
                form.TopLevel = false;
                _addImportOrder.AddControl(form);
                form.Show();
            }
        }
    }
    public void OrderProduct(object sender, EventArgs e)
    {
        var formProduct = (frmProduct)sender;
        var product = formProduct.Product;
        if (productOrdered.ContainsKey(product))
        {
            var cells = _addImportOrder.OrderedGridView.Rows[productOrdered[product]].Cells;
            cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()) + 1;
            cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()) * int.Parse(cells["QuantityColumn"].Value.ToString());
        }
        else
        {
            _addImportOrder.OrderedGridView.Rows.Add(product.ProductName, product.ImportUnitPrice, 1, product.ImportUnitPrice, product.ProductID);
            productOrdered.Add(product, _addImportOrder.OrderedGridView.Rows.Count - 1);
        }
    }
    public void RemoveProduct(object sender, DataGridViewCellEventArgs e)
    {
        var product = productOrdered.Keys.ToList().Find(p => p.ProductID.ToString() == _addImportOrder.OrderedGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value.ToString());
        productOrdered.Remove(product);
        _addImportOrder.OrderedGridView.Rows.RemoveAt(e.RowIndex);
    }
    public void SearchProvider()
    {
        List<Provider>? providers = null;
        providers = _context.Providers.Where(p => p.ProviderName.Contains(_addImportOrder.ProviderSearchText))
            .ToList();
        if (providers != null)
        {
            _addImportOrder.ProviderBindingSource.DataSource = providers;
        }
        else
        {
            MessageBox.Show("Không có nhà cung cấp nào được tìm thấy", "Thông báo");
        }
    }
}