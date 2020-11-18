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
    public partial class MuonSach : UserControl
    {
        private PhieuMuon_BLL pmBUS = new PhieuMuon_BLL();
        private DocGia_BLL dgBUS = new DocGia_BLL();
        private NhanVien_BLL nvBUS = new NhanVien_BLL();
        private Sach_BLL sBUS = new Sach_BLL();
        private CTPhieuMuon_BLL ctpmBUS = new CTPhieuMuon_BLL();
        private bool addpm = false, updatepm = false, addctpm=false, updatectpm=false;

        private void cleantxtPM()
        {
            cboMaDG.Text = "";
            dateEdit1.Text = "";
            cboMaNV.Text = "";
        }
        private void cleantxtCTPM()
        {
            cboMaPhieu.Text = "";
            cboSach.Text = "";
            dateEdit2.Text = "";
        }

        private void bindingPM()
        {
            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", dgvPhieuMuon.DataSource, "MaPhieu");
            cboMaDG.DataBindings.Clear();
            cboMaDG.DataBindings.Add("EditValue", dgvPhieuMuon.DataSource, "MaDG");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("Text", dgvPhieuMuon.DataSource, "NgayMuon");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("EditValue", dgvPhieuMuon.DataSource, "MaNV");
        }
        private void bindingCTPM()
        {
            cboMaPhieu.DataBindings.Clear();
            cboMaPhieu.DataBindings.Add("EditValue", dgvCTPhieuMuon.DataSource, "MaPhieu");
            cboSach.DataBindings.Clear();
            cboSach.DataBindings.Add("EditValue", dgvCTPhieuMuon.DataSource, "MaSach");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("Text", dgvCTPhieuMuon.DataSource, "HanTra");
        }

        //Lấy Thông tin Phieu Muon
        private PhieuMuon_DTO LayTTPM()
        {
            PhieuMuon_DTO pm = new PhieuMuon_DTO();
            pm.MaPhieu = txtMaPhieu.Text; 
            pm.MaDG = cboMaDG.EditValue.ToString();
            pm.NgayMuon = Convert.ToDateTime(dateEdit1.EditValue.ToString());
            pm.MaNV = cboMaNV.EditValue.ToString();
            return pm;
        }
        private CTPhieuMuon_DTO LayTTCTPM()
        {
            CTPhieuMuon_DTO ctpm = new CTPhieuMuon_DTO();
            ctpm.MaPhieu = cboMaPhieu.EditValue.ToString();
            ctpm.MaSach = cboSach.EditValue.ToString();
            ctpm.HanTra = Convert.ToDateTime(dateEdit2.EditValue.ToString());
            return ctpm;
        }

        public MuonSach()
        {
            InitializeComponent();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            // Load combobox Mã NXB
            cboMaDG.Properties.DataSource = dgBUS.LayDSDG();
            cboMaDG.Properties.DisplayMember = "HoTenDG";
            cboMaDG.Properties.ValueMember = "MaDG";

            // Load combobox Mã TG
            cboMaNV.Properties.DataSource = nvBUS.LayDSNV();
            cboMaNV.Properties.DisplayMember = "HoTenNV";
            cboMaNV.Properties.ValueMember = "MaNV";

            //Load ComboBox Mã Phiếu
            cboMaPhieu.Properties.DataSource = pmBUS.LayDSPM();
            cboMaPhieu.Properties.DisplayMember = "MaPhieu";
            cboMaPhieu.Properties.ValueMember = "MaPhieu";

            //Load ComboBox Mã Sách
            cboSach.Properties.DataSource = sBUS.LayDSSach();
            cboSach.Properties.DisplayMember = "TenSach";
            cboSach.Properties.ValueMember = "MaSach";

            //Load DataGrid
            dgvPhieuMuon.DataSource = pmBUS.LayDanhSachPM();
            dgvCTPhieuMuon.DataSource = ctpmBUS.LayDanhSachCTPM();
            groupControl2.Enabled = false;
            groupControl4.Enabled = false;
            bindingPM();
            bindingCTPM();
        }

       
    }
}
