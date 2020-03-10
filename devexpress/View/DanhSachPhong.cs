using devexpress.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
            //var list = db.Rooms.ToList();
            //gcDataList.DataSource = new BindingList<Room>(list) { AllowNew = true };
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
            treeList1.ExpandAll();
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            Danhsachnhomphong dsn = new Danhsachnhomphong();
            dsn.StartPosition= FormStartPosition.CenterScreen;
            dsn.ShowDialog();
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
        int manhom = 0;
        int id = 0;
        int row = 0;
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
                    gcDataList.DataSource = new BindingList<Room>(list) { AllowNew = true };
                    gcDataList.EndUpdate();
                    btnThem.Enabled = true;
                    var rt = db.RoomTangs.FirstOrDefault(m => m.Vitri == e.CellValue.ToString());
                    manhom = rt.Manhom;
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
                    btnThem.Enabled = false;
                }
            }
        }

        private void gvDataList_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            id= Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[6]));
            row = e.RowHandle;
            var tienVND = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[3]));
            var tienUSD = Convert.ToInt32(gvDataList.GetRowCellValue(e.RowHandle, gvDataList.Columns[4]));
            if (tienUSD > 0 && e.Column == grcUSD)
            {
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[3], tienUSD * 22000);
            }
            else if (tienVND > 0 && e.Column == grcVND)
            {
                
               gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[4], tienVND / 22000);
            }
            else if (tienVND <= 0 || tienUSD <= 0)
            {
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[3], "");
                gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[4], "");
            }

        }
        int t = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvDataList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gvDataList.OptionsNavigation.AutoFocusNewRow = true;
            t = 1;
        }

        private void gvDataList_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvDataList.AddNewRow();
            gvDataList.SetRowCellValue(e.RowHandle, gvDataList.Columns[2], 1);
            gvDataList.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(t==1)
            {
                
                    Room r = new Room();
                    r.Sophong = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[5]));
                    r.Songuoi = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[0]));
                    r.Sogiuong = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[1]));
                    r.TienPVND = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[3]));
                    r.TienPUSD = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[4]));
                    r.Manhom = manhom;
                    r.Maloai = Convert.ToInt32(gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[2]));
                    r.Sophone = gvDataList.GetRowCellValue(gvDataList.FocusedRowHandle, gvDataList.Columns[5]).ToString();
                    r.Status = 1;
                    db.Rooms.Add(r);
                    db.SaveChanges();
            }
            else
            {
                for (int i = 0; i < gvDataList.RowCount-1; i++)
                {
                    var id = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[6]));
                    var editroom = db.Rooms.FirstOrDefault(m => m.Id == id);
                    editroom.Maloai = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[2]));
                    editroom.Songuoi = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[0]));
                    editroom.Sogiuong = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[1]));
                    editroom.TienPVND = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[3]));
                    editroom.TienPUSD = Convert.ToInt32(gvDataList.GetRowCellValue(i, gvDataList.Columns[4]));
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Lưu thành công!", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvDataList_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.FocusedColumn==grcSophog)
            {
                if(Convert.ToInt32(e.Value)<=0|| e.Value==null)
                {
                    e.Valid = false;
                    e.ErrorText = "Số phòng không được để trống!";
                }
                int sophong = Convert.ToInt32(e.Value);
                var kt = db.Rooms.Where(m => m.Sophong == sophong).Count();
                if(kt>0)
                {
                    e.Valid = false;
                    e.ErrorText = "Số phòng đã tồn tại!";
                }
            }
            if (view.FocusedColumn == grcSoGiuong)
            {
                if (Convert.ToInt32(e.Value) <= 0 || e.Value == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Số giường không được để trống!";
                }
            }
            if (view.FocusedColumn == grcSoNguoi)
            {
                if (Convert.ToInt32(e.Value) <= 0 || e.Value == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Số người không được để trống!";
                }
            }
            if (view.FocusedColumn == grcPhanLoai)
            {
                if (Convert.ToInt32(e.Value) <= 0 || e.Value == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Loại phòng không được để trống!";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var delroom = db.Rooms.FirstOrDefault(m => m.Id == id);
                db.Rooms.Remove(delroom);
                db.SaveChanges();
                gvDataList.DeleteRow(row);
                MessageBox.Show("Xóa thành công!", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
