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
using System.ComponentModel.DataAnnotations;
using devexpress.Model;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.ObjectModel;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;

namespace devexpress.View
{
    public partial class PhieuDatPhongMoi : DevExpress.XtraEditors.XtraForm
    {
        public PhieuDatPhongMoi()
        {
            InitializeComponent();
            gvDangky.DataController.AllowIEnumerableDetails = true;
        }
        List<DK_Customer> lstDK;
        QLKSDbContext db = new QLKSDbContext();
        private void PhieuDatPhongMoi_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateNgay.EditValue = dt.Date.ToShortDateString();
            dateCheckin.EditValue = dt.Date.ToShortDateString();
            dateCheckout.EditValue = dt.AddDays(1).ToShortDateString();
            var listP = (from p in db.Rooms
                         from t in db.RoomTangs
                       where p.Manhom==t.Manhom
                       select new { p.Sophong,p.Sogiuong,p.Songuoi,t.Vitri}).ToList();
            gcPhong.DataSource = listP;
            gvPhong.ExpandAllGroups();
            var listQT = db.Quoctich.ToList();
            cbQuoctich.DataSource = listQT;
            cbQuoctich.DisplayMember = "TenQT";
            cbQuoctich.ValueMember = "Id";
            var listNH = db.NganHang.ToList();
            glueNganhang.Properties.ValueMember = "Id";
            glueNganhang.Properties.DisplayMember = "TenBank";
            glueNganhang.Properties.DataSource = listNH;
            //checkeditDK.ValueChecked = Convert.ChangeType(1, gvDangky.Columns[5].ColumnType);
            //checkeditDK.ValueUnchecked= Convert.ChangeType(0, gvDangky.Columns[5].ColumnType);
        }


