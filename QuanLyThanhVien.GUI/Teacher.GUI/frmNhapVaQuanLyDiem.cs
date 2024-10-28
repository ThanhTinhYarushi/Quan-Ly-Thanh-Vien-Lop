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

        }

        private void dataGridView_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            foreach (var item in gvS.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID,item.TenLop,item.TietHoc,item.Phong);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

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
