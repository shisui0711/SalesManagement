using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Product;

namespace QLCHWF.Presenters;

public class AddImportOrderPresenter : PaginationPresenter<Product>
{
    private readonly Dictionary<Product, int> _productOrdered = new Dictionary<Product, int>();
    private readonly IAddImportOrder _addImportOrder;
    private readonly IUnitOfWork _unitOfWork;

    public AddImportOrderPresenter(IUnitOfWork unitOfWork, IAddImportOrder addImportOrder) : base(addImportOrder,
        unitOfWork.Products, 6)
    {
        _unitOfWork = unitOfWork;
        _addImportOrder = addImportOrder;
        _addImportOrder.LoadProduct += delegate { RenewItems(); };
        _addImportOrder.RemoveProduct += RemoveProduct!;
        _addImportOrder.SearchProvider += delegate { SearchProvider(); };
        _addImportOrder.SearchProduct += delegate { SearchProduct(); };
        _addImportOrder.AddImportOrder += delegate { Add(); };
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
    public void SearchProduct(string? name = null)
    {
        SearchItems(x => x.ProductName == _addImportOrder.ProductSearchText);
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
}