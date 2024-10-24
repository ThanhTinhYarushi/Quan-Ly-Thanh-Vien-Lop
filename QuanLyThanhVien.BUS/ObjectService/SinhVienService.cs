using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class SinhVienService
    {
        private readonly QLTV2Entities db = new    QLTV2Entities();

        // Hàm lấy sinh viên sử dụng SInhVienInstance.sv.value(from thongtinsinhvien);
        /* vd : 
         * txtMSSV.text =  SInhVienInstance.sv.MSSV;
         * txtHoTen.text =  SInhVienInstance.sv.MSSV;
         * txtDiaChi.text =  SInhVienInstance.sv.MSSV;
         * txtEmail.text =  SInhVienInstance.sv.MSSV;
        */
        // Get điểm của sinh viên trả về một list điểm các môn học sinh viên có tham gia(from Diem)
        public List<Diem> GetDiems()
        {
            return db.Diem.Where(p=>p.MSSV == SinhVienInstance.sv.MSSV ).ToList();
        }  
        // Get tất cả các hoạt động của các lớp mà sinh viên có HỌC (From Hoat Dong)
        public List<HoatDong> GetHoatDong()
        {
            return db.HoatDong.Where(hd => db.LopSinhVien.Join(db.SinhVien,
              lsv => lsv.MSSV,
              sv => sv.MSSV,
              (lsv, sv) => new { lsv.ClassID, sv.MSSV })
            .Where(x => x.MSSV == SinhVienInstance.sv.MSSV)
            .Select(x => x.ClassID)
            .Contains(hd.ClassID))
            .ToList();

        }
        // Đăng kí  và hủy hoạt động nhận vào mssv , mã hoạt động (From Hoat Dong)
        public void DangKyHoatDong(string mssv, string mhd)
        {
            if (mssv!=null && mhd != null)
            {
                ThamGia tg = new ThamGia() { MSSV = mssv ,HoatDongID = int.Parse(mhd)};
                db.ThamGia.Add(tg);
                db.SaveChanges();
            }
        }
        public void HuyDangKy(string mssv, string mhd)
        {
            if (mssv != null && mhd != null)
            {
                ThamGia tg = new ThamGia() { MSSV = mssv, HoatDongID = int.Parse(mhd) };
                db.ThamGia.Remove(tg);
                db.SaveChanges();
            }
        }
        // hàm getLop trả về các lớp mà sinh viên có HỌC (From Thong tin lop hoc)
        public List<Lop> getLop()
        {
            return db.Lop.Where(lop => db.LopSinhVien
            .Join(db.SinhVien, 
             lsv => lsv.MSSV,
             sv => sv.MSSV,
             (lsv, sv) => new { lsv.ClassID, sv.MSSV })
            .Where(x => x.MSSV == SinhVienInstance.sv.MSSV)
            .Select(x => x.ClassID).Contains(lop.ClassID))
            .ToList();

        }
        // Hàm getHDThamGia trả về các hoạt động sinh viên đã đăng kí tham gia (From Thamgia)
        public List<HoatDong> getHDThamGia()
        {
            return db.HoatDong.Where(hd => db.ThamGia
            .Join(db.SinhVien,
             tg => tg.MSSV,
             sv => sv.MSSV,
             (tg, sv) => new { tg.HoatDongID, sv.MSSV })
            .Where(x => x.MSSV == SinhVienInstance.sv.MSSV)
            .Select(x => x.HoatDongID)
            .Contains(hd.HoatDongID))
            .ToList();

        }
        // hàm getThongBao sẽ trả về các thông báo của các Môn học mà sinh viên có HỌC (From thông báo)
        public List<ThongBao> getThongBao()
        {
            return db.ThongBao
            .Where(tb => db.LopSinhVien
            .Join(db.SinhVien,
              lsv => lsv.MSSV,
              sv => sv.MSSV,
              (lsv, sv) => new { lsv.ClassID, sv.MSSV })
            .Where(x => x.MSSV == SinhVienInstance.sv.MSSV)
            .Select(x => x.ClassID)
            .Contains(tb.ClassID))
            .ToList();
        }





    }
}
