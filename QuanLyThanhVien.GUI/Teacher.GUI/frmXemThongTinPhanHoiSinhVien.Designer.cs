namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    partial class frmXemThongTinPhanHoiSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HoatDongID = new System.Windows.Forms.Label();
            this.rtb_txt_NoiDungPhanHoi = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TieuDe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenSinhVien = new System.Windows.Forms.TextBox();
            this.txt_MaSinhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(567, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(798, 582);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất Cả Thông Báo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(782, 551);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellDoubleClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã hoạt động";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tiêu đề HĐ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mô tả";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày thực hiện";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thời gian";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa điểm";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xem  Thông Tin Phản Hồi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.HoatDongID);
            this.groupBox3.Controls.Add(this.rtb_txt_NoiDungPhanHoi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_TieuDe);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_TenSinhVien);
            this.groupBox3.Controls.Add(this.txt_MaSinhVien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(530, 574);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phản Hồi Sinh Viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 74);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 30);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // HoatDongID
            // 
            this.HoatDongID.AutoSize = true;
            this.HoatDongID.Location = new System.Drawing.Point(268, 23);
            this.HoatDongID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoatDongID.Name = "HoatDongID";
            this.HoatDongID.Size = new System.Drawing.Size(0, 25);
            this.HoatDongID.TabIndex = 30;
            this.HoatDongID.Visible = false;
            // 
            // rtb_txt_NoiDungPhanHoi
            // 
            this.rtb_txt_NoiDungPhanHoi.Location = new System.Drawing.Point(0, 208);
            this.rtb_txt_NoiDungPhanHoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_txt_NoiDungPhanHoi.Name = "rtb_txt_NoiDungPhanHoi";
            this.rtb_txt_NoiDungPhanHoi.Size = new System.Drawing.Size(525, 374);
            this.rtb_txt_NoiDungPhanHoi.TabIndex = 29;
            this.rtb_txt_NoiDungPhanHoi.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 176);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nội Dung Phản Hồi";
            // 
            // txt_TieuDe
            // 
            this.txt_TieuDe.Location = new System.Drawing.Point(273, 130);
            this.txt_TieuDe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TieuDe.Name = "txt_TieuDe";
            this.txt_TieuDe.Size = new System.Drawing.Size(235, 30);
            this.txt_TieuDe.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tiêu Đề";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày thực hiện";
            // 
            // txt_TenSinhVien
            // 
            this.txt_TenSinhVien.Location = new System.Drawing.Point(13, 130);
            this.txt_TenSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenSinhVien.Name = "txt_TenSinhVien";
            this.txt_TenSinhVien.Size = new System.Drawing.Size(235, 30);
            this.txt_TenSinhVien.TabIndex = 6;
            // 
            // txt_MaSinhVien
            // 
            this.txt_MaSinhVien.Location = new System.Drawing.Point(13, 74);
            this.txt_MaSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaSinhVien.Name = "txt_MaSinhVien";
            this.txt_MaSinhVien.Size = new System.Drawing.Size(235, 30);
            this.txt_MaSinhVien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(563, 350);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(1197, 73);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(160, 22);
            this.btnQuayLai.TabIndex = 31;
            this.btnQuayLai.Text = " <== Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmXemThongTinPhanHoiSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXemThongTinPhanHoiSinhVien";
            this.Text = "frmXemThongTinPhanHoiSinhVien";
            this.Load += new System.EventHandler(this.frmXemThongTinPhanHoiSinhVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_txt_NoiDungPhanHoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TieuDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenSinhVien;
        private System.Windows.Forms.TextBox txt_MaSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label HoatDongID;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}