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

namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    public partial class frmThongTinCaNhanGiangVien : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmThongTinCaNhanGiangVien()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhanGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                fill_TTGV();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        public void fill_TTGV()
        {
            txt_MaGiangVien.Text = GiaoVienInstance.gv.MSGV;
            txt_TenGiangVien.Text = GiaoVienInstance.gv.HoTen;
            txt_EmailGiangVien.Text = GiaoVienInstance.gv.Email;
            txt_SoDienThoai.Text = GiaoVienInstance.gv.SoDienThoai;
            txt_DiaChi.Text = GiaoVienInstance.gv.DiaChi;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
           bool a = gvS.updateGV(txt_TenGiangVien.Text, txt_EmailGiangVien.Text, txt_SoDienThoai.Text, txt_DiaChi.Text, dtp_NgaySinhGiangVien.Value);
            if (a) 
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Cập Nhật KO Thành Công", "Thông Báo");
            }
        }
    }
}
