using QuanLyThanhVien.BUS;
using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class frmThongTinCaNhanSinhVien : Form
    {
        SinhVienService service = new SinhVienService();
        SinhVien a = SinhVienInstance.sv;
        public frmThongTinCaNhanSinhVien()
        {
            
            InitializeComponent();
            txtDiaChi.Text = a.DiaChi;
            txtEmail.Text = a.Email;
            txtGioiTinh.Text = (a.GioiTinh == true) ? "Nam" : "Nữ";
            txtMSSV.Text = a.MSSV;
            txtSoDienThoai.Text = a.SoDienThoai;
            txtHoTen.Text = a.HoTen;
        }
        private void loadThongtin()
        {
            SinhVien a = SinhVienInstance.sv;
            txtDiaChi.Text = a.DiaChi;
            txtEmail.Text = a.Email;
            txtGioiTinh.Text = (a.GioiTinh == true) ? "Nam" : "Nữ";
            txtMSSV.Text = a.MSSV;
            txtSoDienThoai.Text = a.SoDienThoai;
            txtHoTen.Text = a.HoTen;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra email
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!emailRegex.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            Regex phoneRegex = new Regex(@"^(\+84|0)\d{9,10}$");
            if (!phoneRegex.IsMatch(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại số điện thoại có 9-10 chữ số, bắt đầu bằng +84 hoặc 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra mã số sinh viên
            Regex mssvRegex = new Regex(@"^SV\d{3}$");
            if (!mssvRegex.IsMatch(txtMSSV.Text))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ! Mã phải bắt đầu bằng 'SV' và theo sau là 3 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSSV.Focus();
                return ;
            }

            // Kiểm tra giới tính
            if (txtGioiTinh.Text != "Nam" && txtGioiTinh.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ! Vui lòng nhập 'Nam' hoặc 'Nữ'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return ;
            }

            // Kiểm tra họ tên
            Regex nameRegex = new Regex(@"^[\p{L} ]+$");
            if (!nameRegex.IsMatch(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return ;
            }

            // Kiểm tra địa chỉ (đơn giản là không được để trống)
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống! Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }
            bool a = (txtGioiTinh.Text=="Nam")?true:false;
            bool x = service.capnhat(txtHoTen.Text,dtpNgaySinh.Value,txtEmail.Text,a,txtDiaChi.Text,txtSoDienThoai.Text);
            if (x==true)
            {
                MessageBox.Show("cap nhat thanh cong");
                loadThongtin();
            }
            else
            {
                MessageBox.Show("cap nhat ko thanh cong");
            }
        }
    }
}
