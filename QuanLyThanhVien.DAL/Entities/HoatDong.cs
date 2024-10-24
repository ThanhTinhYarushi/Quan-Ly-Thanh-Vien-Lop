//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThanhVien.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoatDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoatDong()
        {
            this.PhanHoi = new HashSet<PhanHoi>();
            this.ThamGia = new HashSet<ThamGia>();
        }
    
        public int HoatDongID { get; set; }
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
        public System.DateTime NgayThucHien { get; set; }
        public System.TimeSpan ThoiGian { get; set; }
        public string DiaDiem { get; set; }
        public string ClassID { get; set; }
        public string MSGV { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual Lop Lop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanHoi> PhanHoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThamGia> ThamGia { get; set; }
    }
}
