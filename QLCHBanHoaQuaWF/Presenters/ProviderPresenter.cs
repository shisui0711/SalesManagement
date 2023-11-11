using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Provider;
using AppContext = QLCHBanHoaQuaWF.Models.AppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class ProviderPresenter : PresenterCRUD
{
    private IViewProvider _viewProvider;
    private IAddProvider _addProvider;
    private IUpdateProvider _updateProvider;
    private AppContext _context;
    public ProviderPresenter(IViewProvider viewProvider,IAddProvider addProvider,IUpdateProvider updateProvider,AppContext context)
    {
        _viewProvider = viewProvider;
        _addProvider = addProvider;
        _updateProvider = updateProvider;
        _context = context;

        _viewProvider.LoadProvider += delegate { Load(); };
        _viewProvider.RemoveProvider += delegate { Remove(); };
        _viewProvider.SearchProvider += delegate { Search(); };
        _viewProvider.ShowAddProvider += delegate { ShowAddForm(); };
        _viewProvider.ShowUpdateProvider += delegate { ShowUpdateForm(); };

        _addProvider.AddProvider += delegate { Add(); };

        _updateProvider.UpdateProvider += delegate { Update(); };
    }

    public void ShowAddForm()
    {
        var form = _addProvider as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    public void ShowUpdateForm()
    {
        var form = _updateProvider as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    public override void Add()
    {

    }

    public override void Update()
    {

    }

    public override void Remove()
    {

    }

    public override void Search()
    {

    }

    public override void Load()
    {

    }
}