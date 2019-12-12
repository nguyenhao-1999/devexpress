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
        private void ThietBiTienNghi_Load(object sender, EventArgs e)
        {
            var list = db.ThietBi.ToList();
            gcDanhSachPhieuDP.DataSource = list;
        }
    }
}
