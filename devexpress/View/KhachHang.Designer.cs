namespace devexpress.View
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcPhaiThu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcPhaiTra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcDoanhSo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.grcNgaySinh = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcNam = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcTreEm = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcQuocTich = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcDiaChi = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grcSDT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Location = new System.Drawing.Point(1, 47);
            this.gcKhachHang.MainView = this.bandedGridView1;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(1282, 429);
            this.gcKhachHang.TabIndex = 9;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.grcNgaySinh,
            this.grcNam,
            this.grcTreEm,
            this.grcQuocTich,
            this.grcDiaChi,
            this.grcSDT});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.grcPhaiThu,
            this.grcPhaiTra,
            this.grcDoanhSo});
            this.bandedGridView1.GridControl = this.gcKhachHang;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "STT";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Số CMND/Hộ chiếu";
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Họ và tên";
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Đầu kỳ";
            this.gridBand4.Columns.Add(this.grcPhaiThu);
            this.gridBand4.Columns.Add(this.grcPhaiTra);
            this.gridBand4.Columns.Add(this.grcDoanhSo);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 225;
            // 
            // grcPhaiThu
            // 
            this.grcPhaiThu.AppearanceHeader.Options.UseTextOptions = true;
            this.grcPhaiThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcPhaiThu.Caption = "Phải thu";
            this.grcPhaiThu.FieldName = "grcPhaiThu";
            this.grcPhaiThu.Name = "grcPhaiThu";
            this.grcPhaiThu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.grcPhaiThu.Visible = true;
            // 
            // grcPhaiTra
            // 
            this.grcPhaiTra.AppearanceHeader.Options.UseTextOptions = true;
            this.grcPhaiTra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcPhaiTra.Caption = "Phải trả";
            this.grcPhaiTra.Name = "grcPhaiTra";
            this.grcPhaiTra.Visible = true;
            // 
            // grcDoanhSo
            // 
            this.grcDoanhSo.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDoanhSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDoanhSo.Caption = "Doanh số";
            this.grcDoanhSo.Name = "grcDoanhSo";
            this.grcDoanhSo.Visible = true;
            // 
            // grcNgaySinh
            // 
            this.grcNgaySinh.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNgaySinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNgaySinh.Caption = "Ngày sinh";
            this.grcNgaySinh.Name = "grcNgaySinh";
            this.grcNgaySinh.VisibleIndex = 4;
            // 
            // grcNam
            // 
            this.grcNam.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNam.Caption = "Nam";
            this.grcNam.Name = "grcNam";
            this.grcNam.VisibleIndex = 5;
            // 
            // grcTreEm
            // 
            this.grcTreEm.AppearanceHeader.Options.UseTextOptions = true;
            this.grcTreEm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcTreEm.Caption = "Trẻ em";
            this.grcTreEm.Name = "grcTreEm";
            this.grcTreEm.VisibleIndex = 6;
            // 
            // grcQuocTich
            // 
            this.grcQuocTich.AppearanceHeader.Options.UseTextOptions = true;
            this.grcQuocTich.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcQuocTich.Caption = "Quốc tịch";
            this.grcQuocTich.Name = "grcQuocTich";
            this.grcQuocTich.VisibleIndex = 7;
            // 
            // grcDiaChi
            // 
            this.grcDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDiaChi.Caption = "Địa chỉ";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.VisibleIndex = 8;
            // 
            // grcSDT
            // 
            this.grcSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSDT.Caption = "SĐT";
            this.grcSDT.Name = "grcSDT";
            this.grcSDT.VisibleIndex = 9;
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
            this.panelControl1.Location = new System.Drawing.Point(1, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 8;
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
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 731);
            this.Controls.Add(this.gcKhachHang);
            this.Controls.Add(this.panelControl1);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcPhaiThu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcPhaiTra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grcDoanhSo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcNgaySinh;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcNam;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcTreEm;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcQuocTich;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcDiaChi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand grcSDT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
    }
}