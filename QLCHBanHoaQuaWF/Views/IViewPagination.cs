namespace QLCHWF.Views;

public interface IViewPagination
{
    public int CurrentPage { get; set; }
    public event EventHandler PreviousPage;
    public event EventHandler NextPage;
    public void DisableNextPage();
    public void DisablePreviousPage();
    public void EnablePreviousPage();
    public void EnableNextPage();
}