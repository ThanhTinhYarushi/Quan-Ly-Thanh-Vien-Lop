using QuanLyThanhVien.BUS.ObjectService;
using QuanLyThanhVien.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmQuanLyThongBao : Form
    {
        private readonly AdminService service = new AdminService();
        public frmQuanLyThongBao()
        {
            InitializeComponent();
        }

        private void frmQuanLyThongBao_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }

        private void frmQuanLyThongBao_Load(object sender, EventArgs e)
        {
            loadLop();
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
            dataGridView_Lop.Rows.Clear();
            foreach (Lop item in service.GetLops())
            {
                dataGridView_Lop.Rows.Add(item.ClassID, item.TenLop, item.TietHoc, item.Phong);
            }
        }
        private void xemThongBao()
        {
            dataGridView_Lop.Rows.Clear();
            dataGridView_Lop.Columns[0].HeaderText = "Tiêu đề ";
            dataGridView_Lop.Columns[1].HeaderText = "Nội dung";
            dataGridView_Lop.Columns[2].HeaderText = "Ngày tạo";
            dataGridView_Lop.Columns[3].HeaderText = "Mã lớp";
            dataGridView_Lop.Columns[4].HeaderText = "Tên lớp";
            
            dataGridView_Lop.Rows.Clear();
            foreach (var item in service.getthongBaos())
            {
                dataGridView_Lop.Rows.Add(item.TieuDe,item.NoiDung,item.NgayTao,item.Lop.ClassID,item.Lop.TenLop);
            }
        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            loadLop();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            xemThongBao();
        }

        private void dataGridView_Lop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Lop.Columns[0].HeaderText=="Mã lớp")
            {
                string malop = dataGridView_Lop.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(malop);
                dataGridView_Lop.Rows.Clear();
                dataGridView_Lop.Columns[0].HeaderText = "Tiêu đề ";
                dataGridView_Lop.Columns[1].HeaderText = "Nội dung";
                dataGridView_Lop.Columns[2].HeaderText = "Ngày tạo";
                dataGridView_Lop.Columns[3].HeaderText = "Mã lớp";
                dataGridView_Lop.Columns[4].HeaderText = "Tên lớp";

                dataGridView_Lop.Rows.Clear();
                foreach (var item in service.GetThongBaoID(malop))
                {
                    dataGridView_Lop.Rows.Add(item.TieuDe, item.NoiDung, item.NgayTao, item.Lop.ClassID, item.Lop.TenLop);
                }
            }
          
        }
    }

}
