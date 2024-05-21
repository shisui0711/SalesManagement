using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QLCHWF.CustomMessageBox;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Product;
using QLCHWF.Views.SalesOrder;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters
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
        private readonly ISalesOrderRepository _salesOrderRepository;
        //private readonly IEmployeeRepository _employeeRepository;
        //private readonly ICustomerRepository _customerRepository;
        private IAppInfoRepository _appInfoRepository;
        private List<Product> targetSource;

        public SalesOrderPresenter(IViewSalesOrder viewSalesOrder, IAddSalesOrder addSalesOrder,
            IReportSalesOrder report, IDetailSalesOrder detailSales, IViewMain viewMain,
            ISalesOrderRepository salesOrderRepository,IAppInfoRepository appInfoRepository, MyAppContext context)
        {
            productOrdered = new Dictionary<Product, int>();
            _viewMain = viewMain;
            _viewSalesOrder = viewSalesOrder;
            _addSalesOrder = addSalesOrder;
            _report = report;
            _detailSales = detailSales;
            _salesOrderRepository = salesOrderRepository;
            _appInfoRepository = appInfoRepository;
            _context = context;
            _context.SalesOrders.Load();

            #region Handler Event for ViewSalesOrder
            _viewSalesOrder.ShowAdd += delegate { ShowAddFrom(); };
            _viewSalesOrder.RemoveSalesOrder += delegate { Remove(); };
            _viewSalesOrder.LoadSalesOrder += delegate { Load(); };
            _viewSalesOrder.SearchSalesOrder += delegate { Search(); };
            _viewSalesOrder.ShowReport += delegate { ShowReport(); };
            _viewSalesOrder.ShowDetail += delegate { ShowDetail(); };
            #endregion


            #region Handler Event for AddSalesOrder

            _addSalesOrder.RemoveProduct += RemoveProduct;
            _addSalesOrder.LoadCustomer += delegate { LoadCustomer(); };
            _addSalesOrder.LoadProduct += delegate
            {
                _addSalesOrder.CurrentPage = 0;
                targetSource = _context.Products.ToList();
                NextPage();
            };
            _addSalesOrder.SearchCustomer += delegate { SearchCustomer(); };
            _addSalesOrder.SearchProduct += delegate { SearchProduct(); };
            _addSalesOrder.AddSalesOrder += delegate { Add(); };
            _addSalesOrder.NextPage += delegate { NextPage(); };
            _addSalesOrder.PreviousPage += delegate { PreviousPage(); };  

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
            SalesOrder curentOrder = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            SalesOrder order = _salesOrderRepository.GetOrderWithDetail(curentOrder.OrderID);
            _detailSales.DetailOrderBindingSource.DataSource = order.DetailSalesOrders.ToList();
            Form form = (Form)_detailSales;
            form.ShowDialog();
        }
        void LoadReport()
        {
            AppInfo info = _appInfoRepository.GetAll().FirstOrDefault();
            if (info == null) { return; }
            SalesOrder current = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            //SalesOrder order = _salesOrderRepository.GetById(current.OrderID);
            OrderData orderData = _salesOrderRepository.GetOrderData(current.OrderID);
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

            OrderDetailData detailData = _salesOrderRepository.GetOrderDetailData(current.OrderID);
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
                        _addSalesOrder.ShowMessage("Đơn hàng chưa có sản phẩm nào");
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
                        var result = MyMessageBox.Show("Khách chưa trả đủ tiển có muốn tiếp tục ?","Thông báo", MessageBoxButtons.YesNo);
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
                            _addSalesOrder.ShowMessage($@"Số lượng trong kho không đủ cho sản phẩm: {product.ProductName}");
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
                    _addSalesOrder.ShowMessage(@"Thanh toán thành công");
                    _viewSalesOrder.OrderBindingSource.EndEdit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    _addSalesOrder.ShowMessage(@"Lỗi cơ sở dữ liệu. Thanh toán thất bại");
                }
            }
        }

        public void Remove()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteSalesOrder == false)
            {
                _viewSalesOrder.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            SalesOrder? deleted = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            if (deleted == null)
            {
                _viewSalesOrder.ShowMessage(@"Chưa có đơn hàng nào được chọn");
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
                case 0:
                    salesOrders = _context.SalesOrders.ToList();
                    break;
                case 1:
                    salesOrders = _context.SalesOrders.Where(x => x.OrderID.ToString() == (_viewSalesOrder.SearchText)).ToList();
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
                if (_viewSalesOrder.DateStart != DateTime.MinValue)
                {
                    salesOrders = salesOrders.FindAll(x =>
                        x.OrderDate >= _viewSalesOrder.DateStart && x.OrderDate <= _viewSalesOrder.DateEnd);
                }
                _viewSalesOrder.OrderBindingSource.ResetBindings(true);
                _viewSalesOrder.OrderBindingSource.DataSource = salesOrders;
            }
            else
            {
                _viewSalesOrder.ShowMessage("Không tìm thấy bản ghi nào hợp lệ");
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
        protected void SearchProduct()
        {
            _addSalesOrder.CurrentPage = 0;
            targetSource = _context.Products.Where(x => x.ProductName.Contains(_addSalesOrder.ProductSearchText))
                .ToList();
            NextPage();
        }
        protected void LoadProduct(List<Product> products)
        {
            _addSalesOrder.ClearControl();
            foreach (var product in products)
            {
                frmProduct form = new frmProduct(product);
                form.Clicked += OrderProduct;
                form.TopLevel = false;
                _addSalesOrder.AddControl(form);
                form.Show();
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
                _addSalesOrder.ShowMessage("Không có khách hàng nào được tìm thấy");
            }
        }
        void NextPage()
        {
            int totalItems = targetSource.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / 6);
            int currentPage = _addSalesOrder.CurrentPage;
            List<Product> products = targetSource.Skip((currentPage) * 6).Take(6).ToList();
            LoadProduct(products);
            _addSalesOrder.CurrentPage += 1;
            if (_addSalesOrder.CurrentPage > 1)
            {
                _addSalesOrder.EnablePreviousPage();
            }

            if (_addSalesOrder.CurrentPage >= totalPages)
            {
                _addSalesOrder.DisableNextPage();
            }
        }

        void PreviousPage()
        {
            _addSalesOrder.CurrentPage -= 1;
            int totalItems = targetSource.Count;
            int totalPages = (int)Math.Ceiling((double)totalItems / 6);
            int currentPage = _addSalesOrder.CurrentPage;
            List<Product> products = targetSource.Skip((currentPage - 1) * 6).Take(6).ToList();
            LoadProduct(products);
            if (_addSalesOrder.CurrentPage <= 1)
            {
                _addSalesOrder.DisablePreviousPage();
            }

            if (_addSalesOrder.CurrentPage < totalPages)
            {
                _addSalesOrder.EnableNextPage();
            }
        }
    }
}
