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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanTriNguoiDung));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.gcQuanTriNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanTriNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnInPhieu);
            this.panelControl1.Controls.Add(this.btnChuyen);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnDuLieu);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1295, 40);
            this.panelControl1.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(343, 0);
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
            this.btnInPhieu.Location = new System.Drawing.Point(252, 0);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(85, 40);
            this.btnInPhieu.TabIndex = 1;
            this.btnInPhieu.Text = "In phiếu";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnChuyen.Appearance.Options.UseFont = true;
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(162, 0);
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
            // gcQuanTriNguoiDung
            // 
            this.gcQuanTriNguoiDung.Location = new System.Drawing.Point(2, 37);
            this.gcQuanTriNguoiDung.MainView = this.gridView1;
            this.gcQuanTriNguoiDung.Name = "gcQuanTriNguoiDung";
            this.gcQuanTriNguoiDung.Size = new System.Drawing.Size(1295, 559);
            this.gcQuanTriNguoiDung.TabIndex = 12;
            this.gcQuanTriNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcSTT,
            this.grcMa,
            this.grcTen,
            this.grcNgaySinh,
            this.grcDiaChi,
            this.grcDienThoai,
            this.grcTaiKhoan,
            this.grcMatKhau});
            this.gridView1.GridControl = this.gcQuanTriNguoiDung;
            this.gridView1.Name = "gridView1";
            // 
            // grcSTT
            // 
            this.grcSTT.Caption = "STT";
            this.grcSTT.Name = "grcSTT";
            this.grcSTT.Visible = true;
            this.grcSTT.VisibleIndex = 0;
            this.grcSTT.Width = 50;
            // 
            // grcMa
            // 
            this.grcMa.Caption = "Mã";
            this.grcMa.Name = "grcMa";
            this.grcMa.Visible = true;
            this.grcMa.VisibleIndex = 1;
            this.grcMa.Width = 100;
            // 
            // grcTen
            // 
            this.grcTen.Caption = "Họ và tên";
            this.grcTen.Name = "grcTen";
            this.grcTen.Visible = true;
            this.grcTen.VisibleIndex = 2;
            this.grcTen.Width = 200;
            // 
            // grcNgaySinh
            // 
            this.grcNgaySinh.Caption = "Ngày sinh";
            this.grcNgaySinh.Name = "grcNgaySinh";
            this.grcNgaySinh.Visible = true;
            this.grcNgaySinh.VisibleIndex = 3;
            this.grcNgaySinh.Width = 183;
            // 
            // grcDiaChi
            // 
            this.grcDiaChi.Caption = "Địa Chỉ";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.Visible = true;
            this.grcDiaChi.VisibleIndex = 4;
            this.grcDiaChi.Width = 183;
            // 
            // grcDienThoai
            // 
            this.grcDienThoai.Caption = "Điện thoại";
            this.grcDienThoai.Name = "grcDienThoai";
            this.grcDienThoai.Visible = true;
            this.grcDienThoai.VisibleIndex = 5;
            this.grcDienThoai.Width = 183;
            // 
            // grcTaiKhoan
            // 
            this.grcTaiKhoan.Caption = "Tài khoản truy cập";
            this.grcTaiKhoan.Name = "grcTaiKhoan";
            this.grcTaiKhoan.Visible = true;
            this.grcTaiKhoan.VisibleIndex = 6;
            this.grcTaiKhoan.Width = 183;
            // 
            // grcMatKhau
            // 
            this.grcMatKhau.Caption = "Mật khẩu";
            this.grcMatKhau.Name = "grcMatKhau";
            this.grcMatKhau.Visible = true;
            this.grcMatKhau.VisibleIndex = 7;
            this.grcMatKhau.Width = 193;
            // 
            // QuanTriNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 735);
            this.Controls.Add(this.gcQuanTriNguoiDung);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "QuanTriNguoiDung";
            this.Text = "Quản trị người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanTriNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInPhieu;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private DevExpress.XtraGrid.GridControl gcQuanTriNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn grcMa;
        private DevExpress.XtraGrid.Columns.GridColumn grcTen;
        private DevExpress.XtraGrid.Columns.GridColumn grcNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn grcDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn grcDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn grcTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn grcMatKhau;
    }
}