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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmThongTinCaNhanSinhVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmThongTinCaNhanSinhVien frmNV = new frmThongTinCaNhanSinhVien();
            frmNV.MdiParent = this;
            frmNV.WindowState = FormWindowState.Maximized;
            frmNV.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
