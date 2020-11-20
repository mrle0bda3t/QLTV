namespace QLTV.GUI
{
    partial class tkDocGia
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDG = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDG = new DevExpress.XtraEditors.TextEdit();
            this.radDiaChi = new System.Windows.Forms.RadioButton();
            this.radTenDG = new System.Windows.Forms.RadioButton();
            this.radMaDG = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocGia.Location = new System.Drawing.Point(4, 180);
            this.dgvDocGia.MainView = this.gridView1;
            this.dgvDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(1139, 370);
            this.dgvDocGia.TabIndex = 1;
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
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtTenDG);
            this.groupControl1.Controls.Add(this.txtMaDG);
            this.groupControl1.Controls.Add(this.radDiaChi);
            this.groupControl1.Controls.Add(this.radTenDG);
            this.groupControl1.Controls.Add(this.radMaDG);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnHienThi);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnTim);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1139, 162);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Nhập các thông tin";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(467, 126);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(361, 22);
            this.txtDiaChi.TabIndex = 52;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(467, 81);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(361, 22);
            this.txtTenDG.TabIndex = 51;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(467, 37);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(361, 22);
            this.txtMaDG.TabIndex = 50;
            // 
            // radDiaChi
            // 
            this.radDiaChi.AutoSize = true;
            this.radDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDiaChi.Location = new System.Drawing.Point(301, 126);
            this.radDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.radDiaChi.Name = "radDiaChi";
            this.radDiaChi.Size = new System.Drawing.Size(82, 24);
            this.radDiaChi.TabIndex = 49;
            this.radDiaChi.TabStop = true;
            this.radDiaChi.Text = "Địa chỉ";
            this.radDiaChi.UseVisualStyleBackColor = true;
            this.radDiaChi.CheckedChanged += new System.EventHandler(this.radDiaChi_CheckedChanged);
            // 
            // radTenDG
            // 
            this.radTenDG.AutoSize = true;
            this.radTenDG.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenDG.Location = new System.Drawing.Point(301, 81);
            this.radTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.radTenDG.Name = "radTenDG";
            this.radTenDG.Size = new System.Drawing.Size(113, 24);
            this.radTenDG.TabIndex = 47;
            this.radTenDG.TabStop = true;
            this.radTenDG.Text = "Tên độc giả";
            this.radTenDG.UseVisualStyleBackColor = true;
            this.radTenDG.CheckedChanged += new System.EventHandler(this.radTenDG_CheckedChanged);
            // 
            // radMaDG
            // 
            this.radMaDG.AutoSize = true;
            this.radMaDG.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaDG.Location = new System.Drawing.Point(301, 41);
            this.radMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.radMaDG.Name = "radMaDG";
            this.radMaDG.Size = new System.Drawing.Size(110, 24);
            this.radMaDG.TabIndex = 46;
            this.radMaDG.TabStop = true;
            this.radMaDG.Text = "Mã độc giả";
            this.radMaDG.UseVisualStyleBackColor = true;
            this.radMaDG.CheckedChanged += new System.EventHandler(this.radMaDG_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 19);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Tìm kiếm thông tin độc giả theo:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Appearance.Options.UseFont = true;
            this.btnHienThi.ImageOptions.Image = global::QLTV.Properties.Resources.search_all;
            this.btnHienThi.Location = new System.Drawing.Point(928, 76);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(155, 32);
            this.btnHienThi.TabIndex = 44;
            this.btnHienThi.Text = "Hiển thị Tất cả";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(928, 118);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(155, 32);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = global::QLTV.Properties.Resources.search_16;
            this.btnTim.Location = new System.Drawing.Point(928, 34);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(155, 32);
            this.btnTim.TabIndex = 42;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.dgvDocGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 554);
            this.panel1.TabIndex = 3;
            // 
            // tkDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tkDocGia";
            this.Size = new System.Drawing.Size(1147, 554);
            this.Load += new System.EventHandler(this.tkDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTenDG;
        private DevExpress.XtraEditors.TextEdit txtMaDG;
        private System.Windows.Forms.RadioButton radDiaChi;
        private System.Windows.Forms.RadioButton radTenDG;
        private System.Windows.Forms.RadioButton radMaDG;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Panel panel1;
    }
}
