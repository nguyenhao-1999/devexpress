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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace devexpress.View
{
    public partial class BoPhanToChuc : DevExpress.XtraEditors.XtraForm
    {
        public BoPhanToChuc()
        {
            InitializeComponent();
        }
        int stt;
        QLKSDbContext db = new QLKSDbContext();
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate BoPhanEvent;
        private void BoPhanToChuc_Load(object sender, EventArgs e)
        {
            var listbp = db.BoPhan.OrderBy(m=>m.STT).ToList();
            gcBophan.DataSource = new BindingList<BoPhan>(listbp) { AllowNew=true};
            stt = Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.RowCount-1, gvBophan.Columns[3]));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gvBophan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gvBophan.AddNewRow();
            btnUp.Enabled = true;
            gvBophan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(gvBophan.FocusedRowHandle<0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[2]));
                var delbp = db.BoPhan.FirstOrDefault(m => m.Id == id);
                if(gvBophan.FocusedRowHandle<gvBophan.RowCount-1)
                {
                    var idduoi = Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[2]));
                    var editbp = db.BoPhan.FirstOrDefault(m => m.Id == idduoi);
                    editbp.STT = delbp.STT;
                }
                db.BoPhan.Remove(delbp);
                db.SaveChanges();
                BoPhanToChuc_Load(sender, e);
                PostData();
                MessageBox.Show("Xóa thành công!", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var countbp = db.BoPhan.Count();
            if(gvBophan.RowCount>countbp)
            {
                for (int i = countbp; i < gvBophan.RowCount; i++)
                {
                    stt++;
                    BoPhan bp = new BoPhan();
                    bp.MaNhom = gvBophan.GetRowCellValue(i, gvBophan.Columns[0]).ToString();
                    bp.TenNhom = gvBophan.GetRowCellValue(i, gvBophan.Columns[1]).ToString();
                    bp.STT = stt;
                    db.BoPhan.Add(bp);
                    db.SaveChanges();
                    BoPhanToChuc_Load(sender, e);
                    PostData();
                }
                MessageBox.Show("Thêm thành công!", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for(int i=0;i<gvBophan.RowCount;i++)
                {
                    var id= Convert.ToInt32(gvBophan.GetRowCellValue(i, gvBophan.Columns[2]));
                    var editbp = db.BoPhan.FirstOrDefault(m => m.Id == id);
                    editbp.MaNhom= gvBophan.GetRowCellValue(i, gvBophan.Columns[0]).ToString();
                    editbp.TenNhom= gvBophan.GetRowCellValue(i, gvBophan.Columns[1]).ToString();
                    db.SaveChanges();
                    BoPhanToChuc_Load(sender, e);
                    PostData();
                }
                MessageBox.Show("Sửa thành công!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnVitri_Click(object sender, EventArgs e)
        {
            if (gvBophan.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if(gvBophan.FocusedRowHandle>0)
            {
                BoPhan bp = new BoPhan();
                bp.MaNhom = gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle - 1, gvBophan.Columns[0]).ToString();
                bp.TenNhom = gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle - 1, gvBophan.Columns[1]).ToString();
                bp.Id= Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle - 1, gvBophan.Columns[2]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle - 1, gvBophan.Columns[0], gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[0]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle , gvBophan.Columns[0], bp.MaNhom);
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle - 1, gvBophan.Columns[1], gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[1]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[1], bp.TenNhom);
                db.SaveChanges();
                PostData();
                gvBophan.FocusedRowHandle = gvBophan.FocusedRowHandle - 1;
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (gvBophan.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (gvBophan.FocusedRowHandle < gvBophan.RowCount-1)
            {
                BoPhan bp = new BoPhan();
                bp.MaNhom = gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[0]).ToString();
                bp.TenNhom = gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[1]).ToString();
                bp.Id = Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[2]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[0], gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[0]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[0], bp.MaNhom);
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle + 1, gvBophan.Columns[1], gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[1]));
                gvBophan.SetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[1], bp.TenNhom);
                db.SaveChanges();
                PostData();
                gvBophan.FocusedRowHandle = gvBophan.FocusedRowHandle + 1;
            }
        }
        public void PostData()
        {
            var list = db.BoPhan.OrderBy(m => m.STT).ToList();
            BoPhanEvent(this, new UpdateEventArgs { Data = list });
        }

        private void gvBophan_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn == colTenNhom)
            {
                if (e.Value.ToString() == "")
                {
                    e.Valid = false;
                    e.ErrorText = "Tên bộ phận không được để trống!";
                }
                string tennhom = e.Value.ToString();
                int id = Convert.ToInt32(gvBophan.GetRowCellValue(gvBophan.FocusedRowHandle, gvBophan.Columns[2]));
                var kt = db.BoPhan.Where(m => m.TenNhom == tennhom&& m.Id!=id).Count();
                if (kt > 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Tên nhóm đã tồn tại!";
                }
            }
        }
    }

    public class UpdateEventArgs:EventArgs
    {
        public List<BoPhan> Data { get; set; }
    }
}