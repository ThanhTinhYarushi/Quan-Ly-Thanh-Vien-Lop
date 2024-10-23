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
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
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

        private void tsm_XemThongTinCaNhan_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmThongTinCaNhanGiangVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmThongTinCaNhanGiangVien frmNV = new frmThongTinCaNhanGiangVien();
            frmNV.MdiParent = this;
            frmNV.WindowState = FormWindowState.Maximized;
            frmNV.Show();
        }

        private void tsb_QuanLyLopHoc_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmQuanLyLopHoc")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmQuanLyLopHoc frmNV = new frmQuanLyLopHoc();
            frmNV.MdiParent = this;
            frmNV.WindowState = FormWindowState.Maximized;
            frmNV.Show();
        }

        private void tsb_QuanLyHoatDong_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmQuanLyHoatDongLopHoc frmNV = new frmQuanLyHoatDongLopHoc();
            frmNV.MdiParent = this;
            frmNV.WindowState = FormWindowState.Maximized;
            frmNV.Show();
        }

        private void tsb_GuiThongBao_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmGuiThongBao")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmGuiThongBao frm = new frmGuiThongBao();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_DiemDanh_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmDiemDanh")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmDiemDanh frm = new frmDiemDanh();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_NhapVaQuanLyDiem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmNhapVaQuanLyDiem")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmNhapVaQuanLyDiem frm = new frmNhapVaQuanLyDiem();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_XemThongTinPhanHoi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmThongTinCaNhanGiangVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmXemThongTinCoBan frm = new frmXemThongTinCoBan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
