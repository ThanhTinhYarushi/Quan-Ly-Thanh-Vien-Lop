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
    
    public partial class UserAccount
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string MSSV { get; set; }
        public string MSGV { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
