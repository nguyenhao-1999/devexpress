namespace devexpress.View
{
    partial class DoanhThuTongHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThuTongHop));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachPhieuDP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bgrTang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgTienPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgrNhaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgrTong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgDaThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brgConLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhieuDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnInPhieu);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(3, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 12;
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnInPhieu.Appearance.Options.UseFont = true;
            this.btnInPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.ImageOptions.Image")));
            this.btnInPhieu.Location = new System.Drawing.Point(81, 0);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(85, 40);
            this.btnInPhieu.TabIndex = 1;
            this.btnInPhieu.Text = "In phiếu";
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
            this.gcDanhSachPhieuDP.Location = new System.Drawing.Point(3, 62);
            this.gcDanhSachPhieuDP.MainView = this.gridView1;
            this.gcDanhSachPhieuDP.Name = "gcDanhSachPhieuDP";
            this.gcDanhSachPhieuDP.Size = new System.Drawing.Size(1295, 672);
            this.gcDanhSachPhieuDP.TabIndex = 11;
            this.gcDanhSachPhieuDP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bgrTang,
            this.brgTienPhong,
            this.DichVu,
            this.grDienThoai,
            this.bgrNhaHang,
            this.bgrTong,
            this.brgDaThu,
            this.brgConLai});
            this.gridView1.GridControl = this.gcDanhSachPhieuDP;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // bgrTang
            // 
            this.bgrTang.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrTang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrTang.Caption = "Tầng/Phòng";
            this.bgrTang.Name = "bgrTang";
            this.bgrTang.Visible = true;
            this.bgrTang.VisibleIndex = 0;
            // 
            // brgTienPhong
            // 
            this.brgTienPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.brgTienPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brgTienPhong.Caption = "Tiền phòng";
            this.brgTienPhong.Name = "brgTienPhong";
            this.brgTienPhong.Visible = true;
            this.brgTienPhong.VisibleIndex = 1;
            // 
            // DichVu
            // 
            this.DichVu.AppearanceHeader.Options.UseTextOptions = true;
            this.DichVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DichVu.Caption = "Dịch vụ";
            this.DichVu.Name = "DichVu";
            this.DichVu.Visible = true;
            this.DichVu.VisibleIndex = 2;
            // 
            // grDienThoai
            // 
            this.grDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.grDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grDienThoai.Caption = "Điện thoại";
            this.grDienThoai.Name = "grDienThoai";
            this.grDienThoai.Visible = true;
            this.grDienThoai.VisibleIndex = 3;
            // 
            // bgrNhaHang
            // 
            this.bgrNhaHang.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrNhaHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrNhaHang.Caption = "Nhà Hàng";
            this.bgrNhaHang.Name = "bgrNhaHang";
            this.bgrNhaHang.Visible = true;
            this.bgrNhaHang.VisibleIndex = 4;
            // 
            // bgrTong
            // 
            this.bgrTong.AppearanceHeader.Options.UseTextOptions = true;
            this.bgrTong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgrTong.Caption = "Tổng";
            this.bgrTong.Name = "bgrTong";
            this.bgrTong.Visible = true;
            this.bgrTong.VisibleIndex = 5;
            // 
            // brgDaThu
            // 
            this.brgDaThu.Caption = "Đã thu";
            this.brgDaThu.Name = "brgDaThu";
            this.brgDaThu.Visible = true;
            this.brgDaThu.VisibleIndex = 6;
            // 
            // brgConLai
            // 
            this.brgConLai.Caption = "Còn lại";
            this.brgConLai.Name = "brgConLai";
            this.brgConLai.Visible = true;
            this.brgConLai.VisibleIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(605, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "In phiếu";
            // 
            // DoanhThuTongHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 727);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcDanhSachPhieuDP);
            this.Name = "DoanhThuTongHop";
            this.Text = "Doanh thu tổng hợp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhieuDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhieuDP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn bgrTang;
        private DevExpress.XtraGrid.Columns.GridColumn brgTienPhong;
        private DevExpress.XtraGrid.Columns.GridColumn DichVu;
        private DevExpress.XtraGrid.Columns.GridColumn grDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn bgrNhaHang;
        private DevExpress.XtraGrid.Columns.GridColumn bgrTong;
        private DevExpress.XtraGrid.Columns.GridColumn brgDaThu;
        private DevExpress.XtraGrid.Columns.GridColumn brgConLai;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}