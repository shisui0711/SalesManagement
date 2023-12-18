using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCHBanHoaQuaWF.Models
{
    public class Permission
    {
        [Key]
        public int PermissionID { get; set; }
        public virtual UserRole UserRole { get; set; }
        [DisplayName("Cho phép xem sản phẩm")]
        public bool CanReadProduct { get; set; }
        [DisplayName("Cho phép thêm sản phẩm")]
        public bool CanCreateProduct { get; set; }
        [DisplayName("Cho phép sửa sản phẩm")]
        public bool CanUpdateProduct { get; set; }
        [DisplayName("Cho phép xóa sản phẩm")]
        public bool CanDeleteProduct { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng nhập")]
        public bool CanExportImportOrder { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng bán")]
        public bool CanExportSalesOrder { get; set; }
        [DisplayName("Cho phép xem khách hàng")]
        public bool CanReadCustomer { get; set; }
        [DisplayName("Cho phép thêm khách hàng")]
        public bool CanCreateCustomer { get; set; }
        [DisplayName("Cho phép sửa khách hàng")]
        public bool CanUpdateCustomer { get; set; }
        [DisplayName("Cho phép xóa khách hàng")]
        public bool CanDeleteCustomer { get; set; }
        [DisplayName("Cho phép xem nhà cung cấp")]
        public bool CanReadProvider { get; set; }
        [DisplayName("Cho phép thêm nhà cung cấp")]
        public bool CanCreatedProvider { get; set; }
        [DisplayName("Cho phép sửa nhà cung cấp")]
        public bool CanUpdateProvider { get; set; }
        [DisplayName("Cho phép xóa nhà cung cấp")]
        public bool CanDeleteProvider { get; set; }
        [DisplayName("Cho phép xem nhân viên")]
        public bool CanReadEmployee { get; set; }
        [DisplayName("Cho phép thêm nhân viên")]
        public bool CanCreateEmployee { get; set; }
        [DisplayName("Cho phép sửa nhân viên")]
        public bool CanUpdateEmployee { get; set; }
        [DisplayName("Cho phép xóa nhân viên")]
        public bool CanDeleteEmployee { get; set; }
        [DisplayName("Cho phép xem chi tiết đơn hàng nhập")]
        public bool CanReadDetailImportOrder { get; set; }

        [DisplayName("Cho phép xem chi tiết đơn hàng bán")]
        public bool CanReadDetailSalesOrder { get; set; }
        [DisplayName("Cho phép xem thống kê")]
        public bool CanReadStatistics { get; set; }
        [DisplayName("Cho phép xem người dùng")]
        public bool CanReadUser { get; set; }
        [DisplayName("Cho phép xem vai trò")]
        public bool CanReadUserRole { get; set; }
        [DisplayName("Cho phép thêm vai trò")]
        public bool CanCreateUserRole { get; set; }
        [DisplayName("Cho phép sửa vai trò")]
        public bool CanUpdateUserRole { get; set; }
        [DisplayName("Cho phép xóa vai trò")]
        public bool CanDeleteUserRole { get; set; }
        [DisplayName("Cho phép xem thiết lập")]
        public bool CanReadOptions { get; set; }
        [DisplayName("Cho phép xem đơn hàng bán")]
        public bool CanReadSalesOrder { get; set; }
        [DisplayName("Cho phép thêm đơn hàng bán")]
        public bool CanCreateSalesOrder { get; set; }
        [DisplayName("Cho phép xóa đơn hàng bán")]
        public bool CanDeleteSalesOrder { get; set; }
        [DisplayName("Cho phép in đơn hàng bán")]
        public bool CanPrintSalesOrder { get; set; }
        [DisplayName("Cho phép xem đơn hàng nhập")]
        public bool CanReadImportOrder { get; set; }
        [DisplayName("Cho phép thêm đơn hàng nhập")]
        public bool CanCreateImportOrder { get; set; }
        [DisplayName("Cho phép xóa đơn hàng nhập")]
        public bool CanDeleteImportOrder { get; set; }
        [DisplayName("Cho phép in đơn hàng nhập")]
        public bool CanPrintImportOrder { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
