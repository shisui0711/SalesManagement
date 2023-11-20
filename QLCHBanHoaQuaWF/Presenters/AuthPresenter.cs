using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.User;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters
{
    public class AuthPresenter
    {
        public static User User { get; private set; }
        private readonly IViewLogin _viewLogin;
        private readonly IViewMain _viewMain;
        private readonly IViewUser _viewUser;
        private readonly IChangePassword _changePassword;
        private readonly MyAppContext _context;
        private readonly IConfiguration _configuration;
        public AuthPresenter(IViewLogin viewLogin,IViewMain viewMain,IViewUser viewUser,IChangePassword changePassword,MyAppContext context,IConfiguration configuration)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;
            _viewUser = viewUser;
            _changePassword = changePassword;
            _context = context;
            _configuration = configuration;

            _context.Users.Load();

            _viewLogin.LoginEvent += delegate { Login(); };

            _viewUser.ShowChangePassword += delegate { ShowChangPassword(); };
            _viewUser.SearchUser += delegate { SearchUser(); };
            _viewUser.LoadUser += delegate { LoadUser(); };
            _viewUser.LockUser += delegate { LockUser(); };
            _viewUser.UnlockUser += delegate { UnlockUser(); };

            _changePassword.ChangePassowrd += delegate { ChangePassword(); };
        }

        public void Login()
        {
            string Role = _viewLogin.Role;
            if (Role == "Nhân Viên")
            {
                var user = _context.Users.Where(e => e.Email == _viewLogin.Username).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Email không tồn tại!", "Chú ý");
                    return;
                }

                if (user.Password != GetSha256Hash(_viewLogin.Password))
                {
                    MessageBox.Show("Mật khẩu không đúng", "Chú ý");
                    return;
                }

                if (user.Lock)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản lý");
                    return;
                }
                user.LastLogin = DateTime.Now;
                _context.SaveChanges();
                User = user;
            }
            else
            {
                string email = _configuration.GetSection("AccountDemo").GetSection("Email").Value;
                //string password = _configuration.GetSection("AccountDemo").GetSection("Password").Value;
                string role = _configuration.GetSection("AccountDemo").GetSection("Role").Value;
                //if (email != _viewLogin.Username)
                //{
                //    MessageBox.Show("Email không tồn tại");
                //    return;
                //}

                //if (password != _viewLogin.Password)
                //{
                //    MessageBox.Show("Mật khẩu không đúng");
                //    return;
                //}
                UserRole userRole = new UserRole();
                userRole.RoleName = role;
                User user = new User();
                user.Email = email;
                user.UserRole = userRole;
                Permission? permission = new Permission();
                permission.IsAdmin = true;
                permission.UserRole = userRole;
                User = user;

            }
            var loginForm = _viewLogin as Form;
            var mainForm = _viewMain as Form;
            loginForm.Hide();
            mainForm.ShowDialog();
            loginForm.Show();
        }

        public void Register(string email,string password,int roleId)
        {
            UserRole userRole = _context.UserRoles.Find(roleId);
            Employee employee = _context.Employees.Where(e => e.Email == email).FirstOrDefault();
            if (employee != null && userRole != null)
            {
                User user = new User();
                user.Email = email;
                user.EmployeeID = employee.EmployeeID;
                user.RoleID = userRole.RoleID;
                user.Password = GetSha256Hash(password);
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        public void ChangePassword()
        {
            Models.User user = _context.Users.Where(u => u.Email == _changePassword.Email).FirstOrDefault();
            if (user != null)
            {
                if (_changePassword.Password != _changePassword.Repassword)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    return;
                }

                user.Password = GetSha256Hash(_changePassword.Password);
                _context.SaveChanges();
            }
        }

        private void LockUser()
        {
            Models.User userTarget = _viewUser.UserBindingSource.Current as User;
            if (userTarget == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn khóa tài khoản đã chọn","Thông báo",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            userTarget.Lock = true;
            _context.SaveChanges();
        }

        private void UnlockUser()
        {
            Models.User userTarget = _viewUser.UserBindingSource.Current as User;
            if (userTarget == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn mở khóa tài khoản đã chọn", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            userTarget.Lock = false;
            _context.SaveChanges();
        }
        private void LoadUser()
        {
            _viewUser.UserBindingSource.ResetBindings(true);
            _viewUser.UserBindingSource.DataSource = _context.Users.Local.ToBindingList();
        }
        private void SearchUser()
        {
            List<User> users = null;
            users = _context.Users.Include(u => u.Employee)
                .Where(u => u.Employee.EmployeeName.Contains(_viewUser.SearchText)).ToList();
            if (users != null && users.Count > 0) 
            {
                _viewUser.UserBindingSource.DataSource = users;
            }
        }
        private void ShowChangPassword()
        {
            var userChanged = _viewUser.UserBindingSource.Current as User;
            if (userChanged == null)
            {
                return;
            }
            _changePassword.Email = userChanged.Email;
            Form form = (Form)_changePassword;
            form.ShowDialog();
        }
        private string GetSha256Hash(string input)
        {
            using (SHA256 md5Hash = SHA256.Create())
            {
                
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

    }
}
