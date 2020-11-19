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
    public partial class tkSach : UserControl
    {
        private Sach_BLL sBUS = new Sach_BLL();
        private NXB_BLL nxbBUS = new NXB_BLL();
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private TheLoai_BLL tlBUS = new TheLoai_BLL();
        public tkSach()
        {
            InitializeComponent();
        }
        private void cleantxt()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboNXB.Text = "";
            cboTacGia.Text = "";
            cboTheLoai.Text = "";
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            cboNXB.Enabled = false;
            cboTacGia.Enabled = false;
            cboTheLoai.Enabled = false;
            cboNXB.ClosePopup();
            cboTacGia.ClosePopup();
            cboTheLoai.ClosePopup();
        }

        private void tkSach_Load(object sender, EventArgs e)
        {
            //Load combobox tìm kiếm theo tên nhà xuất bản
            cboNXB.Properties.DataSource = nxbBUS.LayDSNXB();
            cboNXB.Properties.DisplayMember = "TenNXB";
            cboNXB.Properties.ValueMember = "MaNXB";

            //Load combobox tìm kiếm theo tên tác giả
            cboTacGia.Properties.DataSource = tgBUS.LayDSTG();
            cboTacGia.Properties.DisplayMember = "HoTenTG";
            cboTacGia.Properties.ValueMember = "MaTG";

            //Load combobox tìm kiếm theo thể loại
            cboTheLoai.Properties.DataSource = tlBUS.LayDSTL();
            cboTheLoai.Properties.DisplayMember = "TenTL";
            cboTheLoai.Properties.ValueMember = "MaTL";

            //Load GridControl
            dgvDanhSach.DataSource = sBUS.LayDanhSachSach();
            cleantxt();
        }

        private void radMaSach_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radMaSach.Checked == true) txtMaSach.Enabled = true;
        }

        private void radTenSach_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenSach.Checked == true) txtTenSach.Enabled = true;
        }

        private void radTenNXB_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenNXB.Checked == true) cboNXB.Enabled = true;
        }

        private void radTenTG_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTenTG.Checked == true) cboTacGia.Enabled = true;
        }

        private void radTheLoai_CheckedChanged(object sender, EventArgs e)
        {
            cleantxt();
            if (radTheLoai.Checked == true) cboTheLoai.Enabled = true;
        }

    }
}
