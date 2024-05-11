
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QLCHWF.Attributes;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.User;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters
{
    public class AuthPresenter
    {
        public static User User { get; private set; }
        private readonly IViewLogin _viewLogin;
        private readonly IViewMain _viewMain;
        private readonly IViewUser _viewUser;
        private readonly IUpdatePassword _updatePassword;
        private readonly IChangePassword _changePassword;
        private readonly MyAppContext _context;
        private readonly IConfiguration _configuration;
        public AuthPresenter(IViewLogin viewLogin, IViewMain viewMain, IViewUser viewUser, IUpdatePassword updatePassword,IChangePassword changePassword, MyAppContext context, IConfiguration configuration)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;
            _viewUser = viewUser;
            _updatePassword = updatePassword;
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

            _updatePassword.UpdatePassowrd += delegate { UpdatePassword(); };
            _changePassword.ChangePassowrd += delegate { ChangePassword(); };
        }
        void CheckPermission(IChangeControl control)
        {
            if (AuthPresenter.User == null)
            {
                return;
            }
            var permissionTypes = AuthPresenter.User.UserRole.Permission.GetType().GetProperties()
                .Where(x => x.PropertyType == typeof(bool) && x.Name.StartsWith("CanRead"));
            foreach (var permission in permissionTypes)
            {
                string permissionName = permission.Name.Substring(7);
                if (!(bool)permission.GetValue(AuthPresenter.User.UserRole.Permission))
                {
                    control.ChangeVisible("btn" + permissionName,false);
                }
                else
                {
                    control.ChangeVisible("btn" + permissionName, true);
                }
            }
        }
        public void Login()
        {
            string Role = _viewLogin.Role;
            if (Role == "Nhân Viên")
            {
                var user = _context.Users.Include(u=>u.UserRole).ThenInclude(u=>u.Permission).Where(e => e.Email == _viewLogin.Username).FirstOrDefault();
                if (user == null)
                {
                    _viewLogin.ShowMessage("Email không tồn tại!");
                    return;
                }

                if (user.Password != GetSha256Hash(_viewLogin.Password))
                {
                    _viewLogin.ShowMessage("Mật khẩu không đúng");
                    return;
                }

                if (user.Lock)
                {
                    _viewLogin.ShowMessage(@"Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản lý");
                    return;
                }
                user.LastLogin = DateTime.Now;
                _context.SaveChanges();
                User = user;
            }
            else
            {
                string email = _configuration.GetSection("AccountDemo").GetSection("Email").Value;
                string password = _configuration.GetSection("AccountDemo").GetSection("Password").Value;
                string role = _configuration.GetSection("AccountDemo").GetSection("Role").Value;
                if (email != _viewLogin.Username)
                {
                    _viewLogin.ShowMessage("Email không tồn tại");
                    return;
                }

                if (password != _viewLogin.Password)
                {
                    _viewLogin.ShowMessage("Mật khẩu không đúng");
                    return;
                }
                UserRole userRole = new UserRole
                {
                    RoleName = role
                };
                User user = new User
                {
                    Email = email,
                    UserRole = userRole
                };
                Permission? permission = new Permission();
                foreach (var propertyInfo in permission.GetType().GetProperties().Where(x => x.PropertyType == typeof(bool)))
                {
                    propertyInfo.SetValue(permission,true);
                }
                userRole.Permission = permission;
                User = user;
            }
            var loginForm = _viewLogin as Form;
            var mainForm = _viewMain as Form;
            CheckPermission(_viewMain);
            loginForm.Hide();
            mainForm.ShowDialog();
            loginForm.Show();
        }

        public void Register(string email, string password, int roleId)
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

        public void UpdatePassword()
        {
            Models.User user = _context.Users.Where(u => u.Email == _updatePassword.Email).FirstOrDefault();
            if (user != null)
            {
                if (_updatePassword.Password != _updatePassword.Repassword)
                {
                    _viewUser.ShowMessage("Mật khẩu không khớp");
                    return;
                }

                user.Password = GetSha256Hash(_updatePassword.Password);
                _context.SaveChanges();
                _viewLogin.ShowMessage(@"Đổi mật khẩu thành công");
            }
        }

        void ChangePassword()
        {
            Models.User user = _context.Users.Where(u => u.Email == _changePassword.Email).FirstOrDefault();
            if (user != null)
            {
                if (user.Password != GetSha256Hash(_changePassword.OldPassword))
                {
                    _viewLogin.ShowMessage(@"Mật khẩu cũ không đúng");
                    return;
                }

                if (_changePassword.NewPassword != _changePassword.Repassword)
                {
                    _viewLogin.ShowMessage(@"Mật khẩu mới không khớp");
                    return;
                }

                user.Password = GetSha256Hash(_changePassword.NewPassword);
                _context.SaveChanges();
                _viewLogin.ShowMessage(@"Đổi mật khẩu thành công");
            }
        }
        private void LockUser()
        {
            Models.User userTarget = _viewUser.UserBindingSource.Current as User;
            if (userTarget == null)
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
            _updatePassword.Email = userChanged.Email;
            Form form = (Form)_updatePassword;
            form.ShowDialog();
        }
        /// <summary>
        /// Generate Sha256Hash string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetSha256Hash(string input)
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
