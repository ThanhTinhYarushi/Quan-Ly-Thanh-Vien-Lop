using QuanLyThanhVien.GUI.Students.GUI;
using QuanLyThanhVien.GUI.Teacher.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
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

        private void tsb_XemThongTinCaNhan_Click(object sender, EventArgs e)
        {

            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmXemThongTinCaNhan")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmXemThongTinCaNhan frm = new frmXemThongTinCaNhan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void tsb_QuanLyLopHoc_Click(object sender, EventArgs e)
        {
            hideForm();
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

            frmQuanLyLopHoc frm = new frmQuanLyLopHoc();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_DiemDanhVaViPham_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmXemDiemDanhVaViPham")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmXemDiemDanhVaViPham frm = new frmXemDiemDanhVaViPham();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_QuanLyHoatDong_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmQuanLyHoatDong")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmQuanLyHoatDong frm = new frmQuanLyHoatDong();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_QuanLyThongBao_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmQuanLyThongBao")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmQuanLyThongBao frm = new frmQuanLyThongBao();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_QuanLyPhanHoi_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmXemThongTinCaNhan")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }

            frmQuanLyPhanHoi frm = new frmQuanLyPhanHoi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox để xác nhận đăng xuất
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác Nhận Đăng Xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Kiểm tra kết quả từ MessageBox
            if (result == DialogResult.Yes)
            {
                frmLogIn loginForm = new frmLogIn(); // Tạo một thể hiện mới của FormLogin
                loginForm.Show(); // Hiển thị lại form đăng nhập
                this.Close(); // Đóng form cha
            }
            // Nếu người dùng chọn No, không làm gì cả
        }
    }
}
