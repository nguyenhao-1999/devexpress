using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using devexpress.Model;
using DevExpress.XtraEditors.Repository;
using devexpress.BUS;

namespace devexpress.View
{
    public partial class Danhsachnhomphong : DevExpress.XtraEditors.XtraForm
    {
        public Danhsachnhomphong()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        int otp = 0;
        private void Danhsachnhomphong_Load(object sender, EventArgs e)
        {
            DanhsachnhomphongBUS.Instance.Xem(gcNhomphong);
            enableEditing(false);
        }

        private void gvNhomphong_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            ColorPickEdit c = new ColorPickEdit();
            c.EditValue = String.Format("{0:X}", gvNhomphong.GetRowCellValue(e.RowHandle, "Mamau"));
            if (e.RowHandle == gvNhomphong.FocusedRowHandle && e.Column == colMa)
            {
                txtMa.EditValue = gvNhomphong.GetRowCellValue(e.RowHandle, "Manhom").ToString().Trim();
                txtVitri.EditValue = gvNhomphong.GetRowCellValue(e.RowHandle, "Vitri").ToString().Trim();
                cpeMau.EditValue = c.EditValue;
            }
        }

        private void cpeMau_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = String.Format("{0:X}", cpeMau.Color.ToArgb());
        }

        private void btnThemnhom_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < gvNhomphong.RowCount; i++)
            {
                if (Convert.ToInt32(gvNhomphong.GetRowCellValue(i, "Manhom")) > k)
                    k = Convert.ToInt32(gvNhomphong.GetRowCellValue(i, "Manhom"));
            }
            k = k + 1;
            txtMa.Text = k.ToString();

            enableEditing(true);
            reset();
            txtVitri.Focus();
            otp = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableEditing(true);
            txtVitri.ReadOnly = false;
            cpeMau.ReadOnly = false;
            txtVitri.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Convert.ToInt32(gvNhomphong.GetRowCellValue(gvNhomphong.FocusedRowHandle, "Manhom"));
                DanhsachnhomphongBUS.Instance.DelDanhsachnhomphong(id);
                DanhsachnhomphongBUS.Instance.Xem(gcNhomphong);
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            RoomTang room = new RoomTang();
            room.Manhom = Convert.ToInt32(txtMa.Text.ToString().Trim());
            room.Vitri = txtVitri.Text.ToString().Trim();
            room.Mamau = "#" + cpeMau.Text.ToString().Trim();
            if (otp == 1)
            {
                DanhsachnhomphongBUS.Instance.NewDanhsachnhomphong(room);
                DanhsachnhomphongBUS.Instance.Xem(gcNhomphong);
                MessageBox.Show("Thêm thành công!");
                otp = 0;
            }
            else
            {
                DanhsachnhomphongBUS.Instance.EditDanhsachnhomphong(room);
                DanhsachnhomphongBUS.Instance.Xem(gcNhomphong);
                MessageBox.Show("Sửa thành công!");
            }
            enableEditing(false);
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông báo Undo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                enableEditing(false);
                otp = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void enableEditing(bool editing)
        {
            btnThemnhom.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnBoqua.Enabled = editing;
            gcNhomphong.Enabled = !editing;
            txtMa.ReadOnly = !editing;
            txtVitri.ReadOnly = !editing;
            cpeMau.ReadOnly = !editing;

        }
        public void reset()
        {
            txtVitri.Text = null;
            cpeMau.EditValue = null;
        }
    }
}