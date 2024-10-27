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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Len = new System.Windows.Forms.Button();
            this.btn_Xuong = new System.Windows.Forms.Button();
            this.btn_CoMat = new System.Windows.Forms.Button();
            this.VangMat = new System.Windows.Forms.Button();
            this.btn_Tre = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_NgayDiemDanh = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox1.Location = new System.Drawing.Point(372, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 237);
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_Lop.Location = new System.Drawing.Point(6, 25);
            this.dataGridView_Lop.Name = "dataGridView_Lop";
            this.dataGridView_Lop.Size = new System.Drawing.Size(786, 206);
            this.dataGridView_Lop.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giảng Viên Phụ Trách";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiết Học";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phòng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(263, 106);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(103, 43);
            this.btn_Tim.TabIndex = 29;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(12, 118);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(245, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 126);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Lớp Học";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(171, 78);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(177, 26);
            this.txt_TenLop.TabIndex = 6;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(171, 34);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(177, 26);
            this.txt_MaLop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(422, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(330, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 55);
            this.label1.TabIndex = 30;
            this.label1.Text = "Điểm Danh Sinh Viên";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Ivory;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(372, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(798, 289);
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
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MSSV";
            this.Column7.Name = "Column7";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Tên Sinh Viên";
            this.Column12.Name = "Column12";
            this.Column12.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Lớp";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên Lớp";
            this.Column9.Name = "Column9";
            this.Column9.Width = 180;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ngày Điểm Danh";
            this.Column10.Name = "Column10";
            this.Column10.Width = 130;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Trạng Thái";
            this.Column11.Name = "Column11";
            // 
            // btn_Len
            // 
            this.btn_Len.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Len.Location = new System.Drawing.Point(25, 70);
            this.btn_Len.Name = "btn_Len";
            this.btn_Len.Size = new System.Drawing.Size(106, 48);
            this.btn_Len.TabIndex = 31;
            this.btn_Len.Text = "Lên";
            this.btn_Len.UseVisualStyleBackColor = false;
            // 
            // btn_Xuong
            // 
            this.btn_Xuong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Xuong.Location = new System.Drawing.Point(25, 128);
            this.btn_Xuong.Name = "btn_Xuong";
            this.btn_Xuong.Size = new System.Drawing.Size(106, 48);
            this.btn_Xuong.TabIndex = 32;
            this.btn_Xuong.Text = "Xuống";
            this.btn_Xuong.UseVisualStyleBackColor = false;
            // 
            // btn_CoMat
            // 
            this.btn_CoMat.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_CoMat.Location = new System.Drawing.Point(226, 43);
            this.btn_CoMat.Name = "btn_CoMat";
            this.btn_CoMat.Size = new System.Drawing.Size(106, 48);
            this.btn_CoMat.TabIndex = 33;
            this.btn_CoMat.Text = "Có Mặt";
            this.btn_CoMat.UseVisualStyleBackColor = false;
            // 
            // VangMat
            // 
            this.VangMat.BackColor = System.Drawing.Color.Crimson;
            this.VangMat.Location = new System.Drawing.Point(226, 97);
            this.VangMat.Name = "VangMat";
            this.VangMat.Size = new System.Drawing.Size(106, 48);
            this.VangMat.TabIndex = 34;
            this.VangMat.Text = "Vắng Mặt";
            this.VangMat.UseVisualStyleBackColor = false;
            // 
            // btn_Tre
            // 
            this.btn_Tre.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Tre.Location = new System.Drawing.Point(226, 151);
            this.btn_Tre.Name = "btn_Tre";
            this.btn_Tre.Size = new System.Drawing.Size(106, 48);
            this.btn_Tre.TabIndex = 35;
            this.btn_Tre.Text = "Đi Trễ";
            this.btn_Tre.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_NgayDiemDanh);
            this.groupBox5.Controls.Add(this.btn_Xuong);
            this.groupBox5.Controls.Add(this.btn_Tre);
            this.groupBox5.Controls.Add(this.btn_Len);
            this.groupBox5.Controls.Add(this.VangMat);
            this.groupBox5.Controls.Add(this.btn_CoMat);
            this.groupBox5.Location = new System.Drawing.Point(22, 304);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 326);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Điều Khiển Điểm Danh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(993, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(990, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày Điểm Danh";
            // 
            // dtp_NgayDiemDanh
            // 
            this.dtp_NgayDiemDanh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayDiemDanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDiemDanh.Location = new System.Drawing.Point(25, 227);
            this.dtp_NgayDiemDanh.Name = "dtp_NgayDiemDanh";
            this.dtp_NgayDiemDanh.Size = new System.Drawing.Size(106, 20);
            this.dtp_NgayDiemDanh.TabIndex = 36;
            // 
            // frmDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiemDanh";
            this.Text = "frmDiemDanh";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btn_Len;
        private System.Windows.Forms.Button btn_Xuong;
        private System.Windows.Forms.Button btn_CoMat;
        private System.Windows.Forms.Button VangMat;
        private System.Windows.Forms.Button btn_Tre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_NgayDiemDanh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}