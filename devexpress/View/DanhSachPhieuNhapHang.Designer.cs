namespace devexpress.View
{
    partial class DanhSachPhieuNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachPhieuNhapHang));
            this.gcHieuQuaKhaiThacPhong = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bgrNgay = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.brgSo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcNgay = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bgrTongCong = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bgrChietKhau = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.grbSTT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbChungTu = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbNhaCC = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbDaiDien = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbHanTT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbNoiDung = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grbNhanVien = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.gcHieuQuaKhaiThacPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcHieuQuaKhaiThacPhong
            // 
            this.gcHieuQuaKhaiThacPhong.Location = new System.Drawing.Point(1, 49);
            this.gcHieuQuaKhaiThacPhong.MainView = this.bandedGridView1;
            this.gcHieuQuaKhaiThacPhong.Name = "gcHieuQuaKhaiThacPhong";
            this.gcHieuQuaKhaiThacPhong.Size = new System.Drawing.Size(1295, 646);
            this.gcHieuQuaKhaiThacPhong.TabIndex = 12;
            this.gcHieuQuaKhaiThacPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.grbSTT,
            this.grbChungTu,
            this.grbNhaCC,
            this.grbDaiDien,
            this.grbHanTT,
            this.grbNoiDung,
            this.grbNhanVien});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.grcNgay,
            this.brgSo,
            this.bgrTongCong,
            this.bgrChietKhau,
            this.bgrNgay});
            this.bandedGridView1.GridControl = this.gcHieuQuaKhaiThacPhong;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // bgrNgay
            // 
            this.bgrNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrNgay.Caption = "Ngày";
            this.bgrNgay.Name = "bgrNgay";
            // 
            // brgSo
            // 
            this.brgSo.AppearanceHeader.Options.UseTextOptions = true;
            this.brgSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brgSo.Caption = "Số";
            this.brgSo.Name = "brgSo";
            this.brgSo.Visible = true;
            // 
            // grcNgay
            // 
            this.grcNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNgay.Caption = "Ngày";
            this.grcNgay.Name = "grcNgay";
            this.grcNgay.Visible = true;
            // 
            // bgrTongCong
            // 
            this.bgrTongCong.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrTongCong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrTongCong.Caption = "Tổng cộng";
            this.bgrTongCong.Name = "bgrTongCong";
            this.bgrTongCong.Visible = true;
            // 
            // bgrChietKhau
            // 
            this.bgrChietKhau.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrChietKhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrChietKhau.Caption = "Chiết khấu";
            this.bgrChietKhau.Name = "bgrChietKhau";
            this.bgrChietKhau.Visible = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 11;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(243, 0);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 40);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(162, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(81, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(324, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
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
            // grbSTT
            // 
            this.grbSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.grbSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbSTT.Caption = "STT";
            this.grbSTT.Name = "grbSTT";
            this.grbSTT.VisibleIndex = 0;
            this.grbSTT.Width = 30;
            // 
            // grbChungTu
            // 
            this.grbChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.grbChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbChungTu.Caption = "Chứng từ";
            this.grbChungTu.Columns.Add(this.bgrNgay);
            this.grbChungTu.Columns.Add(this.brgSo);
            this.grbChungTu.Columns.Add(this.grcNgay);
            this.grbChungTu.Columns.Add(this.bgrTongCong);
            this.grbChungTu.Columns.Add(this.bgrChietKhau);
            this.grbChungTu.Name = "grbChungTu";
            this.grbChungTu.VisibleIndex = 1;
            this.grbChungTu.Width = 300;
            // 
            // grbNhaCC
            // 
            this.grbNhaCC.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNhaCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNhaCC.Caption = "Nhà cung cấp";
            this.grbNhaCC.Name = "grbNhaCC";
            this.grbNhaCC.VisibleIndex = 2;
            this.grbNhaCC.Width = 75;
            // 
            // grbDaiDien
            // 
            this.grbDaiDien.AppearanceHeader.Options.UseTextOptions = true;
            this.grbDaiDien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbDaiDien.Caption = "Đại diện";
            this.grbDaiDien.Name = "grbDaiDien";
            this.grbDaiDien.VisibleIndex = 3;
            this.grbDaiDien.Width = 75;
            // 
            // grbHanTT
            // 
            this.grbHanTT.AppearanceHeader.Options.UseTextOptions = true;
            this.grbHanTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbHanTT.Caption = "Hạn thanh toán";
            this.grbHanTT.Name = "grbHanTT";
            this.grbHanTT.VisibleIndex = 4;
            this.grbHanTT.Width = 75;
            // 
            // grbNoiDung
            // 
            this.grbNoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNoiDung.Caption = "Nội dung";
            this.grbNoiDung.Name = "grbNoiDung";
            this.grbNoiDung.VisibleIndex = 5;
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.AppearanceHeader.Options.UseTextOptions = true;
            this.grbNhanVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grbNhanVien.Caption = "Nhân viên";
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.VisibleIndex = 6;
            // 
            // DanhSachPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 725);
            this.Controls.Add(this.gcHieuQuaKhaiThacPhong);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhSachPhieuNhapHang";
            this.Text = "DanhSachPhieuNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.gcHieuQuaKhaiThacPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHieuQuaKhaiThacPhong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrNgay;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn brgSo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcNgay;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrTongCong;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bgrChietKhau;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbSTT;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbChungTu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNhaCC;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbDaiDien;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbHanTT;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNoiDung;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grbNhanVien;
    }
}