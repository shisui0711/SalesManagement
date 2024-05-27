using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLCHWF.Attributes;

namespace QLCHWF.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionID { get; set; }
        public virtual UserRole UserRole { get; set; }
        [DisplayName("Cho phép xem sản phẩm")]
        [PermissionGroup("Product")]
        public bool CanReadProduct { get; set; }
        [DisplayName("Cho phép thêm sản phẩm")]
        [PermissionGroup("Product")]
        public bool CanCreateProduct { get; set; }
        [DisplayName("Cho phép sửa sản phẩm")]
        [PermissionGroup("Product")]
        public bool CanUpdateProduct { get; set; }
        [DisplayName("Cho phép xóa sản phẩm")]
        [PermissionGroup("Product")]
        public bool CanDeleteProduct { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng nhập")]
        [PermissionGroup("ImportOrder")]
        public bool CanExportImportOrder { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng bán")]
        [PermissionGroup("SalesOrder")]
        public bool CanExportSalesOrder { get; set; }
        [DisplayName("Cho phép xem khách hàng")]
        [PermissionGroup("Customer")]
        public bool CanReadCustomer { get; set; }
        [DisplayName("Cho phép thêm khách hàng")]
        [PermissionGroup("Customer")]
        public bool CanCreateCustomer { get; set; }
        [DisplayName("Cho phép sửa khách hàng")]
        [PermissionGroup("Customer")]
        public bool CanUpdateCustomer { get; set; }
        [PermissionGroup("Customer")]
        [DisplayName("Cho phép xóa khách hàng")]
        public bool CanDeleteCustomer { get; set; }
        [DisplayName("Cho phép xem nhà cung cấp")]
        [PermissionGroup("Provider")]
        public bool CanReadProvider { get; set; }
        [DisplayName("Cho phép thêm nhà cung cấp")]
        [PermissionGroup("Provider")]
        public bool CanCreatedProvider { get; set; }
        [DisplayName("Cho phép sửa nhà cung cấp")]
        [PermissionGroup("Provider")]
        public bool CanUpdateProvider { get; set; }
        [DisplayName("Cho phép xóa nhà cung cấp")]
        [PermissionGroup("Provider")]
        public bool CanDeleteProvider { get; set; }
        [DisplayName("Cho phép xem nhân viên")]
        [PermissionGroup("Employee")]
        public bool CanReadEmployee { get; set; }
        [DisplayName("Cho phép thêm nhân viên")]
        [PermissionGroup("Employee")]
        public bool CanCreateEmployee { get; set; }
        [DisplayName("Cho phép sửa nhân viên")]
        [PermissionGroup("Employee")]
        public bool CanUpdateEmployee { get; set; }
        [DisplayName("Cho phép xóa nhân viên")]
        [PermissionGroup("Employee")]
        public bool CanDeleteEmployee { get; set; }
        [DisplayName("Cho phép xem chi tiết đơn hàng nhập")]
        [PermissionGroup("DetailImportOrder")]
        public bool CanReadDetailImportOrder { get; set; }

        [DisplayName("Cho phép xem chi tiết đơn hàng bán")]
        [PermissionGroup("DetailSalesOrder")]
        public bool CanReadDetailSalesOrder { get; set; }
        [DisplayName("Cho phép xem thống kê")]
        [PermissionGroup("Statistics")]
        public bool CanReadStatistics { get; set; }
        [DisplayName("Cho phép xem người dùng")]
        [PermissionGroup("User")]
        public bool CanReadUser { get; set; }
        [DisplayName("Cho phép xem vai trò")]
        [PermissionGroup("UserRole")]
        public bool CanReadUserRole { get; set; }
        [DisplayName("Cho phép thêm vai trò")]
        [PermissionGroup("UserRole")]
        public bool CanCreateUserRole { get; set; }
        [DisplayName("Cho phép sửa vai trò")]
        [PermissionGroup("UserRole")]
        public bool CanUpdateUserRole { get; set; }
        [DisplayName("Cho phép xóa vai trò")]
        [PermissionGroup("UserRole")]
        public bool CanDeleteUserRole { get; set; }
        [DisplayName("Cho phép xem thiết lập")]
        [PermissionGroup("Options")]
        public bool CanReadOptions { get; set; }
        [DisplayName("Cho phép xem đơn hàng bán")]
        [PermissionGroup("SalesOrder")]
        public bool CanReadSalesOrder { get; set; }
        [DisplayName("Cho phép thêm đơn hàng bán")]
        [PermissionGroup("SalesOrder")]
        public bool CanCreateSalesOrder { get; set; }
        [DisplayName("Cho phép xóa đơn hàng bán")]
        [PermissionGroup("SalesOrder")]
        public bool CanDeleteSalesOrder { get; set; }
        [DisplayName("Cho phép in đơn hàng bán")]
        [PermissionGroup("SalesOrder")]
        public bool CanPrintSalesOrder { get; set; }
        [DisplayName("Cho phép xem đơn hàng nhập")]
        [PermissionGroup("ImportOrder")]
        public bool CanReadImportOrder { get; set; }
        [DisplayName("Cho phép thêm đơn hàng nhập")]
        [PermissionGroup("ImportOrder")]
        public bool CanCreateImportOrder { get; set; }
        [DisplayName("Cho phép xóa đơn hàng nhập")]
        [PermissionGroup("ImportOrder")]
        public bool CanDeleteImportOrder { get; set; }
        [DisplayName("Cho phép in đơn hàng nhập")]
        [PermissionGroup("ImportOrder")]
        public bool CanPrintImportOrder { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
