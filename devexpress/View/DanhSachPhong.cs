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
    public partial class DanhSachPhong : Form
    {
        QLKSDbContext db = new QLKSDbContext();
        public DanhSachPhong()
        {
            InitializeComponent();
        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phanMemQLKSDataSet.Rooms' table. You can move, or remove it, as needed.
            //this.roomsTableAdapter.Fill(this.phanMemQLKSDataSet.Rooms);
            var list = (from p in db.Rooms
                       join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                       select new { p.Sophong, p.Sogiuong, p.Songuoi,pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcDataList.BeginUpdate();
            gcDataList.DataSource = null;
            var list = (from p in db.Rooms
                        join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                        where p.Manhom==2
                        select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
            gcDataList.EndUpdate();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcDataList.BeginUpdate();
            gcDataList.DataSource = null;
            var list = (from p in db.Rooms
                        join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                        where p.Manhom == 1
                        select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
            gcDataList.EndUpdate();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcDataList.BeginUpdate();
            gcDataList.DataSource = null;
            var list = (from p in db.Rooms
                        join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                        where p.Manhom == 3
                        select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
            gcDataList.EndUpdate();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcDataList.BeginUpdate();
            gcDataList.DataSource = null;
            var list = (from p in db.Rooms
                        join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                        where p.Manhom == 4
                        select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
            gcDataList.EndUpdate();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            gcDataList.BeginUpdate();
            gcDataList.DataSource = null;
            var list = (from p in db.Rooms
                        join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                        select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai }).ToList();
            gcDataList.DataSource = list;
            gcDataList.EndUpdate();
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            Danhsachnhomphong dsn = new Danhsachnhomphong();
            dsn.Show();
        }
    }
}
