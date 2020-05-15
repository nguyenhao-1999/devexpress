using devexpress.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devexpress.View
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        public int id;
        public int t;
        public delegate void UpdatePassWord(int id,string mk);
        public event UpdatePassWord PasswordEvent;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn hủy hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                QuanTriNguoiDung qt = new QuanTriNguoiDung();
            }
        }

        private void btnChapnhan_Click(object sender, EventArgs e)
        {
            string mkc = MahoaMD5(txtmkcu.EditValue.ToString().Trim());
            string mkm = MahoaMD5(txtmkm.EditValue.ToString().Trim());
            string laplai = MahoaMD5(txtgolai.EditValue.ToString().Trim());
            if (string.IsNullOrEmpty(mkc))
            {
                MessageBox.Show("Mật khẩu cũ không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmkcu.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(mkm))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmkm.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(laplai))
            {
                MessageBox.Show("Gõ lại mật khẩu mới không được để trống!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgolai.Focus();
                return;
            }
            var ktmkc = db.NhanVien.Where(m => m.Id == id && m.Password == mkc).Count();
            if(ktmkc>0)
            {
                if(mkm==laplai)
                {
                    if (t == 0)
                    {
                        var dmk = db.NhanVien.FirstOrDefault(m => m.Id == id);
                        dmk.Password = mkm;
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(t==1)
                    {
                        if(PasswordEvent!=null)
                        {
                            PasswordEvent(id, mkm);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và gõ lại mật khẩu không khớp!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmkm.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmkcu.Focus();
                return;
            }

        }
        string MahoaMD5(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
    }
}
