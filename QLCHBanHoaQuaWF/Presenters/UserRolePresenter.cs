using Microsoft.EntityFrameworkCore;
using QLCHWF.Models;
using QLCHWF.Views.UserRole;
using System.ComponentModel;

namespace QLCHWF.Presenters;

public class UserRolePresenter : PresenterCRUD
{
    private readonly IViewUserRole _viewUserRole;
    private readonly IAddUserRole _addUserRole;
    private readonly IUpdateUserRole _updateUserRole;
    private readonly MyAppContext _context;
    public UserRolePresenter(IViewUserRole viewUserRole, IAddUserRole addUserRole, IUpdateUserRole updateUserRole, MyAppContext context)
    {
        _viewUserRole = viewUserRole;
        _addUserRole = addUserRole;
        _updateUserRole = updateUserRole;
        _context = context;

        _context.UserRoles.Load();

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
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    private void ShowUpdateForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateUserRole == false)
        {
            _viewUserRole.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var userRoleUpdate = _viewUserRole.UserRoleBindingSource.Current as UserRole;
        _updateUserRole.RoleID = userRoleUpdate.RoleID;
        _updateUserRole.RoleName = userRoleUpdate.RoleName;
        _updateUserRole.Description = userRoleUpdate.Description;
        Form form = (Form)_updateUserRole;
        if (form != null)
        {
            form.ShowDialog();
        }
    }
    public override void Add()
    {
        UserRole userRole = new UserRole();
        userRole.RoleName = _addUserRole.RoleName;
        userRole.Description = _addUserRole.Description;
        if (!IsValid(userRole, _addUserRole))
        {
            return;
        }

        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.UserRoles.Add(userRole);
                Permission permission = new Permission();
                permission.UserRole = userRole;
                foreach (var item in _addUserRole.PermissionSelected.CheckedItems)
                {
                    var property = typeof(Permission).GetProperties().Where(x =>
                    {
                        var displayNamAttribute = (DisplayNameAttribute)x.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                        if (displayNamAttribute != null)
                        {
                            return displayNamAttribute.DisplayName == item.ToString();
                        }

                        return false;
                    }).FirstOrDefault();
                    if (property != null)
                    {

                        property.SetValue(permission, true);

                    }
                }

                _context.Permissions.Add(permission);
                _context.SaveChanges();
                transaction.Commit();
                _addUserRole.ShowMessage(@"Thêm thành công");
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Update()
    {
        UserRole userRole = _context.UserRoles.Find(_updateUserRole.RoleID);
        if (!IsValid(userRole, _updateUserRole))
        {
            return;
        }

        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                Permission permission = _context.Permissions.Find(userRole.Permission.PermissionID);
                for(int i =0; i < _updateUserRole.PermissionSelected.Items.Count; i++)
                {
                    var property = typeof(Permission).GetProperties().Where(x =>
                    {
                        var displayNamAttribute = (DisplayNameAttribute)x.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                        if (displayNamAttribute != null)
                        {
                            return displayNamAttribute.DisplayName == _updateUserRole.PermissionSelected.Items[i].ToString();
                        }

                        return false;
                    }).FirstOrDefault();
                    if (property != null)
                    {
                        bool value = _updateUserRole.PermissionSelected.GetItemChecked(i);
                        property.SetValue(permission, value);
                    }
                }
                _context.SaveChanges();
                transaction.Commit();
                _updateUserRole.ShowMessage(@"Sửa thành công");
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Remove()
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

        var userRoleExist = _context.UserRoles.Include(u => u.Users).FirstOrDefault(u => u.RoleID == deleted.RoleID);
        if (userRoleExist != null && userRoleExist.Users.Count > 0)
        {
            _viewUserRole.ShowMessage(@"Không thể xóa vì vẫn còn nhân viên đảm nhận vai trò này");
            return;
        }
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.UserRoles.Remove(deleted);
                _context.SaveChanges();
                _viewUserRole.UserRoleBindingSource.Remove(deleted);
                transaction.Commit();
                _viewUserRole.ShowMessage(@"Xóa thành công");
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Search()
    {
        List<UserRole> userRoles = null;
        userRoles = _context.UserRoles.Where(u => u.RoleName.Contains(_viewUserRole.SearchText)).ToList();
        if (userRoles != null && userRoles.Count > 0)
        {
            _viewUserRole.UserRoleBindingSource.DataSource = userRoles;
        }
        else
        {
            _viewUserRole.ShowMessage(@"Không tìm thấy bản ghi nào hợp lệ");
        }
    }

    public override void Load()
    {
        _viewUserRole.UserRoleBindingSource.ResetBindings(true);
        _viewUserRole.UserRoleBindingSource.DataSource = _context.UserRoles.Local.ToBindingList();
    }

    private void LoadPermission()
    {
        var properties = typeof(Permission).GetProperties();
        foreach (var propertyInfo in properties)
        {
            var displayNamAttribute = (DisplayNameAttribute)propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
            if (displayNamAttribute != null)
            {
                _addUserRole.PermissionSelected.Items.Add(displayNamAttribute.DisplayName);
            }
        }
    }

    private void LoadUpdatePermission()
    {
        _updateUserRole.PermissionSelected.Items.Clear();
        Permission permission = _context.UserRoles.Include(u => u.Permission)
            .Where(u => u.RoleID == _updateUserRole.RoleID).FirstOrDefault().Permission;
        {
            var properties = typeof(Permission).GetProperties();
            foreach (var propertyInfo in properties)
            {
                var displayNamAttribute = (DisplayNameAttribute)propertyInfo.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
                if (displayNamAttribute != null)
                {
                    bool value = (bool)propertyInfo.GetValue(permission);
                    _updateUserRole.PermissionSelected.Items.Add(displayNamAttribute.DisplayName);
                    int index = _updateUserRole.PermissionSelected.Items.Count - 1;
                    _updateUserRole.PermissionSelected.SetItemChecked(index, value);
                }
            }
        }
    }
}