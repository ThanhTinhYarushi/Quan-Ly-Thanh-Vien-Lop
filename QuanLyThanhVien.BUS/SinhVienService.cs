using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class SinhVienService
    {
        private readonly QLTVEntities1 db = new QLTVEntities1();
        public SinhVien GetSinhVien(string mssv)
        {
            return db.SinhVien.FirstOrDefault(p => p.MSSV == mssv); ;
        }
    }
}
