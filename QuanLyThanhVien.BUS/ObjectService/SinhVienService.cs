using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http.Headers;
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
        public bool updateSV(string hoten, string email, string sdt, string diachi, DateTime ngaySinh)
        {
            if (hoten != null || email != null || sdt != null || diachi != null || ngaySinh != null)
            {
                string mssv = SinhVienInstance.sv.MSSV;
                SinhVien a = new SinhVien()
                {
                    MSSV = mssv,
                    HoTen = hoten,
                    Email = email,
                    SoDienThoai = sdt,
                    DiaChi = diachi,
                    NgaySinh = ngaySinh
                };
                db.SinhVien.AddOrUpdate(a);
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }
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
        public bool DangKyHoatDong(string mssv, string mhd)
        {
            if (mssv!=null && mhd != null)
            {
                ThamGia tg = new ThamGia() { MSSV = mssv ,HoatDongID = int.Parse(mhd),TrangThai="DangKy"};
                db.ThamGia.AddOrUpdate(tg);
                db.SaveChanges();
                return true;
            }else { return false; }
        }
        public bool HuyDangKy(string mssv, string mhd)
        {
            if (mssv != null && mhd != null)
            {
                int ma = int.Parse(mhd);
                ThamGia tg = db.ThamGia.FirstOrDefault(p=>p.MSSV == mssv && p.HoatDongID == ma);
                db.ThamGia.Remove(tg);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
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
        // Hàm trả về một giáo viên
        public GiaoVien GetGiaoVien(string magv)
        {
            if (magv!="")
            {
                return db.GiaoVien.FirstOrDefault(p=>p.MSGV == magv);
            }
            else
            {
                return null;
            }
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
        public List<PhanHoi> GetPhanHois()
        {
            return db.PhanHoi.Where(p=>p.MSSV==SinhVienInstance.sv.MSSV).ToList();
        }
        // laay
        public string getTenLop(string classid)
        {
            return db.Lop.FirstOrDefault(p=>p.ClassID==classid).TenLop;
        }
        public bool guiPhanHoi(string mssv,string hoatdongid,string noidung,DateTime ngay)
        {
            if (mssv!=""||hoatdongid!=""||noidung!=""||ngay!=null)
            {
                PhanHoi ph = new PhanHoi()
                {
                    MSSV = mssv,
                    HoatDongID=int.Parse(hoatdongid),
                    NoiDung=noidung,
                    NgayPhanHoi=ngay
                };
                db.PhanHoi.Add(ph);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getTenHoatDong(int? maHD)
        {
            return db.HoatDong.FirstOrDefault(p=>p.HoatDongID==maHD).TieuDe;
        }





    }
}
