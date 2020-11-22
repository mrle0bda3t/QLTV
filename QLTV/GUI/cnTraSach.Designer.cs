namespace QLTV.GUI
{
    partial class cnTraSach
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboMaSach = new DevExpress.XtraEditors.LookUpEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.cboMaNV = new DevExpress.XtraEditors.LookUpEdit();
            this.cboMaPhieu = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPhatQH = new DevExpress.XtraEditors.TextEdit();
            this.txtPhatHong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dgvTraSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhatHuHong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhatQH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhatQH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhatHong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(252, 207);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = global::QLTV.Properties.Resources.del;
            this.btnXoa.Location = new System.Drawing.Point(71, 151);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 32);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = global::QLTV.Properties.Resources.update;
            this.btnSua.Location = new System.Drawing.Point(71, 91);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 32);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QLTV.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(71, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 32);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.cboMaSach);
            this.groupControl2.Controls.Add(this.btnHuy);
            this.groupControl2.Controls.Add(this.dateNgayTra);
            this.groupControl2.Controls.Add(this.cboMaNV);
            this.groupControl2.Controls.Add(this.cboMaPhieu);
            this.groupControl2.Controls.Add(this.txtPhatQH);
            this.groupControl2.Controls.Add(this.txtPhatHong);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(264, 4);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1115, 207);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Điền đầy đủ các thông tin";
            // 
            // cboMaSach
            // 
            this.cboMaSach.Location = new System.Drawing.Point(169, 78);
            this.cboMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaSach.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhieu", "Mã Phiếu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaSach", "Mã Sách")});
            this.cboMaSach.Size = new System.Drawing.Size(280, 22);
            this.cboMaSach.TabIndex = 47;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(788, 161);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 32);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.EditValue = null;
            this.dateNgayTra.Location = new System.Drawing.Point(615, 33);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNgayTra.Size = new System.Drawing.Size(280, 22);
            this.dateNgayTra.TabIndex = 45;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Location = new System.Drawing.Point(169, 122);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaNV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNV", "Mã NV"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTenNV", "Họ Tên NV")});
            this.cboMaNV.Size = new System.Drawing.Size(280, 22);
            this.cboMaNV.TabIndex = 44;
            // 
            // cboMaPhieu
            // 
            this.cboMaPhieu.Enabled = false;
            this.cboMaPhieu.Location = new System.Drawing.Point(169, 33);
            this.cboMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaPhieu.Name = "cboMaPhieu";
            this.cboMaPhieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaPhieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhieu", "Mã Phiếu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDG", "Mã ĐG"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayMuon", "Ngày Mượn")});
            this.cboMaPhieu.Size = new System.Drawing.Size(280, 22);
            this.cboMaPhieu.TabIndex = 42;
            this.cboMaPhieu.TextChanged += new System.EventHandler(this.cboMaPhieu_TextChanged);
            // 
            // txtPhatQH
            // 
            this.txtPhatQH.Location = new System.Drawing.Point(615, 122);
            this.txtPhatQH.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhatQH.Name = "txtPhatQH";
            this.txtPhatQH.Size = new System.Drawing.Size(280, 22);
            this.txtPhatQH.TabIndex = 41;
            this.txtPhatQH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhatQH_KeyPress);
            // 
            // txtPhatHong
            // 
            this.txtPhatHong.Location = new System.Drawing.Point(615, 78);
            this.txtPhatHong.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhatHong.Name = "txtPhatHong";
            this.txtPhatHong.Size = new System.Drawing.Size(280, 22);
            this.txtPhatHong.TabIndex = 40;
            this.txtPhatHong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhatHong_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(131, 126);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(18, 16);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "(*)";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(48, 126);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(37, 16);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Mã NV";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(504, 126);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(85, 17);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "Phạt Quá Hạn";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QLTV.Properties.Resources.apply;
            this.btnLuu.Location = new System.Drawing.Point(585, 161);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 32);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(131, 81);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 16);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(131, 37);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 16);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(48, 167);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 16);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "(*)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(75, 167);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(227, 17);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = ": Vui lòng nhập đầy đủ các Thông tin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 37);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Mã Phiếu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 81);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 16);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Mã Sách";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(504, 37);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Ngày Trả";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(504, 81);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 17);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Phạt Hư Hỏng";
            // 
            // dgvTraSach
            // 
            this.dgvTraSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTraSach.Location = new System.Drawing.Point(4, 219);
            this.dgvTraSach.MainView = this.gridView1;
            this.dgvTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTraSach.Name = "dgvTraSach";
            this.dgvTraSach.Size = new System.Drawing.Size(1375, 331);
            this.dgvTraSach.TabIndex = 2;
            this.dgvTraSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhieu,
            this.MaSach,
            this.MaNV,
            this.NgayTra,
            this.PhatHuHong,
            this.PhatQH});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvTraSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaPhieu
            // 
            this.MaPhieu.Caption = "Mã Phiếu";
            this.MaPhieu.FieldName = "MaPhieu";
            this.MaPhieu.MinWidth = 27;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Visible = true;
            this.MaPhieu.VisibleIndex = 0;
            this.MaPhieu.Width = 100;
            // 
            // MaSach
            // 
            this.MaSach.Caption = "Mã Sách";
            this.MaSach.FieldName = "MaSach";
            this.MaSach.MinWidth = 27;
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 1;
            this.MaSach.Width = 100;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã NV";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.MinWidth = 27;
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 2;
            this.MaNV.Width = 100;
            // 
            // NgayTra
            // 
            this.NgayTra.Caption = "Ngày Trả";
            this.NgayTra.FieldName = "NgayTra";
            this.NgayTra.MinWidth = 27;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Visible = true;
            this.NgayTra.VisibleIndex = 3;
            this.NgayTra.Width = 100;
            // 
            // PhatHuHong
            // 
            this.PhatHuHong.Caption = "Phạt Hư Hỏng";
            this.PhatHuHong.FieldName = "PhatHuHong";
            this.PhatHuHong.MinWidth = 27;
            this.PhatHuHong.Name = "PhatHuHong";
            this.PhatHuHong.Visible = true;
            this.PhatHuHong.VisibleIndex = 4;
            this.PhatHuHong.Width = 100;
            // 
            // PhatQH
            // 
            this.PhatQH.Caption = "Phạt Quá Hạn";
            this.PhatQH.FieldName = "PhatQuaHan";
            this.PhatQH.MinWidth = 27;
            this.PhatQH.Name = "PhatQH";
            this.PhatQH.Visible = true;
            this.PhatQH.VisibleIndex = 5;
            this.PhatQH.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.dgvTraSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 554);
            this.panel1.TabIndex = 3;
            // 
            // cnTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cnTraSach";
            this.Size = new System.Drawing.Size(1383, 554);
            this.Load += new System.EventHandler(this.cnTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhatQH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhatHong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtPhatQH;
        private DevExpress.XtraEditors.TextEdit txtPhatHong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.DateEdit dateNgayTra;
        private DevExpress.XtraEditors.LookUpEdit cboMaNV;
        private DevExpress.XtraEditors.LookUpEdit cboMaPhieu;
        private DevExpress.XtraGrid.GridControl dgvTraSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LookUpEdit cboMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn PhatHuHong;
        private DevExpress.XtraGrid.Columns.GridColumn PhatQH;
        private System.Windows.Forms.Panel panel1;
    }
}
