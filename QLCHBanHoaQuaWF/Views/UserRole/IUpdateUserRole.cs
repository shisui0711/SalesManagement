namespace QLCHBanHoaQuaWF.Views.UserRole;

public interface IUpdateUserRole : IValidateControl
{
    public int RoleID { get; set; }
    public string RoleName { get; set; }
    public string Description { get; set; }
    public CheckedListBox PermissionSelected { get; }
    public event EventHandler LoadPermission;
    public event EventHandler UpdateUserRole;
}