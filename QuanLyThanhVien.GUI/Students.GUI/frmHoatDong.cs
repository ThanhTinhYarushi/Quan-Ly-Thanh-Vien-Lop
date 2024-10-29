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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class frmHoatDong : Form
    {
        private readonly  SinhVienService service = new SinhVienService();
        public frmHoatDong()
        {
            InitializeComponent();
        }

        

        private void frmHoatDong_Load(object sender, EventArgs e)
        {
            LoadHoatDong(); 
        }
        private void LoadHoatDong()
        {
            dataGridView1.Rows.Clear();
            foreach (HoatDong item in service.GetHoatDong())
            {
                dataGridView1.Rows.Add(item.HoatDongID, item.TieuDe, item.MoTa, item.NgayThucHien, item.ThoiGian, item.DiaDiem);
                comboBox1.Items.Add(item.HoatDongID);
            }
            
        }


        private void btnDangki_Click(object sender, EventArgs e)
        {
            bool x= service.DangKyHoatDong(SinhVienInstance.sv.MSSV,comboBox1.Text);
            if (x == true) MessageBox.Show("DangKyThanhCong");else MessageBox.Show("Dangky that bai");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bool x = service.HuyDangKy(SinhVienInstance.sv.MSSV, comboBox1.Text);
            if (x)
            {
                MessageBox.Show("Huy dang ky thanh cong");
            }
            else
            {
                MessageBox.Show("Huy ko thanh cong");
            }
        }

        private void btnDaThamGia_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in service.getHDThamGia())
            {
                dataGridView1.Rows.Add(item.HoatDongID, item.TieuDe, item.MoTa, item.NgayThucHien, item.ThoiGian, item.DiaDiem);
            }
        }

        private void btnThamGia_Click(object sender, EventArgs e)
        {
            LoadHoatDong();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBox1.Text= row.Cells[0].Value?.ToString(); 
                txtTieuDe.Text = row.Cells[1].Value?.ToString();
                txtMota.Text = row.Cells[2].Value?.ToString(); 
                
                txtDiaDiem.Text = row.Cells[5].Value?.ToString();
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayThucHien))
                {
                    dateNgay.Format = DateTimePickerFormat.Short;
                    dateNgay.Value = ngayThucHien;
                }
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime thoiGian))
                {
                    dateGio.Format = DateTimePickerFormat.Time;
                    dateGio.Value = thoiGian;
                }
            }
        }
    }
}
