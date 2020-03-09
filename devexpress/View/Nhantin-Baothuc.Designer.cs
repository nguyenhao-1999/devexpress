namespace devexpress.View
{
    partial class Nhantin_Baothuc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhantin_Baothuc));
            this.gcThongbaoBT = new DevExpress.XtraGrid.GridControl();
            this.gvThongbaoBT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTat = new DevExpress.XtraEditors.SimpleButton();
            this.ptbClock = new DevExpress.XtraEditors.PictureEdit();
            this.tmClock = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongbaoBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongbaoBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcThongbaoBT
            // 
            this.gcThongbaoBT.Location = new System.Drawing.Point(1, -2);
            this.gcThongbaoBT.MainView = this.gvThongbaoBT;
            this.gcThongbaoBT.Name = "gcThongbaoBT";
            this.gcThongbaoBT.Size = new System.Drawing.Size(445, 210);
            this.gcThongbaoBT.TabIndex = 0;
            this.gcThongbaoBT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThongbaoBT});
            // 
            // gvThongbaoBT
            // 
            this.gvThongbaoBT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhong,
            this.colGio,
            this.colNoidung,
            this.colNgay});
            this.gvThongbaoBT.GridControl = this.gcThongbaoBT;
            this.gvThongbaoBT.Name = "gvThongbaoBT";
            this.gvThongbaoBT.OptionsView.ShowGroupPanel = false;
            // 
            // colPhong
            // 
            this.colPhong.Caption = "Phòng";
            this.colPhong.FieldName = "IdPhong";
            this.colPhong.Name = "colPhong";
            this.colPhong.Visible = true;
            this.colPhong.VisibleIndex = 0;
            // 
            // colGio
            // 
            this.colGio.Caption = "Giờ";
            this.colGio.DisplayFormat.FormatString = "t";
            this.colGio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGio.FieldName = "Gio";
            this.colGio.Name = "colGio";
            this.colGio.Visible = true;
            this.colGio.VisibleIndex = 2;
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nội dung";
            this.colNoidung.FieldName = "NoiDung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 3;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            // 
            // btnTat
            // 
            this.btnTat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTat.ImageOptions.Image")));
            this.btnTat.Location = new System.Drawing.Point(481, 185);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(75, 23);
            this.btnTat.TabIndex = 1;
            this.btnTat.Text = "Tắt";
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // ptbClock
            // 
            this.ptbClock.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbClock.EditValue = global::devexpress.Properties.Resources.alarm_clock_icon;
            this.ptbClock.Location = new System.Drawing.Point(0, 0);
            this.ptbClock.Name = "ptbClock";
            this.ptbClock.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbClock.Properties.ZoomAccelerationFactor = 1D;
            this.ptbClock.Size = new System.Drawing.Size(126, 142);
            this.ptbClock.TabIndex = 0;
            // 
            // tmClock
            // 
            this.tmClock.Interval = 500;
            this.tmClock.Tick += new System.EventHandler(this.tmClock_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ptbClock);
            this.panelControl1.Location = new System.Drawing.Point(453, -2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(126, 142);
            this.panelControl1.TabIndex = 3;
            // 
            // Nhantin_Baothuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 220);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnTat);
            this.Controls.Add(this.gcThongbaoBT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nhantin_Baothuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhantin_Baothuc";
            this.Load += new System.EventHandler(this.Nhantin_Baothuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongbaoBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongbaoBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvThongbaoBT;
        private DevExpress.XtraEditors.SimpleButton btnTat;
        private DevExpress.XtraGrid.Columns.GridColumn colPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGio;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        public DevExpress.XtraGrid.GridControl gcThongbaoBT;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraEditors.PictureEdit ptbClock;
        private System.Windows.Forms.Timer tmClock;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}