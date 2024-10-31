using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThanhVien.BUS.ObjectService
{
    public class AdminService
    {
        private readonly QLTV2Entities db = new QLTV2Entities();

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
        
    }
}
