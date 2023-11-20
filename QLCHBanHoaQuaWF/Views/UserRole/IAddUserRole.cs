namespace QLCHBanHoaQuaWF.Views.UserRole;

public interface IAddUserRole : IValidateControl
{
    public string RoleName { get; set; }
    public string Description { get; set; }
    public CheckedListBox PermissionSelected { get;}
    public event EventHandler LoadPermission;
    public event EventHandler AddUserRole;
}