using QuanLyThanhVien.BUS;
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

namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    public partial class frmThongTinCaNhanGiangVien : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmThongTinCaNhanGiangVien()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhanGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                fill_TTGV();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        public void fill_TTGV()
        {
            txt_MaGiangVien.Text = GiaoVienInstance.gv.MSGV;
            txt_TenGiangVien.Text = GiaoVienInstance.gv.HoTen;
            txt_EmailGiangVien.Text = GiaoVienInstance.gv.Email;
            txt_SoDienThoai.Text = GiaoVienInstance.gv.SoDienThoai;
            txt_DiaChi.Text = GiaoVienInstance.gv.DiaChi;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra email
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!emailRegex.IsMatch(txt_EmailGiangVien.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EmailGiangVien.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            Regex phoneRegex = new Regex(@"^(\+84|0)\d{9,10}$");
            if (!phoneRegex.IsMatch(txt_SoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại số điện thoại có 9-10 chữ số, bắt đầu bằng +84 hoặc 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SoDienThoai.Focus();
                return;
            }

            // Kiểm tra mã số giảng viên
            Regex msgvRegex = new Regex(@"^GV\d{3}$");
            if (!msgvRegex.IsMatch(txt_MaGiangVien.Text))
            {
                MessageBox.Show("Mã số giảng viên không hợp lệ! Mã phải bắt đầu bằng 'GV' và theo sau là 3 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaGiangVien.Focus();
                return;
            }

            // Kiểm tra họ tên
            Regex nameRegex = new Regex(@"^[\p{L} ]+$");
            if (!nameRegex.IsMatch(txt_TenGiangVien.Text))
            {
                MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenGiangVien.Focus();
                return;
            }

            // Kiểm tra địa chỉ (đơn giản là không được để trống)
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống! Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DiaChi.Focus();
                return;
            }

           

            bool a = gvS.updateGV(txt_TenGiangVien.Text, txt_EmailGiangVien.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinhGiangVien.Value);
            if (a) 
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cập Nhật KO Thành Công", "Thông Báo");
            }
        }
    }
}
