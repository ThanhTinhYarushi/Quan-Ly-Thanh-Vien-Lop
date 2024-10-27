using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS
{
    public class GiaoVienService
    {

        QLTV2Entities db = new QLTV2Entities();

        // hàm lấy toàn bộ thông báo giáo viên tạo 

        // hàm cập nhật thông tin cá nhân giảng viên truyền vào các thông tin
        public bool updateGV(string hoten, string email, string sdt, string diachi, DateTime ngaySinh)
        {
            if (hoten != null || email != null || sdt != null || diachi != null || ngaySinh != null)
            {
                string mssv = GiaoVienInstance.gv.MSGV;
                GiaoVien a = new GiaoVien()
                {
                    MSGV = mssv,
                    HoTen = hoten,
                    Email = email,
                    SoDienThoai = sdt,
                    DiaChi = diachi,
                    NgaySinh = ngaySinh
                };
                db.GiaoVien.AddOrUpdate(a);
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }

        public List<ThongBao> GetThongBaos()
        {
            return db.ThongBao
            .Where(tb => db.Lop
            .Join(db.GiaoVien,
              l => l.MSGV,
              gv => gv.MSGV,
              (l, gv) => new { l.ClassID, gv.MSGV })
            .Where(x => x.MSGV == GiaoVienInstance.gv.MSGV)
            .Select(x => x.ClassID)
            .Contains(tb.ClassID))
            .OrderBy(tb => tb.ClassID)
            .ToList();

        }


        // Hàm lấy tên lớp Nhận vào một mã lớp và trả ra một tên lớp
        // Vì hàm getThongBao chỉ trả về classID nên nếu muốn lấy tên lớp hãy gọi getClassName

        public string getClassName(string iClassID)
        {
            if (iClassID != "")
            {
                string name = db.Lop.FirstOrDefault(p => p.ClassID == iClassID).TenLop.ToString();
                if (name != null)
                {
                    return name;
                }
                else
                {
                    return "empty";
                }
            }
            else
            {
                return "empty";
            }
        }

        // Hàm cập nhật  thông báo cho phép giảng viên cập nhật lại các thônb báo đã  gửi 

        public bool UpdateThongBao(string ma,string tieuDe, string NoiDung, DateTime ngayTao, string classID)
        {
            // Kiểm tra xem giảng viên có dạy lớp này ko
            string msgv = GiaoVienInstance.gv.MSGV;
            if (msgv == db.Lop.FirstOrDefault(p => p.ClassID == classID).MSGV)
            {
                ThongBao tb = new ThongBao() { ThongBaoID = int.Parse(ma) ,TieuDe = tieuDe, NoiDung = NoiDung, NgayTao = ngayTao, ClassID = classID };
                db.ThongBao.AddOrUpdate(tb);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // hàm tạo thông báo ko nhận vào mã thông báo
        public bool createThongBao( string tieuDe, string NoiDung, DateTime ngayTao, string classID)
        {
            // Kiểm tra xem giảng viên có dạy lớp này ko
            string msgv = GiaoVienInstance.gv.MSGV;
            if (msgv == db.Lop.FirstOrDefault(p => p.ClassID == classID).MSGV)
            {
                ThongBao tb = new ThongBao() {  TieuDe = tieuDe, NoiDung = NoiDung, NgayTao = ngayTao, ClassID = classID };
                db.ThongBao.AddOrUpdate(tb);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteThongBao(string thongBaoID)
        {
            int thongbaoid = int.Parse(thongBaoID);
            ThongBao tb = db.ThongBao.FirstOrDefault(p => p.ThongBaoID ==thongbaoid );
            if (tb != null)
            {
                db.ThongBao.Remove(tb);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        // Ham lay tat ca lop giao vien co day
        public List<Lop> GetLops()
        {
            return db.Lop
             .Where(tb => db.Lop
             .Join(db.GiaoVien,
               l => l.MSGV,
               gv => gv.MSGV,
               (l, gv) => new { l.ClassID, gv.MSGV })
             .Where(x => x.MSGV == GiaoVienInstance.gv.MSGV)
             .Select(x => x.ClassID)
             .Contains(tb.ClassID))
             .OrderBy(tb => tb.ClassID)
             .ToList();

        }
        // Hàm getDiem sẽ trả về tất cả các điểm số của các sinh viên học lớp đó
        public List<Diem> GetDiems(string classID)
        {
            return db.Diem.Where(p => p.ClassID == classID).ToList();
        }
        public string tenSinhVien(string mssv)
        {
            return db.SinhVien.FirstOrDefault(p=>p.MSSV == mssv).HoTen.ToString();
        }

        public List<HoatDong> GetHoatDong()
        {
            return db.HoatDong.Where(p=>p.MSGV == GiaoVienInstance.gv.MSGV).ToList();
        }



        public bool CreateHoatDong(string tieuDe,string moTa,DateTime ngayThucHien,TimeSpan thoiGian,string diaDiem,string classID)
        {
            string msgv = GiaoVienInstance.gv.MSGV;
            if (msgv == db.Lop.FirstOrDefault(p => p.ClassID == classID).MSGV)
            {
                HoatDong hd = new HoatDong();
                hd.MSGV = msgv;
                hd.TieuDe = tieuDe;
                hd.MoTa = moTa; 
                hd.NgayThucHien = ngayThucHien;
                hd.ThoiGian = thoiGian;
                hd.DiaDiem = diaDiem;
                hd.ClassID = classID;
                db.HoatDong.AddOrUpdate(hd);
                db.SaveChanges();
                return true;
            }else { return false; }

        }
        public bool DeleteHoatDong(int hoatDongID)
        {
            HoatDong hoatDong = db.HoatDong.FirstOrDefault(p => p.HoatDongID == hoatDongID);
            if (hoatDong.MSGV==GiaoVienInstance.gv.MSGV)
            {
                db.HoatDong.Remove(hoatDong);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<SinhVien> GetSinhViens(string classID)
        {
            return db.SinhVien
            .Where(sv => db.LopSinhVien
            .Where(lsv => lsv.ClassID == classID)
            .Select(lsv => lsv.MSSV)
            .Contains(sv.MSSV))
            .ToList();
        }






    }
}
