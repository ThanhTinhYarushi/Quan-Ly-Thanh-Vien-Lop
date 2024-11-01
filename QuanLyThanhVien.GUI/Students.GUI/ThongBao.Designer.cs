namespace QuanLyThanhVien.GUI.Students.GUI
{
    partial class ThongBao
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TieuDeThongBao = new System.Windows.Forms.TextBox();
            this.rtb_txt_NoiDungThongBao = new System.Windows.Forms.RichTextBox();
            this.dtp_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ThongBao = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongBao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTenLop);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtp_NgayTao);
            this.groupBox3.Controls.Add(this.rtb_txt_NoiDungThongBao);
            this.groupBox3.Controls.Add(this.txt_TieuDeThongBao);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(60, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 482);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Thông Báo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Tạo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiêu Đề Thông Báo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nội Dung Thông Báo";
            // 
            // txt_TieuDeThongBao
            // 
            this.txt_TieuDeThongBao.Location = new System.Drawing.Point(166, 33);
            this.txt_TieuDeThongBao.Name = "txt_TieuDeThongBao";
            this.txt_TieuDeThongBao.Size = new System.Drawing.Size(160, 26);
            this.txt_TieuDeThongBao.TabIndex = 13;
            // 
            // rtb_txt_NoiDungThongBao
            // 
            this.rtb_txt_NoiDungThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_txt_NoiDungThongBao.Location = new System.Drawing.Point(10, 168);
            this.rtb_txt_NoiDungThongBao.Name = "rtb_txt_NoiDungThongBao";
            this.rtb_txt_NoiDungThongBao.Size = new System.Drawing.Size(316, 309);
            this.rtb_txt_NoiDungThongBao.TabIndex = 16;
            this.rtb_txt_NoiDungThongBao.Text = "";
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTao.Location = new System.Drawing.Point(166, 118);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(100, 26);
            this.dtp_NgayTao.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(166, 78);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(160, 26);
            this.txtTenLop.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.dgv_ThongBao);
            this.groupBox2.Location = new System.Drawing.Point(453, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 526);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất Cả Thông Báo";
            // 
            // dgv_ThongBao
            // 
            this.dgv_ThongBao.AllowUserToOrderColumns = true;
            this.dgv_ThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ThongBao.Location = new System.Drawing.Point(14, 19);
            this.dgv_ThongBao.Name = "dgv_ThongBao";
            this.dgv_ThongBao.RowHeadersWidth = 62;
            this.dgv_ThongBao.Size = new System.Drawing.Size(723, 501);
            this.dgv_ThongBao.TabIndex = 0;
            this.dgv_ThongBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongBao_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Lớp";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Tạo Thông Báo";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội Dung Thông Báo";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 192;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tiêu Đề Thông Báo";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(385, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 55);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quản Lý Thông Báo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1227, 725);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 714);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            this.Resize += new System.EventHandler(this.ThongBao_Resize);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongBao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_NgayTao;
        private System.Windows.Forms.RichTextBox rtb_txt_NoiDungThongBao;
        private System.Windows.Forms.TextBox txt_TieuDeThongBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}