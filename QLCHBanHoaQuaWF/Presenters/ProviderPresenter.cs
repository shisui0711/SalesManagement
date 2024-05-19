using Microsoft.EntityFrameworkCore;
using QLCHWF.Helpers;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Employee;
using QLCHWF.Views.Provider;
using MyAppContext = QLCHWF.Models.MyAppContext;

namespace QLCHWF.Presenters;

public class ProviderPresenter: PaginationPresenter<Provider>
{
    private readonly IViewProvider _viewProvider;
    private readonly IAddProvider _addProvider;
    private readonly IUpdateProvider _updateProvider;
    private readonly IHistoryImport _historyImport;
    private MyAppContext _context;
    public ProviderPresenter(IViewProvider viewProvider, IAddProvider addProvider, IUpdateProvider updateProvider, IHistoryImport historyImport, MyAppContext context):base(viewProvider,context,20)
    {
        _viewProvider = viewProvider;
        _addProvider = addProvider;
        _updateProvider = updateProvider;
        _historyImport = historyImport;
        _context = context;
        _context.Providers.Load();

        _viewProvider.LoadProvider += delegate
        {
            ResetPage();
            TargetSource = _context.Providers.ToList();
            NextPage();
        };
        _viewProvider.RemoveProvider += delegate { Remove(); };
        _viewProvider.SearchProvider += delegate { Search(); };
        _viewProvider.ShowAddProvider += delegate { ShowAddForm(); };
        _viewProvider.ShowUpdateProvider += delegate { ShowUpdateForm(); };
        _viewProvider.ShowOrderHistory += delegate { ShowHistoryImport(); };

        _addProvider.AddProvider += delegate { Add(); };

        _updateProvider.UpdateProvider += delegate { Update(); };
    }

    void ShowHistoryImport()
    {
        if (_viewProvider.ProviderBindingSource.Current == null)
        {
            _viewProvider.ShowMessage(@"Chưa bản ghi nào được chọn");
            return;
        }
        Provider currentProvider = _viewProvider.ProviderBindingSource.Current as Provider;
        Provider provider = _context.Providers.Include(p => p.ImportOrders)
            .First(p => p.ProviderID == currentProvider.ProviderID);
        if (provider.ImportOrders.Count == 0)
        {
            _viewProvider.ShowMessage(@"Chưa nhập đơn nào từ nhà cung cấp này");
            return;
        }
        _historyImport.ImportBindingSource.DataSource = provider.ImportOrders.ToList();
        Form form = (Form)_historyImport;
        form?.ShowDialog();
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreatedProvider == false)
        {
            _viewProvider.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var form = _addProvider as Form;
        if (form != null)
        {
            form.ShowDialog();
        }
    }

    public void ShowUpdateForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanUpdateProvider == false)
        {
            _viewProvider.ShowMessage(@"Bạn không có quyền này");
            return;
        }
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

    public void Add()
    {
        try
        {
            Provider provider = new Provider();
            provider.ProviderName = _addProvider.ProviderName;
            provider.Email = _addProvider.Email;
            provider.Phone = _addProvider.Phone;
            provider.Address = _addProvider.Address;
            if (!ValidationHelper.IsValid(provider, _addProvider))
            {
                return;
            }

            _context.Providers.Add(provider);
            _context.SaveChanges();
            _viewProvider.ProviderBindingSource.EndEdit();
            _viewProvider.ShowMessage("Thêm thành công");
        }
        catch (Exception e)
        {
           _viewProvider.ShowMessage($"Thêm thất bại: {e.Message}");
        }
    }

    public void Update()
    {
        try
        {
            Provider provider = _context.Providers.Find(_updateProvider.ProviderID);
            provider.ProviderName = _updateProvider.ProviderName;
            provider.Email = _updateProvider.Email;
            provider.Phone = _updateProvider.Phone;
            provider.Address = _updateProvider.Address;
            if (!ValidationHelper.IsValid(provider, _updateProvider))
            {
                _context.Entry(provider).Reload();
                return;
            }

            _context.SaveChanges();
            _viewProvider.ProviderBindingSource.EndEdit();
            _viewProvider.ShowMessage("Cập nhật thành công");
        }
        catch (Exception e)
        {
           _viewProvider.ShowMessage($"Lỗi: {e.Message}");
        }
    }

    public void Remove()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanDeleteProvider == false)
        {
            _viewProvider.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        var deleted = _viewProvider.ProviderBindingSource.Current as Provider;
        if (deleted == null)
        {
            _viewProvider.ShowMessage(@"Không tìm thấy bản ghi đã chọn");
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

    public void Search()
    {
        try
        {
            List<Provider> providers = null;
            switch (_viewProvider.OptionIndex)
            {
                case 1:
                    providers = _context.Providers.Where(x => x.ProviderName.Contains(_viewProvider.SearchText))
                        .ToList();
                    break;
                case 3:
                    providers = _context.Providers.Where(x => x.Email.Contains(_viewProvider.SearchText)).ToList();
                    break;
                case 4:
                    providers = _context.Providers.Where(x => x.Phone.Contains(_viewProvider.SearchText)).ToList();
                    break;
                case 5:
                    providers = _context.Providers.Where(x => x.Address.Contains(_viewProvider.SearchText)).ToList();
                    break;
                default:
                    break;
            }

            if (providers != null && providers.Count >0)
            {
                ResetPage();
                TargetSource = providers;
                NextPage();
            }
            else
            {
                _viewProvider.ShowMessage("Không tìm thấy bản ghi nào hợp lệ");
            }
        }
        catch (Exception e)
        {
            _viewProvider.ShowMessage($"Lỗi: {e.Message}");
        }
    }


    protected override void Load(List<Provider> items)
    {
        _viewProvider.ProviderBindingSource.ResetBindings(true);
        _viewProvider.ProviderBindingSource.DataSource = items;
    }
}