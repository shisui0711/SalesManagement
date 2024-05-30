using QLCHWF.Helpers;
using QLCHWF.Models;
using QLCHWF.Views.UserRole;
using System.ComponentModel;
using QLCHWF.IRepository;

namespace QLCHWF.Presenters;

public class UserRolePresenter
{
    private readonly IViewUserRole _viewUserRole;
    private readonly IAddUserRole _addUserRole;
    private readonly IUpdateUserRole _updateUserRole;
    private readonly IUnitOfWork _unitOfWork;
    public UserRolePresenter(IViewUserRole viewUserRole, IAddUserRole addUserRole, IUpdateUserRole updateUserRole,IUnitOfWork unitOfWork)
    {
        _viewUserRole = viewUserRole;
        _addUserRole = addUserRole;
        _updateUserRole = updateUserRole;
        _unitOfWork = unitOfWork;

        _viewUserRole.LoadUserRole += delegate { Load(); };
        _viewUserRole.RemoveUserRole += delegate { Remove(); };
        _viewUserRole.SearchUserRole += delegate { Search(); };
        _viewUserRole.ShowAddUserRole += delegate { ShowAddForm(); };
        _viewUserRole.ShowUpdateUserRole += delegate { ShowUpdateForm(); };

        _addUserRole.LoadPermission += delegate { LoadPermission(); };
        _addUserRole.AddUserRole += delegate { Add(); };

        _updateUserRole.UpdateUserRole += delegate { Update(); };
        _updateUserRole.LoadPermission += delegate { LoadUpdatePermission(); };
    }

