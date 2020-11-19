namespace QLTV.Use_Control
{
    partial class ttTheLoai
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
            this.dgvTheLoai = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheLoai.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dgvTheLoai.MainView = this.gridView1;
            this.dgvTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.Size = new System.Drawing.Size(1147, 554);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTL,
            this.TenTL,
            this.GhiChu});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.dgvTheLoai;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaTL
            // 
            this.MaTL.Caption = "Mã Thể Loại";
            this.MaTL.FieldName = "MaTL";
            this.MaTL.MinWidth = 27;
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 0;
            this.MaTL.Width = 100;
            // 
            // TenTL
            // 
            this.TenTL.Caption = "Tên Thể Loại";
            this.TenTL.FieldName = "TenTL";
            this.TenTL.MinWidth = 27;
            this.TenTL.Name = "TenTL";
            this.TenTL.Visible = true;
            this.TenTL.VisibleIndex = 1;
            this.TenTL.Width = 100;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.MinWidth = 27;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 2;
            this.GhiChu.Width = 100;
            // 
            // ttTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTheLoai);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ttTheLoai";
            this.Size = new System.Drawing.Size(1147, 554);
            this.Load += new System.EventHandler(this.ttTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TenTL;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;

    }
}
