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
using System.Drawing.Drawing2D;
using System.Security.Policy;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors.Filtering.Templates;

namespace devexpress.View
{
    public partial class Sodophong : DevExpress.XtraEditors.XtraForm
    {
        public Thongtin thongtin;
        QLKSDbContext db = new QLKSDbContext();
        public Sodophong()
        {
            InitializeComponent();
            Load += Sodophong_Load;
        }
        Room rooms;
        public delegate void GetData(Room room);
        string Hoten = "";
        private TileViewItemCustomizeEventArgs s;

        public void PostData(List<DK_Customer> kh)
        {
            if (kh != null)
            {
                foreach (var item in kh)
                {
                    if (item.Daidien == true)
                    {
                        Hoten = item.Hoten;
                    }
                }
            }
        }
        private void Sodophong_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var list = db.Rooms.ToList();
            gcData.DataSource = list;
        }

        private void tileView1_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            s = e;
            var list = db.DK_Customers;
            var list2 = db.Rooms.ToList();
            var list3 = db.Rooms.Where(m => m.Status == 5).ToList();
            foreach (var item in list2)
            {
                var roomtang = db.RoomTangs.ToList();
                foreach (var room in roomtang)
                {
                    ColorPickEdit c = new ColorPickEdit();
                    if (Convert.ToInt32(e.Item.Elements[0].Text) == room.Manhom && item.Manhom == room.Manhom)
                    {
                        c.EditValue = String.Format("{0:X}", room.Mamau);
                        Color mau = c.Color;
                        e.Item.AppearanceItem.Normal.BackColor = mau;
                    }
                }
            }
            
            foreach(var item in list3)
            {
                if (Convert.ToInt32(e.Item.Elements[3].Text) == item.Sophong)
                {
                    e.Item.Elements[6].Image = Properties.Resources.help20;
                }
            }
            if (list.Count() != 0)
            {
                foreach (var item in list.ToList())
                {
                    if (item.Sophong == Convert.ToInt32(e.Item.Elements[3].Text) && item.Daidien == true)
                    {
                        e.Item.Elements[4].Text = item.Hoten;
                        e.Item.Elements[5].Text = item.DateCheckin.ToShortDateString();
                        e.Item.Elements[1].Image = global::devexpress.Properties.Resources.Office_Customer_Male_Light_icon;
                    }
                }
            }

        }

        private void btnHosophong_Click(object sender, EventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.StartPosition = FormStartPosition.CenterScreen;
            tt.ShowDialog();
        }

        private void tileView1_ItemRightClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            popupMenuPhong.ShowPopup(Control.MousePosition);
            rooms = new Room();
            rooms.Sophong = Convert.ToInt32(e.Item.Elements[3].Text);
        }

        private void btnSodophong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.StartPosition = FormStartPosition.CenterScreen;
            var listdk = db.DK_Customers.Select(m => m.Sophong).ToList();
            var list = db.Rooms.Where(x => !listdk.Contains(rooms.Sophong)).Count();
            tt.dateCheckin.Enabled = false;
            tt.txtTimeCheckin.Enabled = false;
            if (list!=0)
            {
                var dt = DateTime.Now;
                tt.dateCheckin.EditValue = dt.ToShortDateString();
                tt.txtTimeCheckin.EditValue = dt.ToShortTimeString();
            }
            else
            {
                var roomdk = db.DK_Customers.FirstOrDefault(m => m.Sophong == rooms.Sophong&&m.Daidien==true);
                tt.dateCheckin.EditValue = roomdk.DateCheckin.ToShortDateString();
                tt.txtTimeCheckin.EditValue = roomdk.GioCheckin;
            }
            GetData mydate = new GetData(tt.PostData);
            mydate(rooms);
            tileView1_ItemCustomize(sender, s);
            tt.ShowDialog();
        }

        private void rbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var datefrom = Convert.ToDateTime(dateEditFrom.EditValue);
            var dateto = Convert.ToDateTime(dateEditTo.EditValue);
            if (rbLoc.SelectedIndex == 0)
            {
                Sodophong_Load(sender, e);
            }
            if (rbLoc.SelectedIndex == 1)
            {
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var listdk = db.DK_Customers.Select(m => m.Sophong).ToArray();
                var list = db.Rooms.Where(x => !listdk.Contains(x.Sophong)).ToList();
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
            if (rbLoc.SelectedIndex == 2)
            {
                datefrom = datefrom.Date;
                dateto = dateto.Date;
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where db.DK_Customers.Any(dk => dk.Sophong == r.Sophong /*&& dk.DateCheckin >= datefrom && dk.DateCheckout <= dateto && dk.Daidien == true*/)
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
            if (rbLoc.SelectedIndex == 3)
            {
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where db.DangKyPhong.Any(dkp => dkp.SoPhong == r.Sophong)
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
            if (rbLoc.SelectedIndex == 4)
            {
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where db.PhongS.Any(ps=>ps.Sophong==r.Sophong)
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
        }
    }
}