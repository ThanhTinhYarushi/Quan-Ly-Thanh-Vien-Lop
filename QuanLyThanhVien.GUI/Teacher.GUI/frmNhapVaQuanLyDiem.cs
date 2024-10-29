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
            setGridViewStyle(dataGridView_Lop);
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
        public void setGridViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // kt
            if (!double.TryParse(txt_DiemChuyenCan.Text, out double diemCC) || diemCC < 0 || diemCC > 10)
            {
                MessageBox.Show("Điểm chuyên cần phải nằm trong khoảng từ 0 đến 10.");
                return; // Kết thúc hàm nếu điểm không hợp lệ
            }

            if (!double.TryParse(txt_DiemGiuaKi.Text, out double diemGK) || diemGK < 0 || diemGK > 10)
            {
                MessageBox.Show("Điểm giữa kỳ phải nằm trong khoảng từ 0 đến 10.");
                return;
            }

            if (!double.TryParse(txt_DiemCuoiKy.Text, out double diemCK) || diemCK < 0 || diemCK > 10)
            {
                MessageBox.Show("Điểm cuối kỳ phải nằm trong khoảng từ 0 đến 10.");
                return;
            }
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
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else
            {
                MessageBox.Show("Cập Nhật Không Thành Công\n", flagname);

            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (dataGridView_Lop.CurrentRow != null)
            {
                

                MessageBox.Show("Đã hủy nhập điểm và khôi phục điểm trước đó.");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loadLop();
        }
        

    }
}
