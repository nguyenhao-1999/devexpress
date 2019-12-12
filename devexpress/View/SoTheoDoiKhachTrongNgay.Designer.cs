namespace devexpress.View
{
    partial class SoTheoDoiKhachTrongNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoTheoDoiKhachTrongNgay));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.bgrViTri = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bgcNgaycheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bgrGioCheckIn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bgrNgayCheckOut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bgrGioCheckout = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grbViTri = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbNhanPhong = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbTraPhong = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbSoCmnd = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbTen = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbDaiDien = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbNam = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbTreEm = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbQuocTich = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbDienThoai = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbDiDong = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbEmail = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbGhiChu = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgrViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 49);
            this.gridControl1.MainView = this.bgrViTri;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 628);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgrViTri});
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnXong);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 10;
            // 
            // btnXong
            // 
            this.btnXong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXong.Appearance.Options.UseFont = true;
            this.btnXong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnXong.Location = new System.Drawing.Point(81, 0);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(75, 40);
            this.btnXong.TabIndex = 1;
            this.btnXong.Text = "Xong";
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDuLieu.Appearance.Options.UseFont = true;
            this.btnDuLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuLieu.ImageOptions.Image")));
            this.btnDuLieu.Location = new System.Drawing.Point(0, 0);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(75, 40);
            this.btnDuLieu.TabIndex = 0;
            this.btnDuLieu.Text = "Dữ liệu";
            // 
            // bgrViTri
            // 
            this.bgrViTri.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbViTri,
            this.grbNhanPhong,
            this.grbTraPhong,
            this.grbSoCmnd,
            this.grbTen,
            this.grbDaiDien,
            this.grbNam,
            this.grbTreEm,
            this.grbQuocTich,
            this.grbDienThoai,
            this.grbDiDong,
            this.grbEmail,
            this.grbGhiChu});
            this.bgrViTri.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bgcNgaycheck,
            this.bgrGioCheckIn,
            this.bgrNgayCheckOut,
            this.bgrGioCheckout});
            this.bgrViTri.GridControl = this.gridControl1;
            this.bgrViTri.Name = "bgrViTri";
            // 
            // bgcNgaycheck
            // 
            this.bgcNgaycheck.AppearanceHeader.Options.UseTextOptions = true;
            this.bgcNgaycheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgcNgaycheck.Caption = "Ngày";
            this.bgcNgaycheck.Name = "bgcNgaycheck";
            this.bgcNgaycheck.Visible = true;
            // 
            // bgrGioCheckIn
            // 
            this.bgrGioCheckIn.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrGioCheckIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrGioCheckIn.Caption = "Giờ";
            this.bgrGioCheckIn.Name = "bgrGioCheckIn";
            this.bgrGioCheckIn.Visible = true;
            // 
            // bgrNgayCheckOut
            // 
            this.bgrNgayCheckOut.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrNgayCheckOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrNgayCheckOut.Caption = "Ngày";
            this.bgrNgayCheckOut.Name = "bgrNgayCheckOut";
            this.bgrNgayCheckOut.Visible = true;
            // 
            // bgrGioCheckout
            // 
            this.bgrGioCheckout.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrGioCheckout.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrGioCheckout.Caption = "Giờ";
            this.bgrGioCheckout.Name = "bgrGioCheckout";
            this.bgrGioCheckout.Visible = true;
            // 
            // grbViTri
            // 
            this.grbViTri.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grbViTri.AppearanceHeader.Options.UseFont = true;
            this.grbViTri.AppearanceHeader.Options.UseTextOptions = true;
            this.grbViTri.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbViTri.Caption = "Vị trí /Phòng";
            this.grbViTri.Name = "grbViTri";
            this.grbViTri.VisibleIndex = 0;
            // 
            // grbNhanPhong
            // 
            this.grbNhanPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNhanPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNhanPhong.Caption = "Nhận phòng";
            this.grbNhanPhong.Columns.Add(this.bgcNgaycheck);
            this.grbNhanPhong.Columns.Add(this.bgrGioCheckIn);
            this.grbNhanPhong.Name = "grbNhanPhong";
            this.grbNhanPhong.VisibleIndex = 1;
            this.grbNhanPhong.Width = 150;
            // 
            // grbTraPhong
            // 
            this.grbTraPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTraPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTraPhong.Caption = "Trả Phòng";
            this.grbTraPhong.Columns.Add(this.bgrNgayCheckOut);
            this.grbTraPhong.Columns.Add(this.bgrGioCheckout);
            this.grbTraPhong.Name = "grbTraPhong";
            this.grbTraPhong.VisibleIndex = 2;
            this.grbTraPhong.Width = 150;
            // 
            // grbSoCmnd
            // 
            this.grbSoCmnd.AppearanceHeader.Options.UseTextOptions = true;
            this.grbSoCmnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbSoCmnd.Caption = "Số CMND/Hộ chiếu";
            this.grbSoCmnd.Name = "grbSoCmnd";
            this.grbSoCmnd.VisibleIndex = 3;
            // 
            // grbTen
            // 
            this.grbTen.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTen.Caption = "Họ tên khách";
            this.grbTen.Name = "grbTen";
            this.grbTen.VisibleIndex = 4;
            // 
            // grbDaiDien
            // 
            this.grbDaiDien.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDaiDien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDaiDien.Caption = "Đại diện";
            this.grbDaiDien.Name = "grbDaiDien";
            this.grbDaiDien.VisibleIndex = 5;
            // 
            // grbNam
            // 
            this.grbNam.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNam.Caption = "Nam nữ";
            this.grbNam.Name = "grbNam";
            this.grbNam.VisibleIndex = 6;
            // 
            // grbTreEm
            // 
            this.grbTreEm.AppearanceHeader.Options.UseTextOptions = true;
            this.grbTreEm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbTreEm.Caption = "Trẻ em";
            this.grbTreEm.Name = "grbTreEm";
            this.grbTreEm.VisibleIndex = 7;
            // 
            // grbQuocTich
            // 
            this.grbQuocTich.AppearanceHeader.Options.UseTextOptions = true;
            this.grbQuocTich.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbQuocTich.Caption = "Quốc tịch";
            this.grbQuocTich.Name = "grbQuocTich";
            this.grbQuocTich.VisibleIndex = 8;
            // 
            // grbDienThoai
            // 
            this.grbDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDienThoai.Caption = "Điện thoại";
            this.grbDienThoai.Name = "grbDienThoai";
            this.grbDienThoai.VisibleIndex = 9;
            // 
            // grbDiDong
            // 
            this.grbDiDong.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDiDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDiDong.Caption = "Di động";
            this.grbDiDong.Name = "grbDiDong";
            this.grbDiDong.VisibleIndex = 10;
            // 
            // grbEmail
            // 
            this.grbEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.grbEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbEmail.Caption = "Email";
            this.grbEmail.Name = "grbEmail";
            this.grbEmail.VisibleIndex = 11;
            // 
            // grbGhiChu
            // 
            this.grbGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.grbGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbGhiChu.Caption = "Ghi chú";
            this.grbGhiChu.Name = "grbGhiChu";
            this.grbGhiChu.VisibleIndex = 12;
            // 
            // SoTheoDoiKhachTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 749);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "SoTheoDoiKhachTrongNgay";
            this.Text = "SoTheoDoiKhachTrongNgay";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgrViTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgrViTri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbViTri;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNhanPhong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgcNgaycheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrGioCheckIn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTraPhong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrNgayCheckOut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrGioCheckout;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbSoCmnd;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTen;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDaiDien;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNam;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbTreEm;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbQuocTich;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDienThoai;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDiDong;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbGhiChu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXong;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
    }
}