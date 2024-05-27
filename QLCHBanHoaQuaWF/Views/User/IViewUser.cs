namespace QLCHWF.Views.User;

public interface IViewUser : IViewBase,IViewPagination
{
    public string SearchText { get; set; }
    public BindingSource UserBindingSource { get; }
    public event EventHandler SearchUser;
    public event EventHandler LoadUser;
    public event EventHandler LockUser;
    public event EventHandler UnlockUser;
    public event EventHandler ShowAddUser;
    public event EventHandler ShowChangePassword;
    public event EventHandler ShowChangeUserRole;
}