namespace devexpress.View
{
    partial class QuanTriNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanTriNguoiDung));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoPhan = new DevExpress.XtraEditors.SimpleButton();
            this.gcQuanTriNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvQuantri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deNgaysinh = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grcCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tlBoPhan = new DevExpress.XtraTreeList.TreeList();
            this.colTenNhom = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanTriNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuantri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaysinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaysinh.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnInPhieu);
            this.panelControl1.Controls.Add(this.btnChuyen);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnBoPhan);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(178, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 40);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(449, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnInPhieu.Appearance.Options.UseFont = true;
            this.btnInPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.ImageOptions.Image")));
            this.btnInPhieu.Location = new System.Drawing.Point(358, 0);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(85, 40);
            this.btnInPhieu.TabIndex = 1;
            this.btnInPhieu.Text = "In phiếu";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnChuyen.Appearance.Options.UseFont = true;
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(268, 0);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(84, 40);
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.Text = "Chuyển";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(97, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBoPhan.Appearance.Options.UseFont = true;
            this.btnBoPhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBoPhan.ImageOptions.Image")));
            this.btnBoPhan.Location = new System.Drawing.Point(0, 0);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(91, 40);
            this.btnBoPhan.TabIndex = 0;
            this.btnBoPhan.Text = "Bộ phận";
            this.btnBoPhan.Click += new System.EventHandler(this.btnBoPhan_Click);
            // 
            // gcQuanTriNguoiDung
            // 
            this.gcQuanTriNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcQuanTriNguoiDung.Location = new System.Drawing.Point(307, 48);
            this.gcQuanTriNguoiDung.MainView = this.gvQuantri;
            this.gcQuanTriNguoiDung.Name = "gcQuanTriNguoiDung";
            this.gcQuanTriNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deNgaysinh});
            this.gcQuanTriNguoiDung.Size = new System.Drawing.Size(990, 615);
            this.gcQuanTriNguoiDung.TabIndex = 12;
            this.gcQuanTriNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuantri});
            // 
            // gvQuantri
            // 
            this.gvQuantri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcId,
            this.grcMa,
            this.grcTen,
            this.grcNgaySinh,
            this.grcCMND,
            this.grcDiaChi,
            this.grcDienThoai,
            this.grcTaiKhoan,
            this.grcMatKhau});
            this.gvQuantri.GridControl = this.gcQuanTriNguoiDung;
            this.gvQuantri.Name = "gvQuantri";
            this.gvQuantri.OptionsView.ShowGroupPanel = false;
            this.gvQuantri.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvQuantri_RowCellClick);
            this.gvQuantri.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvQuantri_CustomRowCellEdit);
            this.gvQuantri.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvQuantri_ValidatingEditor);
            // 
            // grcId
            // 
            this.grcId.Caption = "Id";
            this.grcId.FieldName = "Id";
            this.grcId.Name = "grcId";
            this.grcId.Width = 29;
            // 
            // grcMa
            // 
            this.grcMa.Caption = "Mã";
            this.grcMa.FieldName = "MaNV";
            this.grcMa.Name = "grcMa";
            this.grcMa.Visible = true;
            this.grcMa.VisibleIndex = 0;
            this.grcMa.Width = 59;
            // 
            // grcTen
            // 
            this.grcTen.Caption = "Họ và tên";
            this.grcTen.FieldName = "HoTen";
            this.grcTen.Name = "grcTen";
            this.grcTen.Visible = true;
            this.grcTen.VisibleIndex = 1;
            this.grcTen.Width = 119;
            // 
            // grcNgaySinh
            // 
            this.grcNgaySinh.Caption = "Ngày sinh";
            this.grcNgaySinh.ColumnEdit = this.deNgaysinh;
            this.grcNgaySinh.FieldName = "NgaySinh";
            this.grcNgaySinh.Name = "grcNgaySinh";
            this.grcNgaySinh.Visible = true;
            this.grcNgaySinh.VisibleIndex = 2;
            this.grcNgaySinh.Width = 84;
            // 
            // deNgaysinh
            // 
            this.deNgaysinh.AutoHeight = false;
            this.deNgaysinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaysinh.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaysinh.Name = "deNgaysinh";
            // 
            // grcCMND
            // 
            this.grcCMND.Caption = "CMND";
            this.grcCMND.FieldName = "SoCMND";
            this.grcCMND.Name = "grcCMND";
            this.grcCMND.Visible = true;
            this.grcCMND.VisibleIndex = 3;
            this.grcCMND.Width = 71;
            // 
            // grcDiaChi
            // 
            this.grcDiaChi.Caption = "Địa Chỉ";
            this.grcDiaChi.FieldName = "DiaChi";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.Visible = true;
            this.grcDiaChi.VisibleIndex = 4;
            this.grcDiaChi.Width = 134;
            // 
            // grcDienThoai
            // 
            this.grcDienThoai.Caption = "Điện thoại";
            this.grcDienThoai.FieldName = "DienThoai";
            this.grcDienThoai.Name = "grcDienThoai";
            this.grcDienThoai.Visible = true;
            this.grcDienThoai.VisibleIndex = 5;
            this.grcDienThoai.Width = 98;
            // 
            // grcTaiKhoan
            // 
            this.grcTaiKhoan.Caption = "Tài khoản truy cập";
            this.grcTaiKhoan.FieldName = "Account";
            this.grcTaiKhoan.Name = "grcTaiKhoan";
            this.grcTaiKhoan.Visible = true;
            this.grcTaiKhoan.VisibleIndex = 6;
            this.grcTaiKhoan.Width = 98;
            // 
            // grcMatKhau
            // 
            this.grcMatKhau.Caption = "Mật khẩu";
            this.grcMatKhau.FieldName = "Password";
            this.grcMatKhau.Name = "grcMatKhau";
            this.grcMatKhau.OptionsColumn.AllowEdit = false;
            this.grcMatKhau.OptionsColumn.ReadOnly = true;
            this.grcMatKhau.Visible = true;
            this.grcMatKhau.VisibleIndex = 7;
            this.grcMatKhau.Width = 115;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "package_wordprocessing.png");
            // 
            // tlBoPhan
            // 
            this.tlBoPhan.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenNhom,
            this.colId});
            this.tlBoPhan.Location = new System.Drawing.Point(2, 48);
            this.tlBoPhan.Name = "tlBoPhan";
            this.tlBoPhan.OptionsBehavior.Editable = false;
            this.tlBoPhan.OptionsView.ShowColumns = false;
            this.tlBoPhan.OptionsView.ShowHorzLines = false;
            this.tlBoPhan.OptionsView.ShowIndicator = false;
            this.tlBoPhan.Size = new System.Drawing.Size(299, 615);
            this.tlBoPhan.TabIndex = 14;
            this.tlBoPhan.CustomNodeCellEdit += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.tlBoPhan_CustomNodeCellEdit);
            this.tlBoPhan.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.tlBoPhan_CustomDrawNodeCell);
            // 
            // colTenNhom
            // 
            this.colTenNhom.Caption = "treeListColumn1";
            this.colTenNhom.FieldName = "name";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.Caption = "colId";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 20;
            // 
            // QuanTriNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 735);
            this.Controls.Add(this.tlBoPhan);
            this.Controls.Add(this.gcQuanTriNguoiDung);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "QuanTriNguoiDung";
            this.Text = "Quản trị người dùng";
            this.Load += new System.EventHandler(this.QuanTriNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanTriNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuantri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaysinh.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaysinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlBoPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnBoPhan;
        private DevExpress.XtraGrid.GridControl gcQuanTriNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn grcId;
        private DevExpress.XtraGrid.Columns.GridColumn grcMa;
        private DevExpress.XtraGrid.Columns.GridColumn grcTen;
        private DevExpress.XtraGrid.Columns.GridColumn grcNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn grcDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn grcDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn grcTaiKhoan;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn grcCMND;
        private DevExpress.XtraTreeList.TreeList tlBoPhan;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenNhom;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deNgaysinh;
        public DevExpress.XtraGrid.Views.Grid.GridView gvQuantri;
        private DevExpress.XtraGrid.Columns.GridColumn grcMatKhau;
    }
}