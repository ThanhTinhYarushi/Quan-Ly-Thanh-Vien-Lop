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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmXemThongTinCaNhan : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        private readonly SinhVienService svS = new SinhVienService();
        // lay tat ca sv va gv
        // lay tat ca lop
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }

        public frmXemThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmXemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            /*
             Khi load thông tin sẽ hiển thị tất cả các sinh viên và tất cả giảng viên
            txt_Role hiển thị cho admin là chức vụ j
            khi tìm sẽ tìm ở cả 2 bảng
            có thể thêm/Xoá Sinh viên hay gv nếu ta đang đứng ở bảng có role đó
            có thể sửa password sinh viên dang select -> frm phụ
            - chức vụ nếu sinh viên ko có chức vụ / gv => null
             */
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            // refresh lại tất cả text và dgv
        }

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            // sửa tt ng đó
            // thêm 
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhatAnhDaiDien_Click(object sender, EventArgs e)
        {
            // hàm nay ko can viet som cung dc
        }

        private void btn_DoiPass_Click(object sender, EventArgs e)
        {
            // hàm này mở frm phụ đổi pass word
        }

        private void btn_XemSV_Click(object sender, EventArgs e)
        {
            dataGridView_obj.Rows.Clear();
            dataGridView_obj.Columns[0].HeaderText = "Mã Sinh Viên";
            dataGridView_obj.Columns[1].HeaderText = "Tên Sinh Vien";
            dataGridView_obj.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView_obj.Columns[3].HeaderText = "Giới Tính";
            dataGridView_obj.Columns[4].HeaderText = "Email";
            dataGridView_obj.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView_obj.Columns[6].HeaderText = "Địa Chỉ";

            //foreach (var item in svS.GetSinhVien) // get tat ca sv
            //{
                                
            //}
        }

        private void btn_XemGV_Click(object sender, EventArgs e)
        {
            dataGridView_obj.Rows.Clear();
            dataGridView_obj.Columns[0].HeaderText = "Mã Giáo Viên";
            dataGridView_obj.Columns[1].HeaderText = "Tên Giáo Viên";
            dataGridView_obj.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView_obj.Columns[3].HeaderText = "Giới Tính";
            dataGridView_obj.Columns[4].HeaderText = "Email";
            dataGridView_obj.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView_obj.Columns[6].HeaderText = "Địa Chỉ";

            //foreach (var item in svS.GetGiaoVien) // get tat ca sv
            //{

            //}
        }
    }
}
