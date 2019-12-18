namespace devexpress.View
{
    partial class Danhsachnhomphong
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
            this.gcNhomphong = new DevExpress.XtraGrid.GridControl();
            this.gvNhomphong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVitri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.skColor = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoqua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemnhom = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.txtVitri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cpeMau = new DevExpress.XtraEditors.ColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVitri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeMau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcNhomphong
            // 
            this.gcNhomphong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhomphong.Location = new System.Drawing.Point(0, 0);
            this.gcNhomphong.MainView = this.gvNhomphong;
            this.gcNhomphong.Name = "gcNhomphong";
            this.gcNhomphong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.skColor});
            this.gcNhomphong.Size = new System.Drawing.Size(589, 274);
            this.gcNhomphong.TabIndex = 0;
            this.gcNhomphong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomphong});
            // 
            // gvNhomphong
            // 
            this.gvNhomphong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colVitri,
            this.colMau});
            this.gvNhomphong.GridControl = this.gcNhomphong;
            this.gvNhomphong.Name = "gvNhomphong";
            this.gvNhomphong.OptionsView.ShowGroupPanel = false;
            this.gvNhomphong.OptionsView.ShowIndicator = false;
            this.gvNhomphong.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvNhomphong_CustomRowCellEdit);
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Manhom";
            this.colMa.Name = "colMa";
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            this.colMa.Width = 129;
            // 
            // colVitri
            // 
            this.colVitri.Caption = "Vị trí";
            this.colVitri.FieldName = "Vitri";
            this.colVitri.Name = "colVitri";
            this.colVitri.Visible = true;
            this.colVitri.VisibleIndex = 1;
            this.colVitri.Width = 424;
            // 
            // colMau
            // 
            this.colMau.Caption = "Màu";
            this.colMau.ColumnEdit = this.skColor;
            this.colMau.FieldName = "Mamau";
            this.colMau.Name = "colMau";
            this.colMau.Visible = true;
            this.colMau.VisibleIndex = 2;
            this.colMau.Width = 140;
            // 
            // skColor
            // 
            this.skColor.AutoHeight = false;
            this.skColor.AutomaticColor = System.Drawing.Color.Black;
            this.skColor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.skColor.Name = "skColor";
            this.skColor.StoreColorAsInteger = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnBoqua);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnThemnhom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 379);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(589, 29);
            this.panelControl1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(481, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(388, 1);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(87, 23);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(295, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(202, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(109, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemnhom
            // 
            this.btnThemnhom.Location = new System.Drawing.Point(16, 1);
            this.btnThemnhom.Name = "btnThemnhom";
            this.btnThemnhom.Size = new System.Drawing.Size(87, 23);
            this.btnThemnhom.TabIndex = 0;
            this.btnThemnhom.Text = "Thêm nhóm";
            this.btnThemnhom.Click += new System.EventHandler(this.btnThemnhom_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 291);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(49, 286);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 3;
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(49, 314);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(100, 22);
            this.txtVitri.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 319);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Vị trí";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 347);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Màu";
            // 
            // cpeMau
            // 
            this.cpeMau.EditValue = System.Drawing.Color.Empty;
            this.cpeMau.Location = new System.Drawing.Point(49, 342);
            this.cpeMau.Name = "cpeMau";
            this.cpeMau.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeMau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeMau.Size = new System.Drawing.Size(236, 22);
            this.cpeMau.TabIndex = 7;
            this.cpeMau.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.cpeMau_CustomDisplayText);
            // 
            // Danhsachnhomphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 408);
            this.Controls.Add(this.cpeMau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcNhomphong);
            this.Name = "Danhsachnhomphong";
            this.Text = "Danhsachnhomphong";
            this.Load += new System.EventHandler(this.Danhsachnhomphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhomphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVitri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeMau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcNhomphong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomphong;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colVitri;
        private DevExpress.XtraGrid.Columns.GridColumn colMau;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit skColor;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnBoqua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemnhom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.TextEdit txtVitri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ColorPickEdit cpeMau;
    }
}