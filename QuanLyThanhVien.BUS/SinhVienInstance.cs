using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class SinhVienInstance
    {
        public static SinhVien sv;

        public static void getSinhVien(string mssv)
        {
            QLTVEntities1 qLTVEntities1 = new QLTVEntities1();
            sv = qLTVEntities1.SinhVien.FirstOrDefault(p=>p.MSSV == mssv);
        }
    }
}
