using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Repository;
using QLCHWF.Views;
using QLCHWF.Views.ImportOrder;

namespace QLCHWF.Presenters;

public abstract class PaginationPresenter<T> where T : class
{
    private readonly IViewPagination _viewPagination;
    private readonly MyAppContext _context;
    private readonly IGenericRepository<T> _repository;
    protected List<T> TargetSource;
    private readonly int _itemsPerPage;

    public PaginationPresenter(IViewPagination viewPagination,IGenericRepository<T> repository,int itemsPerPage)
    {
        _viewPagination = viewPagination;
        //_context = context;
        _repository = repository;
        TargetSource = _repository.GetAll().ToList();
        _itemsPerPage = itemsPerPage;
        _viewPagination.NextPage += delegate { NextPage(); };
        _viewPagination.PreviousPage += delegate { PreviousPage(); };
    }

    protected abstract void Load(List<T> items);

    protected void RenewItems()
    {
        ResetPage();
        _viewPagination.CurrentPage = 0;
        TargetSource = _repository.GetAll().ToList();
        NextPage();
    }
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