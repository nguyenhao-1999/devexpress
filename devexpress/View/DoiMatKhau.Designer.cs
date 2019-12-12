namespace devexpress.View
{
    partial class DoiMatKhau
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtmkcu = new DevExpress.XtraEditors.TextEdit();
            this.txtmkm = new DevExpress.XtraEditors.TextEdit();
            this.txtgolai = new DevExpress.XtraEditors.TextEdit();
            this.btnChapnhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgolai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Gõ lại:";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(118, 19);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtmkcu.Properties.Appearance.Options.UseFont = true;
            this.txtmkcu.Size = new System.Drawing.Size(143, 24);
            this.txtmkcu.TabIndex = 3;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(118, 55);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtmkm.Properties.Appearance.Options.UseFont = true;
            this.txtmkm.Size = new System.Drawing.Size(143, 24);
            this.txtmkm.TabIndex = 4;
            // 
            // txtgolai
            // 
            this.txtgolai.Location = new System.Drawing.Point(118, 89);
            this.txtgolai.Name = "txtgolai";
            this.txtgolai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtgolai.Properties.Appearance.Options.UseFont = true;
            this.txtgolai.Size = new System.Drawing.Size(143, 24);
            this.txtgolai.TabIndex = 5;
            // 
            // btnChapnhan
            // 
            this.btnChapnhan.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnChapnhan.Appearance.Options.UseFont = true;
            this.btnChapnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChapnhan.ImageOptions.Image")));
            this.btnChapnhan.Location = new System.Drawing.Point(12, 134);
            this.btnChapnhan.Name = "btnChapnhan";
            this.btnChapnhan.Size = new System.Drawing.Size(117, 28);
            this.btnChapnhan.TabIndex = 6;
            this.btnChapnhan.Text = "Chấp nhận";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(135, 134);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 28);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 183);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChapnhan);
            this.Controls.Add(this.txtgolai);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Location = new System.Drawing.Point(12, 39);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgolai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtmkcu;
        private DevExpress.XtraEditors.TextEdit txtmkm;
        private DevExpress.XtraEditors.TextEdit txtgolai;
        private DevExpress.XtraEditors.SimpleButton btnChapnhan;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}