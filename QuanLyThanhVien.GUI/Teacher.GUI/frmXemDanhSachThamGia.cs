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
    public partial class frmXemDanhSachThamGia : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmXemDanhSachThamGia()
        {
            InitializeComponent();
           
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemDanhSachThamGia_Load(object sender, EventArgs e)
        {
            fill_dgv_HD();
        }
        private void fill_dgv_HD()
        {
            foreach(HoatDong item in gvS.GetHoatDong())
            {
                dataGridView_DSHD.Rows.Add(item.HoatDongID,item.TieuDe);
            }
        }

        private void dataGridView_DSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
