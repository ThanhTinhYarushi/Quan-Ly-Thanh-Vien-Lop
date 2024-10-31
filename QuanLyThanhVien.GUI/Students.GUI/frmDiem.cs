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
    public partial class frmDiem : Form
    {
        private readonly SinhVienService service= new SinhVienService();
        public frmDiem()
        {
            InitializeComponent();
        }


        private void frmDiem_Load(object sender, EventArgs e)
        {
            loadDiem();
        }
        private void loadDiem()
        {
            foreach (var item in service.GetDiems())
            {
                double tong = (((item.DiemGK + item.DiemQT)/2)+item.DiemCK)/2;
                dataGridView1.Rows.Add(item.ClassID,service.getTenLop(item.ClassID),item.DiemQT,item.DiemGK,item.DiemCK,tong);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

               
                textBox1.Text = row.Cells[0].Value?.ToString(); // Mã lớp
                textBox2.Text = row.Cells[1].Value?.ToString(); // Môn học
                textBox4.Text = row.Cells[2].Value?.ToString(); // Điểm chuyên cần
                textBox5.Text = row.Cells[3].Value?.ToString(); // Điểm giữa kì
                textBox6.Text = row.Cells[4].Value?.ToString(); // Điểm cuối kì
                textBox7.Text = row.Cells[5].Value?.ToString(); // Điểm tổng
            }
        }

       

       

        private void frmDiem_Resize_1(object sender, EventArgs e)
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }

}
