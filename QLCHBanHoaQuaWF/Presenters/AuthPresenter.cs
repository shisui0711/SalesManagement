
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.User;
using System.Security.Cryptography;
using System.Text;
using QLCHWF.Helpers;
using QLCHWF.IRepository;

namespace QLCHWF.Presenters
{
    public class AuthPresenter:PaginationPresenter<User>
    {
        public static User? User { get; private set; }
        private readonly IViewLogin _viewLogin;
        private readonly IViewMain _viewMain;
        private readonly IViewUser _viewUser;
        private readonly IAddUser _addUser;
        private readonly IUpdatePassword _updatePassword;
        private readonly IChangePassword _changePassword;
        private readonly IChangeUserRole _changeUserRole;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        public AuthPresenter(IViewLogin viewLogin, IViewMain viewMain, IViewUser viewUser, IAddUser addUser,
            IUpdatePassword updatePassword, IChangePassword changePassword, IChangeUserRole changeUserRole,
            IUnitOfWork unitOfWork, IConfiguration configuration) : base(viewUser, unitOfWork.Users, 20)
        {
            _viewLogin = viewLogin;
            _viewMain = viewMain;
            _viewUser = viewUser;
            _addUser = addUser;
            _updatePassword = updatePassword;
            _changePassword = changePassword;
            _changeUserRole = changeUserRole;
            _unitOfWork = unitOfWork;
            _configuration = configuration;

            _viewLogin.LoginEvent += delegate { Login(); };

            _viewUser.ShowChangePassword += delegate { ShowChangPassword(); };
            _viewUser.SearchUser += delegate { SearchUser(); };
            _viewUser.LoadUser += delegate{RenewItems();};
            _viewUser.LockUser += delegate { LockUser(); };
            _viewUser.UnlockUser += delegate { UnlockUser(); };
            _viewUser.ShowAddUser += delegate { ShowAddUser(); };
            _viewUser.ShowChangeUserRole += delegate { ShowChangeUserRole(); };

            _addUser.AddUser += delegate {AddUser();};
            _updatePassword.UpdatePassowrd += delegate { UpdatePassword(); };
            _changePassword.ChangePassowrd += delegate { ChangePassword(); };
            _changeUserRole.ChangeUserRole += delegate { ChangeUserRole(); };
        }

        void ChangeUserRole()
        {
            User? user = _unitOfWork.Users.GetOne(x=>x.Email == _changeUserRole.Email);
            if (user == null)
            {
                _changeUserRole.ShowMessage("Thất bại: Không tìm thấy email");
                return;
            }

            user.RoleID = _changeUserRole.RoleID;
            _unitOfWork.SaveChanges();
            _changeUserRole.ShowMessage("Đổi vai trò thành công");

        }
        void ShowChangeUserRole()
        {
            User? current  = _viewUser.UserBindingSource.Current as User;
            if (current == null)
            {
                _viewUser.ShowMessage("Không tìm thấy tài khoản được chọn");
                return;
            }

            _changeUserRole.Email = current.Email;
            _changeUserRole.UserRoleBindingSource.DataSource = _unitOfWork.UserRoles.GetAll();
            var form = (Form)_changeUserRole;
            form.ShowDialog();
        }
        void ShowAddUser()
        {
            _addUser.RoleBindingSource.DataSource = _unitOfWork.UserRoles.GetAll();
            var form = (Form)_addUser;
            form.ShowDialog();
        }

        void AddUser()
        {
            try
            {
                if (_addUser.Password != _addUser.Repassword)
                {
                    _addUser.ShowMessage("Mật khẩu không khớp. Vui lòng kiểm tra lại");
                    return;
                }

                var employee = _unitOfWork.Employees.GetOne(x => x.Email == _addUser.Email);
                if (employee == null)
                {
                    _addUser.ShowMessage($"Không tìm thấy nhân viên có email: {_addUser.Email}");
                 return;   
                }
                var user = new User();
                user.Email = _addUser.Email;
                user.Password = _addUser.Password;
                user.EmployeeID = employee.EmployeeID;
                user.RoleID = _addUser.RoleID;
                if (!ValidationHelper.IsValid(user,_addUser))
                {
                    return;
                }

                user.Password = GetSha256Hash(user.Password);
                _unitOfWork.Users.Add(user);
                _addUser.ShowMessage("Tạo thành công");
            }
            catch (Exception e)
            {
                _addUser.ShowMessage($"Lỗi: {e.Message}");
            }
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

            if (user.Password != GetSha256Hash(_viewLogin.Password))
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

        public void Register(string email, string password, int roleId)
        {
            UserRole? userRole = _unitOfWork.UserRoles.GetById(roleId);
            Employee? employee = _unitOfWork.Employees.GetSome(e => e.Email == email).FirstOrDefault();
            if (employee != null && userRole != null)
            {
                User user = new User();
                user.Email = email;
                user.EmployeeID = employee.EmployeeID;
                user.RoleID = userRole.RoleID;
                user.Password = GetSha256Hash(password);
                _unitOfWork.Users.Add(user);
            }
        }

        public void UpdatePassword()
        {
            
            var user = _unitOfWork.Users.GetOne(u => u.Email == _updatePassword.Email);
            if (user != null)
            {
                if (_updatePassword.Password != _updatePassword.Repassword)
                {
                    _viewUser.ShowMessage("Mật khẩu không khớp");
                    return;
                }

                user.Password = GetSha256Hash(_updatePassword.Password);
                _unitOfWork.SaveChanges();
                _viewLogin.ShowMessage(@"Đổi mật khẩu thành công");
            }
        }

        void ChangePassword()
        {
            var user = _unitOfWork.Users.GetOne(u => u.Email == _changePassword.Email);
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
                _unitOfWork.SaveChanges();
                _viewLogin.ShowMessage(@"Đổi mật khẩu thành công");
            }
        }
        private void LockUser()
        {
            var userTarget = _viewUser.UserBindingSource.Current as User;
            if (userTarget == null)
            {
                return;
            }
            
            var user = _unitOfWork.Users.GetOne(x=>x.Email== userTarget.Email);
            if (user != null)
            {
                user.Lock = true;
                _unitOfWork.SaveChanges();
            }
        }

        private void UnlockUser()
        {
            var userTarget = _viewUser.UserBindingSource.Current as User;
            if (userTarget == null)
            {
                return;
            }
            var user = _unitOfWork.Users.GetOne(x => x.Email == userTarget.Email);
            if (user != null) {
                user.Lock = false;
                _unitOfWork.SaveChanges();
            }
        }
        private void SearchUser()
        {
            var users = _unitOfWork.Users.GetUserInclue(u => u.Employee,
                u => u.Employee.EmployeeName.Contains(_viewUser.SearchText)).ToList();
            if (users.Count > 0)
            {
                TargetSource = users;
                ResetPage();
                NextPage();
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
        public static string GetSha256Hash(string input)
        {
            using (SHA256 sha = SHA256.Create())
            {

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        protected override void Load(List<User> items)
        {
            _viewUser.UserBindingSource.ResetBindings(true);
            _viewUser.UserBindingSource.DataSource = items;
        }
    }
}
