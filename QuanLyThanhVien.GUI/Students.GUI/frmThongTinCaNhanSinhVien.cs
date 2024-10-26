using QuanLyThanhVien.BUS;
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
    public partial class frmThongTinCaNhanSinhVien : Form
    {
        public frmThongTinCaNhanSinhVien()
        {
            InitializeComponent();
            txtHoTen.Text = SinhVienInstance.sv.HoTen;
        }

        

    }
}
