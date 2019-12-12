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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Form f = nextForm(tbUserName.Text);
            f.FormClosed += f_FormClosed;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
            ClearTextBox();

        }

        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        Form nextForm(string id)
        {
            Form f = new Form();
            switch(id)
            {
                case "1":
                    f = new Form1();
                    break;
            }
            return f;
        }
        void ClearTextBox()
        {
            tbUserName.Clear();
            tbPassword.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
