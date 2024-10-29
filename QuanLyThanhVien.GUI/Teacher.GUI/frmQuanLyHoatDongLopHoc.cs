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
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = selectedTime.TimeOfDay;
            x = gvS.CreateHoatDong(txt_TieuDe.Text, txt_rtb_MoTa.Text, dtp_NgayThucHien.Value, timeSpan, txt_DiaDiem.Text, txt_MaLopHoatDong.Text);
            if (x)
            {
                MessageBox.Show("Thêm Thành Công","Thông Báo");
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
