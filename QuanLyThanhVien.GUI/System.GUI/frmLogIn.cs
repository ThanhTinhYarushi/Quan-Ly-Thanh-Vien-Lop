using QuanLyThanhVien.BUS;
using QuanLyThanhVien.DAL.Entities;
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

namespace QuanLyThanhVien.GUI
{

    public partial class frmLogIn : Form
    {
        private readonly SystemService sv = new SystemService();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtUsername.Text;
            string mk = txtPassword.Text;
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                UserAccount user = sv.GetUser(tk,mk) ;
                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    // Mở form chính hoặc chuyển đến giao diện tương ứng
                    if (user.Role == "Student")
                    {   
                        frmSinhVien frmSinhVien = new frmSinhVien();
                        SinhVienInstance.getSinhVien(user.MSSV);
                        frmSinhVien.Show();
                    }
                    else if (user.Role == "Teacher")
                    {
                        frmGiangVien frmgv = new frmGiangVien();
                        GiaoVienInstance.getSinhVien(user.MSGV);
                        frmgv.Show();
                    }

                    // Đóng form đăng nhập
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                }
            }
       
        }
    }
}
