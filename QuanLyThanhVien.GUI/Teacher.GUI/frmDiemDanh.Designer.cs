namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    partial class frmDiemDanh
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
            this.dataGridView_Lop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tre = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayDiemDanh = new System.Windows.Forms.DateTimePicker();
            this.VangMat = new System.Windows.Forms.Button();
            this.btn_CoMat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.dataGridView_Lop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(496, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1064, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học";
            // 
            // dataGridView_Lop
            // 
            this.dataGridView_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView_Lop.Location = new System.Drawing.Point(8, 30);
            this.dataGridView_Lop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.RowHeadersWidth = 62;
            this.dataGridView_Lop.Size = new System.Drawing.Size(1048, 254);
            this.dataGridView_Lop.TabIndex = 0;
            this.dataGridView_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lop_CellClick);
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
            this.Column2.Width = 120;
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
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(350, 130);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(137, 53);
            this.btn_Tim.TabIndex = 29;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(16, 146);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(326, 22);
            this.txt_Tim.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TenLop);
            this.groupBox3.Controls.Add(this.txt_MaLop);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(472, 155);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Lớp Học";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(228, 96);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.ReadOnly = true;
            this.txt_TenLop.Size = new System.Drawing.Size(235, 30);
            this.txt_TenLop.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(228, 42);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.ReadOnly = true;
            this.txt_MaLop.Size = new System.Drawing.Size(235, 30);
            this.txt_MaLop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(563, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(440, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 69);
            this.label1.TabIndex = 30;
            this.label1.Text = "Điểm Danh Sinh Viên";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Ivory;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(496, 427);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1064, 356);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column12,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(8, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MSSV";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tên Sinh Viên";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 120;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ngày Điểm Danh";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 130;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Trạng Thái";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // btn_Tre
            // 
            this.btn_Tre.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Tre.Location = new System.Drawing.Point(301, 186);
            this.btn_Tre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Tre.Name = "btn_Tre";
            this.btn_Tre.Size = new System.Drawing.Size(141, 59);
            this.btn_Tre.TabIndex = 35;
            this.btn_Tre.Text = "Đi Trễ(T)";
            this.btn_Tre.UseVisualStyleBackColor = false;
            this.btn_Tre.Click += new System.EventHandler(this.btn_Tre_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtp_NgayDiemDanh);
            this.groupBox5.Controls.Add(this.btn_Tre);
            this.groupBox5.Controls.Add(this.VangMat);
            this.groupBox5.Controls.Add(this.btn_CoMat);
            this.groupBox5.Location = new System.Drawing.Point(29, 374);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(451, 307);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Điều Khiển Điểm Danh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Gán tất cả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Chọn ngày để điểm danh";
            // 
            // dtp_NgayDiemDanh
            // 
            this.dtp_NgayDiemDanh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDiemDanh.Location = new System.Drawing.Point(21, 61);
            this.dtp_NgayDiemDanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayDiemDanh.Name = "dtp_NgayDiemDanh";
            this.dtp_NgayDiemDanh.Size = new System.Drawing.Size(219, 36);
            this.dtp_NgayDiemDanh.TabIndex = 36;
            this.dtp_NgayDiemDanh.ValueChanged += new System.EventHandler(this.dtp_NgayDiemDanh_ValueChanged);
            // 
            // VangMat
            // 
            this.VangMat.BackColor = System.Drawing.Color.Crimson;
            this.VangMat.Location = new System.Drawing.Point(301, 119);
            this.VangMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VangMat.Name = "VangMat";
            this.VangMat.Size = new System.Drawing.Size(141, 59);
            this.VangMat.TabIndex = 34;
            this.VangMat.Text = "Vắng Mặt(V)";
            this.VangMat.UseVisualStyleBackColor = false;
            this.VangMat.Click += new System.EventHandler(this.VangMat_Click);
            // 
            // btn_CoMat
            // 
            this.btn_CoMat.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_CoMat.Location = new System.Drawing.Point(301, 53);
            this.btn_CoMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CoMat.Name = "btn_CoMat";
            this.btn_CoMat.Size = new System.Drawing.Size(141, 59);
            this.btn_CoMat.TabIndex = 33;
            this.btn_CoMat.Text = "Có Mặt(X)";
            this.btn_CoMat.UseVisualStyleBackColor = false;
            this.btn_CoMat.Click += new System.EventHandler(this.btn_CoMat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Luu.Location = new System.Drawing.Point(61, 703);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(141, 59);
            this.btn_Luu.TabIndex = 39;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Location = new System.Drawing.Point(272, 703);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(141, 59);
            this.btn_Huy.TabIndex = 40;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 798);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDiemDanh";
            this.Text = "frmDiemDanh";
            this.Load += new System.EventHandler(this.frmDiemDanh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Tre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_NgayDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button VangMat;
        private System.Windows.Forms.Button btn_CoMat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
    }
}