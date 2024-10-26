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
    
    public partial class frmNhapVaQuanLyDiem : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmNhapVaQuanLyDiem()
        {
            InitializeComponent();
        }
        private void fill_dgv_Lop()
        {
            foreach (Lop item in gvS.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID, item.TenLop, item.MSGV, item.TenLop, item.Phong);
            }
        }
        private void fill_dgv_Diem()
        {
            foreach (Diem item in gvS.GetDiems(txt_MaLop.Text)) 
            {
                dataGridView_Diem.Rows.Add(item.MSSV, gvS.tenSinhVien(item.MSSV), item.DiemQT, item.DiemGK);
            }
        }

        private void frmNhapVaQuanLyDiem_Load(object sender, EventArgs e)
        {
            fill_dgv_Lop();
        }

        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells[0].Value.ToString();
            }
            fill_dgv_Diem();

        }
    }
}
