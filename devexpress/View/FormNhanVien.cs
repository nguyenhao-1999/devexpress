using devexpress.Model;
using DevExpress.XtraTreeList.Nodes;
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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemNV nv = new ThemNV();
            nv.Show();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            var listbp = db.BoPhan.ToList();
            tlBoPhan.SelectImageList = Properties.Resources.package_wordprocessing;
            TreeListNode codeNode = tlBoPhan.AppendNode(null, null);
            codeNode.ImageIndex = 0;
            codeNode.SetValue("name", "Bộ phận tổ chức");
            foreach (var item in listbp)
            {
                TreeListNode childNode = null;
                childNode = tlBoPhan.AppendNode(null, codeNode);
                childNode.SetValue("name", item.TenNhom);
            }
            tlBoPhan.ExpandAll();
        }
    }
}
