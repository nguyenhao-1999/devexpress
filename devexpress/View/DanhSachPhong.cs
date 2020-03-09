using devexpress.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
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
            //var list = (from p in db.Rooms
            //            from pc in db.RoomCategorys
            //            where  p.Maloai == pc.Maloai
            //            select new { p.Sophong, p.Sogiuong, p.Songuoi, pc.Tenloai,p.TienPVND,p.TienPUSD }).ToList();
            var list = db.Rooms.ToList();
            gcDataList.DataSource = list;
            var listtang = db.RoomTangs.ToList();
            treeList1.SelectImageList = imageCollection1;
            TreeListNode codeNode = treeList1.AppendNode(null, null);
            codeNode.ImageIndex = 0;
            codeNode.SetValue("name", "Tất cả các phòng");
            foreach (var item in listtang)
            {
                TreeListNode childNode = null;
                childNode = treeList1.AppendNode(null, codeNode);
                childNode.SetValue("name", item.Vitri);
            }
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            Danhsachnhomphong dsn = new Danhsachnhomphong();
            dsn.StartPosition= FormStartPosition.CenterScreen;
            dsn.Show();
        }

        private void gvDataList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.DisplayText = "STT";
            if (!gridView1.IsGroupRow(e.RowHandle)) //Nếu không phải là Group
            {
                if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;
                    }
                    else
                    {
                        e.Info.ImageIndex = -1; //Không hiển thị hình
                        e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                    }

                    //hàm này dùng thay đổi độ rộng mặc định của cột số thứ tự
                    var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    var _Width = Convert.ToInt32(_Size.Width) + 20;
                    BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDataList); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", e.RowHandle * -1); //Nhân -1 để đánh lại số thứ tự tăng dần
                var _Size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                var _Width = Convert.ToInt32(_Size.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDataList); }));
            }
        }

        private bool cal(int _Width, GridView _View)
        {
            _View.IndicatorWidth = _View.IndicatorWidth < _Width ? _Width : _View.IndicatorWidth;
            return true;
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            var listloai = db.RoomCategorys.ToList();
            glueLoai.DataSource = listloai;
            glueLoai.DisplayMember = "Tenloai";
            glueLoai.ValueMember = "Maloai";
            TreeList tree = sender as TreeList;
            if (e.Node == tree.FocusedNode)
            {
                if (e.CellText != "Tất cả các phòng")
                {
                    gcDataList.BeginUpdate();
                    var list = (from p in db.Rooms
                                join pc in db.RoomCategorys on p.Maloai equals pc.Maloai
                                join pt in db.RoomTangs on p.Manhom equals pt.Manhom
                                where pt.Vitri == e.CellValue.ToString()
                                select p).ToList();
                    gcDataList.DataSource = list;
                    gcDataList.EndUpdate();
                }
                else
                {
                    gcDataList.BeginUpdate();
                    var list = (from p in db.Rooms
                                from pc in db.RoomCategorys
                                where p.Maloai== pc.Maloai
                                select p).ToList();
                    gcDataList.DataSource = list;
                    gcDataList.EndUpdate();
                }
            }
        }

        private void gvDataList_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            var tienVND = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[3]));
            var tienUSD = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[4]));
            if (tienVND>0)
            {
                if(tienVND%22000>0)
                {
                    gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[4], tienVND / 22000+1);
                }
                else
                {
                    gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[4], tienVND / 22000);
                }
                
            }
            else if (tienUSD > 0)
            {
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[3], tienUSD * 22000);
            }
            if(tienVND<=0||tienUSD<=0)
            {
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[3], "");
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[4], "");
            }
            var id = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[6]));
            var editroom = db.Rooms.FirstOrDefault(m => m.Id == id);
            editroom.Maloai = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[2]));
            editroom.Songuoi= Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[0]));
            editroom.Sogiuong= Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[1]));
            editroom.TienPVND= Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[3]));
            editroom.TienPUSD= Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[4]));
            db.SaveChanges();
        }
    }
}
