namespace QLTV.Use_Control
{
    partial class ttSach
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
            this.dgvSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDungTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.MainView = this.gridView1;
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(1147, 554);
            this.dgvSach.TabIndex = 3;
            this.dgvSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.NoiDungTT,
            this.SoTrang,
            this.Gia,
            this.SoLuong,
            this.NgayNhap,
            this.MaNXB,
            this.MaTG,
            this.MaTL,
            this.TinhTrang});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaSach
            // 
            this.MaSach.Caption = "Mã Sách";
            this.MaSach.FieldName = "MaSach";
            this.MaSach.MinWidth = 27;
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            this.MaSach.Width = 100;
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "TenSach";
            this.TenSach.MinWidth = 27;
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            this.TenSach.Width = 100;
            // 
            // NoiDungTT
            // 
            this.NoiDungTT.Caption = "Nội dung tóm tắt";
            this.NoiDungTT.FieldName = "NoiDungTT";
            this.NoiDungTT.MinWidth = 27;
            this.NoiDungTT.Name = "NoiDungTT";
            this.NoiDungTT.Visible = true;
            this.NoiDungTT.VisibleIndex = 2;
            this.NoiDungTT.Width = 100;
            // 
            // SoTrang
            // 
            this.SoTrang.Caption = "Số Trang";
            this.SoTrang.FieldName = "SoTrang";
            this.SoTrang.MinWidth = 27;
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.Visible = true;
            this.SoTrang.VisibleIndex = 3;
            this.SoTrang.Width = 100;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá bìa";
            this.Gia.FieldName = "Gia";
            this.Gia.MinWidth = 27;
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 4;
            this.Gia.Width = 100;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 27;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            this.SoLuong.Width = 100;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.MinWidth = 27;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 6;
            this.NgayNhap.Width = 100;
            // 
            // MaNXB
            // 
            this.MaNXB.Caption = "Mã NXB";
            this.MaNXB.FieldName = "MaNXB";
            this.MaNXB.MinWidth = 27;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Visible = true;
            this.MaNXB.VisibleIndex = 7;
            this.MaNXB.Width = 100;
            // 
            // MaTG
            // 
            this.MaTG.Caption = "Mã TG";
            this.MaTG.FieldName = "MaTG";
            this.MaTG.MinWidth = 27;
            this.MaTG.Name = "MaTG";
            this.MaTG.Visible = true;
            this.MaTG.VisibleIndex = 8;
            this.MaTG.Width = 100;
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã TL";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.MinWidth = 27;
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 9;
            this.MaTL.Width = 100;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Tình Trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.MinWidth = 27;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 10;
            this.TinhTrang.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 554);
            this.panel1.TabIndex = 4;
            // 
            // ttSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ttSach";
            this.Size = new System.Drawing.Size(1147, 554);
            this.Load += new System.EventHandler(this.ttSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDungTT;
        private DevExpress.XtraGrid.Columns.GridColumn SoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn MaTG;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private System.Windows.Forms.Panel panel1;
    }
}
