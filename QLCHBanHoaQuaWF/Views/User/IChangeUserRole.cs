namespace QLCHWF.Views.User;

public interface IChangeUserRole:IViewBase
{
    public string Email { get; set; }
    public int RoleID { get;}
    public BindingSource UserRoleBindingSource { get; set; }
    public event EventHandler ChangeUserRole;
}