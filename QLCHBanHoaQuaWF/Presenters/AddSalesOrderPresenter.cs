using QLCHWF.CustomMessageBox;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Product;
using QLCHWF.Views.SalesOrder;

namespace QLCHWF.Presenters;

public class AddSalesOrderPresenter : PaginationPresenter<Product>
{
    private readonly IAddSalesOrder _addSalesOrder;
    private readonly Dictionary<Product, int> _productOrdered;
    private readonly IUnitOfWork _unitOfWork;
    public AddSalesOrderPresenter(IAddSalesOrder addSalesOrder, IUnitOfWork unitOfWork):base(addSalesOrder,unitOfWork.Products,6)
    {
        _addSalesOrder = addSalesOrder;
        _unitOfWork = unitOfWork;
        _productOrdered = new Dictionary<Product, int>();

        _addSalesOrder.RemoveProduct += RemoveProduct;
        _addSalesOrder.LoadProduct += delegate {RenewItems();};
        _addSalesOrder.SearchCustomer += delegate { SearchCustomer(); };
        _addSalesOrder.SearchProduct += delegate { SearchProduct(); };
        _addSalesOrder.AddSalesOrder += delegate { Add(); };
    }
    public void RemoveProduct(object? sender, DataGridViewCellEventArgs e)
    {
        var product = _productOrdered.Keys.ToList().Find(p => p.ProductID.ToString() == _addSalesOrder.OrderedGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value.ToString());
        _productOrdered.Remove(product!);
        _addSalesOrder.OrderedGridView.Rows.RemoveAt(e.RowIndex);
    }
    public void SearchCustomer()
    {
        var customers = _unitOfWork.Customers.GetSome(c => c.CustomerName.Contains(_addSalesOrder.CustomerSearchText))
            .ToList();
        _addSalesOrder.CustomerBindingSource.DataSource = customers;
    }
    void SearchProduct()
    {
        SearchItems(x => x.ProductName.Contains(_addSalesOrder.ProductSearchText));
    }
    public void Add()
    {
        try
        {
            if (_addSalesOrder.OrderedGridView.RowCount == 0)
            {
                _addSalesOrder.ShowMessage("Đơn hàng chưa có sản phẩm nào");
                return;
            }

            SalesOrder salesOrder = new SalesOrder();
            salesOrder.EmployeeID = _addSalesOrder.EmployeeID;
            salesOrder.CustomerID = _addSalesOrder.CustomerID;
            salesOrder.PurchasePrice = _addSalesOrder.PurchasePrice;
            salesOrder.ChangePrice = _addSalesOrder.ChangePrice;
            salesOrder.TotalPrice = _addSalesOrder.TotalPrice;
            if (salesOrder.PurchasePrice < salesOrder.TotalPrice)
            {
                var result = MyMessageBox.Show("Khách chưa trả đủ tiển có muốn tiếp tục ?", "Thông báo",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            List<DetailSalesOrder> detailSalesOrders = new List<DetailSalesOrder>();
            foreach (DataGridViewRow row in _addSalesOrder.OrderedGridView.Rows)
            {
                Product product = _unitOfWork.Products.GetById(row.Cells["ProductIDColumn"].Value);
                if (product == null)
                {
                    _addSalesOrder.ShowMessage("Các mặt hàng đã chọn không còn tồn tại");
                    return;
                }
                DetailSalesOrder detail = new DetailSalesOrder();
                detail.ProductID = product.ProductID;
                detail.UnitPrice = decimal.Parse(row.Cells["UnitPriceColumn"].Value.ToString()!);
                detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString()!);
                if (detail.Quantity > product.Inventory)
                {
                    _addSalesOrder.ShowMessage($@"Số lượng trong kho không đủ cho sản phẩm: {product.ProductName}");
                    return;
                }

                detail.OrderID = salesOrder.OrderID;
                detailSalesOrders.Add(detail);
            }

            if (_unitOfWork.SalesOrders.AddOrder(salesOrder, detailSalesOrders))
            {
                _addSalesOrder.ShowMessage("Tạo đơn hàng thành công");
            }
            else
            {
                _addSalesOrder.ShowMessage("Tạo đơn hàng thất bại");
            }

        }
        catch (Exception)
        {
            _addSalesOrder.ShowMessage(@"Lỗi không xác định: Thanh toán thất bại");
        }

    }
    protected override void Load(List<Product> items)
    {
        _addSalesOrder.ClearControl();
        foreach (var product in items)
        {
            frmProduct form = new frmProduct(product);
            form.Clicked += OrderProduct;
            form.TopLevel = false;
            _addSalesOrder.AddControl(form);
            form.Show();
        }
    }
    public void OrderProduct(object? sender, EventArgs e)
    {
        var formProduct = (frmProduct)sender!;
        var product = formProduct.Product;
        if (_productOrdered.TryGetValue(product, out var value))
        {
            var cells = _addSalesOrder.OrderedGridView.Rows[value].Cells;
            cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()!) + 1;
            cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * int.Parse(cells["QuantityColumn"].Value.ToString()!);
        }
        else
        {
            _addSalesOrder.OrderedGridView.Rows.Add(product.ProductName, product.UnitPrice, 1, product.UnitPrice, product.ProductID);
            _productOrdered.Add(product, _addSalesOrder.OrderedGridView.Rows.Count - 1);
        }
    }
}