using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class GiaoVienInstance
    {
        public static GiaoVien gv;

        public static void getSinhVien(string msgv)
        {
            QLTV2Entities qLTVEntities1 = new QLTV2Entities();
            gv = qLTVEntities1.GiaoVien.FirstOrDefault(p => p.MSGV == msgv);
        }

    }
}
