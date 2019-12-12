namespace devexpress.View
{
    partial class HieuQuaKhaiThacPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HieuQuaKhaiThacPhong));
            this.gcHieuQuaKhaiThacPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSoTienNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSoTienNgayLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCongSuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTongLuotPhhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCongSuatLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcHieuQuaKhaiThacPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcHieuQuaKhaiThacPhong
            // 
            this.gcHieuQuaKhaiThacPhong.Location = new System.Drawing.Point(2, 50);
            this.gcHieuQuaKhaiThacPhong.MainView = this.gridView1;
            this.gcHieuQuaKhaiThacPhong.Name = "gcHieuQuaKhaiThacPhong";
            this.gcHieuQuaKhaiThacPhong.Size = new System.Drawing.Size(1295, 646);
            this.gcHieuQuaKhaiThacPhong.TabIndex = 10;
            this.gcHieuQuaKhaiThacPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcSTT,
            this.grcNgay,
            this.grcSoPhong,
            this.grcSoTienNgay,
            this.grcSoTienNgayLT,
            this.grcCongSuat,
            this.grcTongLuotPhhong,
            this.grcCongSuatLT});
            this.gridView1.GridControl = this.gcHieuQuaKhaiThacPhong;
            this.gridView1.Name = "gridView1";
            // 
            // grcSTT
            // 
            this.grcSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSTT.Caption = "STT";
            this.grcSTT.Name = "grcSTT";
            this.grcSTT.Visible = true;
            this.grcSTT.VisibleIndex = 0;
            // 
            // grcNgay
            // 
            this.grcNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.grcNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcNgay.Caption = "Ngày";
            this.grcNgay.Name = "grcNgay";
            this.grcNgay.Visible = true;
            this.grcNgay.VisibleIndex = 1;
            // 
            // grcSoPhong
            // 
            this.grcSoPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSoPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSoPhong.Caption = "Số phòng";
            this.grcSoPhong.Name = "grcSoPhong";
            this.grcSoPhong.Visible = true;
            this.grcSoPhong.VisibleIndex = 2;
            // 
            // grcSoTienNgay
            // 
            this.grcSoTienNgay.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSoTienNgay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSoTienNgay.Caption = "Số tiền ngày";
            this.grcSoTienNgay.Name = "grcSoTienNgay";
            this.grcSoTienNgay.Visible = true;
            this.grcSoTienNgay.VisibleIndex = 3;
            // 
            // grcSoTienNgayLT
            // 
            this.grcSoTienNgayLT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSoTienNgayLT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSoTienNgayLT.Caption = "Số tiền ngày lũy tiến";
            this.grcSoTienNgayLT.Name = "grcSoTienNgayLT";
            this.grcSoTienNgayLT.Visible = true;
            this.grcSoTienNgayLT.VisibleIndex = 4;
            // 
            // grcCongSuat
            // 
            this.grcCongSuat.AppearanceHeader.Options.UseTextOptions = true;
            this.grcCongSuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcCongSuat.Caption = "Công suất ngày";
            this.grcCongSuat.Name = "grcCongSuat";
            this.grcCongSuat.Visible = true;
            this.grcCongSuat.VisibleIndex = 5;
            // 
            // grcTongLuotPhhong
            // 
            this.grcTongLuotPhhong.AppearanceHeader.Options.UseTextOptions = true;
            this.grcTongLuotPhhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcTongLuotPhhong.Caption = "Tổng số lượt phòng";
            this.grcTongLuotPhhong.Name = "grcTongLuotPhhong";
            this.grcTongLuotPhhong.Visible = true;
            this.grcTongLuotPhhong.VisibleIndex = 6;
            // 
            // grcCongSuatLT
            // 
            this.grcCongSuatLT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcCongSuatLT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcCongSuatLT.Caption = "Công suất lũy tiến";
            this.grcCongSuatLT.Name = "grcCongSuatLT";
            this.grcCongSuatLT.Visible = true;
            this.grcCongSuatLT.VisibleIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 9;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(81, 0);
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
            // HieuQuaKhaiThacPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 751);
            this.Controls.Add(this.gcHieuQuaKhaiThacPhong);
            this.Controls.Add(this.panelControl1);
            this.Name = "HieuQuaKhaiThacPhong";
            this.Text = "Hiệu quả khai thác phòng";
            ((System.ComponentModel.ISupportInitialize)(this.gcHieuQuaKhaiThacPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcHieuQuaKhaiThacPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn grcNgay;
        private DevExpress.XtraGrid.Columns.GridColumn grcSoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcSoTienNgay;
        private DevExpress.XtraGrid.Columns.GridColumn grcSoTienNgayLT;
        private DevExpress.XtraGrid.Columns.GridColumn grcCongSuat;
        private DevExpress.XtraGrid.Columns.GridColumn grcTongLuotPhhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcCongSuatLT;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
    }
}