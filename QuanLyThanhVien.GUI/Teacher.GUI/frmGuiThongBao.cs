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
    public partial class frmGuiThongBao : Form
    {
        private readonly GiaoVienService gvS = new GiaoVienService();
        bool x;
        public frmGuiThongBao()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

        }

        private void frmGuiThongBao_Load(object sender, EventArgs e)
        {
            try
            {
                refresh();
                setGridViewStyle(dgv_ThongBao);
                fill_dgv();
                fill_cbo_MaLop();
                CamSua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            
        }
        private void fill_dgv()
        {
            foreach (ThongBao item in gvS.GetThongBaos())
            {
                dgv_ThongBao.Rows.Add(item.ThongBaoID, item.TieuDe,item.NoiDung, item.NgayTao, item.ClassID, gvS.getClassName(item.ClassID));
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            x = gvS.createAndUpdateThongBao(txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, dtp_NgayTao.Value, cbo_MaLop.Text);
            if (x)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo");
                refresh();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
        }

        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ThongBao.Rows[e.RowIndex];
                txt_MaThongBao.Text = row.Cells[0].Value.ToString();
                txt_TieuDeThongBao.Text = row.Cells[1].Value.ToString();
                rtb_txt_NoiDungThongBao.Text = row.Cells[2].Value.ToString();

                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayTao))
                {
                    dtp_NgayTao.Format = DateTimePickerFormat.Short;
                    dtp_NgayTao.Value = ngayTao;
                }

                if (row.Cells[4].Value != null)
                {
                    cbo_MaLop.SelectedValue = row.Cells[4].Value.ToString();
                }
                txt_TenLop.Text = row.Cells[5].Value.ToString();
            }
        }
        private void fill_cbo_MaLop()
        {
            cbo_MaLop.Items.Clear();
            foreach (Lop item in gvS.GetLops())
            {
                cbo_MaLop.Items.Add(item.ClassID);
                txt_TenLop.Text = gvS.getClassName(item.ClassID);
            }
        }
        
        private void CamSua(bool choPhep)
        {
            if (choPhep)
            {
                txt_MaThongBao.Enabled = false;
                txt_TenLop.Enabled = false;
            }
        }

        private void refresh()
        {
            dgv_ThongBao.Rows.Clear();
            fill_dgv();

            txt_MaThongBao.Text = string.Empty;
            txt_TieuDeThongBao.Text = string.Empty;
            rtb_txt_NoiDungThongBao.Text = string.Empty;
            dtp_NgayTao.Value = DateTime.Now;
            cbo_MaLop.SelectedIndex = -1;
            txt_TenLop.Text = string.Empty;

            fill_cbo_MaLop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bool x = gvS.createAndUpdateThongBao(txt_TieuDeThongBao.Text, rtb_txt_NoiDungThongBao.Text, dtp_NgayTao.Value, cbo_MaLop.Text);
            if (x)
            {
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
                refresh();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại", "Thông Báo");
            }
        }
    }
}
