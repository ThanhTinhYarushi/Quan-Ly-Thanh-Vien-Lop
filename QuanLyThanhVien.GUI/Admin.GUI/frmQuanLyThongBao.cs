using QuanLyThanhVien.BUS.ObjectService;
using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmQuanLyThongBao : Form
    {
        private readonly AdminService service = new AdminService();
        public frmQuanLyThongBao()
        {
            InitializeComponent();
        }

        private void frmQuanLyThongBao_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }

        private void frmQuanLyThongBao_Load(object sender, EventArgs e)
        {
            loadLop();
        }
        private void loadLop()
        {
            dataGridView_Lop.Rows.Clear();
            dataGridView_Lop.Columns[0].HeaderText = "Mã lớp";
            dataGridView_Lop.Columns[1].HeaderText = "Tên lớp";
            dataGridView_Lop.Columns[2].HeaderText = "Tiết học";
            dataGridView_Lop.Columns[3].HeaderText = "Phòng";
            dataGridView_Lop.Columns[4].HeaderText = "";
            dataGridView_Lop.Columns[5].HeaderText = "";
            dataGridView_Lop.Rows.Clear();
            foreach (Lop item in service.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID, item.TenLop, item.TietHoc, item.Phong);
            }
        }
        private void xemThongBao()
        {
            dataGridView_Lop.Rows.Clear();
            dataGridView_Lop.Columns[0].HeaderText = "Ma tb";
            dataGridView_Lop.Columns[1].HeaderText = "Tiêu đề ";
            dataGridView_Lop.Columns[2].HeaderText = "Nội dung";
            dataGridView_Lop.Columns[3].HeaderText = "Ngày tạo";
            dataGridView_Lop.Columns[4].HeaderText = "Mã lớp";
            dataGridView_Lop.Columns[5].HeaderText = "Tên lớp";
            
            dataGridView_Lop.Rows.Clear();
            foreach (var item in service.getthongBaos())
            {
                dataGridView_Lop.Rows.Add(item.ThongBaoID,item.TieuDe,item.NoiDung,item.NgayTao,item.Lop.ClassID,item.Lop.TenLop);
            }
        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            loadLop();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            xemThongBao();
        }

        private void dataGridView_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Lop.Columns[0].HeaderText=="Mã lớp")
            {
                string malop = dataGridView_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(malop);
                dataGridView_Lop.Rows.Clear();
                dataGridView_Lop.Columns[0].HeaderText = "Ma tb";
                dataGridView_Lop.Columns[1].HeaderText = "Tiêu đề ";
                dataGridView_Lop.Columns[2].HeaderText = "Nội dung";
                dataGridView_Lop.Columns[3].HeaderText = "Ngày tạo";
                dataGridView_Lop.Columns[4].HeaderText = "Mã lớp";
                dataGridView_Lop.Columns[5].HeaderText = "Tên lớp";


                dataGridView_Lop.Rows.Clear();
                foreach (var item in service.GetThongBaoID(malop))
                {
                    dataGridView_Lop.Rows.Add(item.TieuDe, item.NoiDung, item.NgayTao, item.Lop.ClassID, item.Lop.TenLop);
                }
            }
          
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Lop.Columns[0].HeaderText=="Ma tb")
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];
                txt_MaThongBao.Text = row.Cells[0].Value?.ToString();
                txt_TieuDeThongBao.Text = row.Cells[1].Value?.ToString();
                rtb_txt_NoiDungThongBao.Text = row.Cells[2].Value?.ToString();
                dtp_NgayTao.Text = row.Cells[3].Value?.ToString();
                cbo_MaLop.Text = row.Cells[4].Value?.ToString();
                txt_TenLop.Text = row.Cells[5].Value?.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txt_TieuDeThongBao.Text))
            {
                MessageBox.Show("Tiêu đề không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDeThongBao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtb_txt_NoiDungThongBao.Text))
            {
                MessageBox.Show("Nội dung không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_txt_NoiDungThongBao.Focus();
                return;
            }

            if (cbo_MaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_MaLop.Focus();
                return;
            }

            // Gọi hàm thêm thông báo
            DateTime ngayTao = dtp_NgayTao.Value;
            string classID = cbo_MaLop.Text;
            service.themThemThongBao(txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, ngayTao, classID);
            MessageBox.Show("Thêm thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xemThongBao(); // Giả định bạn có hàm để tải lại dữ liệu
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txt_MaThongBao.Text))
            {
                MessageBox.Show("Mã thông báo không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaThongBao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_TieuDeThongBao.Text))
            {
                MessageBox.Show("Tiêu đề không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDeThongBao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtb_txt_NoiDungThongBao.Text))
            {
                MessageBox.Show("Nội dung không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_txt_NoiDungThongBao.Focus();
                return;
            }

            if (cbo_MaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_MaLop.Focus();
                return;
            }

            // Gọi hàm cập nhật thông báo
            int maThongBao = int.Parse(txt_MaThongBao.Text); // Giả định mã thông báo là số nguyên
            DateTime ngayTao = dtp_NgayTao.Value;
            string classID = cbo_MaLop.Text;
            service.updateThongbao(maThongBao, txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, ngayTao, classID);
            MessageBox.Show("Cập nhật thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xemThongBao(); // Giả định bạn có hàm để tải lại dữ liệu
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã thông báo không được để trống
            if (string.IsNullOrWhiteSpace(txt_MaThongBao.Text))
            {
                MessageBox.Show("Mã thông báo không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MaThongBao.Focus();
                return;
            }

            // Xác nhận trước khi xóa
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông báo này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int maThongBao = int.Parse(txt_MaThongBao.Text); // Giả định mã thông báo là số nguyên
                service.XoaThongBao(maThongBao);
                MessageBox.Show("Xóa thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xemThongBao(); // Giả định bạn có hàm để tải lại dữ liệu
            }
        }

    }

}
