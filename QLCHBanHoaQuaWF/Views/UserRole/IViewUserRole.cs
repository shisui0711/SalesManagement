

namespace QLCHWF.Views.UserRole;

public interface IViewUserRole:IViewBase
{
    public string SearchText { get; set; }
    public BindingSource UserRoleBindingSource { get; }
    public event EventHandler RemoveUserRole;
    public event EventHandler LoadUserRole;
    public event EventHandler SearchUserRole;
    public event EventHandler ShowAddUserRole;
    public event EventHandler ShowUpdateUserRole;
}