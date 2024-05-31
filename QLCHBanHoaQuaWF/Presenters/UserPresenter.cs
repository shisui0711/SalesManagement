using QLCHWF.Helpers;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.User;

namespace QLCHWF.Presenters;

public class UserPresenter : PaginationPresenter<User>
{
    private readonly IViewUser _viewUser;
    private readonly IAddUser _addUser;
    private readonly IUpdatePassword _updatePassword;
    private readonly IChangePassword _changePassword;
    private readonly IChangeUserRole _changeUserRole;
    private static IUnitOfWork _unitOfWork;
    public UserPresenter(IViewUser viewUser, IAddUser addUser, IUpdatePassword updatePassword,
        IChangePassword changePassword, IChangeUserRole changeUserRole, IUnitOfWork unitOfWork):base(viewUser,unitOfWork.Users,20)
    {
        _viewUser = viewUser;
        _addUser = addUser;
        _updatePassword = updatePassword;
        _changePassword = changePassword;
        _changeUserRole = changeUserRole;
        _unitOfWork = unitOfWork;

        _viewUser.ShowChangePassword += delegate { ShowChangPassword(); };
        _viewUser.SearchUser += delegate { SearchUser(); };
        _viewUser.LoadUser += delegate { RenewItems(); };
        _viewUser.LockUser += delegate { LockUser(); };
        _viewUser.UnlockUser += delegate { UnlockUser(); };
        _viewUser.ShowAddUser += delegate { ShowAddUser(); };
        _viewUser.ShowChangeUserRole += delegate { ShowChangeUserRole(); };

        _addUser.AddUser += delegate { AddUser(); };
        _updatePassword.UpdatePassowrd += delegate { UpdatePassword(); };
        _changePassword.ChangePassowrd += delegate { ChangePassword(); };
        _changeUserRole.ChangeUserRole += delegate { ChangeUserRole(); };
    }
    void ChangePassword()
    {
        var user = _unitOfWork.Users.GetOne(u => u.Email == _changePassword.Email);
        if (user != null)
        {
            if (user.Password != SecurityHelper.GetSha256Hash(_changePassword.OldPassword))
            {
                _changePassword.ShowMessage(@"Mật khẩu cũ không đúng");
                return;
            }

            if (_changePassword.NewPassword != _changePassword.Repassword)
            {
                _changePassword.ShowMessage(@"Mật khẩu mới không khớp");
                return;
            }

            user.Password = SecurityHelper.GetSha256Hash(_changePassword.NewPassword);
            _unitOfWork.SaveChanges();
            _changePassword.ShowMessage(@"Đổi mật khẩu thành công");
        }
        else
        {
            _changePassword.ShowMessage(@"Không tìm thấy email này trong hệ thống");
        }
    }
    void ChangeUserRole()
    {
        User? user = _unitOfWork.Users.GetOne(x => x.Email == _changeUserRole.Email);
        if (user == null)
        {
            _changeUserRole.ShowMessage("Thất bại: Không tìm thấy email");
            return;
        }

        if (_changeUserRole.RoleID == null)
        {
            _changeUserRole.ShowMessage("Thất bại: Vui lòng chọn vai trò");
            return;
        }
        user.RoleID = (int)_changeUserRole.RoleID;
        _unitOfWork.SaveChanges();
        _changeUserRole.ShowMessage("Đổi vai trò thành công");

    }
    void ShowChangeUserRole()
    {
        User? current = _viewUser.UserBindingSource.Current as User;
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
            if (!ValidationHelper.IsValid(user, _addUser))
            {
                return;
            }

            user.Password = SecurityHelper.GetSha256Hash(user.Password);
            _unitOfWork.Users.Add(user);
            _addUser.ShowMessage("Tạo thành công");
        }
        catch (Exception e)
        {
            _addUser.ShowMessage($"Lỗi: {e.Message}");
        }
    }
    public static void Register(string email, string password, int roleId)
    {
        UserRole? userRole = _unitOfWork.UserRoles.GetById(roleId);
        Employee? employee = _unitOfWork.Employees.GetSome(e => e.Email == email).FirstOrDefault();
        if (employee != null && userRole != null)
        {
            User user = new User();
            user.Email = email;
            user.EmployeeID = employee.EmployeeID;
            user.RoleID = userRole.RoleID;
            user.Password = SecurityHelper.GetSha256Hash(password);
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

            user.Password = SecurityHelper.GetSha256Hash(_updatePassword.Password);
            _unitOfWork.SaveChanges();
            _updatePassword.ShowMessage(@"Đổi mật khẩu thành công");
        }
    }

   
    private void LockUser()
    {
        var userTarget = _viewUser.UserBindingSource.Current as User;
        if (userTarget == null)
        {
            return;
        }

        var user = _unitOfWork.Users.GetOne(x => x.Email == userTarget.Email);
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
        if (user != null)
        {
            user.Lock = false;
            _unitOfWork.SaveChanges();
        }
    }
    private void SearchUser()
    {
        SearchItems(u => u.Employee.EmployeeName.Contains(_viewUser.SearchText));
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

    protected override void Load(List<User> items)
    {
        _viewUser.UserBindingSource.ResetBindings(true);
        _viewUser.UserBindingSource.DataSource = items;
    }
}