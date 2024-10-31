using QuanLyThanhVien.BUS.ObjectService;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmQuanLyLopHoc : Form
    {
        private readonly AdminService service = new AdminService();
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
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong,item.TrangThaiLop,item.MSGV,item.GiaoVien.HoTen,item.GiaoVien.Email,item.GiaoVien.SoDienThoai);
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

            bool x = service.CreateAndUpdateLop(txt_MaLop.Text,txt_TenLop.Text,txtMSGV.Text,txtTiet.Text,txtPhong.Text,true);
            if (x == true)
            {
                MessageBox.Show("them lop thanh cong");
                loadLop();
            }
            else
            {
                MessageBox.Show("that bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
