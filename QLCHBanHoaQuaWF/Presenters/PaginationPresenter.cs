using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.ImportOrder;

namespace QLCHWF.Presenters;

public abstract class PaginationPresenter<T> where T : class
{
    private readonly IViewPagination _viewPagination;
    private readonly MyAppContext _context;
    protected List<T> TargetSource;
    private readonly int _itemsPerPage;
    public PaginationPresenter(IViewPagination viewPagination,MyAppContext context,int itemsPerPage)
    {
        _viewPagination = viewPagination;
        _context = context;
        TargetSource = _context.Set<T>().ToList();
        _itemsPerPage = itemsPerPage;
        _viewPagination.NextPage += delegate { NextPage(); };
        _viewPagination.PreviousPage += delegate { PreviousPage(); };
    }

    protected abstract void Load(List<T> items);

    protected void ResetPage()
    {
        _viewPagination.DisablePreviousPage();
        _viewPagination.EnableNextPage();
        _viewPagination.CurrentPage = 0;
    }

    protected void NextPage()
    {
        int totalItems = TargetSource.Count;
        int totalPages = (int)Math.Ceiling((double)totalItems / _itemsPerPage);
        int currentPage = _viewPagination.CurrentPage;
        List<T> items = TargetSource.Skip((currentPage) * _itemsPerPage).Take(_itemsPerPage).ToList();
        Load(items);
        _viewPagination.CurrentPage += 1;
        if (_viewPagination.CurrentPage > 1)
        {
            _viewPagination.EnablePreviousPage();
        }

        if (_viewPagination.CurrentPage >= totalPages)
        {
            _viewPagination.DisableNextPage();
        }
    }
    protected void  PreviousPage()
    {
        _viewPagination.CurrentPage -= 1;
        int totalItems = TargetSource.Count;
        int totalPages = (int)Math.Ceiling((double)totalItems / _itemsPerPage);
        int currentPage = _viewPagination.CurrentPage;
        List<T> items = TargetSource.Skip((currentPage - 1) * _itemsPerPage).Take(_itemsPerPage).ToList();
        Load(items);
        if (_viewPagination.CurrentPage <= 1)
        {
            _viewPagination.DisablePreviousPage();
        }

        if (_viewPagination.CurrentPage < totalPages)
        {
            _viewPagination.EnableNextPage();
        }

    }
}