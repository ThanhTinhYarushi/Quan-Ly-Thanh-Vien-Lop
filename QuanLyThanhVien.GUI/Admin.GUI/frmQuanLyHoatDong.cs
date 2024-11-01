using QuanLyThanhVien.BUS;
using QuanLyThanhVien.BUS.ObjectService;
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

namespace QuanLyThanhVien.GUI.Admin.GUI
{
    public partial class frmQuanLyHoatDong : Form
    {
        private readonly AdminService service = new AdminService();
        private readonly GiaoVienService gvs = new GiaoVienService();
        public frmQuanLyHoatDong()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Tính toán vị trí để căn giữa GroupBox
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }

        private void frmQuanLyHoatDong_Load(object sender, EventArgs e)
        {   

            loadHoatDong();
        }
        private void loadHoatDong()
        {
            datagridview1.Rows.Clear();
            datagridview1.Columns[0].HeaderText = "Mã hoạt động";
            datagridview1.Columns[1].HeaderText = "Tiêu đề";
            datagridview1.Columns[2].HeaderText = "Mô tả";
            datagridview1.Columns[3].HeaderText = "Ngày thực hiện";
            datagridview1.Columns[4].HeaderText = "Thời gian";
            datagridview1.Columns[5].HeaderText = "Địa điểm";
            datagridview1.Columns[6].HeaderText = "Mã lớp";
            foreach (var item in service.GetHoatDongs())
            {
                datagridview1.Rows.Add(item.HoatDongID,item.TieuDe,item.MoTa,item.NgayThucHien,item.ThoiGian,item.DiaDiem,item.ClassID);
            }
        }
        private void loadThamGiaHoatDong(int mahoatdong)
        {
            datagridview1.Rows.Clear();
            datagridview1.Columns[0].HeaderText = "MSSV";
            datagridview1.Columns[1].HeaderText = "Tên sinh viên";
            datagridview1.Columns[2].HeaderText = "Trạng thái";
            datagridview1.Columns[3].HeaderText = "";
            datagridview1.Columns[4].HeaderText = "";
            datagridview1.Columns[5].HeaderText = "";
            datagridview1.Columns[6].HeaderText = "";
            foreach (var item in service.GetThamGias(mahoatdong))
            {
                datagridview1.Rows.Add(item.MSSV,item.SinhVien.HoTen,item.TrangThai);
            }
        }

        private void btnXemThamGia_Click(object sender, EventArgs e)
        {
            if (txt_MaHoatDong.Text != "")
            {
                int mahoatdong = int.Parse(txt_MaHoatDong.Text);
                if (datagridview1.Columns[0].HeaderText == "Mã hoạt động")
                {
                    loadThamGiaHoatDong(mahoatdong);
                }

            }
        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu hàng được chọn là hợp lệ
            {
                DataGridViewRow row = datagridview1.Rows[e.RowIndex];

                txt_MaHoatDong.Text = row.Cells[0].Value?.ToString();
                txt_TieuDe.Text = row.Cells[1].Value?.ToString();
                txt_rtb_MoTa.Text = row.Cells[2].Value?.ToString();
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
                txt_DiaDiem.Text = row.Cells[5].Value?.ToString();
                txt_MaLopHoatDong.Text = row.Cells[6].Value?.ToString();
            }
        }

     

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            loadHoatDong();
        }

        private void btnXemPhanHoi_Click(object sender, EventArgs e)
        {
            if (txt_MaHoatDong.Text!="")
            {
                int mahoatdong = int.Parse(txt_MaHoatDong.Text);
                if (datagridview1.Columns[0].HeaderText == "Mã hoạt động")
                {
                    loadPhanHoi(mahoatdong);
                }
                
            }
            
            
            
        }
        private void loadPhanHoi(int mahoatdong)
        {
            datagridview1.Rows.Clear();
            datagridview1.Columns[0].HeaderText = "MSSV";
            datagridview1.Columns[1].HeaderText = "Tên sinh viên";
            datagridview1.Columns[2].HeaderText = "Noi dung";
            datagridview1.Columns[3].HeaderText = "Ngay phan hoi";
            datagridview1.Columns[4].HeaderText = "";
            datagridview1.Columns[5].HeaderText = "";
            datagridview1.Columns[6].HeaderText = "";
            foreach (var item in service.GetPhanHois(mahoatdong))
            {
                datagridview1.Rows.Add(item.MSSV, item.SinhVien.HoTen, item.NoiDung,item.NgayPhanHoi);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        { 
            DateTime date = dtp_NgayThucHien.Value;
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);

            bool x = service.CreateHoatDong(txt_TieuDe.Text,txt_rtb_MoTa.Text,date,timeSpan,txt_DiaDiem.Text,txt_MaLopHoatDong.Text,"");
            if (x==true)
            {
                MessageBox.Show("Tao hoat dong thanh cong");
                loadHoatDong();
            }
            else
            {
                MessageBox.Show("Tao hoat dong ko  thanh cong");
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_NgayThucHien.Value;
            DateTime selectedTime = t_ThoiGian.Value;
            TimeSpan timeSpan = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);

            bool x = service.CreateHoatDong(txt_TieuDe.Text, txt_rtb_MoTa.Text, date, timeSpan, txt_DiaDiem.Text, txt_MaLopHoatDong.Text,txt_MaHoatDong.Text);
            if (x == true)
            {
                MessageBox.Show("cap nhat hoat dong thanh cong");
                loadHoatDong();
            }
            else
            {
                MessageBox.Show("cap nhat hoat dong ko  thanh cong");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (service.GetThamGias(int.Parse(txt_MaHoatDong.Text)).Count!=0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không? Nếu xóa sẽ mất danh sách tham gia", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    service.xoaHoatDong(int.Parse(txt_MaHoatDong.Text));
                    loadHoatDong() ;
                    MessageBox.Show("xoa thanh cong");
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không? hoat dong chua ai tham gia", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    service.xoaHoatDong(int.Parse(txt_MaHoatDong.Text));
                    loadHoatDong() ;
                    MessageBox.Show("xoa thanh cong");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
