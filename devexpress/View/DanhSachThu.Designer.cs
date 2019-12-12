namespace devexpress.View
{
    partial class DanhSachThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachThu));
            this.gcDanhSachThu = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcSo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcNgay = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcSoTien = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcLoaiTien = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcTiGia = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcQuiDoi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcHinhThuc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcNoiDung = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDanhSachThu
            // 
            this.gcDanhSachThu.Location = new System.Drawing.Point(1, 39);
            this.gcDanhSachThu.MainView = this.bandedGridView1;
            this.gcDanhSachThu.Name = "gcDanhSachThu";
            this.gcDanhSachThu.Size = new System.Drawing.Size(1295, 609);
            this.gcDanhSachThu.TabIndex = 5;
            this.gcDanhSachThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand7,
            this.gridBand8,
            this.gridBand5});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.grcSo,
            this.grcNgay,
            this.grcSoTien,
            this.grcLoaiTien,
            this.grcTiGia,
            this.grcQuiDoi,
            this.grcHinhThuc,
            this.grcNoiDung});
            this.bandedGridView1.GridControl = this.gcDanhSachThu;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "STT";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 30;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Chứng từ";
            this.gridBand2.Columns.Add(this.grcSo);
            this.gridBand2.Columns.Add(this.grcNgay);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 150;
            // 
            // grcSo
            // 
            this.grcSo.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSo.Caption = "Số";
            this.grcSo.Name = "grcSo";
            this.grcSo.Visible = true;
            // 
            // grcNgay
            // 
            this.grcNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNgay.Caption = "Ngày";
            this.grcNgay.Name = "grcNgay";
            this.grcNgay.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Thực thu";
            this.gridBand3.Columns.Add(this.grcSoTien);
            this.gridBand3.Columns.Add(this.grcLoaiTien);
            this.gridBand3.Columns.Add(this.grcTiGia);
            this.gridBand3.Columns.Add(this.grcQuiDoi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 300;
            // 
            // grcSoTien
            // 
            this.grcSoTien.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSoTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSoTien.Caption = "Số tiền";
            this.grcSoTien.Name = "grcSoTien";
            this.grcSoTien.Visible = true;
            // 
            // grcLoaiTien
            // 
            this.grcLoaiTien.AppearanceHeader.Options.UseTextOptions = true;
            this.grcLoaiTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcLoaiTien.Caption = "Loại tiền";
            this.grcLoaiTien.Name = "grcLoaiTien";
            this.grcLoaiTien.Visible = true;
            // 
            // grcTiGia
            // 
            this.grcTiGia.AppearanceHeader.Options.UseTextOptions = true;
            this.grcTiGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcTiGia.Caption = "Tỉ giá";
            this.grcTiGia.Name = "grcTiGia";
            this.grcTiGia.Visible = true;
            // 
            // grcQuiDoi
            // 
            this.grcQuiDoi.AppearanceHeader.Options.UseTextOptions = true;
            this.grcQuiDoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcQuiDoi.Caption = "Qui đổi";
            this.grcQuiDoi.Name = "grcQuiDoi";
            this.grcQuiDoi.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Hình thức";
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Số phòng";
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 4;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Nhân viên";
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 5;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Khách hàng";
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 6;
            // 
            // grcHinhThuc
            // 
            this.grcHinhThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.grcHinhThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcHinhThuc.Caption = "Hình thức";
            this.grcHinhThuc.Name = "grcHinhThuc";
            this.grcHinhThuc.Visible = true;
            // 
            // grcNoiDung
            // 
            this.grcNoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNoiDung.Caption = "Nội dung";
            this.grcNoiDung.Name = "grcNoiDung";
            this.grcNoiDung.Visible = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnInPhieu);
            this.panelControl1.Controls.Add(this.btnChiTiet);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(1, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(334, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnInPhieu.Appearance.Options.UseFont = true;
            this.btnInPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.ImageOptions.Image")));
            this.btnInPhieu.Location = new System.Drawing.Point(243, 0);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(85, 40);
            this.btnInPhieu.TabIndex = 1;
            this.btnInPhieu.Text = "In phiếu";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChiTiet.Location = new System.Drawing.Point(162, 0);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 40);
            this.btnChiTiet.TabIndex = 1;
            this.btnChiTiet.Text = "Chi tiết";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(81, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
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
            // DanhSachThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 684);
            this.Controls.Add(this.gcDanhSachThu);
            this.Controls.Add(this.panelControl1);
            this.Name = "DanhSachThu";
            this.Text = "Danh Sách Thu";
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSachThu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcSo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcNgay;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcSoTien;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcLoaiTien;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcTiGia;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcQuiDoi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcHinhThuc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcNoiDung;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
    }
}