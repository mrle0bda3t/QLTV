using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.GUI
{
    public partial class tkDocGia : UserControl
    {
        private DocGia_BLL dgBUS = new DocGia_BLL();

        public tkDocGia()
        {
            InitializeComponent();
        }

        private void cleantxt()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            txtDiaChi.Text = "";
            txtMaDG.Enabled = false;
            txtTenDG.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void tkDocGia_Load(object sender, EventArgs e)
        {
            // Load DataGrid
            dgvDocGia.DataSource = dgBUS.LayDanhSachDocGia();
            cleantxt();
        }

        private void radMaDG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radMaDG.Checked == true) txtMaDG.Enabled = true;
        }

        private void radTenDG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenDG.Checked == true) txtTenDG.Enabled = true;
        }

        private void radDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radDiaChi.Checked == true) txtDiaChi.Enabled = true;
        }
        
    }
}
