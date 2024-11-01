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
    public partial class frmQuanLyHoatDongLopHoc : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        bool x; // giup cac ham them/sua/xoa in thong bao
        public frmQuanLyHoatDongLopHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoatDongLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dataGridView_HoatDong);
                fill_dgv();
                CamSua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void fill_dgv()
        {
            foreach (HoatDong item in gvS.GetHoatDong())
            {
                dataGridView_HoatDong.Rows.Add(item.HoatDongID, item.TieuDe, item.MoTa, item.NgayThucHien, item.ThoiGian, item.DiaDiem, item.ClassID);
                
            }
        }
        private void dataGridView_HoatDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_HoatDong.Rows[e.RowIndex];
                txt_MaHoatDong.Text = row.Cells[0].Value.ToString();
                txt_TieuDe.Text = row.Cells[1].Value.ToString();
                txt_rtb_MoTa.Text = row.Cells[2].Value.ToString();
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayThucHien))
                {
                    dtp_NgayThucHien.Format = DateTimePickerFormat.Short;
                    dtp_NgayThucHien.Value = ngayThucHien;
                }
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime thoiGian))
                {
                    t_ThoiGian.Format = DateTimePickerFormat.Time;
                    t_ThoiGian.Value = thoiGian;
                }


                txt_DiaDiem.Text = row.Cells[5].Value.ToString();
                txt_MaLopHoatDong.Text = row.Cells[6].Value.ToString();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra tiêu đề
            Regex titleRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!titleRegex.IsMatch(txt_TieuDe.Text))
            {
                MessageBox.Show("Tiêu đề không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDe.Focus();
                return;
            }

            // Kiểm tra mô tả
            Regex descriptionRegex = new Regex(@".{10,500}");
            if (!descriptionRegex.IsMatch(txt_rtb_MoTa.Text))
            {
                MessageBox.Show("Mô tả không hợp lệ! Vui lòng nhập từ 10 đến 500 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rtb_MoTa.Focus();
                return;
            }

            // Kiểm tra địa điểm
            Regex locationRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!locationRegex.IsMatch(txt_DiaDiem.Text))
            {
                MessageBox.Show("Địa điểm không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DiaDiem.Focus();
                return;
            }

            // Kiểm tra mã lớp hoạt động
            bool kt = gvS.KtLopThuocGiaoVien(txt_MaLopHoatDong.Text);
            if (!kt)
            {
                MessageBox.Show("Vui lòng chỉ chọn các lớp bạn dạy");
                txt_MaLopHoatDong.Focus();
                return;
            }
            DateTime selectedDate = dtp_NgayThucHien.Value;
            if (selectedDate <= DateTime.Today)
            {
                MessageBox.Show("Ngày thực hiện không được là ngày trong quá khứ và ngày hôm nay ! Vui lòng chọn một ngày hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_NgayThucHien.Focus();
                return;
            }

            // Tạo hoạt động
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = selectedTime.TimeOfDay;
            bool x = gvS.CreateHoatDong(txt_TieuDe.Text, txt_rtb_MoTa.Text, dtp_NgayThucHien.Value, timeSpan, txt_DiaDiem.Text, txt_MaLopHoatDong.Text);
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_MaHoatDong.Text))
            {
                MessageBox.Show("Không thể xoá nếu để trống mã lớp", "Thông Báo");
                return; // thoat sk neu ko se hien box xac nhan xoa
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xoá không?", "Xác Nhận Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                x = gvS.DeleteHoatDong(int.Parse(txt_MaHoatDong.Text));
                if (x)
                {
                    MessageBox.Show("Xoá Thành Công", "Thông Báo");
                    refresh();
                }
                else
                {
                    MessageBox.Show("Xoá Thất Bại", "Thông Báo");
                    refresh();
                }
            }
                
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra tiêu đề
            Regex titleRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!titleRegex.IsMatch(txt_TieuDe.Text))
            {
                MessageBox.Show("Tiêu đề không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TieuDe.Focus();
                return;
            }

            // Kiểm tra mô tả
            Regex descriptionRegex = new Regex(@".{10,500}");
            if (!descriptionRegex.IsMatch(txt_rtb_MoTa.Text))
            {
                MessageBox.Show("Mô tả không hợp lệ! Vui lòng nhập từ 10 đến 500 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rtb_MoTa.Focus();
                return;
            }

            // Kiểm tra địa điểm
            Regex locationRegex = new Regex(@"^[\w\s]{5,100}$");
            if (!locationRegex.IsMatch(txt_DiaDiem.Text))
            {
                MessageBox.Show("Địa điểm không hợp lệ! Vui lòng nhập từ 5 đến 100 ký tự, chỉ bao gồm chữ cái, số và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DiaDiem.Focus();
                return;
            }

            // Kiểm tra mã lớp hoạt động
            bool kt = gvS.KtLopThuocGiaoVien(txt_MaLopHoatDong.Text);
            if (!kt)
            {
                MessageBox.Show("Vui lòng chỉ chọn các lớp bạn dạy");
                txt_MaLopHoatDong.Focus();
                return;
            }
            DateTime selectedDate = dtp_NgayThucHien.Value;
            if (selectedDate <= DateTime.Today)
            {
                MessageBox.Show("Ngày thực hiện không được là ngày trong quá khứ và ngày hôm nay ! Vui lòng chọn một ngày hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_NgayThucHien.Focus();
                return;
            }

            // Tạo hoạt động
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = selectedTime.TimeOfDay;
            int ma = int.Parse(txt_MaHoatDong.Text);
            bool x = gvS.UpdateHoatDong(ma,txt_TieuDe.Text, txt_rtb_MoTa.Text, dtp_NgayThucHien.Value, timeSpan, txt_DiaDiem.Text, txt_MaLopHoatDong.Text);
            if (x)
            {
                MessageBox.Show("Cap nhat Thành Công", "Thông Báo");
                refresh();
            }
            else
            {
                MessageBox.Show("Cap nhat Thất Bại", "Thông Báo");
            }

        }
        private void CamSua(bool choPhep)
        {
            if (choPhep)
            {
                txt_MaHoatDong.Enabled = false;
            }
        }
        private void refresh()
        {
            dataGridView_HoatDong.Rows.Clear();
            fill_dgv();
            txt_MaHoatDong.Text = string.Empty;
            txt_TieuDe.Text = string.Empty;
            txt_rtb_MoTa.Text = string.Empty;
            dtp_NgayThucHien.Value = DateTime.Now;
            t_ThoiGian.Value = DateTime.Now;
            txt_DiaDiem.Text = string.Empty;
            txt_MaLopHoatDong.Text = string.Empty;
            dataGridView_HoatDong.ClearSelection();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
