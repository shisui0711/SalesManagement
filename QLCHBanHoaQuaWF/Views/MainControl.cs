using System.Reflection;
using System.Windows.Forms;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.Product;
using QLCHBanHoaQuaWF.Views.Provider;

namespace QLCHBanHoaQuaWF.Views;

public class MainControl
{
    private IViewMain _viewMain;
    private IViewEmployee _viewEmployee;
    private IViewCustomer _viewCustomer;
    private IViewProduct _viewProduct;
    private IViewProvider _viewProvider;
    public MainControl(IViewMain viewMain, IViewCustomer viewCustomer, IViewEmployee viewEmployee, IViewProduct viewProduct, IViewProvider viewProvider)
    {
        _viewMain = viewMain;
        _viewCustomer = viewCustomer;
        _viewEmployee = viewEmployee;
        _viewProduct = viewProduct;
        _viewProvider = viewProvider;

        _viewMain.LoadPages += delegate { LoadPages(); };
    }

    public void LoadPages()
    {
        List<FieldInfo> fieldViews = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => f.FieldType.Name.StartsWith("IView")).ToList();
        foreach (TabPage tabPage in _viewMain.NavigationBar.TabPages)
        {
            string name = tabPage.Name.Substring(3);
            var field = fieldViews.Find(f => f.FieldType.Name.Substring(5) == name);
            if (field != null)
            {
                Form form = (Form)field.GetValue(this);
                form.TopLevel = false;
                tabPage.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }

        }
    }
}