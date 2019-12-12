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
    public partial class DanhSachPhong : Form
    {
        public DanhSachPhong()
        {
            InitializeComponent();
        }

        private void nbTang1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //var b = db.BangGia.Count();
            //MessageBox.Show(b.ToString());
            //TreeListNode tln = treeList1.AppendNode(null, null);
            //tln.SetValue("name", "Tất cả phòng");
            //TreeListNode tln1 = treeList1.AppendNode(null, null);
            //tln1.SetValue("name", "Tất cả phòng 2");
            //TreeListNode childNode = null;
            //childNode = treeList1.AppendNode(null, tln);
            //childNode.SetValue("name", "Phòng 1");
        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            

        }
    }
}
