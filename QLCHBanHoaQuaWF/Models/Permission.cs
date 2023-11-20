using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBanHoaQuaWF.Models
{
    public class Permission
    {
        [Key]
        public int PermissionID { get; set; }

        public int UserRoleID { get; set; }
        [ForeignKey("UserRoleID")]
        public UserRole UserRole { get; set; }
        [DisplayName("Cho phép xem sản phẩm")]
        public bool CanReadProduct { get; set; }
        [DisplayName("Cho phép thêm sản phẩm")]
        public bool CanCreateProduct { get; set; }
        [DisplayName("Cho phép sửa sản phẩm")]
        public bool CanUpdateProduct { get; set; }
        [DisplayName("Cho phép xóa sản phẩm")]
        public bool CanDeleteProduct { get; set; }
        [DisplayName("Cho phép xuất file sản phẩm")]
        public bool CanExportProduct { get; set; }
        [DisplayName("Cho phép nhập file sản phẩm")]
        public bool CanImportProduct { get; set; }
        [DisplayName("Cho phép xóa đơn hàng nhập")]
        public bool CanDeleteImportOrder { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng nhập")]
        public bool CanExportImportOrder { get; set; }
        [DisplayName("Cho phép nhập file đơn hàng nhập")]
        public bool CanImportImportOrder { get; set; }
        [DisplayName("Cho phép xóa đơn hàng bán")]
        public bool CanDeleteSalesOrder { get; set; }
        [DisplayName("Cho phép xuất file đơn hàng bán")]
        public bool CanExportSalesOrder { get; set; }
        [DisplayName("Cho phép nhập file đơn hàng bán")]
        public bool CanImportSalesOrder { get; set; }
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
        public bool IsAdmin { get; set; }
    }
}
