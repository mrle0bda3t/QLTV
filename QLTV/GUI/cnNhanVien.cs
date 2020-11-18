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
    public partial class cnNhanVien : UserControl
    {

        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private bool add = false, update = false;

        private void cleantxt()
        {
            txtHoTenNV.Text = "";
            cboGioiTinh.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            dateEdit1.Text = "";
            dateEdit2.Text = "";
            txtMatKhau.Text = "";
        }

        private void binding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "MaNV");
            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", dgvNhanVien.DataSource, "HoTenNV");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "GioiTinhNV");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgaySinhNV");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvNhanVien.DataSource, "DienThoaiNV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhanVien.DataSource, "DiaChiNV");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvNhanVien.DataSource, "EmailNV");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text", dgvNhanVien.DataSource, "NgayVaoLam");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvNhanVien.DataSource, "MatKhau");
            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text",dgvNhanVien.DataSource, "QuyenHan");
        }

        //Lấy Thông tin Thể loại
        private NhanVien_DTO LayTTDG()
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = txtMaNV.Text;
            nv.HoTenNV = txtHoTenNV.Text;
            nv.GioiTinhNV = (cboGioiTinh.Text == "Nam") ? 1 : 0;
            nv.NgaySinhNV = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            nv.DienThoaiNV = txtSdt.Text;
            nv.DiaChiNV = txtDiaChi.Text;
            nv.EmailNV = txtEmail.Text;
            nv.NgayVaoLam = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            nv.MatKhau = txtMatKhau.Text;
            nv.QuyenHan = (cboQuyenHan.Text == "Quản Lý") ? 1 : 0;
            return nv;
        }

        public cnNhanVien()
        {
            InitializeComponent();
        }

        private void cnNhanVien_Load(object sender, EventArgs e)
        {
            //Load DataGrid
            dgvNhanVien.DataSource = nvBUS.LayDanhSachNhanVien();
            groupControl1.Enabled = false;
            binding();
        }


    }
}
