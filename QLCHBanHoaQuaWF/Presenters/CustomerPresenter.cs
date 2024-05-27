using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Customer;
using AutoMapper;
using QLCHWF.Helpers;
using QLCHWF.IRepository;

namespace QLCHWF.Presenters
{
    public class CustomerPresenter : PaginationPresenter<Customer>
    {
        private readonly IViewCustomer _viewCustomer;
        private readonly IAddCustomer _addCustomer;
        private readonly IUpdateCustomer _updateCustomer;
        private readonly IHistorySales _historySales;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerPresenter(IViewCustomer viewCustomer, IAddCustomer addCustomer, IUpdateCustomer updateCustomer,
            IHistorySales historySales, IUnitOfWork unitOfWork, IMapper mapper) : base(viewCustomer,
            unitOfWork.Customers, 20)
        {
            _viewCustomer = viewCustomer;
            _addCustomer = addCustomer;
            _updateCustomer = updateCustomer;
            _historySales = historySales;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _viewCustomer.LoadCustomer += delegate{RenewItems();};
            _viewCustomer.RemoveCustomer += delegate { Remove(); };
            _viewCustomer.SearchCustomer += delegate { Search(); };
            _viewCustomer.ShowAddCustomer += delegate { ShowAddForm(); };
            _viewCustomer.ShowUpdateCustomer += delegate { ShowUpdateForm(); };
            _viewCustomer.ShowSalesHistory += delegate { SalesHistory(); };

            _addCustomer.AddCustomer += delegate { Add(); };
            _updateCustomer.UpdateCustomer += delegate { Update(); };

        }

        void SalesHistory()
        {
            if (_viewCustomer.CustomerBindingSource.Current == null)
            {
                _viewCustomer.ShowMessage("Chưa bản ghi nào được chọn");
                return;
            }
            Customer? currentCustomer = _viewCustomer.CustomerBindingSource.Current as Customer;
            if (currentCustomer == null)
            {
                _viewCustomer.ShowMessage("Không tìm thấy khách hàng được chọn");
                return;
            }
            Customer customer = _unitOfWork.Customers.GetCustomerWithSalesOrder(currentCustomer.CustomerID);
            if (customer.SalesOrders.Count == 0)
            {
                _viewCustomer.ShowMessage(@"Khách hàng này chưa mua hàng lần nào");
                return;
            }
            _historySales.SalesBindingSource.DataSource = customer.SalesOrders.ToList();
            Form form = (Form)_historySales;
            form.ShowDialog();
        }
        public void ShowAddForm()
        {
            if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateCustomer == false)
            {
                _viewCustomer.ShowMessage(@"Bạn không có quyền này");
                return;
            }
            _addCustomer.Reset();
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
                Customer customer = _mapper.Map<Customer>(_addCustomer);
                if (!ValidationHelper.IsValid(customer, _addCustomer))
                {
                    return;
                }

                _unitOfWork.Customers.Add(customer);
                _unitOfWork.SaveChanges();
                _addCustomer.Reset();
                _viewCustomer.CustomerBindingSource.EndEdit();
                _addCustomer.ShowMessage("Thêm thành công");
                RenewItems();
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
                Customer? customerExist = _unitOfWork.Customers.GetById(_updateCustomer.CustomerID);
                if (customerExist == null)
                {
                    _updateCustomer.ShowMessage("Không tìm thấy khách hàng cần cập nhật");
                    return;
                }

                customerExist = _mapper.Map<Customer>(_updateCustomer);
                if (!ValidationHelper.IsValid(customerExist, _updateCustomer))
                {
                   return;
                }
                _unitOfWork.Customers.Update(customerExist,customerExist.CustomerID);
                _viewCustomer.CustomerBindingSource.EndEdit();
                _updateCustomer.ShowMessage("Cập nhật thành công");
                RenewItems();
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

                if (_unitOfWork.Customers.Remove(deleted))
                {
                    _viewCustomer.ShowMessage("Xóa thành công");
                    RenewItems();
                }
                else
                {
                    _viewCustomer.ShowMessage($"Xóa thất bại");
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
                List<Customer>? customers = null;
                switch (_viewCustomer.OptionIndex)
                {
                    case 1:
                        customers = _unitOfWork.Customers.GetSome(x =>
                            x.CustomerName.ToLower().Contains(_viewCustomer.SearchText.ToLower())).ToList();
                        break;
                    case 2:
                        customers = _unitOfWork.Customers.GetSome(x => x.Email.Contains(_viewCustomer.SearchText)).ToList();
                        break;
                    case 3:
                        customers = _unitOfWork.Customers.GetSome(x => x.Phone.Contains(_viewCustomer.SearchText)).ToList();
                        break;
                    case 4:
                        customers = _unitOfWork.Customers.GetSome(x => x.Address.Contains(_viewCustomer.SearchText))
                            .ToList();
                        break;
                }
                if (customers != null && customers.Count > 0)
                {
                    _viewCustomer.CustomerBindingSource.ResetBindings(true);
                    ResetPage();
                    TargetSource = customers;
                    NextPage();
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
        protected override void Load(List<Customer> customers)
        {
            _viewCustomer.CustomerBindingSource.ResetBindings(true);
            _viewCustomer.CustomerBindingSource.DataSource = customers;
        }

    }
}
