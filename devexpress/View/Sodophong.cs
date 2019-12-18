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
            var list = db.DK_Customers;
            var list2 = db.Rooms.ToList();
            foreach (var color in list2)
            {
                var roomtang = db.RoomTangs.ToList();
                foreach (var room in roomtang)
                {
                    ColorPickEdit c = new ColorPickEdit();
                    if (Convert.ToInt32(e.Item.Elements[0].Text) == room.Manhom && color.Manhom == room.Manhom)
                    {
                        c.EditValue = String.Format("{0:X}", room.Mamau);
                        Color mau = c.Color;
                        e.Item.AppearanceItem.Normal.BackColor = mau;
                    }
                }
            }

            if (list.Count() != 0)
            {
                foreach (var item in list.ToList())
                {
                    if (item.IdKH == Convert.ToInt32(e.Item.Elements[3].Text) && item.Daidien == true)
                    {
                        e.Item.Elements[4].Text = item.Hoten;
                        e.Item.Elements[5].Text = item.DateCheckin.ToShortDateString();
                        e.Item.Elements[1].Image = global::devexpress.Properties.Resources.Actions_list_add_user_icon;
                    }
                }
            }

        }

        private void btnHosophong_Click(object sender, EventArgs e)
        {
            Thongtin tt = new Thongtin();
            tt.StartPosition = FormStartPosition.CenterScreen;
            tt.Show();
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
            GetData mydate = new GetData(tt.PostData);
            mydate(rooms);
            tt.Show();
        }

        private void rbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbLoc.SelectedIndex == 0)
            {
                Sodophong_Load(sender, e);
            }
            if (rbLoc.SelectedIndex == 1)
            {
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where !db.DK_Customers.Any(dk => dk.IdKH == r.Sophong)
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
            if (rbLoc.SelectedIndex == 2)
            {
                var datefrom = Convert.ToDateTime(dateEditFrom.EditValue);
                var dateto = Convert.ToDateTime(dateEditTo.EditValue);
                datefrom = datefrom.Date;
                dateto = dateto.Date;
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where db.DK_Customers.Any(dk => dk.IdKH == r.Sophong && dk.DateCheckin >= datefrom && dk.DateCheckin <= dateto && dk.Daidien == true)
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
            if (rbLoc.SelectedIndex == 3)
            {
                gcData.BeginUpdate();
                gcData.DataSource = null;
                var list = from r in db.Rooms
                           where r.Status == 0
                           select r;
                gcData.DataSource = list.ToList();
                gcData.EndUpdate();
            }
        }

        private void adornerUIManager1_QueryGuideFlyoutControl(object sender, DevExpress.Utils.VisualEffects.QueryGuideFlyoutControlEventArgs e)
        {

        }
    }
}