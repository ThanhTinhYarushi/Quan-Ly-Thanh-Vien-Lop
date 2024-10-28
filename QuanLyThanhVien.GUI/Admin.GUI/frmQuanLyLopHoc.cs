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
    public partial class frmQuanLyLopHoc : Form
    {
        string role = ""; // trạng thái kt là gv hay sv 
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            /*Khi mà ta load sẽ ko cho nhấn nút thêm và xoá, chỉ khi load dgv SV */
        }
    }
}
