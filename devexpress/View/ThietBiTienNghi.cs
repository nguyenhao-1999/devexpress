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
    public partial class ThietBiTienNghi : Form
    {
        public ThietBiTienNghi()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        int otp = 0;
        private void ThietBiTienNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.ThietBi' table. You can move, or remove it, as needed.
            this.thietBiTableAdapter.Fill(this.qLKhachSanDataSet.ThietBi);
            var list = db.ThietBi.ToList();
            gcThietBi.DataSource = list;
        }

        private void gvThietBi_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
         
            if (e.RowHandle == gvThietBi.FocusedRowHandle)
            {
                txtSTT.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "Id").ToString().Trim();
                txtMa.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "MaTB").ToString().Trim();
                txtTen.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "TenTB").ToString().Trim();
                txtDVT.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "DVT").ToString().Trim();
                txtNoiSX.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "NoiSX").ToString().Trim();
                txtGhiChu.EditValue = gvThietBi.GetRowCellValue(e.RowHandle, "GhiChu").ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            int k = 0;
            for (int i = 0; i < gvThietBi.RowCount; i++)
            {
                if (Convert.ToInt32(gvThietBi.GetRowCellValue(i, "Id")) > k)
                    k = Convert.ToInt32(gvThietBi.GetRowCellValue(i, "Id"));
            }
            k = k + 1;
            txtSTT.Text = k.ToString();
            enableEditing(true);
            reset();
            txtMa.Focus();
            txtMaNhom.Focus();
            txtTen.Focus();
            txtDVT.Focus();
            txtNoiSX.Focus();
            txtGhiChu.Focus();
            
            otp = 1;
        }
        public void enableEditing(bool editing)
        {
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnBoqua.Enabled = editing;
            gcThietBi.Enabled = !editing;
            txtSTT.ReadOnly = !editing;
            txtMa.ReadOnly = !editing;
            txtMaNhom.ReadOnly = !editing;
            txtTen.ReadOnly = !editing;
            txtDVT.ReadOnly = !editing;
            txtNoiSX.ReadOnly = !editing;
            txtGhiChu.ReadOnly = !editing;
        }
        public void reset()
        {
            txtMa.Text = null;
            txtMaNhom.Text = null;
            txtTen.Text = null;
            txtDVT.Text = null;
            txtNoiSX.Text = null;
            txtGhiChu.Text = null;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông báo Undo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                enableEditing(false);
                otp = 0;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.Id = Convert.ToInt32(txtSTT.Text.ToString().Trim());
            tb.MaTB = txtMa.Text.ToString().Trim();
            tb.MaNhom = txtMa.Text.ToString().Trim();
            tb.TenTB = txtTen.Text.ToString().Trim();
            tb.NoiSX = txtNoiSX.Text.ToString().Trim();
            tb.DVT = txtDVT.Text.ToString().Trim();
            tb.GhiChu = txtGhiChu.Text.ToString().Trim();
            if (otp == 1)
            {
                ThietBiTienNghiBUS.Instance.NewThietBiTienNghi(tb);
                ThietBiTienNghiBUS.Instance.Xem(gcThietBi);
                MessageBox.Show("Thêm thành công!");
                otp = 0;
            }
            else
            {
                ThietBiTienNghiBUS.Instance.EditThietBiTienNghi(tb);
                ThietBiTienNghiBUS.Instance.Xem(gcThietBi);
                MessageBox.Show("Sửa thành công!");
            }
            enableEditing(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Convert.ToInt32(gvThietBi.GetRowCellValue(gvThietBi.FocusedRowHandle, "Id"));
                ThietBiTienNghiBUS.Instance.DelThietBiTienNghi(id);
                ThietBiTienNghiBUS.Instance.Xem(gcThietBi);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableEditing(true);
            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDVT.ReadOnly = false;
            txtNoiSX.ReadOnly=false;
            txtGhiChu.ReadOnly=false;
        }
    }
}
