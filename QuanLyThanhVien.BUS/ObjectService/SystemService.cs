using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class SystemService
    {
        private readonly QLTV2Entities db = new QLTV2Entities();
        public UserAccount GetUser(string name, string mk)
        {
            return db.UserAccount.FirstOrDefault(p=>(p.Username == name &&  p.Password == mk));
        }
    }
}
