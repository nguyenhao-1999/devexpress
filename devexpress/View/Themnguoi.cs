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

namespace devexpress.View
{
    public partial class Themnguoi : DevExpress.XtraEditors.XtraForm
    {
        public Themnguoi()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Themnguoi_Load(object sender, EventArgs e)
        {
            var list = db.Quoctich.ToList();
        }
    }
}