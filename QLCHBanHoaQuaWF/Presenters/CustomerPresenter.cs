using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Customer;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF.Presenters
{
    internal class CustomerPresenter : PresenterCRUD
    {
        private IViewCustomer _viewCustomer;
        private IAddCustomer _addCustomer;
        private IUpdateCustomer _updateCustomer;
        private AppContext _context;

        public CustomerPresenter(IViewCustomer viewCustomer,IAddCustomer addCustomer,IUpdateCustomer updateCustomer,AppContext context)
        {
            _viewCustomer = viewCustomer;
            _addCustomer = addCustomer;
            _updateCustomer = updateCustomer;
            _context = context;
            _viewCustomer.LoadCustomer += delegate { Load(); };
            _viewCustomer.RemoveCustomer += delegate { Remove(); };
            _viewCustomer.SearchCustomer += delegate { Search(); };
            _viewCustomer.ShowAddCustomer += delegate { ShowAddForm(); };
            _viewCustomer.ShowUpdateCustomer += delegate { ShowUpdateForm(); };
            _addCustomer.AddCustomer += delegate { Add(); };
            _updateCustomer.UpdateCustomer += delegate { Update(); };

            _context.Customers.Load();
        }

        public void ShowAddForm()
        {
            var form = _addCustomer as Form;
            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public void ShowUpdateForm()
        {
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
        public override void Add()
        {
            var customer = new Customer();
            customer.CustomerName = _addCustomer.CustomerName;
            customer.Email = _addCustomer.Email;
            customer.Phone = _addCustomer.Phone;
            customer.Address = _addCustomer.Address;
            if (!IsValid(customer,_addCustomer))
            {
                return;
            }
            _context.Customers.Add(customer);
            _viewCustomer.CustomerBindingSource.EndEdit();
            _context.SaveChanges();

        }

        public override void Update()
        {
            var customer = new Customer();
            customer.CustomerID = _updateCustomer.CustomerID;
            customer.CustomerName = _updateCustomer.CustomerName;
            customer.Email = _updateCustomer.Email;
            customer.Phone = _updateCustomer.Phone;
            customer.Address = _updateCustomer.Address;
            if (!IsValid(customer,_updateCustomer))
            {
                return;
            }

            var customerExist = _context.Customers.Find(customer.CustomerID);
            if (customerExist != null)
            {
                _context.Entry(customerExist).CurrentValues.SetValues(customer);
                _viewCustomer.CustomerBindingSource.EndEdit();
                _context.SaveChanges();
            }
        }

        public override void Remove()
        {
            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            var deleted = _viewCustomer.CustomerBindingSource.Current as Customer;
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Entry(deleted).State = EntityState.Deleted;
                    _context.SaveChanges();
                    transaction.Commit();
                    _viewCustomer.CustomerBindingSource.Remove(deleted);
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }
        }

        public override void Search()
        {
            List<Customer> customers = null;
            switch (_viewCustomer.OptionIndex)
            {
                case 1:
                    customers = _context.Customers.Where(x => x.CustomerName.Contains(_viewCustomer.SearchText)).ToList();
                    break;
                case 2:
                    customers = _context.Customers.Where(x => x.Email.Contains(_viewCustomer.SearchText)).ToList();
                    break;
                case 3:
                    customers = _context.Customers.Where(x => x.Phone.Contains(_viewCustomer.SearchText)).ToList();
                    break;
                case 4:
                    customers = _context.Customers.Where(x => x.Address.Contains(_viewCustomer.SearchText)).ToList();
                    break;
                default:
                    break;
            }

            if (customers != null)
            {
                _viewCustomer.CustomerBindingSource.ResetBindings(true);
                _viewCustomer.CustomerBindingSource.DataSource = customers;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi nào hợp lệ", "Thông báo");
            }
        }

        public override void Load()
        {
            _viewCustomer.CustomerBindingSource.ResetBindings(true);
            _viewCustomer.CustomerBindingSource.DataSource = _context.Customers.Local.ToBindingList();
            _viewCustomer.CustomerBindingSource.EndEdit();
        }
    }
}
