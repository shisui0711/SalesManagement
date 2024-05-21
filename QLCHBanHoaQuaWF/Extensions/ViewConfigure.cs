using Microsoft.Extensions.DependencyInjection;
using QLCHWF.Views.Customer;
using QLCHWF.Views.Employee;
using QLCHWF.Views.ImportOrder;
using QLCHWF.Views.Options;
using QLCHWF.Views.Product;
using QLCHWF.Views.Provider;
using QLCHWF.Views.SalesOrder;
using QLCHWF.Views.Statistics;
using QLCHWF.Views.User;
using QLCHWF.Views.UserRole;
using QLCHWF.Views;

namespace QLCHWF.Extensions;

public static class ViewConfigure
{
    public static void AddView(this IServiceCollection services)
    {
        services.AddSingleton<IViewMain, frmMain>();
        services.AddSingleton<IViewCustomer, frmViewCustomer>();
        services.AddSingleton<IAddCustomer, frmAddCustomer>();
        services.AddSingleton<IUpdateCustomer, frmUpdateCustomer>();
        services.AddSingleton<IViewEmployee, frmViewEmployee>();
        services.AddSingleton<IAddEmployee, frmAddEmployee>();
        services.AddSingleton<IUpdateEmployee, frmUpdateEmployee>();
        services.AddSingleton<IViewSalary, frmViewSalary>();
        services.AddSingleton<IViewProduct, frmViewProduct>();
        services.AddSingleton<IAddProduct, frmAddProduct>();
        services.AddSingleton<IUpdateProduct, frmUpdateProduct>();
        services.AddSingleton<IViewProvider, frmViewProvider>();
        services.AddSingleton<IAddProvider, frmAddProvider>();
        services.AddSingleton<IUpdateProvider, frmUpdateProvider>();
        services.AddSingleton<IViewSalesOrder, frmViewSalesOrder>();
        services.AddSingleton<IAddSalesOrder, frmAddSalesOrder>();
        services.AddSingleton<IDetailSalesOrder, frmViewDetailSales>();
        services.AddSingleton<IReportSalesOrder, frmReportSalesOrder>();
        services.AddSingleton<IViewImportOrder, frmViewImportOrder>();
        services.AddSingleton<IAddImportOrder, frmAddImportOrder>();
        services.AddSingleton<IDetailImportOrder, frmViewDetailImport>();
        services.AddSingleton<IReportImportOrder, frmReportImportOrder>();
        services.AddSingleton<IViewUser, frmViewUser>();
        services.AddSingleton<IAddUser, frmAddUser>();
        services.AddSingleton<IUpdatePassword, frmUpdatePassword>();
        services.AddSingleton<IChangePassword, frmChangePassword>();
        services.AddSingleton<IViewUserRole, frmViewUserRole>();
        services.AddSingleton<IAddUserRole, frmAddUserRole>();
        services.AddSingleton<IUpdateUserRole, frmUpdateUserRole>();
        services.AddSingleton<IViewOptions, frmViewOptions>();
        services.AddSingleton<IViewStatistics, frmStatistics>();
        services.AddSingleton<IAppInfo, frmAppInfo>();
        services.AddSingleton<IViewLogin, frmLogin>();
        services.AddSingleton<IHistoryImport, frmHistoryImportOrder>();
        services.AddSingleton<IHistorySales, frmHistorySalesOrder>();
    }
}