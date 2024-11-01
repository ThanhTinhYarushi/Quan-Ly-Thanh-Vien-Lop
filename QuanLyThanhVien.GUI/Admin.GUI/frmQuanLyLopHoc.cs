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
    public partial class frmQuanLyLopHoc : Form
    {
        private readonly AdminService service = new AdminService();
        QLTV2Entities db = new QLTV2Entities() ;
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
           loadLop();
        }
        private void loadLop()
        {
            dataGridView_Lop.Rows.Clear();
            foreach(Lop item in service.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong,item.TrangThaiLop,item.MSGV);
            }
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells[0].Value?.ToString();
                txt_TenLop.Text = row.Cells[1].Value?.ToString();
                txtTiet.Text = row.Cells[2].Value?.ToString();
                txtPhong.Text = row.Cells[3].Value?.ToString();
                txtMSGV.Text = row.Cells[5].Value?.ToString();
                txtTrangThai.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Biểu thức regex chỉ cho phép chữ cái, chữ số và khoảng trắng
            Regex regex = new Regex(@"^[\p{L}\d\s]+$");

            // Kiểm tra mã lớp
            if (string.IsNullOrWhiteSpace(txt_MaLop.Text) || !regex.IsMatch(txt_MaLop.Text))
            {
                MessageBox.Show("Mã lớp không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaLop.Focus();
                return;
            }

            // Kiểm tra tên lớp
            if (string.IsNullOrWhiteSpace(txt_TenLop.Text) || !regex.IsMatch(txt_TenLop.Text))
            {
                MessageBox.Show("Tên lớp không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenLop.Focus();
                return;
            }

            // Kiểm tra MSGV
            if (string.IsNullOrWhiteSpace(txtMSGV.Text) || !regex.IsMatch(txtMSGV.Text))
            {
                MessageBox.Show("MSGV không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSGV.Focus();
                return;
            }
            if (db.GiaoVien.FirstOrDefault(p=>p.MSGV==txtMSGV.Text)==null)
            {
                MessageBox.Show("MSGV ko ton tai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSGV.Focus();
                return;
            }

            // Kiểm tra số tiết
            if (string.IsNullOrWhiteSpace(txtTiet.Text))
            {
                MessageBox.Show("Tiet không được để trống! Vui lòng nhập tiet.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiet.Focus();
                return;
            }

            // Kiểm tra phòng học
            if (string.IsNullOrWhiteSpace(txtPhong.Text) || !regex.IsMatch(txtPhong.Text))
            {
                MessageBox.Show("Phòng học không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhong.Focus();
                return;
            }

            // Gọi hàm sau khi kiểm tra tất cả các trường hợp hợp lệ
            bool x = service.CreateAndUpdateLop(txt_MaLop.Text, txt_TenLop.Text, txtMSGV.Text, txtTiet.Text, txtPhong.Text, true);
            if (x)
            {
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLop();
            }
            else
            {
                MessageBox.Show("Thêm lớp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Biểu thức regex chỉ cho phép chữ cái, chữ số và khoảng trắng
            Regex regex = new Regex(@"^[\p{L}\d\s]+$");

            // Kiểm tra mã lớp
            if (string.IsNullOrWhiteSpace(txt_MaLop.Text) || !regex.IsMatch(txt_MaLop.Text))
            {
                MessageBox.Show("Mã lớp không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaLop.Focus();
                return;
            }

            // Kiểm tra tên lớp
            if (string.IsNullOrWhiteSpace(txt_TenLop.Text) || !regex.IsMatch(txt_TenLop.Text))
            {
                MessageBox.Show("Tên lớp không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TenLop.Focus();
                return;
            }

            // Kiểm tra MSGV
            if (string.IsNullOrWhiteSpace(txtMSGV.Text) || !regex.IsMatch(txtMSGV.Text))
            {
                MessageBox.Show("MSGV không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSGV.Focus();
                return;
            }
            if (db.GiaoVien.FirstOrDefault(p => p.MSGV == txtMSGV.Text) == null)
            {
                MessageBox.Show("MSGV ko ton tai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSGV.Focus();
                return;
            }

            // Kiểm tra số tiết
            if (string.IsNullOrWhiteSpace(txtTiet.Text))
            {
                MessageBox.Show("Tiet không được để trống! Vui lòng nhập tiet.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiet.Focus();
                return;
            }

            // Kiểm tra phòng học
            if (string.IsNullOrWhiteSpace(txtPhong.Text) || !regex.IsMatch(txtPhong.Text))
            {
                MessageBox.Show("Phòng học không hợp lệ! Vui lòng nhập không để trống và không chứa ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhong.Focus();
                return;
            }
            bool x = service.CreateAndUpdateLop(txt_MaLop.Text, txt_TenLop.Text, txtMSGV.Text, txtTiet.Text, txtPhong.Text,bool.Parse(txtTrangThai.Text));
            if (x == true)
            {
                MessageBox.Show("cap nhat thanh cong");
                loadLop();
            }
            else
            {
                MessageBox.Show("that bai");
            }
        }
    }
}
