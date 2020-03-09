namespace devexpress.View
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.qLKhachSan2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSan2DataSet = new devexpress.QLKhachSan2DataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMucLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qLKhachSan1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSan1DataSet = new devexpress.QLKhachSan1DataSet();
            this.qLKhachSan1DataSet1 = new devexpress.QLKhachSan1DataSet1();
            this.qLKhachSan1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNV
            // 
            this.btnThemNV.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemNV.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThemNV.Appearance.Options.UseBackColor = true;
            this.btnThemNV.Appearance.Options.UseFont = true;
            this.btnThemNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(0, 0);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(83, 36);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.Text = "Thêm NV";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(91, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnThemNV);
            this.panelControl1.Location = new System.Drawing.Point(1, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1904, 40);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(228, 1);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(162, 1);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.qLKhachSan2DataSetBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1542, 595);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qLKhachSan2DataSetBindingSource
            // 
            this.qLKhachSan2DataSetBindingSource.DataSource = this.qLKhachSan2DataSet;
            this.qLKhachSan2DataSetBindingSource.Position = 0;
            // 
            // qLKhachSan2DataSet
            // 
            this.qLKhachSan2DataSet.DataSetName = "QLKhachSan2DataSet";
            this.qLKhachSan2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.Silver;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.HeaderPanel.Image = ((System.Drawing.Image)(resources.GetObject("gridView1.Appearance.HeaderPanel.Image")));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseImage = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.colMaNV,
            this.colHoten,
            this.colNgaySinh,
            this.colSOCMND,
            this.colDiaChi,
            this.colSDT,
            this.colMail,
            this.colTaiKhoan,
            this.colNganHang,
            this.colAccount,
            this.colPassword,
            this.colMucLuong,
            this.colLoai,
            this.colNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // clSTT
            // 
            this.clSTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.clSTT.AppearanceCell.Options.UseFont = true;
            this.clSTT.AppearanceCell.Options.UseTextOptions = true;
            this.clSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceCell.Options.UseTextOptions = true;
            this.colMaNV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 1;
            // 
            // colHoten
            // 
            this.colHoten.AppearanceCell.Options.UseTextOptions = true;
            this.colHoten.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHoten.Caption = "Họ tên";
            this.colHoten.Name = "colHoten";
            this.colHoten.Visible = true;
            this.colHoten.VisibleIndex = 2;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.AppearanceCell.Options.UseTextOptions = true;
            this.colNgaySinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgaySinh.Caption = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            // 
            // colSOCMND
            // 
            this.colSOCMND.AppearanceCell.Options.UseTextOptions = true;
            this.colSOCMND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOCMND.Caption = "Số CMND";
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 4;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AppearanceCell.Options.UseTextOptions = true;
            this.colDiaChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            // 
            // colSDT
            // 
            this.colSDT.AppearanceCell.Options.UseTextOptions = true;
            this.colSDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 14;
            // 
            // colMail
            // 
            this.colMail.AppearanceCell.Options.UseTextOptions = true;
            this.colMail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMail.Caption = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 6;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.AppearanceCell.Options.UseTextOptions = true;
            this.colTaiKhoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTaiKhoan.Caption = "Tài khoản";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 7;
            // 
            // colNganHang
            // 
            this.colNganHang.AppearanceCell.Options.UseTextOptions = true;
            this.colNganHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNganHang.Caption = "Ngân hàng";
            this.colNganHang.Name = "colNganHang";
            this.colNganHang.Visible = true;
            this.colNganHang.VisibleIndex = 8;
            // 
            // colAccount
            // 
            this.colAccount.AppearanceCell.Options.UseTextOptions = true;
            this.colAccount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccount.Caption = "Account";
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 9;
            // 
            // colPassword
            // 
            this.colPassword.AppearanceCell.Options.UseTextOptions = true;
            this.colPassword.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPassword.Caption = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 10;
            // 
            // colMucLuong
            // 
            this.colMucLuong.AppearanceCell.Options.UseTextOptions = true;
            this.colMucLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMucLuong.Caption = "Mức lương";
            this.colMucLuong.Name = "colMucLuong";
            this.colMucLuong.Visible = true;
            this.colMucLuong.VisibleIndex = 11;
            // 
            // colLoai
            // 
            this.colLoai.AppearanceCell.Options.UseTextOptions = true;
            this.colLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoai.Caption = "Chức vụ";
            this.colLoai.Name = "colLoai";
            this.colLoai.Visible = true;
            this.colLoai.VisibleIndex = 12;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Options.UseTextOptions = true;
            this.colNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.Caption = "Ghi chú";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 13;
            // 
            // qLKhachSan1DataSetBindingSource
            // 
            this.qLKhachSan1DataSetBindingSource.DataSource = this.qLKhachSan1DataSet;
            this.qLKhachSan1DataSetBindingSource.Position = 0;
            // 
            // qLKhachSan1DataSet
            // 
            this.qLKhachSan1DataSet.DataSetName = "QLKhachSan1DataSet";
            this.qLKhachSan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKhachSan1DataSet1
            // 
            this.qLKhachSan1DataSet1.DataSetName = "QLKhachSan1DataSet1";
            this.qLKhachSan1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKhachSan1DataSet1BindingSource
            // 
            this.qLKhachSan1DataSet1BindingSource.DataSource = this.qLKhachSan1DataSet1;
            this.qLKhachSan1DataSet1BindingSource.Position = 0;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 791);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSan1DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoten;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colMucLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private System.Windows.Forms.BindingSource qLKhachSan1DataSetBindingSource;
        private QLKhachSan1DataSet qLKhachSan1DataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private QLKhachSan1DataSet1 qLKhachSan1DataSet1;
        private System.Windows.Forms.BindingSource qLKhachSan1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource qLKhachSan2DataSetBindingSource;
        private QLKhachSan2DataSet qLKhachSan2DataSet;
    }
}