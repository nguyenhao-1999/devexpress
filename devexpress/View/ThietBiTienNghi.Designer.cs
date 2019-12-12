namespace devexpress.View
{
    partial class ThietBiTienNghi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThietBiTienNghi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachPhieuDP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.brgMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgrTenTb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgrNoiSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgrKoSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bgcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhieuDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.panelControl1.Location = new System.Drawing.Point(1, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 12;
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
            // gcDanhSachPhieuDP
            // 
            this.gcDanhSachPhieuDP.Location = new System.Drawing.Point(1, 47);
            this.gcDanhSachPhieuDP.MainView = this.gridView1;
            this.gcDanhSachPhieuDP.Name = "gcDanhSachPhieuDP";
            this.gcDanhSachPhieuDP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcDanhSachPhieuDP.Size = new System.Drawing.Size(1295, 531);
            this.gcDanhSachPhieuDP.TabIndex = 11;
            this.gcDanhSachPhieuDP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.brgMa,
            this.bgrTenTb,
            this.grcDVT,
            this.bgrNoiSX,
            this.bgrKoSD,
            this.bgcGhiChu});
            this.gridView1.GridControl = this.gcDanhSachPhieuDP;
            this.gridView1.Name = "gridView1";
            // 
            // brgMa
            // 
            this.brgMa.AppearanceHeader.Options.UseTextOptions = true;
            this.brgMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brgMa.Caption = "Mã";
            this.brgMa.FieldName = "Id";
            this.brgMa.Name = "brgMa";
            this.brgMa.Visible = true;
            this.brgMa.VisibleIndex = 0;
            this.brgMa.Width = 100;
            // 
            // bgrTenTb
            // 
            this.bgrTenTb.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrTenTb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrTenTb.Caption = "Tên thiết bị";
            this.bgrTenTb.FieldName = "TenTB";
            this.bgrTenTb.Name = "bgrTenTb";
            this.bgrTenTb.Visible = true;
            this.bgrTenTb.VisibleIndex = 1;
            this.bgrTenTb.Width = 223;
            // 
            // grcDVT
            // 
            this.grcDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDVT.Caption = "ĐVT";
            this.grcDVT.FieldName = "DVT";
            this.grcDVT.Name = "grcDVT";
            this.grcDVT.Visible = true;
            this.grcDVT.VisibleIndex = 2;
            this.grcDVT.Width = 223;
            // 
            // bgrNoiSX
            // 
            this.bgrNoiSX.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrNoiSX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrNoiSX.Caption = "Nói sản xuất";
            this.bgrNoiSX.FieldName = "NoiSX";
            this.bgrNoiSX.Name = "bgrNoiSX";
            this.bgrNoiSX.Visible = true;
            this.bgrNoiSX.VisibleIndex = 3;
            this.bgrNoiSX.Width = 223;
            // 
            // bgrKoSD
            // 
            this.bgrKoSD.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrKoSD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrKoSD.Caption = "Không sử dung";
            this.bgrKoSD.ColumnEdit = this.repositoryItemCheckEdit1;
            this.bgrKoSD.Name = "bgrKoSD";
            this.bgrKoSD.Visible = true;
            this.bgrKoSD.VisibleIndex = 4;
            this.bgrKoSD.Width = 223;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // bgcGhiChu
            // 
            this.bgcGhiChu.Caption = "Ghi chú";
            this.bgcGhiChu.FieldName = "GhiChu";
            this.bgcGhiChu.Name = "bgcGhiChu";
            this.bgcGhiChu.Visible = true;
            this.bgcGhiChu.VisibleIndex = 5;
            this.bgcGhiChu.Width = 233;
            // 
            // ThietBiTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 725);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDanhSachPhieuDP);
            this.Name = "ThietBiTienNghi";
            this.Text = "ThietBiTienNghi";
            this.Load += new System.EventHandler(this.ThietBiTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhieuDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhieuDP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn brgMa;
        private DevExpress.XtraGrid.Columns.GridColumn bgrTenTb;
        private DevExpress.XtraGrid.Columns.GridColumn grcDVT;
        private DevExpress.XtraGrid.Columns.GridColumn bgrNoiSX;
        private DevExpress.XtraGrid.Columns.GridColumn bgrKoSD;
        private DevExpress.XtraGrid.Columns.GridColumn bgcGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}