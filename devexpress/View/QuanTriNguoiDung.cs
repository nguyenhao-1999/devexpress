using devexpress.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devexpress.View
{
    public partial class QuanTriNguoiDung : Form
    {
        public QuanTriNguoiDung()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        List<NhanVien> lstNV = new List<NhanVien>();
        private void QuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            var lstbp = db.BoPhan.OrderBy(m => m.STT).ToList();
            CreateTreeList(lstbp);
            var listnv = db.NhanVien.OrderBy(m => m.Id).ToList();
            lstNV = listnv;
            foreach(var item in lstNV)
            {
                NhanVien nv = new NhanVien();
                nv.Id = item.Id;
                nv.Password = item.Password;
                nv.HoTen = item.HoTen;
                nv.MaNV = item.MaNV;
                nv.SoCMND = item.SoCMND;
                nv.DienThoai = item.DienThoai;
                nv.Account = item.Account;
                lstNhanvien.Add(nv);
            }
        }
        public void CreateTreeList(List<BoPhan> lst)
        {
            tlBoPhan.SelectImageList = imageCollection1;
            TreeListNode codeNode = tlBoPhan.AppendNode(null, null);
            codeNode.ImageIndex = 0;
            codeNode.SetValue("name", "Bộ phận tổ chức");
            foreach (var item in lst)
            {
                TreeListNode childNode = null;
                childNode = tlBoPhan.AppendNode(null, codeNode);
                childNode.SetValue("name", item.TenNhom);
                childNode.SetValue("Id", item.Id);
                childNode.Expanded = true;
            }
            tlBoPhan.ExpandAll();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            BoPhanToChuc bptc = new BoPhanToChuc();
            bptc.BoPhanEvent += bptc_BoPhanEvent;
            bptc.ShowDialog();
        }

        private void bptc_BoPhanEvent(object sender, UpdateEventArgs args)
        {
            tlBoPhan.Nodes.Clear();
            CreateTreeList(args.Data);

        }
        string manhom = "";
        private CustomDrawNodeCellEventArgs s;

        private void tlBoPhan_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            s = e;
            TreeList tree = sender as TreeList;
            if (e.Node == tree.FocusedNode)
            {
                if (e.CellText != "Bộ phận tổ chức")
                {
                    gcQuanTriNguoiDung.BeginUpdate();
                    var list = (from nv in lstNV
                                join bp in db.BoPhan on nv.MaNhom equals bp.MaNhom
                               where bp.TenNhom == e.CellValue.ToString()
                               select nv).ToList();
                    gcQuanTriNguoiDung.DataSource = new BindingList<NhanVien>(list) { AllowNew = true };
                    gcQuanTriNguoiDung.EndUpdate();
                    btnThem.Enabled = true;
                    var mn = db.BoPhan.FirstOrDefault(m => m.TenNhom == e.CellValue.ToString());
                    manhom = mn.MaNhom;
                    value = e.CellValue.ToString();
                }
                else
                {
                    gcQuanTriNguoiDung.BeginUpdate();
                    var list = lstNV;
                    gcQuanTriNguoiDung.DataSource = list;
                    gcQuanTriNguoiDung.EndUpdate();
                    btnThem.Enabled = false;
                }
            }
            for(int i=0;i<gvQuantri.RowCount;i++)
            {
                gvQuantri.SetRowCellValue(i, grcMatKhau, "***********");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNV nv = new ThemNV();
            nv.cbNhom.EditValue = manhom;
            nv.cbNhom.Enabled = false;
            nv.NhanVienEvent += nv_NhanVienEvent;
            nv.ShowDialog();
        }

        private void nv_NhanVienEvent(object sender, UpEventArgs args)
        {
            tlBoPhan.Nodes.Clear();
            QuanTriNguoiDung_Load(this, args);
            tlBoPhan.FocusedNode = n;
            lstNV = args.Data;
        }
        TreeListNode n;
        string value = "";

        private void tlBoPhan_CustomNodeCellEdit(object sender, GetCustomNodeCellEditEventArgs e)
        {
            n = tlBoPhan.FindNodeByFieldValue("name", value);
        }
        List<NhanVien> lstNhanvien = new List<NhanVien>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            for(int i=0;i<gvQuantri.RowCount;i++)
            {
                var id = Convert.ToInt32(gvQuantri.GetRowCellValue(i, gvQuantri.Columns[0]));
                var editnv = db.NhanVien.FirstOrDefault(m => m.Id == id);
                editnv.HoTen = gvQuantri.GetRowCellValue(i, gvQuantri.Columns[2]).ToString();
                editnv.MaNV= gvQuantri.GetRowCellValue(i, gvQuantri.Columns[1]).ToString();
                editnv.NgaySinh= Convert.ToDateTime(gvQuantri.GetRowCellValue(i, gvQuantri.Columns[3]));
                editnv.SoCMND= Convert.ToInt32(gvQuantri.GetRowCellValue(i, gvQuantri.Columns[4]));
                editnv.DiaChi= gvQuantri.GetRowCellValue(i, gvQuantri.Columns[5]).ToString();
                editnv.DienThoai= gvQuantri.GetRowCellValue(i, gvQuantri.Columns[6]).ToString();
                editnv.Account= gvQuantri.GetRowCellValue(i, gvQuantri.Columns[7]).ToString();
                foreach(var item in lstNhanvien)
                {
                    if(item.Id==id)
                    {
                        editnv.Password = item.Password;
                    }
                }
                db.SaveChanges();
                Form1 f = new Form1();
                if (Convert.ToInt32(f.txtIdNhanvien.EditValue) == id)
                {
                    f.txtUserName.EditValue = editnv.HoTen;
                }
            }
            MessageBox.Show("Lưu thành công!", "Success",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvQuantri.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var id = Convert.ToInt32(gvQuantri.GetRowCellValue(gvQuantri.FocusedRowHandle, gvQuantri.Columns[0]));
                Form1 f = new Form1();
                var iddn = Convert.ToInt32(f.txtIdNhanvien.EditValue);
                if(id==iddn)
                {
                    MessageBox.Show("Tài khoản này đang đăng nhập không thể xóa!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                var delnv = db.NhanVien.FirstOrDefault(m => m.Id == id);
                db.NhanVien.Remove(delnv);
                gvQuantri.DeleteRow(gvQuantri.FocusedRowHandle);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void gvQuantri_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn == grcMa)
            {
                if (e.Value.ToString() =="")
                {
                    e.Valid = false;
                    e.ErrorText = "Mã nhân viên không được để trống!";
                }
                string manv = e.Value.ToString();
                int id = Convert.ToInt32(gvQuantri.GetRowCellValue(gvQuantri.FocusedRowHandle, gvQuantri.Columns[0]));
                var kt = db.NhanVien.Where(m => m.MaNV == manv&&m.Id!=id).Count();
                if (kt > 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã nhân viên đã tồn tại!";
                }
            }
            if (view.FocusedColumn == grcTen)
            {
                if (e.Value.ToString() == "")
                {
                    e.Valid = false;
                    e.ErrorText = "Tên nhân viên không được để trống!";
                }
            }
             if (view.FocusedColumn == grcCMND)
            {
                if (Convert.ToInt32(e.Value) <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Chứng minh nhân dân không được để trống!";
                }
            }
             if(view.FocusedColumn==grcDienThoai)
            {
                if (e.Value.ToString() == "")
                {
                    e.Valid = false;
                    e.ErrorText = "Điện thoại không được để trống!";
                }
            }
             if(view.FocusedColumn==grcTaiKhoan)
            {
                if (e.Value.ToString() == "")
                {
                    e.Valid = false;
                    e.ErrorText = "Tài khoản không được để trống!";
                }
            }
            if (view.FocusedColumn == grcMatKhau)
            {
                if (e.Value.ToString() == "")
                {
                    e.Valid = false;
                    e.ErrorText = "Mật khẩu không được để trống!";
                }
                
            }
        }

        private void gvQuantri_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            
            for (int i=0;i<gvQuantri.RowCount;i++)
            {
                var id = Convert.ToInt32(gvQuantri.GetRowCellValue(i, gvQuantri.Columns[0]));
                var editnv = db.NhanVien.FirstOrDefault(m => m.Id == id);
                if(editnv.DiaChi==null)
                {
                    gvQuantri.SetRowCellValue(i, gvQuantri.Columns[5], "");
                }
                if(gvQuantri.GetRowCellValue(i,gvQuantri.Columns[3]).ToString()==null)
                {
                    gvQuantri.SetRowCellValue(i, gvQuantri.Columns[5], "");
                }
            }
        }
        private void gvQuantri_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (gvQuantri.FocusedColumn == grcMatKhau)
            {
                if (gvQuantri.FocusedRowHandle >= 0)
                {
                    DoiMatKhau dmk = new DoiMatKhau();
                    dmk.id = Convert.ToInt32(gvQuantri.GetRowCellValue(gvQuantri.FocusedRowHandle, gvQuantri.Columns[0]));
                    dmk.t = 1;
                    dmk.PasswordEvent += dmk_PasswordEvent;
                    dmk.ShowDialog();
                }
            }
        }

        private void dmk_PasswordEvent(int id, string mk)
        {
            foreach(var item in lstNhanvien)
            {
                if(item.Id==id)
                {
                    item.Password = mk;
                }
            }
        }
    }
}
