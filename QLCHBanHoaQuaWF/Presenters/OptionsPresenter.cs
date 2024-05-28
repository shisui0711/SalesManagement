using AutoMapper;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.Options;

namespace QLCHWF.Presenters;

public class OptionsPresenter
{
    private readonly IViewOptions _viewOptions;
    private readonly IAppInfo _appInfo;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public OptionsPresenter(IViewOptions viewOptions,IMapper mapper,IUnitOfWork unitOfWork, IAppInfo appInfo)
    {
        _viewOptions = viewOptions;
        _appInfo = appInfo;
        _mapper = mapper;
        _unitOfWork = unitOfWork;

        _viewOptions.ShowAppInfo += delegate { ShowAppInfo(); };

        _appInfo.UpdateAppInfo += delegate { UpdateAppInfo(); };
    }



    void ShowAppInfo()
    {
        AppInfo? info = _unitOfWork.AppInfos.GetAll().FirstOrDefault();
        if (info == null)
        {
            return;
        }

        _appInfo.AppName = info.AppName;
        _appInfo.Address = info.Address;
        _appInfo.Email = info.Email ?? "";
        _appInfo.Phone = info.Phone;
        Form form = (Form)_appInfo;
        form.ShowDialog();
    }

    void UpdateAppInfo()
    {
        AppInfo? info = _unitOfWork.AppInfos.GetOne(x => x.AppName == _appInfo.AppName);
        if (info == null)
        {
            return;
        }

        info = _mapper.Map<AppInfo>(_appInfo);
        try
        {
            _unitOfWork.AppInfos.Update(info, info.AppName);    
            _appInfo.ShowMessage(@"Cập nhật thông tin thành công");
        }
        catch
        {
            _appInfo.ShowMessage(@"Dữ liệu không hợp lệ");
        }
    }
}