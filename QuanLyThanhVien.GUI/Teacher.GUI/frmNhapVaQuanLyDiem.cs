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
            try
            {
                setGridViewStyle(dataGridView_Lop);
                setGridViewStyle(dataGridView_Diem);
                fill_dgv_Lop();
                CamSua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void fill_dgv_Lop()
        {
            foreach (Lop item in gvS.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID, item.TenLop, item.MSGV, item.TenLop, item.Phong);
            }
        }
        private void fill_dgv_Diem()
        {
            foreach (Diem item in gvS.GetDiems(txt_MaLop.Text)) 
            {
                // ep kieu
                double diemChuyenCan = item.DiemQT;
                double diemGiuaKi = item.DiemGK;
                double diemCuoiKi = item.DiemCK;
                /*
                  * diem qua trinh = 40% chuyen can + 60% giua ki
                 */
                double diemQuaTrinh = (diemChuyenCan * 0.4f) + (diemGiuaKi * 0.6f);
                double diemTongKet = (diemQuaTrinh * 0.5f) + (diemCuoiKi * 0.5f);

                // F1 se xuat den chu so thap phan thu nhat
                dataGridView_Diem.Rows.Add(item.MSSV, gvS.tenSinhVien(item.MSSV), item.DiemQT, item.DiemGK, item.DiemCK, diemQuaTrinh.ToString("F1"), diemTongKet.ToString("F1"));
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
        private void dataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Diem.Rows.Clear();
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells[0].Value.ToString();
                txt_TenLop.Text = row.Cells[1].Value.ToString();
            }
            fill_dgv_Diem(); // khi click lop thi moi cho phep hien diem tuong ung
        }
        private void CamSua(bool choPhep)
        {
            if (choPhep)
            {
                txt_MaLop.ReadOnly = true;
                txt_TenLop.ReadOnly = true;
                txt_MaSinhVien.ReadOnly = true;
                txt_TenSinhVien.ReadOnly = true;
                txt_DiemChuyenCan.ReadOnly = false;
                txt_DiemGiuaKi.ReadOnly = false;
                txt_DiemCuoiKy.ReadOnly = false;
                txt_DiemQuaTrinh.ReadOnly = true; // Điểm quá trình là tự động tính nên luôn là ReadOnly
                txt_DiemTongKet.ReadOnly = true;  // Đi
            }
        }
        private void refresh()
        {
            dataGridView_Lop.Rows.Clear();
            fill_dgv_Lop();
            txt_MaLop.Text = string.Empty;
            txt_TenLop.Text = string.Empty;
            dataGridView_Diem.Rows.Clear();
            txt_MaSinhVien.Text = string.Empty;
            txt_TenSinhVien.Text = string.Empty;
            txt_DiemChuyenCan.Text = string.Empty;
            txt_DiemGiuaKi.Text = string.Empty;
            txt_DiemCuoiKy.Text = string.Empty;
            txt_DiemQuaTrinh.Text = string.Empty;
            txt_DiemTongKet.Text = string.Empty;
        }
        private void dataGridView_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Diem.Rows[e.RowIndex];
                txt_MaSinhVien.Text = row.Cells[0].Value.ToString();
                txt_TenSinhVien.Text = row.Cells[1].Value.ToString();
                txt_DiemChuyenCan.Text = row.Cells[2].Value.ToString();
                txt_DiemGiuaKi.Text = row.Cells[3].Value.ToString();
                txt_DiemCuoiKy.Text = row.Cells[4].Value.ToString();
                txt_DiemQuaTrinh.Text = row.Cells[5].Value.ToString();
                txt_DiemTongKet.Text = row.Cells[6].Value.ToString();
            }
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
