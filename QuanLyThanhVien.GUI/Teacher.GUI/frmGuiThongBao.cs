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
    public partial class frmGuiThongBao : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmGuiThongBao()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }

        private void frmGuiThongBao_Load(object sender, EventArgs e)
        {
            fill_dgv();
            fill_cbo_MaLop();
            fill_cbo_TenLop();
        }
        private void fill_dgv()
        {
            foreach (ThongBao item in gvS.GetThongBaos())
            {
                dgv_ThongBao.Rows.Add(item.ThongBaoID, item.TieuDe,item.NoiDung, item.NgayTao, item.ClassID, gvS.getClassName(item.ClassID));
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //bool x = gvS.createAndUpdateThongBao(txt_TieuDeThongBao.Text, txt_TieuDeThongBao.Text, dtp_NgayTao.Value);
        }

        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ThongBao.Rows[e.RowIndex];

            }
        }
        private void fill_cbo_MaLop()
        {
            foreach (Lop item in gvS.GetLops())
            {
                cbo_MaLop.Items.Add(item.ClassID);
            }
        }
        private void fill_cbo_TenLop()
        {
            foreach (Lop item in gvS.GetLops())
            {
                cbo_Lop.Items.Add(gvS.getClassName(item.ClassID));
            }
        }
    }
}
