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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        int otp = 0;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            var list = db.Khach.ToList();
            gcKhachHang.DataSource = list;
        }
        private void loadData()
        {
            var listQT = db.Quoctich.ToList();
            LockupEditItemQT.DataSource = listQT;
            LockupEditItemQT.DisplayMember = "TenQT";
            LockupEditItemQT.ValueMember = "Id";
            lookUpEditQuoctich.Properties.DataSource = listQT;
            lookUpEditQuoctich.Properties.DisplayMember = "TenQT";
            lookUpEditQuoctich.Properties.ValueMember = "Id";

        }

        private void gvKhach_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var list = db.Quoctich.ToList();
            if (e.RowHandle == gvKhach.FocusedRowHandle)
            {
                txtSTT.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "Id").ToString().Trim();
                txtSoCMND.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "SoCMND").ToString().Trim();
                txtHoTen.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "HoTen").ToString().Trim();
                txtEmail.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "Email").ToString().Trim();
                txtSDT.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "Phone").ToString().Trim();
                txtDiaChi.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "DiaChi").ToString().Trim();
                txtSoATM.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "SoATM").ToString().Trim();
                txtMaBank.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "MaBank").ToString().Trim();
                txtGhichu.EditValue = gvKhach.GetRowCellValue(e.RowHandle, "GhiChu").ToString().Trim();
                dateNgaySinh.EditValue = Convert.ToDateTime(gvKhach.GetRowCellValue(e.RowHandle, "NgaySinh").ToString().Trim());
                foreach (var item in list)
                {
                    if (item.Id == Convert.ToInt32(gvKhach.GetRowCellValue(e.RowHandle, "MaQT").ToString()))
                    {
                        lookUpEditQuoctich.EditValue = Convert.ToInt32(gvKhach.GetRowCellValue(e.RowHandle, "MaQT").ToString());
                        lookUpEditQuoctich.Properties.NullText = item.TenQT;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < gvKhach.RowCount; i++)
            {
                if (Convert.ToInt32(gvKhach.GetRowCellValue(i, "Id")) > k)
                    k = Convert.ToInt32(gvKhach.GetRowCellValue(i, "Id"));
            }
            k = k + 1;
            txtSTT.Text = k.ToString();
            enableEditing(true);
            reset();
            txtSoCMND.Focus();
            txtHoTen.Focus();
            txtSDT.Focus();
            txtEmail.Focus();
            cbNam.Checked = false;
            txtDiaChi.Focus();
            txtSoATM.Focus();
            txtGhichu.Focus();
            txtMaBank.Focus();
            dateNgaySinh.Focus();
            lookUpEditQuoctich.Properties.NullText = @"Chọn quốc tịch";
            otp = 1;
        }
        public void enableEditing(bool editing)
        {
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnLuu.Enabled = editing;
            btnBoqua.Enabled = editing;
            gcKhachHang.Enabled = !editing;
            txtSTT.ReadOnly = !editing;
            txtSoCMND.ReadOnly = !editing;
            txtHoTen.ReadOnly = !editing;
            txtSDT.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            txtDiaChi.ReadOnly = !editing;
            txtGhichu.ReadOnly = !editing;
            txtSoATM.ReadOnly = !editing;
            txtMaBank.ReadOnly = !editing;
            lookUpEditQuoctich.ReadOnly = !editing;
        }
        public void reset()
        {
            txtSoCMND.Text = null;
            txtHoTen.Text = null;
            txtEmail.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtMaBank.Text = null;
            txtSoATM.Text = null;
            txtGhichu.Text = null;
            dateNgaySinh.Text = null;
            lookUpEditQuoctich.Text = null;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            Khach kh = new Khach();
            kh.Id = Convert.ToInt32(txtSTT.Text.ToString().Trim());
            kh.SoCMND = txtSoCMND.Text.ToString().Trim();
            kh.HoTen = txtHoTen.Text.ToString().Trim();
            kh.Phone = txtSDT.Text.ToString().Trim();
            kh.Email = txtEmail.Text.ToString().Trim();
            kh.DiaChi = txtDiaChi.Text.ToString().Trim();
            kh.SoATM = Convert.ToInt32(txtSoATM.Text.ToString().Trim());
            kh.MaBank = txtMaBank.Text.ToString().Trim();
            kh.GhiChu = txtGhichu.Text.ToString().Trim();
            kh.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text.ToString().Trim());
            if (cbNam.Checked == true)
            {
                kh.GioiTnh = true;
            }
            else
            {
                kh.GioiTnh = false;
            }
            kh.MaQT = kh.MaQT;
            kh.GioiTnh = kh.GioiTnh;
            if (otp == 1)
            {
                KhachHangBUS.Instance.NewKhachHang(kh);
                KhachHangBUS.Instance.Xem(gcKhachHang);
                MessageBox.Show("Thêm thành công!");
                otp = 0;
            }
            else
            {
                KhachHangBUS.Instance.EditKhachHang(kh);
                KhachHangBUS.Instance.Xem(gcKhachHang);
                MessageBox.Show("Sửa thành công!");
            }
            enableEditing(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableEditing(true);
            txtSoCMND.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtMaBank.ReadOnly = false;
            txtSoATM.ReadOnly = false;
            txtGhichu.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            lookUpEditQuoctich.ReadOnly = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua không?", "Thông báo Undo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                enableEditing(false);
                otp = 0;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int id = Convert.ToInt32(gvKhach.GetRowCellValue(gvKhach.FocusedRowHandle, "Id"));
                KhachHangBUS.Instance.DelKhachHang(id);
                KhachHangBUS.Instance.Xem(gcKhachHang);
                MessageBox.Show("Xóa thành công!");
            }
        }
    }
}
