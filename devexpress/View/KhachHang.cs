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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet2.DK_Customers' table. You can move, or remove it, as needed.
            this.dK_CustomersTableAdapter.Fill(this.qLKhachSanDataSet2.DK_Customers);
            // TODO: This line of code loads data into the 'qLKhachSanDataSet1.Khach' table. You can move, or remove it, as needed.
            this.khachTableAdapter.Fill(this.qLKhachSanDataSet1.Khach);

        }
    }
}
