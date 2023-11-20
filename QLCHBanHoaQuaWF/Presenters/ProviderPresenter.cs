using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;
using MyAppContext = QLCHBanHoaQuaWF.Models.MyAppContext;

namespace QLCHBanHoaQuaWF.Presenters;

public class ProviderPresenter : PresenterCRUD
{
    private IViewProvider _viewProvider;
    private IAddProvider _addProvider;
    private IUpdateProvider _updateProvider;
    private MyAppContext _context;
    public ProviderPresenter(IViewProvider viewProvider,IAddProvider addProvider,IUpdateProvider updateProvider,MyAppContext context)
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
        Provider updated = _viewProvider.ProviderBindingSource.Current as Provider;
        if (updated == null)
        {
            return;
        }

        _updateProvider.ProviderID = updated.ProviderID;
        _updateProvider.ProviderName = updated.ProviderName;
        _updateProvider.Email = updated.Email;
        _updateProvider.Phone = updated.Phone;
        _updateProvider.Address = updated.Address;
        var form = _updateProvider as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    public override void Add()
    {
        Provider provider = new Provider();
        provider.ProviderName = _addProvider.ProviderName;
        provider.Email = _addProvider.Email;
        provider.Phone = _addProvider.Phone;
        provider.Address = _addProvider.Address;
        if (!IsValid(provider,_addProvider))
        {
            return;
        }

        _context.Providers.Add(provider);
        _context.SaveChanges();
        _viewProvider.ProviderBindingSource.EndEdit();
    }

    public override void Update()
    {
        Provider provider = _context.Providers.Find(_updateProvider.ProviderID);
        provider.ProviderName = _updateProvider.ProviderName;
        provider.Email = _updateProvider.Email;
        provider.Phone = _updateProvider.Phone;
        provider.Address = _updateProvider.Address;
        if (!IsValid(provider, _updateProvider))
        {   
            _context.Entry(provider).Reload();
            return;
        }
        _context.SaveChanges();
        _viewProvider.ProviderBindingSource.EndEdit();
    }

    public override void Remove()
    {
        var deleted = _viewProvider.ProviderBindingSource.Current as Provider;
        if (deleted == null)
        {
            return;
        }
        var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Cancel)
        {
            return;
        }
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Providers.Remove(deleted);
                _context.SaveChanges();
                _viewProvider.ProviderBindingSource.Remove(deleted);
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
        }
    }

    public override void Search()
    {
        List<Provider> providers = null;
        providers = _context.Providers.Where(p => p.ProviderName.Contains(_viewProvider.SearchText)).ToList();
        if (providers != null)
        {
            _viewProvider.ProviderBindingSource.DataSource = providers;
        }
    }

    public override void Load()
    {
        _viewProvider.ProviderBindingSource.ResetBindings(true);
        _viewProvider.ProviderBindingSource.DataSource = _context.Providers.Local.ToBindingList();
    }
}