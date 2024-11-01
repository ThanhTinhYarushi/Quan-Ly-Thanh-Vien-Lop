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

namespace QuanLyThanhVien.GUI.Students.GUI
{
    public partial class ThongBao : Form
    {
        private readonly SinhVienService service = new SinhVienService();
        public ThongBao()
        {
            InitializeComponent();
        }

        private void dgv_ThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dgv_ThongBao.Rows[e.RowIndex];

                txt_TieuDeThongBao.Text = row.Cells[0].Value?.ToString();
                rtb_txt_NoiDungThongBao.Text = row.Cells[1].Value?.ToString();
                dtp_NgayTao.Text = row.Cells[2].Value?.ToString();
                txtTenLop.Text = row.Cells[3].Value?.ToString();
               

            }
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            LoadThongBao();
        }
        private void LoadThongBao()
        {
            foreach (var item in service.getThongBao())
            {
                dgv_ThongBao.Rows.Add(item.TieuDe,item.NoiDung,item.NgayTao,service.getTenLop(item.ClassID));
            }
        }

        private void ThongBao_Resize(object sender, EventArgs e)
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }
}
