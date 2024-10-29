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

namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    public partial class frmThongTinCaNhanGiangVien : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        private BindingSource gvBindingSource = new BindingSource(); // dung de rang buoc du lieu
        public frmThongTinCaNhanGiangVien()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhanGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                fill_TTGV();
                gvBindingSource.DataSource = GiaoVienInstance.gv;
                camSua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        public void fill_TTGV()
        {
            // sd lop instance tu bus de lay ttsv
            txt_MaGiangVien.Text = GiaoVienInstance.gv.MSGV;
            txt_TenGiangVien.Text = GiaoVienInstance.gv.HoTen;
            txt_EmailGiangVien.Text = GiaoVienInstance.gv.Email;
            txt_SoDienThoai.Text = GiaoVienInstance.gv.SoDienThoai;
            txt_DiaChi.Text = GiaoVienInstance.gv.DiaChi;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) // kt 
            {
                return;
            }
            gvBindingSource.EndEdit();
            // goi ham tu gvS roi dung bool de kt
            bool isSuccess = gvS.updateGV(txt_TenGiangVien.Text, txt_EmailGiangVien.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinhGiangVien.Value);

            if (isSuccess)
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cập Nhật Không Thành Công", "Thông Báo");
            }
        }
        private void camSua(bool choPhep)
        {
            if (choPhep)
            {
                txt_MaGiangVien.Enabled = false;
                txt_TenGiangVien.Enabled = false;
            }
        }
        private void BindControls() // ham su dung bindingtrol: databinbding
        {
            txt_MaGiangVien.DataBindings.Add("Text", gvBindingSource, nameof(GiaoVien.MSGV));
            txt_TenGiangVien.DataBindings.Add("Text", gvBindingSource, nameof(GiaoVien.HoTen));
            txt_EmailGiangVien.DataBindings.Add("Text", gvBindingSource, nameof(GiaoVien.Email));
            txt_SoDienThoai.DataBindings.Add("Text", gvBindingSource, nameof(GiaoVien.SoDienThoai));
            txt_DiaChi.DataBindings.Add("Text", gvBindingSource, nameof(GiaoVien.DiaChi));
            dtp_NgaySinhGiangVien.DataBindings.Add("Value", gvBindingSource, nameof(GiaoVien.NgaySinh));
        }
        // ham kiem tra tien cho viec goi va sua dung lai -> tuong minh hon
        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txt_TenGiangVien.Text))
            {
                MessageBox.Show("Họ tên không được để trống", "Lỗi");
                txt_TenGiangVien.Focus();
                return false;
            }

            if (!IsValidEmail(txt_EmailGiangVien.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "Lỗi");
                txt_EmailGiangVien.Focus();
                return false;
            }

            if (!IsPhoneNumberValid(txt_SoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi");
                txt_SoDienThoai.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi");
                txt_DiaChi.Focus();
                return false;
            }
            // tuoi phai 25 tro len
            int age = DateTime.Now.Year - dtp_NgaySinhGiangVien.Value.Year;
            if (dtp_NgaySinhGiangVien.Value > DateTime.Now.AddYears(-age))
            {
                age--; // check ngay sinh neu chua den time bay gio
            }
            if (age < 25)
            {
                MessageBox.Show("Giảng viên phải ít nhất 25 tuổi", "Lỗi");
                dtp_NgaySinhGiangVien.Focus();
                return false;
            }
            //neu dung het moi duoc di tiep
            return true;
        }
        private bool IsValidEmail(string email)
        {
            // regex lay tren trang https://regex101.com/library/SOgUIV
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // regex lay tren trang https://itforusblog.wordpress.com/2020/05/28/regex-so-dien-thoai-viet-nam/
            var phonePattern = @"^\d{10}$"; // Giả sử số điện thoại có 10 chữ số
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
