namespace QuanLyThanhVien.GUI.Admin.GUI
{
    partial class frmQuanLyHoatDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemPhanHoi = new System.Windows.Forms.Button();
            this.btnXemThamGia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.txt_MaLopHoatDong = new System.Windows.Forms.TextBox();
            this.txt_DiaDiem = new System.Windows.Forms.TextBox();
            this.txt_rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.txt_MaHoatDong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemPhanHoi);
            this.groupBox1.Controls.Add(this.btnXemThamGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.datagridview1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1776, 1002);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnXemPhanHoi
            // 
            this.btnXemPhanHoi.Location = new System.Drawing.Point(710, 933);
            this.btnXemPhanHoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemPhanHoi.Name = "btnXemPhanHoi";
            this.btnXemPhanHoi.Size = new System.Drawing.Size(132, 51);
            this.btnXemPhanHoi.TabIndex = 26;
            this.btnXemPhanHoi.Text = "Xem phản hồi";
            this.btnXemPhanHoi.UseVisualStyleBackColor = true;
            this.btnXemPhanHoi.Click += new System.EventHandler(this.btnXemPhanHoi_Click);
            // 
            // btnXemThamGia
            // 
            this.btnXemThamGia.Location = new System.Drawing.Point(561, 933);
            this.btnXemThamGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemThamGia.Name = "btnXemThamGia";
            this.btnXemThamGia.Size = new System.Drawing.Size(141, 51);
            this.btnXemThamGia.TabIndex = 25;
            this.btnXemThamGia.Text = "Xem tham gia";
            this.btnXemThamGia.UseVisualStyleBackColor = true;
            this.btnXemThamGia.Click += new System.EventHandler(this.btnXemThamGia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Các hoạt động của Giảng viên";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1616, 932);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(141, 51);
            this.btn_Refresh.TabIndex = 23;
            this.btn_Refresh.Text = "Quay lại";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(321, 932);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(132, 51);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(171, 932);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(141, 51);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(19, 932);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(142, 51);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.datagridview1.Location = new System.Drawing.Point(561, 172);
            this.datagridview1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowHeadersWidth = 62;
            this.datagridview1.Size = new System.Drawing.Size(1196, 751);
            this.datagridview1.TabIndex = 17;
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hoạt Động";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tiêu Đề Hoạt Động";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mô Tả";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Thực Hiện";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời Gian";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Địa Điểm";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Lớp";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_ThoiGian);
            this.groupBox2.Controls.Add(this.dtp_NgayThucHien);
            this.groupBox2.Controls.Add(this.txt_MaLopHoatDong);
            this.groupBox2.Controls.Add(this.txt_DiaDiem);
            this.groupBox2.Controls.Add(this.txt_rtb_MoTa);
            this.groupBox2.Controls.Add(this.txt_TieuDe);
            this.groupBox2.Controls.Add(this.txt_MaHoatDong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(516, 791);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hoạt Động";
            // 
            // t_ThoiGian
            // 
            this.t_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.t_ThoiGian.Location = new System.Drawing.Point(240, 582);
            this.t_ThoiGian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_ThoiGian.Name = "t_ThoiGian";
            this.t_ThoiGian.Size = new System.Drawing.Size(247, 35);
            this.t_ThoiGian.TabIndex = 16;
            // 
            // dtp_NgayThucHien
            // 
            this.dtp_NgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThucHien.Location = new System.Drawing.Point(240, 523);
            this.dtp_NgayThucHien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_NgayThucHien.Name = "dtp_NgayThucHien";
            this.dtp_NgayThucHien.Size = new System.Drawing.Size(247, 35);
            this.dtp_NgayThucHien.TabIndex = 15;
            // 
            // txt_MaLopHoatDong
            // 
            this.txt_MaLopHoatDong.Location = new System.Drawing.Point(240, 705);
            this.txt_MaLopHoatDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaLopHoatDong.Name = "txt_MaLopHoatDong";
            this.txt_MaLopHoatDong.Size = new System.Drawing.Size(247, 35);
            this.txt_MaLopHoatDong.TabIndex = 14;
            // 
            // txt_DiaDiem
            // 
            this.txt_DiaDiem.Location = new System.Drawing.Point(178, 643);
            this.txt_DiaDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DiaDiem.Name = "txt_DiaDiem";
            this.txt_DiaDiem.Size = new System.Drawing.Size(308, 35);
            this.txt_DiaDiem.TabIndex = 13;
            // 
            // txt_rtb_MoTa
            // 
            this.txt_rtb_MoTa.Location = new System.Drawing.Point(120, 232);
            this.txt_rtb_MoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_rtb_MoTa.Name = "txt_rtb_MoTa";
            this.txt_rtb_MoTa.Size = new System.Drawing.Size(367, 250);
            this.txt_rtb_MoTa.TabIndex = 12;
            this.txt_rtb_MoTa.Text = "";
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Location = new System.Drawing.Point(18, 157);
            this.txt_TieuDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(469, 35);
            this.txt_TieuDe.TabIndex = 11;
            // 
            // txt_MaHoatDong
            // 
            this.txt_MaHoatDong.Location = new System.Drawing.Point(312, 52);
            this.txt_MaHoatDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaHoatDong.Name = "txt_MaHoatDong";
            this.txt_MaHoatDong.Size = new System.Drawing.Size(175, 35);
            this.txt_MaHoatDong.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 705);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Lớp Hoạt Động";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 643);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa Điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 591);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời Gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Thực Hiện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô Tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiêu Đề Hoạt Động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hoạt Động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(417, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 82);
            this.label1.TabIndex = 18;
            this.label1.Text = "QUẢN LÝ HOẠT ĐỘNG";
            // 
            // frmQuanLyHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 997);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyHoatDong";
            this.Text = "frmQuanLyHoatDong";
            this.Load += new System.EventHandler(this.frmQuanLyHoatDong_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemPhanHoi;
        private System.Windows.Forms.Button btnXemThamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker t_ThoiGian;
        private System.Windows.Forms.DateTimePicker dtp_NgayThucHien;
        private System.Windows.Forms.TextBox txt_MaLopHoatDong;
        private System.Windows.Forms.TextBox txt_DiaDiem;
        private System.Windows.Forms.RichTextBox txt_rtb_MoTa;
        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.TextBox txt_MaHoatDong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}