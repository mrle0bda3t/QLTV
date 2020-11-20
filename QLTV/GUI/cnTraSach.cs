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

namespace QLTV.GUI
{
    public partial class cnTraSach : UserControl
    {
        private TraSach_BLL ptBUS = new TraSach_BLL();
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        private Sach_BLL sBUS = new Sach_BLL();
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            cboMaPhieu.Text = "";
            cboMaNV.Text = "";
            cboMaSach.Text = "";
            txtPhatHong.Text = "";
            txtPhatQH.Text = "";
        }

        //Binding Dữ liệu lên textbox tương ứng
        public void binding()
        {
            cboMaPhieu.DataBindings.Clear();
            cboMaPhieu.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaPhieu");
            cboMaSach.DataBindings.Clear();
            cboMaSach.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaSach");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("EditValue", dgvTraSach.DataSource, "MaNV");
            dateNgayTra.DataBindings.Clear();
            dateNgayTra.DataBindings.Add("Text", dgvTraSach.DataSource, "NgayTra");
            txtPhatHong.DataBindings.Clear();
            txtPhatHong.DataBindings.Add("Text", dgvTraSach.DataSource, "PhatHuHong");
            txtPhatQH.DataBindings.Clear();
            txtPhatQH.DataBindings.Add("Text", dgvTraSach.DataSource, "PhatQuaHan");
        }

        //Lấy Thông tin Trả Sách
        private TraSach_DTO LayTTTS()
        {
            TraSach_DTO ts = new TraSach_DTO();
            ts.MaPhieu = cboMaPhieu.EditValue.ToString();
            ts.MaNV = cboMaNV.EditValue.ToString();
            ts.MaSach = cboMaSach.EditValue.ToString();
            ts.NgayTra = Convert.ToDateTime(dateNgayTra.EditValue.ToString());
            ts.PhatHuHong = Convert.ToInt32(txtPhatHong.Text);
            ts.PhatQuaHan = Convert.ToInt32(txtPhatQH.Text);
            return ts;
        }

        public cnTraSach()
        {
            InitializeComponent();
        }

        private void cnTraSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã Phiếu
            cboMaPhieu.Properties.DataSource = pmBUS.LayDSPM();
            cboMaPhieu.Properties.DisplayMember = "MaPhieu";
            cboMaPhieu.Properties.ValueMember = "MaPhieu";

            // Load combobox Mã NV
            cboMaNV.Properties.DataSource = nvBUS.LayDSNV();
            cboMaNV.Properties.DisplayMember = "HoTenNV";
            cboMaNV.Properties.ValueMember = "MaNV";

            //Load DataGrid
            dgvTraSach.DataSource = ptBUS.LayDanhSachTRASACH();
            groupControl2.Enabled = false;
            binding();
        }

        
    }
}
