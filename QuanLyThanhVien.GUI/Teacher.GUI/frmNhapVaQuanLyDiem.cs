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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    
    public partial class frmNhapVaQuanLyDiem : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmNhapVaQuanLyDiem()
        {
            InitializeComponent();
        }

        private void frmNhapVaQuanLyDiem_Load(object sender, EventArgs e)
        {
            loadLop();
        }
        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];


                txt_MaSinhVien.Text = row.Cells[0].Value?.ToString(); // Mã lớp
                txt_TenSinhVien.Text = row.Cells[1].Value?.ToString(); // Môn học
                txt_DiemChuyenCan.Text = row.Cells[2].Value?.ToString(); // Điểm chuyên cần
                txt_DiemGiuaKi.Text = row.Cells[3].Value?.ToString(); // Điểm giữa kì
                txt_DiemCuoiKy.Text = row.Cells[4].Value?.ToString(); // Điểm cuối kì
                txt_DiemTongKet.Text = row.Cells[5].Value?.ToString(); // Điểm tổng
            }
        }

        private void dataGridView_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_MaLop.Text = dataGridView_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridView_Lop.Rows.Clear();
            dataGridView_Lop.Columns[0].HeaderText = "MSSV";
            dataGridView_Lop.Columns[1].HeaderText = "Họ và tên";
            dataGridView_Lop.Columns[2].HeaderText = "Điểm CC";
            dataGridView_Lop.Columns[3].HeaderText = "Điểm GK";
            dataGridView_Lop.Columns[4].HeaderText = "Điểm CK";
            dataGridView_Lop.Columns[5].HeaderText = "Điểm tổng";
            foreach (var item in gvS.GetSinhViens(ma))
            {   Diem diem = gvS.getDiemSV(item.MSSV,ma);
                    if (diem == null)
                {
                    dataGridView_Lop.Rows.Add(item.MSSV, item.HoTen,0,0,0,0);
                }
                else
                {   double tong= (((diem.DiemQT+diem.DiemGK)/2)+diem.DiemCK)/2;
                    dataGridView_Lop.Rows.Add(item.MSSV, item.HoTen,diem.DiemQT,diem.DiemGK,diem.DiemCK,tong);
                }

            }

        }

        private void loadLop()
        {
            dataGridView_Lop.Rows.Clear();  
            dataGridView_Lop.Columns[0].HeaderText = "Mã lớp";
            dataGridView_Lop.Columns[1].HeaderText = "Tên lớp";
            dataGridView_Lop.Columns[2].HeaderText = "Tiết học";
            dataGridView_Lop.Columns[3].HeaderText = "Phòng";
            dataGridView_Lop.Columns[4].HeaderText = "";
            dataGridView_Lop.Columns[5].HeaderText = "";

            foreach (var item in gvS.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string flagname ="";
            foreach (DataGridViewRow row in dataGridView_Lop.Rows)
            {
                if (row.IsNewRow)
                    continue;
                string mssv = row.Cells[0].Value.ToString();
                string classid = txt_MaLop.Text;
                double cc = double.Parse( row.Cells[2].Value.ToString());
                double gk = double.Parse(row.Cells[3].Value.ToString());
                double ck = double.Parse(row.Cells[4].Value.ToString());
                bool a = gvS.capNhatDiem(mssv, classid, cc, gk,ck);
                if (a == false)
                {
                    flag = false;
                    flagname += row.Cells[1].Value.ToString() + " ";
                }

            }
            if (flag == true)
            {
                MessageBox.Show("cap nhat  thanh cong");
            }
            else
            {
                MessageBox.Show("cap nhat ko thanh ko\n", flagname);

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loadLop();
        }
    }
}
