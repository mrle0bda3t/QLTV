﻿using System;
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
    public partial class cnNXB : UserControl
    {
        private NXB_BLL nxbBUS = new NXB_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtWebsite.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaNXB.DataBindings.Clear();
            txtMaNXB.DataBindings.Add("Text", dgvNXB.DataSource, "MaNXB");
            txtTenNXB.DataBindings.Clear();
            txtTenNXB.DataBindings.Add("Text", dgvNXB.DataSource, "TenNXB");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNXB.DataSource, "DiaChiNXB");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvNXB.DataSource, "DienThoaiNXB");
            txtWebsite.DataBindings.Clear();
            txtWebsite.DataBindings.Add("Text", dgvNXB.DataSource, "Website");
        }

        //Lấy Thông tin NXB
        private NXB_DTO LayTTNXB()
        {
            NXB_DTO nxb = new NXB_DTO();
            nxb.MaNXB = txtMaNXB.Text;
            nxb.TenNXB = txtTenNXB.Text;
            nxb.DiaChiNXB = txtDiaChi.Text;
            nxb.DienThoaiNXB = txtSdt.Text;
            nxb.Website = txtWebsite.Text;
            return nxb;
        }

        public cnNXB()
        {
            InitializeComponent();
        }

        private void cnNXB_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvNXB.DataSource = nxbBUS.LayDanhSachNXB();
            groupControl1.Enabled = false;
            binding();
        }

    }
}
