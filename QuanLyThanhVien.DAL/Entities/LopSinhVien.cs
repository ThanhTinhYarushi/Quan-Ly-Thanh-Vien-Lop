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
    
    public partial class LopSinhVien
    {
        public int LopSinhVienID { get; set; }
        public int ClassID { get; set; }
        public string MSSV { get; set; }
    
        public virtual Lop Lop { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
