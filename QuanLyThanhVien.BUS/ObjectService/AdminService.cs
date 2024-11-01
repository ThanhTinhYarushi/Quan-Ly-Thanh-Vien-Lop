using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS.ObjectService
{
    public class AdminService
    {
        private readonly QLTV2Entities db = new QLTV2Entities();
        public List<GiaoVien> GetGiaoViens()
        {
            return db.GiaoVien.ToList();
        }
        public List<SinhVien> GetSinhViens()
        {
            return db.SinhVien.ToList();
        }
        public List<HoatDong> GetHoatDongs()
        {
            return db.HoatDong.ToList();
        }
        public List<ThamGia> GetThamGias(int hoatdongID)
        {
            return db.ThamGia.Where(p => p.HoatDongID == hoatdongID).ToList();
        }
        public List<PhanHoi> GetPhanHois(int hoatdongID)
        {
            return db.PhanHoi.Where(p=>p.HoatDongID==hoatdongID).ToList();
        }
        public bool CreateHoatDong(string tieuDe, string moTa, DateTime ngayThucHien, TimeSpan thoiGian, string diaDiem, string classID,string hoatdongid)
        {
            if (hoatdongid == "")
            {
                HoatDong hd = new HoatDong();
                hd.TieuDe = tieuDe;
                hd.MoTa = moTa;
                hd.NgayThucHien = ngayThucHien;
                hd.ThoiGian = thoiGian;
                hd.DiaDiem = diaDiem;
                hd.ClassID = classID;
                db.HoatDong.AddOrUpdate(hd);
                db.SaveChanges();
                return true;

            }
            else
            {
                HoatDong hd = new HoatDong();
                hd.HoatDongID = int.Parse( hoatdongid);
                hd.TieuDe = tieuDe;
                hd.MoTa = moTa;
                hd.NgayThucHien = ngayThucHien;
                hd.ThoiGian = thoiGian;
                hd.DiaDiem = diaDiem;
                hd.ClassID = classID;
                db.HoatDong.AddOrUpdate(hd);
                db.SaveChanges();
                return true;
            }

        }
        public bool xoaHoatDong(int hoatdongID)
        {
            try
            {
                HoatDong hd = db.HoatDong.FirstOrDefault(p => p.HoatDongID == hoatdongID);
                db.HoatDong.Remove(hd);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool CreateAndUpdateLop(string classID, string tenLop, string MSGV, string tietHoc, string phong, bool trangthailop)
        {
            if (classID != "" || tenLop != "" || MSGV != "" || tietHoc != "" || phong != "")
            {
                Lop lop = new Lop();
                lop.ClassID = classID;
                lop.TenLop = tenLop;
                lop.MSGV = MSGV;
                lop.TietHoc = tietHoc;
                lop.Phong = phong;
                lop.TrangThaiLop = trangthailop;
                db.Lop.AddOrUpdate (lop);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Lop> GetLops()
        {
            return db.Lop.ToList();
        }
        public List<ThongBao> getthongBaos()
        {   
            return db.ThongBao.ToList();
        }
        public List<ThongBao> GetThongBaoID(string classid)
        {
            return db.ThongBao.Where(p=>p.ClassID == classid).ToList(); 
        }
        public bool capnhatSV(string mssv,string ten,string email,string sdt,string diachi,DateTime ngaySinh,bool trangThai)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = mssv;
            sv.HoTen= ten;
            sv.Email = email;
            sv.SoDienThoai = sdt;
            sv.DiaChi= diachi;
            sv.NgaySinh= ngaySinh;
            sv.TrangThaiSV= trangThai;
            db.SinhVien.AddOrUpdate(sv);
            db.SaveChanges();
            return true;
        }
        public bool capnhatGV(string msgv, string ten, string email, string sdt, string diachi, DateTime ngaySinh, bool trangThai)
        {
            GiaoVien sv = new GiaoVien();
            sv.MSGV = msgv;
            sv.HoTen = ten;
            sv.Email = email;
            sv.SoDienThoai = sdt;
            sv.DiaChi = diachi;
            sv.NgaySinh = ngaySinh;
            sv.TrangThaiGV = trangThai;
            db.GiaoVien.AddOrUpdate(sv);
            db.SaveChanges();
            return true;
        }
        public bool capTaiKhoan(string ma,string role)
        {
            UserAccount userAccount = new UserAccount();
            userAccount.Username = ma;
            userAccount.Password = "password123";
            userAccount.Role  = role;
            if (role == "Student")
            {
                userAccount.MSSV = ma;
            }
            else
            {
                userAccount.MSGV = ma;
            }
            db.UserAccount.Add(userAccount);
            db.SaveChanges();
            return true;
        }
        public void themThemThongBao(string tieude,string noidung,DateTime ngayTao,string classID)
        {
            ThongBao  thongBao = new ThongBao();
            thongBao.NgayTao = ngayTao;
            thongBao.TieuDe = tieude;
            thongBao.NoiDung = noidung;
            thongBao.ClassID = classID;
            db.ThongBao.Add(thongBao);
            db.SaveChanges ();
        }
        public void updateThongbao(int ma,string tieude, string noidung, DateTime ngayTao, string classID)
        {
            ThongBao thongBao = new ThongBao();
            thongBao.NgayTao = ngayTao;
            thongBao.TieuDe = tieude;
            thongBao.NoiDung = noidung;
            thongBao.ClassID = classID;
            thongBao.ThongBaoID = ma;
            db.ThongBao.AddOrUpdate(thongBao);
            db.SaveChanges();
        }
        public void XoaThongBao(int thongbaoID)
        {
           ThongBao tb = db.ThongBao.FirstOrDefault(p=>p.ThongBaoID == thongbaoID);
            db.ThongBao.Remove(tb);
            db.SaveChanges();
        }

    }
}
