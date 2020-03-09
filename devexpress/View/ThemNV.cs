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
using System.Security.Cryptography;

namespace devexpress.View
{
    public partial class ThemNV : DevExpress.XtraEditors.XtraForm
    {
        public ThemNV()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        private void ThemNV_Load(object sender, EventArgs e)
        {
            var nhom = db.BoPhan.ToList();
            cbNhom.Properties.DataSource = nhom;
            cbNhom.Properties.DisplayMember = "TenNhom";
            cbNhom.Properties.ValueMember = "MaNhom";
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.EditValue.ToString().Trim();
            string cmnd = txtCMND.EditValue.ToString().Trim();
            string tk = txtTK.EditValue.ToString().Trim();
            string mk = txtMK.EditValue.ToString().Trim();
            string golai = txtGolai.EditValue.ToString().Trim();
            string hoten = txtHoten.EditValue.ToString().Trim();
            string manv = txtMaNV.EditValue.ToString().Trim();
            if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(cmnd)|| string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk) || string.IsNullOrEmpty(golai) || string.IsNullOrEmpty(hoten)|| string.IsNullOrEmpty(manv) )
            {
                MessageBox.Show("Các dòng (*) không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(mk!=golai)
            {
                MessageBox.Show("Mật khẩu và lặp lại mật khẩu không khớp!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mk);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            NhanVien nv = new NhanVien();
            nv.MaNV = manv;
            nv.SoCMND = Convert.ToInt32(cmnd);
            nv.NgaySinh = Convert.ToDateTime(dateEditNS.EditValue).ToShortDateString();
            nv.DienThoai = Convert.ToInt32(txtSDT.EditValue);
            nv.MaNhom = cbNhom.EditValue.ToString();
            nv.TaiKhoan = tk;
            nv.Password = mk;
            nv.HoTen = hoten;
            nv.DiaChi = txtDiachi.EditValue.ToString();
            db.NhanVien.Add(nv);
            db.SaveChanges();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
