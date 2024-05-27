using Microsoft.Reporting.WinForms;
using QLCHWF.CustomMessageBox;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.Product;
using QLCHWF.Views.SalesOrder;

namespace QLCHWF.Presenters
{
    public class SalesOrderPresenter : PaginationPresenter<Product>
    {
        private readonly IViewSalesOrder _viewSalesOrder;
        private readonly IAddSalesOrder _addSalesOrder;
        private readonly IReportSalesOrder _report;
        private readonly IDetailSalesOrder _detailSales;
        private readonly Dictionary<Product, int> _productOrdered;
        private readonly IUnitOfWork _unitOfWork;
        private IAppInfoRepository _appInfoRepository;

        public SalesOrderPresenter(IViewSalesOrder viewSalesOrder, IAddSalesOrder addSalesOrder,
            IReportSalesOrder report, IDetailSalesOrder detailSales, IUnitOfWork unitOfWork,IAppInfoRepository appInfoRepository):base(addSalesOrder,unitOfWork.Products,6)
        {
            _productOrdered = new Dictionary<Product, int>();
            _viewSalesOrder = viewSalesOrder;
            _addSalesOrder = addSalesOrder;
            _report = report;
            _detailSales = detailSales;
            _appInfoRepository = appInfoRepository;
            _unitOfWork = unitOfWork;

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
                RenewItems();
            };
            _addSalesOrder.SearchCustomer += delegate { SearchCustomer(); };
            _addSalesOrder.SearchProduct += delegate { SearchProduct(); };
            _addSalesOrder.AddSalesOrder += delegate { Add(); };

            #endregion

            #region Handler Event for Report

