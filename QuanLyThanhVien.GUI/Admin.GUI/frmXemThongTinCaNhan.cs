using QuanLyThanhVien.BUS;
using QuanLyThanhVien.BUS.ObjectService;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmXemThongTinCaNhan : Form
    {
        private readonly AdminService service = new AdminService(); 
        QLTV2Entities db = new QLTV2Entities();
        // lay tat ca sv va gv
        // lay tat ca lop
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }

        public frmXemThongTinCaNhan()
        {
            InitializeComponent();
           
        }

        private void frmXemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadGiaoVien();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            txt_TrangThai.Text = "";
            txt_SoDienThoai.Text = "";
            txt_Ten.Text = "";
            txt_Tim.Text = "";
        }

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            // sửa tt ng đó
            // thêm 
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

       

        

        private void btn_XemSV_Click(object sender, EventArgs e)
        {
            dataGridView_obj.Rows.Clear();
            dataGridView_obj.Columns[0].HeaderText = "MSSV";
            loadSinhVien(); 
        }

        private void btn_XemGV_Click(object sender, EventArgs e)
        {
            dataGridView_obj.Rows.Clear();
            dataGridView_obj.Columns[0].HeaderText = "MSGV";
            loadGiaoVien();
        }
        private void loadSinhVien()
        {
            dataGridView_obj.Rows.Clear();
            foreach (SinhVien item in service.GetSinhViens())
            {
                dataGridView_obj.Rows.Add(item.MSSV,item.HoTen,item.Email,item.SoDienThoai,item.DiaChi,item.NgaySinh,item.TrangThaiSV);
            }
        }
        private void loadGiaoVien()
        {
            dataGridView_obj.Rows.Clear();
            foreach (GiaoVien item in service.GetGiaoViens())
            {
                dataGridView_obj.Rows.Add(item.MSGV, item.HoTen, item.Email, item.SoDienThoai, item.DiaChi, item.NgaySinh, item.TrangThaiGV);
            }
        }

        private void dataGridView_obj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView_obj.Rows[e.RowIndex];

                txtMa.Text = row.Cells[0].Value?.ToString();
                txt_Ten.Text = row.Cells[1].Value?.ToString();
                txt_Email.Text = row.Cells[2].Value?.ToString();
                txt_SoDienThoai.Text = row.Cells[3].Value?.ToString();
                txt_DiaChi.Text = row.Cells[4].Value?.ToString();
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime ngayThucHien))
                {
                    dtp_NgaySinh.Format = DateTimePickerFormat.Short;
                    dtp_NgaySinh.Value = ngayThucHien;
                }
               
                txt_TrangThai.Text = row.Cells[6].Value?.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((db.UserAccount.FirstOrDefault(p => p.MSGV == txtMa.Text || p.MSSV == txtMa.Text)) == null)
            {
                if (txtMa.Text.Contains("GV"))
                {
                    service.capTaiKhoan(txtMa.Text, "Teacher");
                    MessageBox.Show("Cap thanh cong");
                }
                else
                {
                    service.capTaiKhoan(txtMa.Text, "Student");
                    MessageBox.Show("Cap thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Tai khoan da ton tai");
            }
           
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra email
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!emailRegex.IsMatch(txt_Email.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                return;
            }

            // Kiểm tra số điện thoại
            Regex phoneRegex = new Regex(@"^(\+84|0)\d{9,10}$");
            if (!phoneRegex.IsMatch(txt_SoDienThoai .Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại số điện thoại có 9-10 chữ số, bắt đầu bằng +84 hoặc 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SoDienThoai.Focus();
                return;
            }

            // Kiểm tra mã số 
            Regex mssvRegex = new Regex(@"^(SV|GV)\d{3}$");
            string inputText = txtMa.Text.Trim();
            if (!mssvRegex.IsMatch(inputText))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ! Mã phải bắt đầu bằng 'SV or GV' và theo sau là 3 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                return;
            }



            // Kiểm tra họ tên
            Regex nameRegex = new Regex(@"^[\p{L} ]+$");
            if (!nameRegex.IsMatch(txt_Ten.Text))
            {
                MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Ten.Focus();
                return;
            }

            // Kiểm tra địa chỉ (đơn giản là không được để trống)
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống! Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DiaChi.Focus();
                return;
            }
            if (txtMa.Text.Contains("GV"))
            {
                bool x= service.capnhatGV(txtMa.Text,txt_Ten.Text, txt_Email.Text, txt_SoDienThoai.Text,  txt_DiaChi.Text, dtp_NgaySinh.Value,true);
                if (x == true)
                {
                    MessageBox.Show("cap nhat thanh cong");
                    loadGiaoVien();
                }
                else
                {
                    MessageBox.Show("cap nhat ko thanh cong");
                }
            }
            else
            {
                bool x = service.capnhatSV(txtMa.Text, txt_Ten.Text, txt_Email.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinh.Value, true);
                if (x == true)
                {
                    MessageBox.Show("cap nhat thanh cong");
                    loadGiaoVien();
                }
                else
                {
                    MessageBox.Show("cap nhat ko thanh cong");
                }
            }
            
        }

        private void btn_SuaThongTin_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra email
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (!emailRegex.IsMatch(txt_Email.Text))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
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

            // Kiểm tra mã số 
            Regex mssvRegex = new Regex(@"^(SV|GV)\d{3}$");
            if (!mssvRegex.IsMatch(txtMa.Text))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ! Mã phải bắt đầu bằng 'SV or GV' và theo sau là 3 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                return;
            }



            // Kiểm tra họ tên
            Regex nameRegex = new Regex(@"^[\p{L} ]+$");
            if (!nameRegex.IsMatch(txt_Ten.Text))
            {
                MessageBox.Show("Họ tên không hợp lệ! Vui lòng chỉ nhập chữ cái và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Ten.Focus();
                return;
            }

            // Kiểm tra địa chỉ (đơn giản là không được để trống)
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống! Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DiaChi.Focus();
                return;
            }
            if (txtMa.Text.Contains("GV"))
            {
                bool x = service.capnhatGV(txtMa.Text, txt_Ten.Text, txt_Email.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinh.Value, true);
                if (x == true)
                {
                    MessageBox.Show("cap nhat thanh cong");
                    loadGiaoVien();
                }
                else
                {
                    MessageBox.Show("cap nhat ko thanh cong");
                }
            }
            else
            {
                bool x = service.capnhatSV(txtMa.Text, txt_Ten.Text, txt_Email.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinh.Value, true);
                if (x == true)
                {
                    MessageBox.Show("cap nhat thanh cong");
                    loadGiaoVien();
                }
                else
                {
                    MessageBox.Show("cap nhat ko thanh cong");
                }
            }

        }
    }
}