    private void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreateUserRole == false)
        {
            _viewUserRole.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        Form form = (Form)_addUserRole;
        form.ShowDialog();
    }

    private void ShowUpdateForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateUserRole == false)
        {
            _viewUserRole.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var userRoleUpdate = _viewUserRole.UserRoleBindingSource.Current as UserRole;
        if (userRoleUpdate == null)
        {
            _viewUserRole.ShowMessage("Không tìm thấy vai trò được chọn");
            return;
        }
        _updateUserRole.RoleID = userRoleUpdate.RoleID;
        _updateUserRole.RoleName = userRoleUpdate.RoleName;
        _updateUserRole.Description = userRoleUpdate.Description ?? "";
        Form form = (Form)_updateUserRole;
        form.ShowDialog();
    }
    public void Add()
    {
        UserRole userRole = new UserRole();
        userRole.RoleName = _addUserRole.RoleName;
        userRole.Description = _addUserRole.Description;
        if (!ValidationHelper.IsValid(userRole, _addUserRole))
        {
            return;
        }
        Permission permission = new Permission();
        foreach (var item in _addUserRole.PermissionSelected.CheckedItems)
        {
            var property = typeof(Permission).GetProperties().Where(x =>
            {
                var displayNamAttribute = (DisplayNameAttribute)x.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault()!;
                return displayNamAttribute.DisplayName == item.ToString();
            }).FirstOrDefault();
            if (property != null)
            {

                property.SetValue(permission, true);

            }
        }

        if (_unitOfWork.UserRoles.AddUserRoleWithPermission(userRole, permission))
        {
            _addUserRole.ShowMessage(@"Thêm thành công");
            Load();
        }
        else
        {
            _addUserRole.ShowMessage(@"Thêm thất bại");
        }
        
    }

    public void Update()
    {
        UserRole? userRole = _unitOfWork.UserRoles.GetById(_updateUserRole.RoleID);
        if (userRole == null)
        {
            _updateUserRole.ShowMessage("Không tìm thấy vai trò");
            return;
        }
        if (!ValidationHelper.IsValid(userRole, _updateUserRole))
        {
            return;
        }

        userRole.RoleName = _updateUserRole.RoleName;
        userRole.Description = _updateUserRole.Description;
        Permission permission = _unitOfWork.UserRoles.GetPermission(userRole.Permission.PermissionID);
        for (int i = 0; i < _updateUserRole.PermissionSelected.Items.Count; i++)
        {
            var property = typeof(Permission).GetProperties().Where(x =>
            {
                DisplayNameAttribute? displayNamAttribute = (DisplayNameAttribute)x.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                if (displayNamAttribute != null)
                    return displayNamAttribute.DisplayName == _updateUserRole.PermissionSelected.Items[i].ToString();
                return false;
            }).FirstOrDefault();
            if (property != null)
            {
                bool value = _updateUserRole.PermissionSelected.GetItemChecked(i);
                property.SetValue(permission, value);
            }
        }
        if (_unitOfWork.UserRoles.UpdateRoleWithPermission(userRole,permission))
        {
            _updateUserRole.ShowMessage(@"Sửa thành công");
        }
        else
        {
            _updateUserRole.ShowMessage(@"Sửa thất bại");
        }
        
    }

    public void Remove()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteUserRole == false)
        {
            _viewUserRole.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var deleted = _viewUserRole.UserRoleBindingSource.Current as UserRole;
        if (deleted == null)
        {
            _viewUserRole.ShowMessage(@"Chưa bản ghi nào được chọn");
            return;
        }

        UserRole? userRoleExist = _unitOfWork.UserRoles.GetOneInluce(u => u.Users, u => u.RoleID == deleted.RoleID);
        if (userRoleExist != null && userRoleExist.Users.Count > 0)
        {
            _viewUserRole.ShowMessage(@"Không thể xóa vì vẫn còn nhân viên đảm nhận vai trò này");
            return;
        }
        else if(userRoleExist == null)
        {
            _viewUserRole.ShowMessage("Vai trò đã chọn không còn tồn tại");
            return;
        }

        if (_unitOfWork.UserRoles.Remove(userRoleExist))
        {
            _viewUserRole.ShowMessage(@"Xóa thành công");
            Load();
        }
        else
        {
            _viewUserRole.ShowMessage(@"Xóa thất bại");
        }
    }

    public void Search()
    {
        List<UserRole> userRoles = _unitOfWork.UserRoles.GetSome(u => u.RoleName.Contains(_viewUserRole.SearchText)).ToList();
        if (userRoles.Count > 0)
        {
            _viewUserRole.UserRoleBindingSource.DataSource = userRoles;
        }
        else
        {
            _viewUserRole.ShowMessage(@"Không tìm thấy bản ghi nào hợp lệ");
        }
    }

    public void Load()
    {
        _viewUserRole.UserRoleBindingSource.ResetBindings(true);
        _viewUserRole.UserRoleBindingSource.DataSource = _unitOfWork.UserRoles.GetAll().ToList();
    }

    private void LoadPermission()
    {
        var properties = typeof(Permission).GetProperties().Where(x=>x.PropertyType == typeof(bool));
        foreach (var propertyInfo in properties)
        {
            DisplayNameAttribute? displayNamAttribute = (DisplayNameAttribute)propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
            if (displayNamAttribute != null) _addUserRole.PermissionSelected.Items.Add(displayNamAttribute.DisplayName);
        }
    }

    private void LoadUpdatePermission()
    {
        _updateUserRole.PermissionSelected.Items.Clear();
        Permission permission = _unitOfWork.UserRoles
            .GetOneInluce(u => u.Permission, u => u.RoleID == _updateUserRole.RoleID)!.Permission;
        {
            var properties = typeof(Permission).GetProperties().Where(x=>x.PropertyType == typeof(bool));
            foreach (var propertyInfo in properties)
            {
                DisplayNameAttribute? displayNamAttribute = (DisplayNameAttribute)propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                if (propertyInfo.GetValue(permission) != null && displayNamAttribute != null)
                {
                    bool value = (bool)propertyInfo.GetValue(permission)!;
                    _updateUserRole.PermissionSelected.Items.Add(displayNamAttribute.DisplayName);
                    int index = _updateUserRole.PermissionSelected.Items.Count - 1;
                    _updateUserRole.PermissionSelected.SetItemChecked(index, value);
                }
            }
        }
    }
}