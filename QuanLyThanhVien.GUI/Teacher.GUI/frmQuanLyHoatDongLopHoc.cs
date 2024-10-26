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
    public partial class frmQuanLyHoatDongLopHoc : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        bool x;
        public frmQuanLyHoatDongLopHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoatDongLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                fill_dgv();
            }
            catch 
            {
                
            }
        }
        private void fill_dgv()
        {
            foreach (HoatDong item in gvS.GetHoatDong())
            {
                dataGridView1.Rows.Add(item.HoatDongID, item.TieuDe);
                
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = selectedTime.TimeOfDay;
            x = gvS.CreateHoatDong(txt_TieuDe.Text, txt_rtb_MoTa.Text, dtp_NgayThucHien.Value,timeSpan, txt_DiaDiem.Text, txt_MaLopHoatDong.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            x = gvS.DeleteHoatDong(int.Parse(txt_MaHoatDong.Text));
        }
    }
}
