using Microsoft.EntityFrameworkCore;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.ImportOrder;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.SalesOrder;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class ImportOrderPresenter:PresenterCRUD
{
    private Dictionary<Product, int> productOrdered = new Dictionary<Product, int>();
    private readonly IViewImportOrder _viewImportOrder;
    private readonly IAddImportOrder _addImportOrder;
    private readonly MyAppContext _context;
    public ImportOrderPresenter(IViewImportOrder viewImportOrder,IAddImportOrder addImportOrder,MyAppContext context)
    {
        _viewImportOrder = viewImportOrder;
        _addImportOrder = addImportOrder;
        _context = context;

        _viewImportOrder.ShowAdd += delegate { ShowAddForm(); };
        _viewImportOrder.LoadImportOrder += delegate { Load(); };
        _viewImportOrder.RemoveImportOrder += delegate { Remove(); };
        _viewImportOrder.SearchImportOrder += delegate { Search(); };

        _addImportOrder.LoadProduct += delegate{LoadProduct();};
        _addImportOrder.LoadProvider += delegate { LoadProvider(); };
        _addImportOrder.RemoveProduct += RemoveProduct;
        _addImportOrder.SearchProvider += delegate { SearchProvider(); };
        _addImportOrder.SearchProduct += delegate { LoadProduct(_addImportOrder.ProductSearchText); };
        _addImportOrder.AddSalesOrder += delegate { Add(); };


    }

    public void ShowAddForm()
    {
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
                _viewImportOrder.OrderBindingSource.EndEdit();
                _context.SaveChanges();

                foreach (DataGridViewRow row in _addImportOrder.OrderedGridView.Rows)
                {
                    Product product = _context.Products.Find(row.Cells["ProductIDColumn"].Value);
                    DetailImportOrder detail = new DetailImportOrder();
                    detail.Product = product;
                    detail.UnitPrice = decimal.Parse(row.Cells["UnitPricePriceColumn"].Value.ToString());
                    detail.ImportOrder = importOrder;
                    detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());
                    detail.TotalPrice = int.Parse(row.Cells["TotalPriceColumn"].Value.ToString());
                    detail.OrderID = importOrder.OrderID;
                    _context.DetailImportOrders.Add(detail);
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Update()
    {

    }

    public override void Remove()
    {
        ImportOrder deleted = _viewImportOrder.OrderBindingSource.Current as ImportOrder;
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
        List<ImportOrder> importOrders = null;
        switch (_viewImportOrder.OptionIndex)
        {
            case 1:
                importOrders = _context.ImportOrders.Where(x => x.OrderID.ToString().Contains(_viewImportOrder.SearchText)).ToList();
                break;
            case 2:
                importOrders = _context.ImportOrders.Include(s => s.Employee)
                    .Where(s => s.Employee.EmployeeName.Contains(_viewImportOrder.SearchText)).ToList();
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

    public void LoadProduct(string name = null)
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
                form.Clicked += OrderProduct;
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
        List<Provider> providers = null;
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