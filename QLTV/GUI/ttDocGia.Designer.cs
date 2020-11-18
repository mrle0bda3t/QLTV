namespace QLTV.Use_Control
{
    partial class ttDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDocGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmailDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoaiDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLamThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocGia.Location = new System.Drawing.Point(0, 0);
            this.dgvDocGia.MainView = this.gridView1;
            this.dgvDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(1147, 554);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDG,
            this.TenDG,
            this.EmailDG,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChiDG,
            this.DienThoaiDG,
            this.NgayLamThe,
            this.NgayHetHan,
            this.HoatDong});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvDocGia;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaDG
            // 
            this.MaDG.Caption = "Mã ĐG";
            this.MaDG.FieldName = "MaDG";
            this.MaDG.MinWidth = 27;
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = true;
            this.MaDG.VisibleIndex = 0;
            this.MaDG.Width = 100;
            // 
            // TenDG
            // 
            this.TenDG.Caption = "Tên ĐG";
            this.TenDG.FieldName = "HoTenDG";
            this.TenDG.MinWidth = 27;
            this.TenDG.Name = "TenDG";
            this.TenDG.Visible = true;
            this.TenDG.VisibleIndex = 1;
            this.TenDG.Width = 100;
            // 
            // EmailDG
            // 
            this.EmailDG.Caption = "Email ĐG";
            this.EmailDG.FieldName = "EmailDG";
            this.EmailDG.MinWidth = 27;
            this.EmailDG.Name = "EmailDG";
            this.EmailDG.Visible = true;
            this.EmailDG.VisibleIndex = 2;
            this.EmailDG.Width = 100;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GioiTinhDG";
            this.GioiTinh.MinWidth = 27;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 3;
            this.GioiTinh.Width = 100;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.FieldName = "NgaySinhDG";
            this.NgaySinh.MinWidth = 27;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 4;
            this.NgaySinh.Width = 100;
            // 
            // DiaChiDG
            // 
            this.DiaChiDG.Caption = "Địa Chỉ ĐG";
            this.DiaChiDG.FieldName = "DiaChiDG";
            this.DiaChiDG.MinWidth = 27;
            this.DiaChiDG.Name = "DiaChiDG";
            this.DiaChiDG.Visible = true;
            this.DiaChiDG.VisibleIndex = 5;
            this.DiaChiDG.Width = 100;
            // 
            // DienThoaiDG
            // 
            this.DienThoaiDG.Caption = "Điện Thoại ĐG";
            this.DienThoaiDG.FieldName = "DienThoaiDG";
            this.DienThoaiDG.MinWidth = 27;
            this.DienThoaiDG.Name = "DienThoaiDG";
            this.DienThoaiDG.Visible = true;
            this.DienThoaiDG.VisibleIndex = 6;
            this.DienThoaiDG.Width = 100;
            // 
            // NgayLamThe
            // 
            this.NgayLamThe.Caption = "Ngày Làm Thẻ";
            this.NgayLamThe.FieldName = "NgayLamThe";
            this.NgayLamThe.MinWidth = 27;
            this.NgayLamThe.Name = "NgayLamThe";
            this.NgayLamThe.Visible = true;
            this.NgayLamThe.VisibleIndex = 7;
            this.NgayLamThe.Width = 100;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.Caption = "Ngày Hết Hạn";
            this.NgayHetHan.FieldName = "NgayHetHan";
            this.NgayHetHan.MinWidth = 27;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Visible = true;
            this.NgayHetHan.VisibleIndex = 8;
            this.NgayHetHan.Width = 100;
            // 
            // HoatDong
            // 
            this.HoatDong.Caption = "Hoạt Động";
            this.HoatDong.FieldName = "HoatDong";
            this.HoatDong.MinWidth = 27;
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.Visible = true;
            this.HoatDong.VisibleIndex = 9;
            this.HoatDong.Width = 100;
            // 
            // ttDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocGia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ttDocGia";
            this.Size = new System.Drawing.Size(1147, 554);
            this.Load += new System.EventHandler(this.ttDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDocGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDG;
        private DevExpress.XtraGrid.Columns.GridColumn TenDG;
        private DevExpress.XtraGrid.Columns.GridColumn EmailDG;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiDG;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoaiDG;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLamThe;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn HoatDong;
    }
}
