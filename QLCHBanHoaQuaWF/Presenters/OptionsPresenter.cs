using QLCHBanHoaQuaWF.Models;
using QLCHBanHoaQuaWF.Views.Options;

namespace QLCHBanHoaQuaWF.Presenters;

public class OptionsPresenter
{
    private readonly IViewOptions _viewOptions;
    private readonly IAppInfo _appInfo;
    private readonly MyAppContext _context;
    public OptionsPresenter(IViewOptions viewOptions, MyAppContext context, IAppInfo appInfo)
    {
        _viewOptions = viewOptions;
        _appInfo = appInfo;
        _context = context;

        _viewOptions.ShowAppInfo += delegate { ShowAppInfo(); };

        _appInfo.UpdateAppInfo += delegate { UpdateAppInfo(); };


    }



    void ShowAppInfo()
    {
        AppInfo info = _context.AppInfos.FirstOrDefault();
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
        AppInfo info = _context.AppInfos.Find(_appInfo.AppName);
        if (info == null)
        {
            return;
        }

        info.AppName = _appInfo.AppName;
        info.Address = _appInfo.Address;
        info.Phone = _appInfo.Phone;
        info.Email = _appInfo.Email;
        try
        {
            _context.SaveChanges();
            MessageBox.Show("Cập nhật thông tin thành công");
            Form form = (Form)_appInfo;
            form.Close();
        }
        catch (Exception e)
        {
            _context.Entry(info).Reload();
            MessageBox.Show("Dữ liệu không hợp lệ");
        }
    }
}