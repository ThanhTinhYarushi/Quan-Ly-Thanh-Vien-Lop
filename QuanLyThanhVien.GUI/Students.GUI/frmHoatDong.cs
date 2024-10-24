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

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class frmHoatDong : Form
    {
        SinhVienService service = new SinhVienService();
        public frmHoatDong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmHoatDong_Load(object sender, EventArgs e)
        {
            foreach (HoatDong item in service.GetHoatDong())
            {
                dataGridView1.Rows.Add(item.TieuDe);
            }
        }
    }
}
