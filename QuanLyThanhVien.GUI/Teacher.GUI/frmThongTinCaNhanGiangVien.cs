﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThanhVien.GUI.Teacher.GUI
{
    public partial class frmThongTinCaNhanGiangVien : Form
    {
        //private readonly GiangVienService giangVienService = new GiangVienService()
        public frmThongTinCaNhanGiangVien()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhanGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
       
    }
}
