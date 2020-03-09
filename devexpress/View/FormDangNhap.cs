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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn hủy bỏ hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.EditValue.ToString()) || string.IsNullOrEmpty(txtPassWord.EditValue.ToString()))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            string username = txtUserName.EditValue.ToString();
            string password = txtPassWord.EditValue.ToString();
            if (LoginDN(username,password))
            {
                Form1 f = new Form1();
                this.Hide();
                var nv = db.NhanVien.FirstOrDefault(m => m.TaiKhoan == username);
                f.txtUserName.EditValue = nv.HoTen;
                f.txtIdNhanvien.EditValue = nv.Id;
                f.ShowDialog();
                this.Show();
                ClearTextBox();
                txtUserName.Focus();
            }
            else
            {
                var kttk = db.NhanVien.Where(m => m.TaiKhoan == username).Count();
                if (kttk > 0)
                {
                    XtraMessageBox.Show("Sai mật khẩu!");
                    txtPassWord.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Sai tên tài khoản!");
                    txtUserName.Focus();
                }
            }
        }
        void ClearTextBox()
        {
            txtUserName.EditValue = "";
            txtPassWord.EditValue = "";
        }

        private bool LoginDN(string username,string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            var dn = db.NhanVien.Where(m => m.TaiKhoan == username && m.Password == hasPass).Count();
            if(dn>0)
            {
                return true;
            }
            return false;
        }

        private Form nextForm(string id)
        {
            Form f = new Form();
            switch (id)
            {
                case "1":
                    f = new Form1();
                    break;
            }
            return f;
        }
    }
}