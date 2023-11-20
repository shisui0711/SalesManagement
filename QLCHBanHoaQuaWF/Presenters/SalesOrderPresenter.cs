using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;
using QLCHBanHoaQuaWF.Views.SalesOrder;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters
{
    public class SalesOrderPresenter: PresenterCRUD
    {
        private readonly IViewSalesOrder _viewSalesOrder;
        private readonly IAddSalesOrder _addSalesOrder;
        private readonly MyAppContext _context;
        private Dictionary<Product, int> productOrdered = new Dictionary<Product, int>();

        public SalesOrderPresenter(IViewSalesOrder viewSalesOrder, IAddSalesOrder addSalesOrder, MyAppContext context)
        {
            _viewSalesOrder = viewSalesOrder;
            _addSalesOrder = addSalesOrder;
            _context = context;

            _viewSalesOrder.ShowAdd += delegate { ShowAddFrom(); };
            _viewSalesOrder.RemoveSalesOrder += delegate { Remove(); };
            _viewSalesOrder.LoadSalesOrder += delegate { Load(); };
            _viewSalesOrder.SearchSalesOrder += delegate { Search(); };

            _addSalesOrder.RemoveProduct += RemoveProduct;
            _addSalesOrder.LoadCustomer += delegate { LoadCustomer(); };
            _addSalesOrder.LoadProduct += delegate { LoadProduct(); };
            _addSalesOrder.SearchCustomer += delegate { SearchCustomer(); };
            _addSalesOrder.SearchProduct += delegate { LoadProduct(_addSalesOrder.ProductSearchText); };
            _addSalesOrder.AddSalesOrder += delegate { Add(); };
        }

        public void ShowAddFrom()
        {
            var form = _addSalesOrder as Form;
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
                    SalesOrder salesOrder = new SalesOrder();
                    salesOrder.Employee = _context.Employees.Where(e=>e.Email == AuthPresenter.User.Email).FirstOrDefault();
                    salesOrder.Customer = _context.Customers.Find(_addSalesOrder.CustomerID);
                    salesOrder.TotalPrice = _addSalesOrder.TotalPrice;
                    _context.SalesOrders.Add(salesOrder);
                    _viewSalesOrder.OrderBindingSource.EndEdit();
                    _context.SaveChanges();

                    foreach (DataGridViewRow row in _addSalesOrder.OrderedGridView.Rows)
                    {
                        Product product = _context.Products.Find(row.Cells["ProductIDColumn"].Value);
                        DetailSalesOrder detail = new DetailSalesOrder();
                        detail.Product = product;
                        detail.UnitPrice = decimal.Parse(row.Cells["UnitPricePriceColumn"].Value.ToString());
                        detail.SalesOrder = salesOrder;
                        detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());
                        detail.TotalPrice = int.Parse(row.Cells["TotalPriceColumn"].Value.ToString());
                        detail.OrderID = salesOrder.OrderID;
                        _context.DetailSalesOrders.Add(detail);
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
            SalesOrder deleted = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
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
                    _context.SalesOrders.Remove(deleted);
                    _context.SaveChanges();
                    _viewSalesOrder.OrderBindingSource.Remove(deleted);
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
            List<SalesOrder> salesOrders = null;
            switch (_viewSalesOrder.OptionIndex)
            {
                case 1:
                    salesOrders = _context.SalesOrders.Where(x => x.OrderID.ToString().Contains(_viewSalesOrder.SearchText)).ToList();
                    break;
                case 2:
                    salesOrders = _context.SalesOrders.Include(s => s.Employee)
                        .Where(s => s.Employee.EmployeeName.Contains(_viewSalesOrder.SearchText)).ToList();
                    break;
                case 3:
                    salesOrders = _context.SalesOrders.Include(s => s.Customer)
                        .Where(s => s.Customer.CustomerName.Contains(_viewSalesOrder.SearchText)).ToList();
                    break;
            }

            if (salesOrders != null)
            {
                salesOrders = salesOrders.FindAll(x =>
                    x.OrderDate >= _viewSalesOrder.DateStart && x.OrderDate <= _viewSalesOrder.DateEnd);
                _viewSalesOrder.OrderBindingSource.ResetBindings(true);
                _viewSalesOrder.OrderBindingSource.DataSource = salesOrders;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi nào hợp lệ", "Thông báo");
            }
        }

        public override void Load()
        {
            _viewSalesOrder.OrderBindingSource.ResetBindings(true);
            _viewSalesOrder.OrderBindingSource.DataSource = _context.SalesOrders.Local.ToBindingList();
        }

        public void LoadCustomer()
        {
            _addSalesOrder.CustomerBindingSource.DataSource = _context.Customers.ToList();
        }

        public void LoadProduct(string name = null)
        {
            _addSalesOrder.ClearControl();
            if (name != null)
            {
                foreach (var product in _context.Products.Where(p=>p.ProductName.Contains(name)).ToList())
                {
                    frmProduct form = new frmProduct(product);
                    form.Clicked += OrderProduct;
                    form.TopLevel = false;
                    _addSalesOrder.AddControl(form);
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
                    _addSalesOrder.AddControl(form);
                    form.Show();
                }
            }
            
        }

        public void OrderProduct(object sender,EventArgs e)
        {
            var formProduct = (frmProduct)sender;
            var product = formProduct.Product;
            if (productOrdered.ContainsKey(product))
            {
                var cells = _addSalesOrder.OrderedGridView.Rows[productOrdered[product]].Cells;
                cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()) + 1;
                cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()) * int.Parse(cells["QuantityColumn"].Value.ToString());
            }
            else
            {
                _addSalesOrder.OrderedGridView.Rows.Add(product.ProductName, product.UnitPrice, 1, product.UnitPrice,product.ProductID);
                productOrdered.Add(product,_addSalesOrder.OrderedGridView.Rows.Count-1);
            }
        }

        public void RemoveProduct(object sender,DataGridViewCellEventArgs e)
        {
            var product = productOrdered.Keys.ToList().Find(p => p.ProductID.ToString() == _addSalesOrder.OrderedGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value.ToString());
            productOrdered.Remove(product);
            _addSalesOrder.OrderedGridView.Rows.RemoveAt(e.RowIndex);
        }

        public void SearchCustomer()
        {
            List<Customer> customers = null;
            customers = _context.Customers.Where(c => c.CustomerName.Contains(_addSalesOrder.CustomerSearchText))
                .ToList();
            if (customers != null)
            {
                _addSalesOrder.CustomerBindingSource.DataSource = customers;
            }
            else
            {
                MessageBox.Show("Không có khách hàng nào được tìm thấy", "Thông báo");
            }
        }
    }
}
