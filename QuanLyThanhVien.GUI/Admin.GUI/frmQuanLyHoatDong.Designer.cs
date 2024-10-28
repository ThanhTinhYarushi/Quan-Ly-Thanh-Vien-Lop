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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataGridView_HoatDong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoatDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1076, 46);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(94, 33);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Tạo Mới";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(213, 605);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 33);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(113, 605);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 33);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 605);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 33);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HoatDong
            // 
            this.dataGridView_HoatDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoatDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_HoatDong.Location = new System.Drawing.Point(373, 85);
            this.dataGridView_HoatDong.Name = "dataGridView_HoatDong";
            this.dataGridView_HoatDong.Size = new System.Drawing.Size(797, 553);
            this.dataGridView_HoatDong.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hoạt Động";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tiêu Đề Hoạt Động";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mô Tả";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Thực Hiện";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời Gian";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Địa Điểm";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Lớp";
            this.Column8.Name = "Column8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_ThoiGian);
            this.groupBox1.Controls.Add(this.dtp_NgayThucHien);
            this.groupBox1.Controls.Add(this.txt_MaLopHoatDong);
            this.groupBox1.Controls.Add(this.txt_DiaDiem);
            this.groupBox1.Controls.Add(this.txt_rtb_MoTa);
            this.groupBox1.Controls.Add(this.txt_TieuDe);
            this.groupBox1.Controls.Add(this.txt_MaHoatDong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 514);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hoạt Động";
            // 
            // t_ThoiGian
            // 
            this.t_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.t_ThoiGian.Location = new System.Drawing.Point(160, 378);
            this.t_ThoiGian.Name = "t_ThoiGian";
            this.t_ThoiGian.Size = new System.Drawing.Size(166, 26);
            this.t_ThoiGian.TabIndex = 16;
            // 
            // dtp_NgayThucHien
            // 
            this.dtp_NgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayThucHien.Location = new System.Drawing.Point(160, 340);
            this.dtp_NgayThucHien.Name = "dtp_NgayThucHien";
            this.dtp_NgayThucHien.Size = new System.Drawing.Size(166, 26);
            this.dtp_NgayThucHien.TabIndex = 15;
            // 
            // txt_MaLopHoatDong
            // 
            this.txt_MaLopHoatDong.Location = new System.Drawing.Point(160, 458);
            this.txt_MaLopHoatDong.Name = "txt_MaLopHoatDong";
            this.txt_MaLopHoatDong.Size = new System.Drawing.Size(166, 26);
            this.txt_MaLopHoatDong.TabIndex = 14;
            // 
            // txt_DiaDiem
            // 
            this.txt_DiaDiem.Location = new System.Drawing.Point(119, 418);
            this.txt_DiaDiem.Name = "txt_DiaDiem";
            this.txt_DiaDiem.Size = new System.Drawing.Size(207, 26);
            this.txt_DiaDiem.TabIndex = 13;
            // 
            // txt_rtb_MoTa
            // 
            this.txt_rtb_MoTa.Location = new System.Drawing.Point(80, 151);
            this.txt_rtb_MoTa.Name = "txt_rtb_MoTa";
            this.txt_rtb_MoTa.Size = new System.Drawing.Size(246, 164);
            this.txt_rtb_MoTa.TabIndex = 12;
            this.txt_rtb_MoTa.Text = "";
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Location = new System.Drawing.Point(12, 102);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(314, 26);
            this.txt_TieuDe.TabIndex = 11;
            // 
            // txt_MaHoatDong
            // 
            this.txt_MaHoatDong.Location = new System.Drawing.Point(208, 34);
            this.txt_MaHoatDong.Name = "txt_MaHoatDong";
            this.txt_MaHoatDong.Size = new System.Drawing.Size(118, 26);
            this.txt_MaHoatDong.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Lớp Hoạt Động";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa Điểm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời Gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Thực Hiện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô Tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiêu Đề Hoạt Động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hoạt Động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(277, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông Tin Các Hoạt Động Lớp";
            // 
            // frmQuanLyHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 648);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView_HoatDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyHoatDong";
            this.Text = "frmQuanLyHoatDong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoatDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView_HoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
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