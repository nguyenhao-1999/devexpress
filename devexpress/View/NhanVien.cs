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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemNV nv = new ThemNV();
            nv.Show();
        }
    }
}
