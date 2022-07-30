//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_KhachHang()
        {
            this.tb_HDBanHang = new HashSet<tb_HDBanHang>();
        }

        public int MaKH { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HoTen { get; set; }

        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(11, ErrorMessage = "Số điện thoại phải 10 hoặc 11 số", MinimumLength = 10)]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Địa không được để trống")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HDBanHang> tb_HDBanHang { get; set; }
    }
}