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
    public partial class frmLopSinhVien : Form
    {
        private readonly SinhVienService service= new SinhVienService();
        public frmLopSinhVien()
        {
            InitializeComponent();
        }

        private void frmLopSinhVien_Load(object sender, EventArgs e)
        {
            loadLop();
        }
        private void loadLop()
        {
            foreach (var item in service.getLop() )
            {
                GiaoVien gv = service.GetGiaoVien(item.MSGV);
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong,gv.HoTen,gv.SoDienThoai,gv.Email);  
            }
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];

                txtMaLop.Text = row.Cells[0].Value?.ToString(); 
                txtTenLop.Text = row.Cells[1].Value?.ToString(); 
                txtTiet.Text = row.Cells[2].Value?.ToString();
                txtPhong.Text = row.Cells[3].Value?.ToString();
                txtTenGiangVien.Text = row.Cells[4].Value?.ToString(); 
                txtSDT.Text = row.Cells[5].Value?.ToString(); 
                txtEmail.Text = row.Cells[6].Value?.ToString();   

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
