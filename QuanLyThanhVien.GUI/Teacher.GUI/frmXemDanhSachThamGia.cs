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
    public partial class frmXemDanhSachThamGia : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        public frmXemDanhSachThamGia()
        {
            InitializeComponent();
           
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemDanhSachThamGia_Load(object sender, EventArgs e)
        {
            fill_dgv_HD();
            setGridViewStyle(dataGridView_HoatDong);
            setGridViewStyle(dataGridView_SV);
        }
        private void fill_dgv_HD()
        {
            foreach (HoatDong item in gvS.GetHoatDong())
            {
                dataGridView_HoatDong.Rows.Add(item.HoatDongID, item.TieuDe, item.MoTa, item.NgayThucHien, item.ThoiGian, item.DiaDiem, item.ClassID);

            }
        }
        private void fill_dgv_SV(string malop)
        {
            foreach (SinhVien item in gvS.GetSinhViens(malop))
            {
                string gt;
                if (item.GioiTinh.Value == true)
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

        private void dataGridView_HoatDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_SV.Rows.Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_HoatDong.Rows[e.RowIndex];
                txt_MaHoatDong.Text = row.Cells[0].Value.ToString();
                txt_TieuDe.Text = row.Cells[1].Value.ToString();
                txt_rtb_MoTa.Text = row.Cells[2].Value.ToString();
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayThucHien))
                {
                    dtp_NgayThucHien.Format = DateTimePickerFormat.Short;
                    dtp_NgayThucHien.Value = ngayThucHien;
                }
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime thoiGian))
                {
                    t_ThoiGian.Format = DateTimePickerFormat.Time;
                    t_ThoiGian.Value = thoiGian;
                }
                txt_DiaDiem.Text = row.Cells[5].Value.ToString();
                txt_MaLopHoatDong.Text = row.Cells[6].Value.ToString();
            }
            fill_dgv_SV(txt_MaLopHoatDong.Text);
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
        public void setGridViewStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
