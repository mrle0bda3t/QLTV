﻿namespace QLTV.GUI
{
    partial class cnMatKhau
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
            this.lblThongBao = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtReNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.lblThongBao);
            this.groupControl1.Controls.Add(this.btnDoiMK);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.txtReNewPass);
            this.groupControl1.Controls.Add(this.txtNewPass);
            this.groupControl1.Controls.Add(this.txtOldPass);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1147, 554);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đổi Mật Khẩu";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Appearance.Options.UseFont = true;
            this.lblThongBao.Appearance.Options.UseForeColor = true;
            this.lblThongBao.Location = new System.Drawing.Point(432, 310);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(179, 19);
            this.lblThongBao.TabIndex = 16;
            this.lblThongBao.Text = "Mật khẩu chưa được đổi !";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Appearance.Options.UseFont = true;
            this.btnDoiMK.ImageOptions.Image = global::QLTV.Properties.Resources.update32;
            this.btnDoiMK.Location = new System.Drawing.Point(328, 348);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(160, 47);
            this.btnDoiMK.TabIndex = 15;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QLTV.Properties.Resources.cancel32;
            this.btnHuy.Location = new System.Drawing.Point(559, 348);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(160, 47);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(432, 261);
            this.txtReNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Size = new System.Drawing.Size(323, 23);
            this.txtReNewPass.TabIndex = 13;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(432, 206);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(323, 23);
            this.txtNewPass.TabIndex = 12;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(432, 150);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(323, 23);
            this.txtOldPass.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(272, 265);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(122, 19);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Nhập lại Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(272, 209);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Mật Khẩu Mới";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(272, 154);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mật Khẩu Cũ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(483, 80);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 26);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Đổi Mật Khẩu";
            // 
            // cnMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cnMatKhau";
            this.Size = new System.Drawing.Size(1147, 554);
            this.Load += new System.EventHandler(this.cnMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtReNewPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        public DevExpress.XtraEditors.LabelControl lblThongBao;
    }
}
