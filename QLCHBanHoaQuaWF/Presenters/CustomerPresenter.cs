using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Customer;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters
{
    public class CustomerPresenter : ValidPresenter
    {
        private readonly IViewCustomer _viewCustomer;
        private readonly IAddCustomer _addCustomer;
        private readonly IUpdateCustomer _updateCustomer;
        private readonly IHistorySales _historySales;
        private MyAppContext _context;

        public CustomerPresenter(IViewCustomer viewCustomer, IAddCustomer addCustomer, IUpdateCustomer updateCustomer, IHistorySales historySales, MyAppContext context)
        {
            _viewCustomer = viewCustomer;
            _addCustomer = addCustomer;
            _updateCustomer = updateCustomer;
            _historySales = historySales;
            _context = context;
            _viewCustomer.LoadCustomer += delegate { Load(); };
            _viewCustomer.RemoveCustomer += delegate { Remove(); };
            _viewCustomer.SearchCustomer += delegate { Search(); };
            _viewCustomer.ShowAddCustomer += delegate { ShowAddForm(); };
            _viewCustomer.ShowUpdateCustomer += delegate { ShowUpdateForm(); };
            _viewCustomer.ShowSalesHistory += delegate { SalesHistory(); };
            _addCustomer.AddCustomer += delegate { Add(); };
            _updateCustomer.UpdateCustomer += delegate { Update(); };

            _context.Customers.Load();
        }

        void SalesHistory()
        {
            if (_viewCustomer.CustomerBindingSource.Current == null)
            {
                _viewCustomer.ShowMessage("Chưa bản ghi nào được chọn");
                return;
            }
            Customer currentCustomer = _viewCustomer.CustomerBindingSource.Current as Customer;
            Customer customer = _context.Customers.Include(c => c.SalesOrders)
                .First(c => c.CustomerID == currentCustomer.CustomerID);
            if (customer.SalesOrders.Count == 0)
            {
                _viewCustomer.ShowMessage(@"Khách hàng này chưa mua hàng lần nào");
                return;
            }
            _historySales.SalesBindingSource.DataSource = customer.SalesOrders.ToList();
            Form form = (Form)_historySales;
            form?.ShowDialog();
        }
        public void ShowAddForm()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateCustomer == false)
            {
                _viewCustomer.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            var form = _addCustomer as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowUpdateForm()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateCustomer == false && AuthPresenter.User.UserRole.Permission.IsAdmin == false)
            {
                _viewCustomer.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            var updated = _viewCustomer.CustomerBindingSource.Current as Customer;
            if (updated == null)
            {
                return;
            }
            _updateCustomer.CustomerID = updated.CustomerID;
            _updateCustomer.CustomerName = updated.CustomerName;
            _updateCustomer.Email = updated.Email;
            _updateCustomer.Phone = updated.Phone;
            _updateCustomer.Address = updated.Address;
            var form = _updateCustomer as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }
        public void Add()
        {
            try
            {
                var customer = new Customer();
                customer.CustomerName = _addCustomer.CustomerName;
                customer.Email = _addCustomer.Email;
                customer.Phone = _addCustomer.Phone;
                customer.Address = _addCustomer.Address;
                if (!IsValid(customer, _addCustomer))
                {
                    return;
                }

                _context.Customers.Add(customer);
                _viewCustomer.CustomerBindingSource.EndEdit();
                _context.SaveChanges();
                _addCustomer.Reset();
                _addCustomer.ShowMessage("Thêm thành công");
            }
            catch (Exception e)
            {
                _addCustomer.ShowMessage($@"Lỗi: {e.Message}");
            }

        }

        public void Update()
        {
            try
            {
                var customer = _context.Customers.Where(x=>x.CustomerID== _updateCustomer.CustomerID).FirstOrDefault();
                if (customer == null)
                {
                    _updateCustomer.ShowMessage("Không tìm thấy khách hàng cần cập nhật");
                    return;
                }
                customer.CustomerName = _updateCustomer.CustomerName;
                customer.Email = _updateCustomer.Email;
                customer.Phone = _updateCustomer.Phone;
                customer.Address = _updateCustomer.Address;
                if (!IsValid(customer, _updateCustomer))
                {
                    try
                    {
                        _context.Entry(customer).Reload();
                        return;
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                }

                _viewCustomer.CustomerBindingSource.EndEdit();
                _context.SaveChanges();
                _updateCustomer.ShowMessage("Cập nhật thành công");
            }
            catch (Exception e)
            {
                _updateCustomer.ShowMessage($"Lỗi: {e.Message}");
            }
        }

        public void Remove()
        {
            try
            {
                if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteCustomer == false &&
                    AuthPresenter.User.UserRole.Permission.IsAdmin == false)
                {
                    _viewCustomer.ShowMessage(@"Bạn không có quyền này");
                    return;
                }

                var deleted = _viewCustomer.CustomerBindingSource.Current as Customer;
                if (deleted == null)
                {
                    return;
                }

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Entry(deleted).State = EntityState.Deleted;
                        _context.SaveChanges();
                        transaction.Commit();
                        _viewCustomer.CustomerBindingSource.Remove(deleted);
                        _viewCustomer.ShowMessage("Xóa thành công");
                    }
                    catch (SqlException e)
                    {
                        transaction.Rollback();
                        _viewCustomer.ShowMessage($"Xóa thất bại:{e.Message}");
                    }
                }
            }
            catch (Exception e)
            {
                _viewCustomer.ShowMessage($"Lỗi: {e.Message}");
            }
        }

        public void Search()
        {
            try
            {
                List<Customer> customers = null;
                switch (_viewCustomer.OptionIndex)
                {
                    case 1:
                        customers = _context.Customers.Where(x =>
                            x.CustomerName.ToLower().Contains(_viewCustomer.SearchText.ToLower())).ToList();
                        break;
                    case 2:
                        customers = _context.Customers.Where(x => x.Email.Contains(_viewCustomer.SearchText)).ToList();
                        break;
                    case 3:
                        customers = _context.Customers.Where(x => x.Phone.Contains(_viewCustomer.SearchText)).ToList();
                        break;
                    case 4:
                        customers = _context.Customers.Where(x => x.Address.Contains(_viewCustomer.SearchText))
                            .ToList();
                        break;
                    default:
                        break;
                }

                if (customers != null && customers.Count > 0)
                {
                    _viewCustomer.CustomerBindingSource.ResetBindings(true);
                    _viewCustomer.CustomerBindingSource.DataSource = customers;
                }
                else
                {
                    _viewCustomer.ShowMessage("Không tìm thấy bản ghi nào hợp lệ");
                }
            }
            catch (Exception e)
            {
                _viewCustomer.ShowMessage($"Lỗi: {e.Message}");
            }
        }

        public void Load()
        {
            try
            {
                _viewCustomer.CustomerBindingSource.ResetBindings(true);
                _viewCustomer.CustomerBindingSource.DataSource = _context.Customers.Local.ToBindingList();
            }
            catch (Exception e)
            {
                _viewCustomer.ShowMessage($"Lỗi: {e.Message}");
            }
        }
    }
}
