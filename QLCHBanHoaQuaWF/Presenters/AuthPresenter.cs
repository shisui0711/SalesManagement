
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.User;
using QLCHWF.Helpers;
using QLCHWF.IRepository;

namespace QLCHWF.Presenters
{
    public class AuthPresenter
    {
        public static User? User { get; private set; }
        private readonly IViewLogin _viewLogin;
        private readonly IViewMain _viewMain;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        public AuthPresenter(IViewLogin viewLogin, IViewMain viewMain, IViewUser viewUser, IAddUser addUser, IChangeUserRole changeUserRole,
            IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;
            _unitOfWork = unitOfWork;
            _configuration = configuration;

            _viewLogin.LoginEvent += delegate { Login(); };

        }

        void CheckPermission(IChangeControl control)
        {
            if (User == null)
            {
                return;
            }
            var permissionTypes = AuthPresenter.User.UserRole.Permission.GetType().GetProperties()
                .Where(x => x.PropertyType == typeof(bool) && x.Name.StartsWith("CanRead"));
            foreach (var permission in permissionTypes)
            {
                string permissionName = permission.Name.Substring(7);
                if (permission.GetValue(AuthPresenter.User.UserRole.Permission) == null)
                {
                    continue;
                }
                if (!(bool)permission.GetValue(AuthPresenter.User.UserRole.Permission)!)
                {
                    control.ChangeVisible("btn" + permissionName,false);
                }
                else
                {
                    control.ChangeVisible("btn" + permissionName, true);
                }
            }
        }

        private bool ProductionLogin()
        {
            var user = _unitOfWork.Users.GetUserWithPermission(_viewLogin.Username);
            if (user == null)
            {
                _viewLogin.ShowMessage("Email không tồn tại!");
                return false;
            }

            if (user.Password != SecurityHelper.GetSha256Hash(_viewLogin.Password))
            {
                _viewLogin.ShowMessage("Mật khẩu không đúng");
                return false;
            }

            if (user.Lock)
            {
                _viewLogin.ShowMessage(@"Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản lý");
                return false;
            }
            user.LastLogin = DateTime.Now;
            _unitOfWork.SaveChanges();
            User = user;
            return true;
        }

        private bool DevelopmentLogin()
        {
            try
            {
                string? email = _configuration.GetSection("AccountDemo").GetSection("Email").Value;
                string? password = _configuration.GetSection("AccountDemo").GetSection("Password").Value;
                string? role = _configuration.GetSection("AccountDemo").GetSection("Role").Value;
                if (email == null || password == null || role == null)
                {
                    return false;
                }
                if (email == _viewLogin.Username && password == _viewLogin.Password)
                {
                    UserRole userRole = new UserRole
                    {
                        RoleName = role
                    };
                    User user = new User
                    {
                        Email = email,
                        UserRole = userRole
                    };
                    Permission permission = new Permission();
                    foreach (var propertyInfo in permission.GetType().GetProperties()
                                 .Where(x => x.PropertyType == typeof(bool)))
                    {
                        propertyInfo.SetValue(permission, true);
                    }

                    userRole.Permission = permission;
                    User = user;
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Login()
        {
            if (Debugger.IsAttached && DevelopmentLogin())
            {
                goto DangNhap;

            }

            if (!ProductionLogin())
            {
                return;
            }
            DangNhap:
            var loginForm = _viewLogin as Form;
            var mainForm = _viewMain as Form;
            CheckPermission(_viewMain);
            loginForm?.Hide();
            mainForm?.ShowDialog();
            loginForm?.Show();
        }
    }
}
