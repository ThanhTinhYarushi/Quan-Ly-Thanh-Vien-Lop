using QuanLyThanhVien.BUS;
using QuanLyThanhVien.DAL.Entities;
using QuanLyThanhVien.GUI.Students.GUI;
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
    public partial class frmQuanLyLopHoc : Form
    {
        private readonly GiaoVienService _service = new GiaoVienService();
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void btn_XemDanhSachThamGia_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = (frmGiangVien)this.ParentForm;
            frm.xemThamgia();
        }
        private void btn_XemBangDiem_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = (frmGiangVien)this.ParentForm;
            frm.xemBangDiem();
        }

        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dataGridView_SV);
            setGridViewStyle(dataGridView_Lop);
            fill_dgv_Lop();
            CamSua();
        }

        private void fill_dgv_Lop()
        {
            foreach (Lop item in _service.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID, item.TenLop, item.MSGV, item.TenLop, item.Phong);
            }
        }
        private void fill_dgv_SV(string malop)
        {
            foreach (SinhVien item in _service.GetSinhViens(malop))
            {
                string gt;
                if(item.GioiTinh.Value == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                dataGridView_SV.Rows.Add(item.MSSV, item.HoTen, item.NgaySinh, gt, item.Email, item.SoDienThoai, item.DiaChi);
            }
        }

        private void DataGridView_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_SV.Rows.Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Lop.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells[0].Value.ToString();
                txt_TenLop.Text = row.Cells[1].Value.ToString();
            }
            fill_dgv_SV(txt_MaLop.Text);
        }

        private void dataGridView_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_SV.Rows[e.RowIndex];

                    txt_MaSinhVien.Text = row.Cells[0].Value.ToString();
                    txt_TenSinhVien.Text = row.Cells[1].Value.ToString();
                    if (DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime ngaySinh))
                    {
                        dtp_NgaySinh.Format = DateTimePickerFormat.Short;
                        dtp_NgaySinh.Value = ngaySinh;
                    }
                    txt_GioiTinh.Text = (row.Cells[3].Value.ToString() == "Nam") ? "Nam" : "Nữ";
                    txt_Email.Text = row.Cells[4].Value.ToString();
                    txt_SoDienThoai.Text = row.Cells[5].Value.ToString();
                    txt_DiaChi.Text = row.Cells[6].Value.ToString();
                }
        }

        private void CamSua()
        {
            txt_MaLop.ReadOnly = true;
            txt_TenLop.ReadOnly = true;
            txt_MaSinhVien.ReadOnly = true;
            txt_TenSinhVien.ReadOnly = true;
            dtp_NgaySinh.Enabled = false;
            txt_GioiTinh.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_SoDienThoai.ReadOnly = true;
            txt_DiaChi.ReadOnly = true;
        }

        public void setGridViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tim = txt_Tim.Text.Trim().ToLower();
            // Duyet cac dgv de tim lop
            foreach (DataGridViewRow row in dataGridView_Lop.Rows)
            {
                if(!row.IsNewRow)
                {
                    // neu loi null o cot dulieu, xai Value?
                    string maLop = row.Cells[0].Value.ToString().ToLower();
                    string tenLop = row.Cells[1].Value.ToString().ToLower();

                    if(maLop != null && maLop.Contains(tim) || tenLop != null && tenLop.Contains(tim))
                    {
                        row.Visible = true;

                        // hien thi sv thuoc lop do
                        dataGridView_SV.Rows.Clear();
                        fill_dgv_SV(maLop);
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            dataGridView_Lop.Rows.Clear();
            dataGridView_SV.Rows.Clear();
            fill_dgv_Lop();
        }
    }
}
