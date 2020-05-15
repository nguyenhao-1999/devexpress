namespace devexpress.View
{
    partial class ChonDV
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgLoc = new DevExpress.XtraEditors.RadioGroup();
            this.txtLoc = new DevExpress.XtraEditors.TextEdit();
            this.gcDichvu = new DevExpress.XtraGrid.GridControl();
            this.gvDichvu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSoluong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lọc theo";
            // 
            // rgLoc
            // 
            this.rgLoc.Location = new System.Drawing.Point(72, 6);
            this.rgLoc.Name = "rgLoc";
            this.rgLoc.Properties.Columns = 2;
            this.rgLoc.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mã")});
            this.rgLoc.Size = new System.Drawing.Size(118, 29);
            this.rgLoc.TabIndex = 1;
            // 
            // txtLoc
            // 
            this.txtLoc.EditValue = "Nhập tên (mã) để lọc dữ liệu";
            this.txtLoc.Location = new System.Drawing.Point(196, 12);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(385, 22);
            this.txtLoc.TabIndex = 2;
            this.txtLoc.Enter += new System.EventHandler(this.txtLoc_Enter);
            this.txtLoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoc_KeyUp);
            this.txtLoc.Leave += new System.EventHandler(this.txtLoc_Leave);
            // 
            // gcDichvu
            // 
            this.gcDichvu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDichvu.Location = new System.Drawing.Point(1, 37);
            this.gcDichvu.MainView = this.gvDichvu;
            this.gcDichvu.Name = "gcDichvu";
            this.gcDichvu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.spSoluong});
            this.gcDichvu.Size = new System.Drawing.Size(592, 343);
            this.gcDichvu.TabIndex = 3;
            this.gcDichvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDichvu});
            // 
            // gvDichvu
            // 
            this.gvDichvu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colName,
            this.colDVT,
            this.colDongia,
            this.colSL,
            this.colId,
            this.colSoluong});
            this.gvDichvu.GridControl = this.gcDichvu;
            this.gvDichvu.Name = "gvDichvu";
            this.gvDichvu.OptionsSelection.MultiSelect = true;
            this.gvDichvu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDichvu.OptionsView.ShowGroupPanel = false;
            // 
            // colMa
            // 
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "MaDV";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.AllowEdit = false;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.Caption = "Tên dịch vụ";
            this.colName.FieldName = "TenDV";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "ĐVT";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 3;
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.DisplayFormat.FormatString = "### ### ###";
            this.colDongia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDongia.FieldName = "GiaBinhQuan";
            this.colDongia.Name = "colDongia";
            this.colDongia.OptionsColumn.AllowEdit = false;
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 4;
            // 
            // colSL
            // 
            this.colSL.Caption = "Số lượng";
            this.colSL.ColumnEdit = this.spSoluong;
            this.colSL.FieldName = "SoLuong";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 5;
            // 
            // spSoluong
            // 
            this.spSoluong.AutoHeight = false;
            this.spSoluong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSoluong.Name = "spSoluong";
            this.spSoluong.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spSoluong_EditValueChanging);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Tồn kho";
            this.colSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoluong.FieldName = "Note";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.OptionsColumn.AllowEdit = false;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::devexpress.Properties.Resources._3floppy_unmount18;
            this.btnLuu.Location = new System.Drawing.Point(505, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ChonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 421);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gcDichvu);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.rgLoc);
            this.Controls.Add(this.labelControl1);
            this.Name = "ChonDV";
            this.Text = "Chọn dịch vụ";
            this.Load += new System.EventHandler(this.ChonDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rgLoc;
        private DevExpress.XtraEditors.TextEdit txtLoc;
        private DevExpress.XtraGrid.GridControl gcDichvu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDichvu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
    }
}