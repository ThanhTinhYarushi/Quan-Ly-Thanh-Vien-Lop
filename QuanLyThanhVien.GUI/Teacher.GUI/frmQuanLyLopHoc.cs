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
    public partial class frmQuanLyLopHoc : Form
    {
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void btn_XemDanhSachThamGia_Click(object sender, EventArgs e)
        {
            frmXemDanhSachThamGia frm = new frmXemDanhSachThamGia();
            frm.ShowDialog();
        }
    }
}
