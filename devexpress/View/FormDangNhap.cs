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
            string username = txtUserName.EditValue.ToString();
            string password = txtPassWord.EditValue.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (LoginDN(username,password))
            {
                Form1 f = new Form1();
                this.Hide();
                var nv = db.NhanVien.FirstOrDefault(m => m.Account == username);
                f.txtUserName.EditValue = nv.HoTen;
                f.txtIdNhanvien.EditValue = nv.Id;
                txtUserName.EditValue = password;
                f.ShowDialog();
                this.Show();
                ClearTextBox();
                txtUserName.Focus();
            }
            else
            {
                var kttk = db.NhanVien.Where(m => m.Account == username).Count();
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
        public string key = "";
        private bool LoginDN(string username,string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            txtUserName.EditValue = hasPass;
            var dn = db.NhanVien.Where(m => m.Account == username && m.Password == hasPass).Count();
            if(dn>0)
            {
                key = txtPassWord.EditValue.ToString();
                return true;
            }
            return false;
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnDangnhap_Click(sender, e);
            }
        }
    }
}