using AutoMapper;
using QLCHWF.Helpers;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views;
using QLCHWF.Views.Provider;

namespace QLCHWF.Presenters;

public class ProviderPresenter: PaginationPresenter<Provider>
{
    private readonly IViewProvider _viewProvider;
    private readonly IAddProvider _addProvider;
    private readonly IUpdateProvider _updateProvider;
    private readonly IHistoryImport _historyImport;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public ProviderPresenter(IViewProvider viewProvider, IAddProvider addProvider, IUpdateProvider updateProvider, IHistoryImport historyImport,IMapper mapper, IUnitOfWork unitOfWork):base(viewProvider,unitOfWork.Providers,20)
    {
        _viewProvider = viewProvider;
        _addProvider = addProvider;
        _updateProvider = updateProvider;
        _historyImport = historyImport;
        _mapper = mapper;
        _unitOfWork = unitOfWork;

        _viewProvider.LoadProvider += delegate
        {
           RenewItems();
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
        Provider? currentProvider = _viewProvider.ProviderBindingSource.Current as Provider;
        if (currentProvider == null)
        {
            _viewProvider.ShowMessage("Không tìm thấy nhà cung cấp được chọn");
            return;
        }
        Provider provider = _unitOfWork.Providers.GetProviderWithImportOrder(currentProvider.ProviderID);
        if (provider.ImportOrders.Count == 0)
        {
            _viewProvider.ShowMessage(@"Chưa nhập đơn nào từ nhà cung cấp này");
            return;
        }
        _historyImport.ImportBindingSource.DataSource = provider.ImportOrders.ToList();
        Form form = (Form)_historyImport;
        form.ShowDialog();
    }
    public void ShowAddForm()
    {
        if (AuthPresenter.User != null && AuthPresenter.User.UserRole.Permission.CanCreatedProvider == false)
        {
            _viewProvider.ShowMessage(@"Bạn không có quyền này");
            return;
        }
        _addProvider.Reset();
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
        Provider? updated = _viewProvider.ProviderBindingSource.Current as Provider;
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
            Provider provider = _mapper.Map<Provider>(_addProvider);
            if (!ValidationHelper.IsValid(provider, _addProvider))
            {
                return;
            }

            _unitOfWork.Providers.Add(provider);
            _viewProvider.ProviderBindingSource.EndEdit();
            _viewProvider.ShowMessage("Thêm thành công");
            RenewItems();
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
            Provider? providerExist = _unitOfWork.Providers.GetById(_updateProvider.ProviderID);
            if (providerExist == null)
            {
                _viewProvider.ShowMessage("Không tìm thấy nhà cung cấp cần cập nhật");
                return;
            }
            providerExist = _mapper.Map<Provider>(_updateProvider);
            if (!ValidationHelper.IsValid(providerExist, _updateProvider))
            {
                return;
            }

            _unitOfWork.Providers.Update(providerExist, providerExist.ProviderID);
            _viewProvider.ProviderBindingSource.EndEdit();
            _viewProvider.ShowMessage("Cập nhật thành công");
            RenewItems();
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

        if (_unitOfWork.Providers.Remove(deleted))
        {
            _viewProvider.ProviderBindingSource.Remove(deleted);
            _viewProvider.ShowMessage("Xóa thành công");
            RenewItems();
        }
        else
        {
            _viewProvider.ShowMessage("Xóa thất bại");
        }
    }

    public void Search()
    {
        try
        {
            switch (_viewProvider.OptionIndex)
            {
                case 1:
                    SearchItems(x => x.ProviderName.Contains(_viewProvider.SearchText));
                    break;
                case 2:
                   SearchItems(x => x.Email.Contains(_viewProvider.SearchText));
                    break;
                case 3:
                   SearchItems(x => x.Phone.StartsWith(_viewProvider.SearchText));
                    break;
                case 4:
                   SearchItems(x => x.Address.Contains(_viewProvider.SearchText));
                    break;
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