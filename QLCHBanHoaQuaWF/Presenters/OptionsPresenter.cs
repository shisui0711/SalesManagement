using AutoMapper;
using QLCHWF.IRepository;
using QLCHWF.Models;
using QLCHWF.Views.Options;

namespace QLCHWF.Presenters;

public class OptionsPresenter
{
    private readonly IViewOptions _viewOptions;
    private readonly IAppInfo _appInfo;
    private readonly IAppInfoRepository _appInfoRepository;
    private readonly IMapper _mapper;
    public OptionsPresenter(IViewOptions viewOptions,IMapper mapper,IAppInfoRepository appInfoRepository, IAppInfo appInfo)
    {
        _viewOptions = viewOptions;
        _appInfo = appInfo;
        _mapper = mapper;
        _appInfoRepository = appInfoRepository;

        _viewOptions.ShowAppInfo += delegate { ShowAppInfo(); };

        _appInfo.UpdateAppInfo += delegate { UpdateAppInfo(); };
    }



    void ShowAppInfo()
    {
        AppInfo info = _appInfoRepository.GetAll().FirstOrDefault();
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
        AppInfo info = _appInfoRepository.GetOne(x => x.AppName == _appInfo.AppName);
        if (info == null)
        {
            return;
        }

        info = _mapper.Map<AppInfo>(_appInfo);
        try
        {
            _appInfoRepository.Update(info, info.AppName);    
            _appInfo.ShowMessage(@"Cập nhật thông tin thành công");
        }
        catch (Exception e)
        {
            _appInfo.ShowMessage(@"Dữ liệu không hợp lệ");
        }
    }
}