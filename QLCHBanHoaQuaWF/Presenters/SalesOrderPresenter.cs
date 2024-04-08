using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.ImportOrder;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.SalesOrder;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters
{
    public class SalesOrderPresenter
    {
        private readonly IViewSalesOrder _viewSalesOrder;
        private readonly IAddSalesOrder _addSalesOrder;
        private readonly IReportSalesOrder _report;
        private readonly IDetailSalesOrder _detailSales;
        private readonly IViewMain _viewMain;
        private readonly MyAppContext _context;
        private Dictionary<Product, int> productOrdered;

        public SalesOrderPresenter(IViewSalesOrder viewSalesOrder, IAddSalesOrder addSalesOrder, IReportSalesOrder report, IDetailSalesOrder detailSales, IViewMain viewMain, MyAppContext context)
        {
            productOrdered = new Dictionary<Product, int>();
            _viewMain = viewMain;
            _viewSalesOrder = viewSalesOrder;
            _addSalesOrder = addSalesOrder;
            _report = report;
            _detailSales = detailSales;
            _context = context;
            _context.SalesOrders.Load();

            _viewSalesOrder.ShowAdd += delegate { ShowAddFrom(); };
            _viewSalesOrder.RemoveSalesOrder += delegate { Remove(); };
            _viewSalesOrder.LoadSalesOrder += delegate { Load(); };
            _viewSalesOrder.SearchSalesOrder += delegate { Search(); };
            _viewSalesOrder.ShowReport += delegate { ShowReport(); };
            _viewSalesOrder.ShowDetail += delegate { ShowDetail(); };

            _addSalesOrder.RemoveProduct += RemoveProduct;
            _addSalesOrder.LoadCustomer += delegate { LoadCustomer(); };
            _addSalesOrder.LoadProduct += delegate { LoadProduct(); };
            _addSalesOrder.SearchCustomer += delegate { SearchCustomer(); };
            _addSalesOrder.SearchProduct += delegate { LoadProduct(); };
            _addSalesOrder.AddSalesOrder += delegate { Add(); };

            _report.LoadReport += delegate { LoadReport(); };
        }

        void ShowDetail()
        {
            if (_viewSalesOrder.OrderBindingSource.Current == null)
            {
                MessageBox.Show("Chưa bản ghi nào được chọn");
                return;
            }
            SalesOrder curentOrder = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            SalesOrder order = _context.SalesOrders.Include(o => o.DetailSalesOrders).First(o => o.OrderID == curentOrder.OrderID);
            _detailSales.DetailOrderBindingSource.DataSource = order.DetailSalesOrders.ToList();
            Form form = (Form)_detailSales;
            form.ShowDialog();
        }
        void LoadReport()
        {
            AppInfo info = _context.AppInfos.FirstOrDefault();
            if (info == null) { return; }
            SalesOrder current = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            SalesOrder order = _context.SalesOrders.Find(current.OrderID);
            var orderData = (from s in _context.SalesOrders
                             join c in _context.Customers on s.CustomerID equals c.CustomerID
                             where s.OrderID == order.OrderID
                             select new
                             {
                                 DateCreated = s.OrderDate,
                                 OrderID = s.OrderID,
                                 CustomerName = c.CustomerName,
                                 CustomerPhone = c.Phone,
                                 CustomerAddress = c.Address,
                                 TotalPrice = s.TotalPrice,
                                 PurchasePrice = s.PurchasePrice,
                                 ChangePrice = s.ChangePrice
                             }).FirstOrDefault();
            var orderFullData = new
            {
                DateCreated = orderData.DateCreated,
                AppName = info.AppName,
                AppAddress = info.Address,
                AppPhone = info.Phone,
                OrderID = orderData.OrderID,
                CustomerName = orderData.CustomerName,
                CustomerPhone = orderData.CustomerPhone,
                CustomerAddress = orderData.CustomerAddress,
                TotalPrice = orderData.TotalPrice.ToString("C0"),
                PurchasePrice = orderData.PurchasePrice.ToString("C0"),
                ChangePrice = orderData.ChangePrice.ToString("C0")
            };

            var detailData = from d in _context.DetailSalesOrders
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
            _report.ReportViewer.LocalReport.ReportPath = "./Reports/ReportSalesOrder.rdlc";
            ReportDataSource detailDataSource = new ReportDataSource();
            detailDataSource.Name = "DataSetDetailSalesOrder";
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
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanPrintSalesOrder == false)
            {
                MessageBox.Show("Bạn không có quyền này");
                return;
            }
            if (_viewSalesOrder.OrderBindingSource.Current == null)
            {
                MessageBox.Show("Chưa bản ghi nào được chọn");
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
                MessageBox.Show("Bạn không có quyền này");
                return;
            }
            var addSalesOrderForm = _addSalesOrder as Form;
            var viewMain = _viewMain as Form;
            if (viewMain != null && addSalesOrderForm != null)
            {
                viewMain.Hide();
                addSalesOrderForm.ShowDialog();
                viewMain.Show();
            }
        }
        public void Add()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    if (_addSalesOrder.OrderedGridView.RowCount == 0)
                    {
                        MessageBox.Show("Đơn hàng chưa có sản phẩm nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }
                    SalesOrder? salesOrder = new SalesOrder();
                    salesOrder.Employee = _context.Employees.Find(_addSalesOrder.EmployeeID);
                    salesOrder.Customer = _context.Customers.Find(_addSalesOrder.CustomerID);
                    salesOrder.PurchasePrice = _addSalesOrder.PurchasePrice;
                    salesOrder.ChangePrice = _addSalesOrder.ChangePrice;
                    salesOrder.TotalPrice = _addSalesOrder.TotalPrice;
                    if (salesOrder.PurchasePrice < salesOrder.TotalPrice)
                    {
                        var result = MessageBox.Show("Khách chưa trả đủ tiển có muốn tiếp tục ?","Thông báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            transaction.Rollback();
                            return;
                        }
                    }
                    _context.SalesOrders.Add(salesOrder);

                    foreach (DataGridViewRow row in _addSalesOrder.OrderedGridView.Rows)
                    {
                        Product product = _context.Products.Find(row.Cells["ProductIDColumn"].Value)!;
                        DetailSalesOrder detail = new DetailSalesOrder();
                        detail.Product = product;
                        detail.UnitPrice = decimal.Parse(row.Cells["UnitPriceColumn"].Value.ToString());
                        detail.SalesOrder = salesOrder;
                        detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());
                        if (detail.Quantity > product.Inventory)
                        {
                            MessageBox.Show($"Số lượng trong kho không đủ cho sản phẩm: {product.ProductName}");
                            _context.Entry(salesOrder).State = EntityState.Detached;
                            transaction.Rollback();
                            return;
                        }
                        detail.OrderID = salesOrder.OrderID;
                        _context.DetailSalesOrders.Add(detail);
                        product.Inventory -= detail.Quantity;
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Thanh toán thành công");
                    _viewSalesOrder.OrderBindingSource.EndEdit();
                }
                catch (SqlException e)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi cơ sở dữ liệu. Thanh toán thất bại");
                }
            }
        }

        public void Remove()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteSalesOrder == false)
            {
                MessageBox.Show("Bạn không có quyền này");
                return;
            }
            SalesOrder? deleted = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
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

        public void Search()
        {
            List<SalesOrder?> salesOrders = null;
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

        public void Load()
        {
            _viewSalesOrder.OrderBindingSource.ResetBindings(true);
            _viewSalesOrder.OrderBindingSource.DataSource = _context.SalesOrders.Local.ToBindingList();
        }

        public void LoadCustomer()
        {
            _addSalesOrder.CustomerBindingSource.DataSource = _context.Customers.ToList();
        }

        public void LoadProduct()
        {
            _addSalesOrder.ClearControl();
            if (!string.IsNullOrEmpty(_addSalesOrder.ProductSearchText))
            {
                var products = _context.Products.Where(p => p.ProductName.Contains(_addSalesOrder.ProductSearchText))
                    .ToList();
                int itemsPerPage = 6;
                int skipStep = (_addSalesOrder.Page - 1) * itemsPerPage;
                foreach (var product in products.Skip(skipStep).Take(itemsPerPage))
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
                var products = _context.Products.ToList();
                int itemsPerPage = 6;
                int skipStep = (_addSalesOrder.Page - 1) * itemsPerPage;
                foreach (var product in products.Skip(skipStep).Take(itemsPerPage))
                {
                    frmProduct form = new frmProduct(product);
                    form.Clicked += OrderProduct;
                    form.TopLevel = false;
                    _addSalesOrder.AddControl(form);
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
                var cells = _addSalesOrder.OrderedGridView.Rows[productOrdered[product]].Cells;
                cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()) + 1;
                cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()) * int.Parse(cells["QuantityColumn"].Value.ToString());
            }
            else
            {
                _addSalesOrder.OrderedGridView.Rows.Add(product.ProductName, product.UnitPrice, 1, product.UnitPrice, product.ProductID);
                productOrdered.Add(product, _addSalesOrder.OrderedGridView.Rows.Count - 1);
            }
        }

        public void RemoveProduct(object sender, DataGridViewCellEventArgs e)
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
