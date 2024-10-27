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
            QLTV2Entities qLTVEntities1 = new QLTV2Entities();
            sv = qLTVEntities1.SinhVien.FirstOrDefault(p=>p.MSSV == mssv);
        }
    }
}
