﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ch_nhac_cu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.CTHoaDons = new HashSet<CTHoaDon>();
        }

        [DisplayName("Mã hóa đơn")]
        public string MaHD { get; set; }
        [DisplayName("Ngày đặt hàng")]
        public System.DateTime NgayDH { get; set; }
        [DisplayName("Ngày giao hàng")]
        public Nullable<System.DateTime> NgayGH { get; set; }
        [DisplayName("Mã khách hàng")]
        public string MaKH { get; set; }
        [DisplayName("Mã nhân viên")]
        public string MaNV { get; set; }
        [DisplayName("Tình trang duyệt")]
        public bool TinhTrangDuyet { get; set; }
        [DisplayName("Tình trạng đơn hàng")]
        public bool TinhTrangDonHang { get; set; }
        [DisplayName("Tổng tiền")]
        public Nullable<int> TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
