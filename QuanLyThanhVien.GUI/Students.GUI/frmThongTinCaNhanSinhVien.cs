using QuanLyThanhVien.BUS;
using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class frmThongTinCaNhanSinhVien : Form
    {
        public frmThongTinCaNhanSinhVien()
        {
            InitializeComponent();
            SinhVien a = SinhVienInstance.sv;
            txtDiaChi.Text = a.DiaChi;
            txtEmail.Text = a.Email;
            txtGioiTinh.Text = (a.GioiTinh == true) ? "Nam" : "Nữ";
            txtMSSV.Text=a.MSSV;
            txtSoDienThoai.Text = a.SoDienThoai;
            txtHoTen.Text = a.HoTen;
        }



    }
}
