using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmQuanLyPhanHoi : Form
    {
        // lay tat ca phan hoi
        public frmQuanLyPhanHoi()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhanHoi_Load(object sender, EventArgs e)
        {
            // co trl phan hoi, huy trl, hoac xoa phan hoi do lun
        }

        private void frmQuanLyPhanHoi_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }
}
