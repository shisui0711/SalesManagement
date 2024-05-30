using System.Linq.Expressions;
using System.Text.RegularExpressions;
using QLCHWF.IRepository;
using QLCHWF.Views;

namespace QLCHWF.Presenters;

public abstract class PaginationPresenter<T> where T : class
{
    private readonly IViewPagination _viewPagination;
    private readonly IGenericRepository<T> _repository;
    private bool _isSearchMode = false;
    private List<T> TargetSource;
    private readonly int _itemsPerPage;
    private int _totalItems;
    private int _totalPages;
    private Expression<Func<T, bool>> _match;

    public PaginationPresenter(IViewPagination viewPagination,IGenericRepository<T> repository,int itemsPerPage)
    {
        _viewPagination = viewPagination;
        _repository = repository;
        _itemsPerPage = itemsPerPage;
        _totalItems = _repository.Count();
        _totalPages = (int)Math.Ceiling((double)_totalItems / _itemsPerPage);
        _viewPagination.NextPage += delegate { NextPage(); };
        _viewPagination.PreviousPage += delegate { PreviousPage(); };
    }

    protected abstract void Load(List<T> items);


    protected void RenewItems()
    {
        _isSearchMode = false;
        ResetPage();
        _totalItems = _repository.Count();
        _totalPages = (int)Math.Ceiling((double)_totalItems / _itemsPerPage);
        TargetSource = _repository.GetPagination((_viewPagination.CurrentPage) * _itemsPerPage, _itemsPerPage).ToList();
        NextPage();
    }
    protected void ResetPage()
    {
        _viewPagination.DisablePreviousPage();
        _viewPagination.EnableNextPage();
        _viewPagination.CurrentPage = 0;
    }

    protected void SearchItems(Expression<Func<T,bool>> match)
    {
        ResetPage();
        _isSearchMode = true;
        _totalItems = _repository.Count(match);
        _totalPages = (int)Math.Ceiling((double)_totalItems / _itemsPerPage);
        _match = match;
        NextPage();
    }
    protected void NextPage()
    {
        if (!_isSearchMode)
        {
            TargetSource = _repository.GetPagination((_viewPagination.CurrentPage) * _itemsPerPage, _itemsPerPage).ToList();
        }
        else
        {
            TargetSource = _repository.GetPagination((_viewPagination.CurrentPage) * _itemsPerPage, _itemsPerPage, _match).ToList();
        }
        Load(TargetSource);
        _viewPagination.CurrentPage += 1;
        if (_viewPagination.CurrentPage > 1)
        {
            _viewPagination.EnablePreviousPage();
        }

        if (_viewPagination.CurrentPage >= _totalPages)
        {
            _viewPagination.DisableNextPage();
        }
    }
    protected void  PreviousPage()
    {
        _viewPagination.CurrentPage -= 1;
        if (!_isSearchMode)
        {
            TargetSource = _repository.GetPagination((_viewPagination.CurrentPage -1) * _itemsPerPage, _itemsPerPage).ToList();
        }
        else
        {
            TargetSource = _repository.GetPagination((_viewPagination.CurrentPage -1) * _itemsPerPage, _itemsPerPage, _match).ToList();
        }
        Load(TargetSource);
        if (_viewPagination.CurrentPage <= 1)
        {
            _viewPagination.DisablePreviousPage();
        }

        if (_viewPagination.CurrentPage < _totalPages)
        {
            _viewPagination.EnableNextPage();
        }

    }
}