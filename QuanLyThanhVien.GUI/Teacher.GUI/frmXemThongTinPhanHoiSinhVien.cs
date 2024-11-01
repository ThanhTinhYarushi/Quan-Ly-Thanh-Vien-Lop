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
    public partial class frmXemThongTinPhanHoiSinhVien : Form
    {
        private readonly GiaoVienService service = new GiaoVienService();
        public frmXemThongTinPhanHoiSinhVien()
        {
            InitializeComponent();
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[0].HeaderText == "MSSV")
            {
                if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                    txt_MaSinhVien.Text = row.Cells[0].Value?.ToString(); 
                    txt_TenSinhVien.Text = row.Cells[1].Value?.ToString(); 
                    txt_TieuDe.Text = row.Cells[2].Value?.ToString();
                    dateTimePicker1.Text = row.Cells[4].Value?.ToString();
                    rtb_txt_NoiDungPhanHoi.Text = row.Cells[3].Value?.ToString(); 
                    
                }
            }
        }

        private void dataGridView_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[0].HeaderText == "MSSV")
            {
                return;
            }
            HoatDongID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "MSSV";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Tiêu đề";
            dataGridView1.Columns[3].HeaderText = "Nội dung";
            dataGridView1.Columns[4].HeaderText = "Ngày phản hồi";
            dataGridView1.Columns[5].Visible = false;
            

            foreach (var item in service.getPhanHoi(HoatDongID.Text))
            {
                dataGridView1.Rows.Add(item.MSSV,item.SinhVien.HoTen,item.HoatDong.TieuDe,item.NoiDung,item.NgayPhanHoi);            }

        }

        private void frmXemThongTinPhanHoiSinhVien_Load(object sender, EventArgs e)
        {
            loadHoatDong();
        }
        private void loadHoatDong()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "Mã hoạt động";
            dataGridView1.Columns[1].HeaderText = "Tiêu đề";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
            dataGridView1.Columns[3].HeaderText = "Ngày thực hiện";
            dataGridView1.Columns[4].HeaderText = "Thời gian";
            dataGridView1.Columns[5].HeaderText = "Địa điểm";

            foreach (var item in service.GetHoatDong() )
            {
                dataGridView1.Rows.Add(item.HoatDongID,item.TieuDe,item.MoTa,item.NgayThucHien,item.ThoiGian,item.DiaDiem);
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loadHoatDong();
        }
    }
}