        private void checkeditDK_CheckStateChanged(object sender, EventArgs e)
        {

        }
        
        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            List<int> row = gvPhong.GetSelectedRows().Where(m => m >= 0).ToList();
            List<Room> lstRoom = new List<Room>();
            lstDK = new List<DK_Customer>();
            foreach (var item in row)
            {
                lstRoom.Add(new Room() { Sophong = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[0])),
                                        Sogiuong = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[2])),
                                        Songuoi = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[3])),
                                         });
                
            }
            gcDangky.DataSource = lstRoom;
        }

        private void gvDangky_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void gvDangky_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            Room room = (Room)gvDangky.GetRow(e.RowHandle);
            List<DK_Customer> lst = new List<DK_Customer>();
            BindingSource source = new BindingSource();
                for (int i = 0; i < room.Songuoi; i++)
                {
                    source.AllowNew = true;
                    lst.Add(new DK_Customer() { IdKH =room.Sophong});
                MessageBox.Show("" + room.Sophong);
                }
                source.DataSource = lst;
            
                e.ChildList = source;
        }

        private void gvDangky_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gvDangky_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        

        private void gvPhong_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CreateSTT(gvPhong, e);
        }

        private void gvDangky_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CreateSTT(gvDangky, e);
        }

        private void gvKhach_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            CreateSTT(gvKhach, e);
        }
        public void CreateSTT(GridView view, RowIndicatorCustomDrawEventArgs e)
        {
            if (!view.IsGroupRow(e.RowHandle))
            {
                if (e.Info.IsRowIndicator)
                {
                    if (e.RowHandle < 0)
                    {
                        e.Info.ImageIndex = 0;
                        e.Info.DisplayText = string.Empty;

                    }
                    else
                    {
                        e.Info.ImageIndex = -1;
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                    SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                    Int32 width = Convert.ToInt32(size.Width) + 30;
                    BeginInvoke(new MethodInvoker(delegate { cal(width, view); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle * -1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(size.Width) + 0;
                BeginInvoke(new MethodInvoker(delegate { cal(width, view); }));
            }
        }
       public bool cal(Int32 width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
            return true;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        { 
            gcDangky.BeginUpdate();
            gcDangky.DataSource = null;
            gcDangky.EndUpdate();
            gvPhong.ClearSelection();
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            GridView dView = gvDangky.GetDetailView(gvDangky.FocusedRowHandle,0) as GridView;
            if(dView==null)
            {
                MessageBox.Show("Hiện tại chưa có khách đăng ký!");
                return;
            }
            dView.SetRowCellValue(dView.FocusedRowHandle, dView.Columns[0], "");
            dView.SetRowCellValue(dView.FocusedRowHandle, dView.Columns[1], "");
            dView.SetRowCellValue(dView.FocusedRowHandle, dView.Columns[2], false);
            dView.SetRowCellValue(dView.FocusedRowHandle, dView.Columns[3], 0);
            dView.SetRowCellValue(dView.FocusedRowHandle, dView.Columns[4], 0);


        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (gvDangky.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa!");
                return;
            }
            else
            {
                gvDangky.DeleteRow(gvDangky.FocusedRowHandle);
            }
        }
        

        private void spinPhong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (spinPhong.Value > db.Rooms.Where(m => m.Status == 1).Count())
            {
                MessageBox.Show("Số phòng đã đạt tối đa!");
                spinPhong.Focus();
                return;
            }
            else
            {
                gvPhong.BeginUpdate();
                gcPhong.DataSource = null;
                var listP = (from p in db.Rooms
                             from t in db.RoomTangs
                             where p.Manhom == t.Manhom && p.Status==1
                             select new { p.Sophong, p.Sogiuong, p.Songuoi, t.Vitri }).ToList();
                gcPhong.DataSource = listP;
                gvPhong.ExpandAllGroups();
                gvPhong.EndUpdate();
            }
        }

        private void spSoKhach_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (spSoKhach.Value > db.Rooms.Where(m => m.Status == 1).Sum(m=>m.Songuoi))
            {
                MessageBox.Show("Số người đã đạt tối đa!");
                spinPhong.Focus();
                return;
            }
            else
            {
                gvPhong.BeginUpdate();
                gcPhong.DataSource = null;
                var listP = (from p in db.Rooms
                             from t in db.RoomTangs
                             where p.Manhom == t.Manhom && p.Status == 1
                             select new { p.Sophong, p.Sogiuong, p.Songuoi, t.Vitri }).ToList();
                gcPhong.DataSource = listP;
                gvPhong.ExpandAllGroups();
                gvPhong.EndUpdate();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < gvDangky.RowCount; j++)
            {
                GridView dView = gvDangky.GetDetailView(j, 0) as GridView;
                if(dView==null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng đăng ký!");
                    return;
                }
                for (int i = 0; i < dView.RowCount; i++)
                {
                    if(dView.GetRowCellValue(i, dView.Columns[0])!=null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                    {
                        
                    }
                }
            }
            
        }

        private void cbHinhthuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbHinhthuc.SelectedIndex==1)
            {
                tbSoTK.Enabled = true;
                glueNganhang.Enabled = true;
            }
            else
            {
                tbSoTK.Enabled = false;
                glueNganhang.Enabled = false;
            }
        }

        private void edtDienThoai_Enter(object sender, EventArgs e)
        {
            if (edtDienThoai.Text == "Nhập số điện thoại")
            {
                edtDienThoai.Text = "";
            }
        }

        private void edtDienThoai_Leave(object sender, EventArgs e)
        {
            if(edtDienThoai.Text == "")
            {
                edtDienThoai.Text = "Nhập số điện thoại";
            }
        }

        private void tbDattruoc_Enter(object sender, EventArgs e)
        {
            if (tbDattruoc.Text == "Số tiền")
            {
                tbDattruoc.Text = "";
            }
        }

        private void tbDattruoc_Leave(object sender, EventArgs e)
        {
            if (tbDattruoc.Text == "")
            {
                tbDattruoc.Text = "Số tiền";
            }
        }

        private void tbSoTK_Enter(object sender, EventArgs e)
        {
            if (tbSoTK.Text == "Số tài khoản")
            {
                tbSoTK.Text = "";
            }
        }

        private void tbSoTK_Leave(object sender, EventArgs e)
        {
            if (tbSoTK.Text == "")
            {
                tbSoTK.Text = "Số tài khoản";
            }
        }

        private void edtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDattruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}