            _report.LoadReport += async delegate { await LoadReport(); };

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
            SalesOrder order = _unitOfWork.SalesOrders.GetOrderWithDetail(curentOrder.OrderID);
            _detailSales.DetailOrderBindingSource.DataSource = order.DetailSalesOrders.ToList();
            Form form = (Form)_detailSales;
            form.ShowDialog();
        }
        async Task LoadReport()
        {
            AppInfo? info = _appInfoRepository.GetAll().FirstOrDefault();
            if (info == null) { return; }
            SalesOrder? current = _viewSalesOrder.OrderBindingSource.Current as SalesOrder;
            if (current == null)
            {
                _viewSalesOrder.ShowMessage("Không tìm thấy đơn hàng được chọn");
                return;
            }
            Task<OrderData> orderDataTask = _unitOfWork.SalesOrders.GetOrderDataAsync(current.OrderID);
            Task<List<OrderDetailData>> orderDetailTask = _unitOfWork.SalesOrders.GetOrderDetailDataAsync(current.OrderID);
            await Task.WhenAll(orderDataTask, orderDetailTask);
            OrderData orderData = await orderDataTask;
            List<OrderDetailData> detailData = await orderDetailTask;

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
                _report.ReportViewer.LocalReport.SetParameters(new ReportParameter(propertyInfo.Name, propertyInfo.GetValue(orderFullData)?.ToString()));
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
            if (addSalesOrderForm != null)
            {
                addSalesOrderForm.ShowDialog();
            }
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
                    Product product = _unitOfWork.Products.GetById(row.Cells["ProductIDColumn"].Value)!;
                    DetailSalesOrder detail = new DetailSalesOrder();
                    detail.ProductID = int.Parse(row.Cells["ProductIDColumn"].Value.ToString()!);
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
                _addSalesOrder.ShowMessage(@"Lỗi cơ sở dữ liệu: Thanh toán thất bại");
            }

        }
        //public void Add()
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            if (_addSalesOrder.OrderedGridView.RowCount == 0)
        //            {
        //                _addSalesOrder.ShowMessage("Đơn hàng chưa có sản phẩm nào");
        //                transaction.Rollback();
        //                return;
        //            }
        //            SalesOrder? salesOrder = new SalesOrder();
        //            salesOrder.Employee = _context.Employees.Find(_addSalesOrder.EmployeeID);
        //            salesOrder.Customer = _context.Customers.Find(_addSalesOrder.CustomerID);
        //            salesOrder.PurchasePrice = _addSalesOrder.PurchasePrice;
        //            salesOrder.ChangePrice = _addSalesOrder.ChangePrice;
        //            salesOrder.TotalPrice = _addSalesOrder.TotalPrice;
        //            if (salesOrder.PurchasePrice < salesOrder.TotalPrice)
        //            {
        //                var result = MyMessageBox.Show("Khách chưa trả đủ tiển có muốn tiếp tục ?","Thông báo", MessageBoxButtons.YesNo);
        //                if (result == DialogResult.No)
        //                {
        //                    transaction.Rollback();
        //                    return;
        //                }
        //            }
        //            _context.SalesOrders.Add(salesOrder);

        //            foreach (DataGridViewRow row in _addSalesOrder.OrderedGridView.Rows)
        //            {
        //                Product product = _context.Products.Find(row.Cells["ProductIDColumn"].Value)!;
        //                DetailSalesOrder detail = new DetailSalesOrder();
        //                detail.Product = product;
        //                detail.UnitPrice = decimal.Parse(row.Cells["UnitPriceColumn"].Value.ToString());
        //                detail.SalesOrder = salesOrder;
        //                detail.Quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());
        //                if (detail.Quantity > product.Inventory)
        //                {
        //                    _addSalesOrder.ShowMessage($@"Số lượng trong kho không đủ cho sản phẩm: {product.ProductName}");
        //                    _context.Entry(salesOrder).State = EntityState.Detached;
        //                    transaction.Rollback();
        //                    return;
        //                }
        //                detail.OrderID = salesOrder.OrderID;
        //                _context.DetailSalesOrders.Add(detail);
        //                product.Inventory -= detail.Quantity;
        //            }

        //            _context.SaveChanges();
        //            transaction.Commit();
        //            _addSalesOrder.ShowMessage(@"Thanh toán thành công");
        //            _viewSalesOrder.OrderBindingSource.EndEdit();
        //        }
        //        catch (Exception e)
        //        {
        //            transaction.Rollback();
        //            _addSalesOrder.ShowMessage(@"Lỗi cơ sở dữ liệu. Thanh toán thất bại");
        //        }
        //    }
        //}

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

            if (_unitOfWork.SalesOrders.Remove(deleted) && _unitOfWork.SaveChanges() != 0)
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
            List<SalesOrder>? salesOrders = null;
            switch (_viewSalesOrder.OptionIndex)
            {
                case 0:
                    salesOrders = _unitOfWork.SalesOrders.GetAll().ToList();
                    break;
                case 1:
                    salesOrders = _unitOfWork.SalesOrders.GetSome(x => x.OrderID.ToString() == (_viewSalesOrder.SearchText)).ToList();
                    break;
                case 2:
                    salesOrders = _unitOfWork.SalesOrders.GetOrdersInclue(e => e.Employee,
                        s =>s.Employee !=null &&  s.Employee.EmployeeName.Contains(_viewSalesOrder.SearchText)).ToList();
                    break;
                case 3:
                    salesOrders = _unitOfWork.SalesOrders.GetOrdersInclue(e => e.Customer,
                        s =>s.Customer != null &&  s.Customer.CustomerName.Contains(_viewSalesOrder.SearchText)).ToList();
                    break;
            }

            if (salesOrders != null && salesOrders.Count > 0)
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
            _viewSalesOrder.OrderBindingSource.DataSource = _unitOfWork.SalesOrders.GetAll();
        }

        public void LoadCustomer()
        {
            _addSalesOrder.CustomerBindingSource.DataSource = _unitOfWork.Customers.GetAll();
        }
        protected void SearchProduct()
        {
            ResetPage();
            TargetSource = _unitOfWork.Products.GetSome(
                    x => x.ProductName.Contains(_addSalesOrder.ProductSearchText)).ToList();
            NextPage();
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

        //void NextPage()
        //{
        //    int totalItems = targetSource.Count;
        //    int totalPages = (int)Math.Ceiling((double)totalItems / 6);
        //    int currentPage = _addSalesOrder.CurrentPage;
        //    List<Product> products = targetSource.Skip((currentPage) * 6).Take(6).ToList();
        //    LoadProduct(products);
        //    _addSalesOrder.CurrentPage += 1;
        //    if (_addSalesOrder.CurrentPage > 1)
        //    {
        //        _addSalesOrder.EnablePreviousPage();
        //    }

        //    if (_addSalesOrder.CurrentPage >= totalPages)
        //    {
        //        _addSalesOrder.DisableNextPage();
        //    }
        //}

        //void PreviousPage()
        //{
        //    _addSalesOrder.CurrentPage -= 1;
        //    int totalItems = targetSource.Count;
        //    int totalPages = (int)Math.Ceiling((double)totalItems / 6);
        //    int currentPage = _addSalesOrder.CurrentPage;
        //    List<Product> products = targetSource.Skip((currentPage - 1) * 6).Take(6).ToList();
        //    LoadProduct(products);
        //    if (_addSalesOrder.CurrentPage <= 1)
        //    {
        //        _addSalesOrder.DisablePreviousPage();
        //    }

        //    if (_addSalesOrder.CurrentPage < totalPages)
        //    {
        //        _addSalesOrder.EnableNextPage();
        //    }
        //}
    }
}
