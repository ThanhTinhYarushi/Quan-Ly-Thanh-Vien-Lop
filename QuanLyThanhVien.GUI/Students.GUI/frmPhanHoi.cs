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

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class frmPhanHoi : Form
    {
        private readonly SinhVienService service = new SinhVienService();
        public frmPhanHoi()
        {
            InitializeComponent();
            //dataGridView1.Rows.
        }

       
        private void frmPhanHoi_Load(object sender, EventArgs e)
        {
            LoadHoatDong();
        }
        private void LoadHoatDong()
        {
            dataGridView1.Rows.Clear();
            
            dataGridView1.Columns[0].HeaderText = "Mã hoạt động";
            dataGridView1.Columns[1].HeaderText = "Tiêu đề";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
            dataGridView1.Columns[3].HeaderText = "Ngày thực hiện";
            dataGridView1.Columns[4].HeaderText = "Thời gian";
            dataGridView1.Columns[5].HeaderText = "Địa điểm";
            foreach (HoatDong item in service.GetHoatDong())
            {
                dataGridView1.Rows.Add(item.HoatDongID, item.TieuDe, item.MoTa, item.NgayThucHien, item.ThoiGian, item.DiaDiem);
               
            }

        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            LoadHoatDong();
        }

        private void btnXemPhanHoi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns[0].HeaderText = "Mã hoạt động";
            dataGridView1.Columns[1].HeaderText = "Nội dung";
            dataGridView1.Columns[2].HeaderText = "Ngày phản hồi";
            dataGridView1.Columns[3].HeaderText = "Hoạt động";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            
            foreach (var item in service.GetPhanHois())
            {
                
                
                dataGridView1.Rows.Add(item.MSSV, item.NoiDung, item.NgayPhanHoi,service.getTenHoatDong(item.HoatDongID));
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaHD.Text = row.Cells[0].Value?.ToString();
                txtTieuDe.Text = row.Cells[1].Value?.ToString();
              
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            
            var a =service.guiPhanHoi(SinhVienInstance.sv.MSSV, txtMaHD.Text, txtNoiDung.Text, dateTimePicker1.Value);
            if (a==true)
            {
                MessageBox.Show("Gui phan hoi thanh cong");
            }
            else
            {
                MessageBox.Show("Gui phan hoi that bai");
            }
        }

        private void btnThuHoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtNoiDung.Text = "";
            txtTieuDe.Text = "";
          
        }

        private void frmPhanHoi_Resize(object sender, EventArgs e)
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }
}
