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

namespace QLTV.Use_Control
{
    public partial class cnSach : UserControl
    {
        private Sach_BLL sBUS = new Sach_BLL();
        private NXB_BLL nxbBUS = new NXB_BLL();
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private TheLoai_BLL tlBUS = new TheLoai_BLL();
        private bool add = false, update = false;

        private void cleantxt()
        {
            txtTenSach.Text = "";
            txtNDTT.Text = "";
            txtSoTrang.Text = "";
            txtGia.Text = "";
            cboNXB.Text = "";
            cboTacGia.Text = "";
            cboTheLoai.Text = "";
            txtSoLuong.Text = "";
            dateEdit1.Text = "";
        }

        private void binding()
        {
            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dgvSach.DataSource, "MaSach");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dgvSach.DataSource, "TenSach");
            txtNDTT.DataBindings.Clear();
            txtNDTT.DataBindings.Add("Text", dgvSach.DataSource, "NoiDungTT");
            txtSoTrang.DataBindings.Clear();
            txtSoTrang.DataBindings.Add("Text", dgvSach.DataSource, "SoTrang");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvSach.DataSource, "Gia");
            cboNXB.DataBindings.Clear();
            cboNXB.DataBindings.Add("EditValue", dgvSach.DataSource, "MaNXB");
            cboTacGia.DataBindings.Clear();
            cboTacGia.DataBindings.Add("EditValue", dgvSach.DataSource, "MaTG");
            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("EditValue", dgvSach.DataSource, "MaTL");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvSach.DataSource, "SoLuong");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvSach.DataSource, "NgayNhap");
            cboTinhTrang.DataBindings.Clear();
            cboTinhTrang.DataBindings.Add("Text", dgvSach.DataSource, "TinhTrang");
        }

        //Lấy Thông tin Sách
        private Sach_DTO LayTTSach()
        {
            Sach_DTO s = new Sach_DTO();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.NoiDungTT = txtNDTT.Text;
            s.SoTrang = Convert.ToInt16(txtSoTrang.Text);
            s.Gia = Convert.ToInt32(txtGia.Text);
            s.MaNXB = cboNXB.EditValue.ToString();
            s.MaTG = cboTacGia.EditValue.ToString();
            s.MaTL = cboTheLoai.EditValue.ToString();
            s.TinhTrang = (cboTinhTrang.Text == "Sách Mới") ? 1 : 0;
            s.SoLuong = Convert.ToInt16(txtSoLuong.Text);
            s.NgayNhap = Convert.ToDateTime(dateEdit1.EditValue.ToString());  
            return s;
        }

        public cnSach()
        {
            InitializeComponent();
        }

        private void cnSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã NXB
            cboNXB.Properties.DataSource = nxbBUS.LayDSNXB();
            cboNXB.Properties.DisplayMember = "TenNXB";
            cboNXB.Properties.ValueMember = "MaNXB";

            // Load combobox Mã TG
            cboTacGia.Properties.DataSource = tgBUS.LayDSTG();
            cboTacGia.Properties.DisplayMember = "HoTenTG";
            cboTacGia.Properties.ValueMember = "MaTG";

            // Load combobox Mã TL
            cboTheLoai.Properties.DataSource = tlBUS.LayDSTL();
            cboTheLoai.Properties.DisplayMember = "TenTL";
            cboTheLoai.Properties.ValueMember = "MaTL";

            //Load DataGrid
            dgvSach.DataSource = sBUS.LayDanhSachSach();
            groupControl1.Enabled = false;
            binding();
        }


    }
}
