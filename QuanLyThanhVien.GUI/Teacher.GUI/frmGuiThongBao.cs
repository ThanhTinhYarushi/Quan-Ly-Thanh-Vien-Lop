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
    public partial class frmGuiThongBao : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
      
        public frmGuiThongBao()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }
        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ThongBao.Rows[e.RowIndex];
                txt_MaThongBao.Text = row.Cells[0].Value.ToString();
                txt_TieuDeThongBao.Text = row.Cells[1].Value.ToString();
                rtb_txt_NoiDungThongBao.Text = row.Cells[2].Value.ToString();

                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayTao))
                {
                    dtp_NgayTao.Format = DateTimePickerFormat.Short;
                    dtp_NgayTao.Value = ngayTao;
                }

                if (row.Cells[4].Value != null)
                {
                    cbo_MaLop.Text = row.Cells[4].Value.ToString();
                }
                txt_TenLop.Text = row.Cells[5].Value.ToString();
            }
        }

        private void frmGuiThongBao_Load(object sender, EventArgs e)
        {
            try
            {
              
                setGridViewStyle(dgv_ThongBao);
                fill_dgv();
                fill_cbo_MaLop();
                CamSua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
        }
        private void fill_dgv()
        {
            foreach (ThongBao item in gvS.GetThongBaos())
            {
                dgv_ThongBao.Rows.Add(item.ThongBaoID, item.TieuDe,item.NoiDung, item.NgayTao, item.ClassID, gvS.getClassName(item.ClassID));
            }
        }
        public void setGridViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

      
        private void fill_cbo_MaLop()
        {
            cbo_MaLop.Items.Clear();
            foreach (Lop item in gvS.GetLops())
            {
                cbo_MaLop.Items.Add(item.ClassID);
                txt_TenLop.Text = gvS.getClassName(item.ClassID);
            }
        }
        
        private void CamSua(bool choPhep)
        {
            if (choPhep)
            {
                txt_MaThongBao.Enabled = false;
                txt_TenLop.Enabled = false;
            }
        }

        private void refresh()
        {
            dgv_ThongBao.Rows.Clear();
            fill_dgv();

            txt_MaThongBao.Text = string.Empty;
            txt_TieuDeThongBao.Text = string.Empty;
            rtb_txt_NoiDungThongBao.Text = string.Empty;
            dtp_NgayTao.Value = DateTime.Now;
            cbo_MaLop.SelectedIndex = -1;
            txt_TenLop.Text = string.Empty;

            fill_cbo_MaLop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra tiêu đề
            Regex titleRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!titleRegex.IsMatch(txt_TieuDeThongBao.Text))
            {
                MessageBox.Show("Tiêu đề không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDeThongBao.Focus();
                return;
            }

            // Kiểm tra nội dung
            Regex contentRegex = new Regex(@".{10,500}");
            if (!contentRegex.IsMatch(rtb_txt_NoiDungThongBao.Text))
            {
                MessageBox.Show("Nội dung không hợp lệ! Vui lòng nhập từ 10 đến 500 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_txt_NoiDungThongBao.Focus();
                return;
            }

            // Kiểm tra ngày tạo
            DateTime createdDate = dtp_NgayTao.Value;
            if (createdDate < DateTime.Today)
            {
                MessageBox.Show("Ngày tạo không được là ngày trong quá khứ ! Vui lòng chọn một ngày hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_NgayTao.Focus();
                return;
            }

            // Kiểm tra mã lớp
            bool kt = gvS.KtLopThuocGiaoVien(cbo_MaLop.Text);
            if (!kt)
            {
                MessageBox.Show("Vui lòng chỉ chọn các lớp bạn dạy");
                cbo_MaLop.Focus();
                return;
            }

            // Tạo thông báo
            bool x = gvS.createThongBao(txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, dtp_NgayTao.Value, cbo_MaLop.Text);
            if (x)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }

        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra tiêu đề
            Regex titleRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!titleRegex.IsMatch(txt_TieuDeThongBao.Text))
            {
                MessageBox.Show("Tiêu đề không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDeThongBao.Focus();
                return;
            }

            // Kiểm tra nội dung
            Regex contentRegex = new Regex(@".{10,500}");
            if (!contentRegex.IsMatch(rtb_txt_NoiDungThongBao.Text))
            {
                MessageBox.Show("Nội dung không hợp lệ! Vui lòng nhập từ 10 đến 500 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtb_txt_NoiDungThongBao.Focus();
                return;
            }

            // Kiểm tra ngày tạo
            DateTime createdDate = dtp_NgayTao.Value;
            if (createdDate < DateTime.Today)
            {
                MessageBox.Show("Ngày tạo không được là ngày trong quá khứ ! Vui lòng chọn một ngày hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_NgayTao.Focus();
                return;
            }

            // Kiểm tra mã lớp
            bool kt = gvS.KtLopThuocGiaoVien(cbo_MaLop.Text);
            if (!kt)
            {
                MessageBox.Show("Vui lòng chỉ chọn các lớp bạn dạy");
                cbo_MaLop.Focus();
                return;
            }

            // Tạo thông báo
            bool x = gvS.UpdateThongBao(txt_MaThongBao.Text,txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, dtp_NgayTao.Value, cbo_MaLop.Text);
            if (x)
            {
                MessageBox.Show("Cập nhật Thành Công", "Thông Báo");
                refresh();
            }
            else
            {
                MessageBox.Show("Cập nhật Thất Bại", "Thông Báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông báo này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                bool x = gvS.deleteThongBao(txt_MaThongBao.Text);
                if (x)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Đã hủy xóa thông báo.", "Thông Báo");
            }
        }
    }
}
