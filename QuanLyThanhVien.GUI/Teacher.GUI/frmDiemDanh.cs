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
    public partial class frmDiemDanh : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            loadClass();  

        }

        private void loadClass()
        {
            dataGridView_Lop.Rows.Clear();
            foreach (Lop item in gvS.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong);
            }
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];

                // Giả sử các cột trong DataGridView có thứ tự từ 0 đến n, với n là số cột
                txt_MaLop.Text = row.Cells[0].Value?.ToString();
                txt_TenLop.Text = row.Cells[1].Value?.ToString();
                loadSinhVienLop();
            }
        }
        private void loadSinhVienLop()
        {
            dataGridView1.Rows.Clear(); 
            foreach (var item in gvS.GetSinhViens(txt_MaLop.Text))
            {
                dataGridView1.Rows.Add(item.MSSV, item.HoTen,dtp_NgayDiemDanh.Text);
            }
        }

        private void dtp_NgayDiemDanh_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[2].Value = dtp_NgayDiemDanh.Value;
            }
        }

        private void btn_CoMat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Value = "X";
            }
        }

        private void VangMat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Value = "V";
            }
        }

        private void btn_Tre_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Value = "T" ;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool flag =true;
            string flagname ="";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {   
                if (row.IsNewRow)
                continue;
                string mssv = row.Cells[0].Value.ToString();
                string classid = txt_MaLop.Text;
                DateTime ngay = DateTime.Parse( row.Cells[2].Value.ToString());
                string trangthai = row.Cells[3].Value.ToString();
                bool a = gvS.DiemDanhSinhVien(mssv, classid, ngay, trangthai);
                if (a==false)
                {
                    flag = false;
                    flagname += row.Cells[1].Value.ToString()+" ";
                }

            }
            if (flag == true)
            {
                MessageBox.Show("diem danh thanh cong");
            }
            else
            {
                MessageBox.Show("diem danh ko thanh ko\n", flagname);

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[2].Value = "";
                row.Cells[3].Value = "";
            }
        }
    }
}
