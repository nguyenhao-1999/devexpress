namespace devexpress.View
{
    partial class PhieuTraHang
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.edtHan = new DevExpress.XtraEditors.TextEdit();
            this.edtTen = new DevExpress.XtraEditors.TextEdit();
            this.cbxNhan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.edtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.edtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.dateNhap = new DevExpress.XtraEditors.DateEdit();
            this.edtSoCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 126);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1274, 578);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcSTT,
            this.grcMa,
            this.grcTenHangHoa,
            this.grcDVT,
            this.grcSoLuong,
            this.grcDonGia,
            this.grcThanhtien,
            this.grcGhiChu});
            this.gridView1.GridControl = this.gridControl1;
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
            this.grcSTT.Width = 40;
            // 
            // grcMa
            // 
            this.grcMa.AppearanceHeader.Options.UseTextOptions = true;
            this.grcMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcMa.Caption = "Mã";
            this.grcMa.Name = "grcMa";
            this.grcMa.Visible = true;
            this.grcMa.VisibleIndex = 1;
            this.grcMa.Width = 80;
            // 
            // grcTenHangHoa
            // 
            this.grcTenHangHoa.AppearanceHeader.Options.UseTextOptions = true;
            this.grcTenHangHoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcTenHangHoa.Caption = "Tên hàng hóa";
            this.grcTenHangHoa.Name = "grcTenHangHoa";
            this.grcTenHangHoa.Visible = true;
            this.grcTenHangHoa.VisibleIndex = 2;
            this.grcTenHangHoa.Width = 134;
            // 
            // grcDVT
            // 
            this.grcDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDVT.Caption = "ĐVT";
            this.grcDVT.Name = "grcDVT";
            this.grcDVT.Visible = true;
            this.grcDVT.VisibleIndex = 3;
            this.grcDVT.Width = 134;
            // 
            // grcSoLuong
            // 
            this.grcSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.grcSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcSoLuong.Caption = "Số lượng";
            this.grcSoLuong.Name = "grcSoLuong";
            this.grcSoLuong.Visible = true;
            this.grcSoLuong.VisibleIndex = 4;
            this.grcSoLuong.Width = 134;
            // 
            // grcDonGia
            // 
            this.grcDonGia.AppearanceHeader.Options.UseTextOptions = true;
            this.grcDonGia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcDonGia.Caption = "Đơn giá vốn";
            this.grcDonGia.Name = "grcDonGia";
            this.grcDonGia.Visible = true;
            this.grcDonGia.VisibleIndex = 5;
            this.grcDonGia.Width = 134;
            // 
            // grcThanhtien
            // 
            this.grcThanhtien.AppearanceHeader.Options.UseTextOptions = true;
            this.grcThanhtien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcThanhtien.Caption = "Thành tiền";
            this.grcThanhtien.Name = "grcThanhtien";
            this.grcThanhtien.Visible = true;
            this.grcThanhtien.VisibleIndex = 6;
            this.grcThanhtien.Width = 134;
            // 
            // grcGhiChu
            // 
            this.grcGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.grcGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grcGhiChu.Caption = "Ghi chú";
            this.grcGhiChu.Name = "grcGhiChu";
            this.grcGhiChu.Visible = true;
            this.grcGhiChu.VisibleIndex = 7;
            this.grcGhiChu.Width = 143;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.edtHan);
            this.panelControl1.Controls.Add(this.edtTen);
            this.panelControl1.Controls.Add(this.cbxNhan);
            this.panelControl1.Controls.Add(this.edtNhanVien);
            this.panelControl1.Controls.Add(this.edtNoiDung);
            this.panelControl1.Controls.Add(this.dateNhap);
            this.panelControl1.Controls.Add(this.edtSoCT);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1274, 125);
            this.panelControl1.TabIndex = 2;
            // 
            // edtHan
            // 
            this.edtHan.Location = new System.Drawing.Point(432, 76);
            this.edtHan.Name = "edtHan";
            this.edtHan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtHan.Properties.Appearance.Options.UseFont = true;
            this.edtHan.Size = new System.Drawing.Size(189, 28);
            this.edtHan.TabIndex = 8;
            // 
            // edtTen
            // 
            this.edtTen.Location = new System.Drawing.Point(388, 42);
            this.edtTen.Name = "edtTen";
            this.edtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtTen.Properties.Appearance.Options.UseFont = true;
            this.edtTen.Size = new System.Drawing.Size(189, 28);
            this.edtTen.TabIndex = 11;
            // 
            // cbxNhan
            // 
            this.cbxNhan.Location = new System.Drawing.Point(388, 5);
            this.cbxNhan.Name = "cbxNhan";
            this.cbxNhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbxNhan.Properties.Appearance.Options.UseFont = true;
            this.cbxNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNhan.Size = new System.Drawing.Size(165, 28);
            this.cbxNhan.TabIndex = 10;
            // 
            // edtNhanVien
            // 
            this.edtNhanVien.Location = new System.Drawing.Point(111, 65);
            this.edtNhanVien.Name = "edtNhanVien";
            this.edtNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtNhanVien.Properties.Appearance.Options.UseFont = true;
            this.edtNhanVien.Size = new System.Drawing.Size(189, 28);
            this.edtNhanVien.TabIndex = 8;
            // 
            // edtNoiDung
            // 
            this.edtNoiDung.Location = new System.Drawing.Point(111, 96);
            this.edtNoiDung.Name = "edtNoiDung";
            this.edtNoiDung.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtNoiDung.Properties.Appearance.Options.UseFont = true;
            this.edtNoiDung.Size = new System.Drawing.Size(189, 28);
            this.edtNoiDung.TabIndex = 9;
            // 
            // dateNhap
            // 
            this.dateNhap.EditValue = null;
            this.dateNhap.Location = new System.Drawing.Point(111, 35);
            this.dateNhap.Name = "dateNhap";
            this.dateNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateNhap.Properties.Appearance.Options.UseFont = true;
            this.dateNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNhap.Size = new System.Drawing.Size(189, 28);
            this.dateNhap.TabIndex = 8;
            // 
            // edtSoCT
            // 
            this.edtSoCT.Location = new System.Drawing.Point(111, 5);
            this.edtSoCT.Name = "edtSoCT";
            this.edtSoCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.edtSoCT.Properties.Appearance.Options.UseFont = true;
            this.edtSoCT.Size = new System.Drawing.Size(189, 28);
            this.edtSoCT.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(306, 45);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 21);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Họ tên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(306, 72);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(120, 21);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Hạn thanh toán:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(307, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 21);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Nhận của:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nội dung:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày nhập:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhân viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số chứng từ:";
            // 
            // PhieuTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 730);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "PhieuTraHang";
            this.Text = "Phiếu trả hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSoCT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn grcMa;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn grcDVT;
        private DevExpress.XtraGrid.Columns.GridColumn grcSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn grcThanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn grcGhiChu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit edtHan;
        private DevExpress.XtraEditors.TextEdit edtTen;
        private DevExpress.XtraEditors.ComboBoxEdit cbxNhan;
        private DevExpress.XtraEditors.TextEdit edtNhanVien;
        private DevExpress.XtraEditors.TextEdit edtNoiDung;
        private DevExpress.XtraEditors.DateEdit dateNhap;
        private DevExpress.XtraEditors.TextEdit edtSoCT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}