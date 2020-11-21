using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTV.BLL;
using QLTV.DTO;

namespace QLTV.Use_Control
{
    public partial class cnTheLoai : UserControl
    {
        private TheLoai_BLL tlBUS=new TheLoai_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTL.Text = "";
            txtGhiChu.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTL.DataBindings.Clear();
            txtMaTL.DataBindings.Add("Text", dgvTheLoai.DataSource, "MaTL");
            txtTenTL.DataBindings.Clear();
            txtTenTL.DataBindings.Add("Text", dgvTheLoai.DataSource, "TenTL");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvTheLoai.DataSource, "GhiChu");
        }

        //Lấy Thông tin Thể loại
        private TheLoai_DTO LayTTTL()
        {
            TheLoai_DTO tl = new TheLoai_DTO();
            tl.MaTL = txtMaTL.Text;
            tl.TenTL = txtTenTL.Text;
            tl.GhiChu = txtGhiChu.Text;
            return tl;
        }

        public cnTheLoai()
        {
            InitializeComponent();
        }

        private void cnTheLoai_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvTheLoai.DataSource = tlBUS.LayDanhSachTheLoai();
            groupControl1.Enabled = false;
            binding();
        }


    }
}
