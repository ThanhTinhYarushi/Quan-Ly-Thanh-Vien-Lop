namespace QuanLyThanhVien.GUI.Admin.GUI
{
    partial class frmQuanLyLopHoc
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txtMSGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1782, 1010);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(272, 779);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(129, 76);
            this.btnCapNhat.TabIndex = 60;
            this.btnCapNhat.Text = "Cập nhật lớp";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(52, 779);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 76);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPhong);
            this.groupBox5.Controls.Add(this.txtTiet);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTrangThai);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txt_TenLop);
            this.groupBox5.Controls.Add(this.txt_MaLop);
            this.groupBox5.Controls.Add(this.txtMSGV);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(31, 206);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(459, 563);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Lớp Học";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(183, 225);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(254, 35);
            this.txtPhong.TabIndex = 18;
            // 
            // txtTiet
            // 
            this.txtTiet.Location = new System.Drawing.Point(183, 176);
            this.txtTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(254, 35);
            this.txtTiet.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tiết học";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(195, 386);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(87, 35);
            this.txtTrangThai.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 55);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trạng thái";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(184, 115);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(264, 35);
            this.txt_TenLop.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(184, 48);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(264, 35);
            this.txt_MaLop.TabIndex = 5;
            // 
            // txtMSGV
            // 
            this.txtMSGV.Location = new System.Drawing.Point(183, 287);
            this.txtMSGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSGV.Name = "txtMSGV";
            this.txtMSGV.Size = new System.Drawing.Size(254, 35);
            this.txtMSGV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(633, 438);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(300, 154);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã giảng viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.dataGridView_Lop);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1261, 853);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Lớp Học";
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_Lop.Location = new System.Drawing.Point(7, 34);
            this.dataGridView_Lop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.RowHeadersWidth = 62;
            this.dataGridView_Lop.Size = new System.Drawing.Size(1230, 809);
            this.dataGridView_Lop.TabIndex = 0;
            this.dataGridView_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 82);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản Lý Lớp Học";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiết Học";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phòng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Trạng thái";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã giáo viên ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên giáo viên";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "email";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số điện thoại";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // frmQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 997);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyLopHoc";
            this.Text = "QuanLyLopHoc";
            this.Load += new System.EventHandler(this.QuanLyLopHoc_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMSGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}