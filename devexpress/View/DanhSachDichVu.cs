using devexpress.BUS;
using devexpress.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devexpress.View
{
    public partial class DanhSachDichVu : Form
    {
        public DanhSachDichVu()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        int otp = 0;
        private void DichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet3.DichVu' table. You can move, or remove it, as needed.
            //this.dichVuTableAdapter.Fill(this.qLKhachSanDataSet3.DichVu);
            var list = db.DichVu.ToList();
            gcDichVu.DataSource = list;

        }

        private void gvDichVu_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle == gvDichVu.FocusedRowHandle)
            {
                txtSTT.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "Id").ToString().Trim();
                txtMaDV.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "MaDV").ToString().Trim();
                txtTenDV.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "TenDV").ToString().Trim();
                txtMaNhom.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "MaNhom").ToString().Trim();
                txtDVT.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "DVT").ToString().Trim();
                txtSoLuong.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "SoLuong").ToString().Trim();
                txtGiaTri.EditValue = gvDichVu.GetRowCellValue(e.RowHandle, "GiaNhapCuoi").ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < gvDichVu.RowCount; i++)
            {
                if (Convert.ToInt32(gvDichVu.GetRowCellValue(i, "Id")) > k)
                    k = Convert.ToInt32(gvDichVu.GetRowCellValue(i, "Id"));
            }
            k = k + 1;
            txtSTT.Text = k.ToString();
            enableEditing(true);
            reset();
            txtMaDV.Focus();
            txtMaNhom.Focus();
            txtTenDV.Focus();
            txtDVT.Focus();
            txtSoLuong.Focus();
            txtDVT.Focus();
            txtGiaTri.Focus();

            otp = 1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Model.DichVu dv = new Model.DichVu();
            dv.Id = Convert.ToInt32(txtSTT.Text.ToString().Trim());
            dv.MaDV = txtMaDV.Text.ToString().Trim();
            dv.MaNhom = txtMaNhom.Text.ToString().Trim();
            dv.TenDV = txtTenDV.Text.ToString().Trim();
            dv.GiaNhapCuoi = Convert.ToInt32(txtGiaTri.Text.ToString().Trim());
            dv.DVT = txtDVT.Text.ToString().Trim();
            dv.SoLuong = Convert.ToInt32(txtSoLuong.Text.ToString().Trim());
            if (otp == 1)
            {
                DichVuBUS.Instance.NewDichVu(dv);
                DichVuBUS.Instance.Xem(gcDichVu);
                MessageBox.Show("Thêm thành công!");
                otp = 0;
            }
            else
            {
                DichVuBUS.Instance.EditDichVu(dv);
                DichVuBUS.Instance.Xem(gcDichVu);
                MessageBox.Show("Sửa thành công!");
            }
            enableEditing(false);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            enableEditing(true);
            txtMaDV.ReadOnly = false;
            txtMaNhom.ReadOnly = false;
            txtDVT.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenDV.ReadOnly = false;
            txtGiaTri.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Convert.ToInt32(gvDichVu.GetRowCellValue(gvDichVu.FocusedRowHandle, "Id"));
                DichVuBUS.Instance.DelDichVu(id);
                DichVuBUS.Instance.Xem(gcDichVu);
                MessageBox.Show("Xóa thành công!");
            }
        }

      
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông báo Undo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                enableEditing(false);
                otp = 0;
            }
        }
        public void enableEditing(bool editing)
        {
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnBoQua.Enabled = editing;
            gcDichVu.Enabled = !editing;
            txtMaDV.ReadOnly = !editing;
            txtMaNhom.ReadOnly = !editing;
            txtTenDV.ReadOnly = !editing;
            txtDVT.ReadOnly = !editing;
            txtSoLuong.ReadOnly = !editing;
            txtGiaTri.ReadOnly = !editing;
        }
        public void reset()
        {
            txtMaDV.Text = null;
            txtMaNhom.Text = null;
            txtTenDV.Text = null;
            txtDVT.Text = null;
            txtGiaTri.Text = null;
            txtSoLuong.Text = null;
        }

       
    }
}
