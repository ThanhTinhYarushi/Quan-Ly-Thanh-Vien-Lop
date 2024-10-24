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
            QLTVEntities1 qLTVEntities1 = new QLTVEntities1();
            gv = qLTVEntities1.GiaoVien.FirstOrDefault(p => p.MSGV == msgv);
        }
    }
}
