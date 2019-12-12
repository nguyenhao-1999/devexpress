namespace devexpress.View
{
    partial class DoiTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiTac));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.gcDoiTac = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcQuocTich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNguonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.Location = new System.Drawing.Point(2, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 42);
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
            // gcDoiTac
            // 
            this.gcDoiTac.Location = new System.Drawing.Point(2, 39);
            this.gcDoiTac.MainView = this.gridView1;
            this.gcDoiTac.Name = "gcDoiTac";
            this.gcDoiTac.Size = new System.Drawing.Size(1303, 503);
            this.gcDoiTac.TabIndex = 7;
            this.gcDoiTac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcSTT,
            this.grcMa,
            this.grcHoTen,
            this.grcSDT,
            this.grcDiaChi,
            this.grcSTK,
            this.grcNganHang,
            this.grcQuocTich,
            this.grcNguonHang});
            this.gridView1.GridControl = this.gcDoiTac;
            this.gridView1.Name = "gridView1";
            // 
            // grcSTT
            // 
            this.grcSTT.Caption = "STT";
            this.grcSTT.MinWidth = 40;
            this.grcSTT.Name = "grcSTT";
            this.grcSTT.Visible = true;
            this.grcSTT.VisibleIndex = 0;
            this.grcSTT.Width = 40;
            // 
            // grcMa
            // 
            this.grcMa.AppearanceHeader.Options.UseTextOptions = true;
            this.grcMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcMa.Caption = "Mã/CMND";
            this.grcMa.Name = "grcMa";
            this.grcMa.Visible = true;
            this.grcMa.VisibleIndex = 1;
            this.grcMa.Width = 77;
            // 
            // grcHoTen
            // 
            this.grcHoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.grcHoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcHoTen.Caption = "Họ tên/Đơn vị";
            this.grcHoTen.Name = "grcHoTen";
            this.grcHoTen.Visible = true;
            this.grcHoTen.VisibleIndex = 2;
            this.grcHoTen.Width = 200;
            // 
            // grcSDT
            // 
            this.grcSDT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSDT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSDT.Caption = "Điện thoại";
            this.grcSDT.Name = "grcSDT";
            this.grcSDT.Visible = true;
            this.grcSDT.VisibleIndex = 3;
            this.grcSDT.Width = 98;
            // 
            // grcDiaChi
            // 
            this.grcDiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDiaChi.Caption = "Đại Chỉ";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.Visible = true;
            this.grcDiaChi.VisibleIndex = 4;
            this.grcDiaChi.Width = 176;
            // 
            // grcSTK
            // 
            this.grcSTK.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSTK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSTK.Caption = "Số tài khoản";
            this.grcSTK.Name = "grcSTK";
            this.grcSTK.Visible = true;
            this.grcSTK.VisibleIndex = 5;
            this.grcSTK.Width = 176;
            // 
            // grcNganHang
            // 
            this.grcNganHang.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNganHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNganHang.Caption = "Ngân hàng";
            this.grcNganHang.Name = "grcNganHang";
            this.grcNganHang.Visible = true;
            this.grcNganHang.VisibleIndex = 6;
            this.grcNganHang.Width = 176;
            // 
            // grcQuocTich
            // 
            this.grcQuocTich.AppearanceHeader.Options.UseTextOptions = true;
            this.grcQuocTich.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcQuocTich.Caption = "Quốc tịch";
            this.grcQuocTich.Name = "grcQuocTich";
            this.grcQuocTich.Visible = true;
            this.grcQuocTich.VisibleIndex = 7;
            this.grcQuocTich.Width = 176;
            // 
            // grcNguonHang
            // 
            this.grcNguonHang.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNguonHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNguonHang.Caption = "Nguồn Hàng";
            this.grcNguonHang.Name = "grcNguonHang";
            this.grcNguonHang.Visible = true;
            this.grcNguonHang.VisibleIndex = 8;
            this.grcNguonHang.Width = 164;
            // 
            // DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 730);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDoiTac);
            this.Name = "DoiTac";
            this.Text = "Đối tác";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private DevExpress.XtraGrid.GridControl gcDoiTac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn grcMa;
        private DevExpress.XtraGrid.Columns.GridColumn grcHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn grcSDT;
        private DevExpress.XtraGrid.Columns.GridColumn grcDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTK;
        private DevExpress.XtraGrid.Columns.GridColumn grcNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn grcQuocTich;
        private DevExpress.XtraGrid.Columns.GridColumn grcNguonHang;
    }
}