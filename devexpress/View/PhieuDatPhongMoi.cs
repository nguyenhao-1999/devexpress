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
        public int p = 0;
        List<DK_Customer> lstDK;
        QLKSDbContext db = new QLKSDbContext();
        public int t = 0;
        int tam = 0;
        private void PhieuDatPhongMoi_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //dateNgay.EditValue = dt.Date.ToShortDateString();
            //dateCheckin.EditValue = dt.Date.ToShortDateString();
            //dateCheckout.EditValue = dt.AddDays(1).ToShortDateString();
            var listP = (from p in db.Rooms
                         from t in db.RoomTangs
                       where p.Manhom==t.Manhom && p.Status==1
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
            var listDT = db.Khach.ToList();
            glueDoitac.Properties.ValueMember = "Id";
            glueDoitac.Properties.DisplayMember = "HoTen";
            glueDoitac.Properties.DataSource = listDT;
            glueDoitac.Focus();
            //checkeditDK.ValueChecked = Convert.ChangeType(1, gvDangky.Columns[5].ColumnType);
            //checkeditDK.ValueUnchecked= Convert.ChangeType(0, gvDangky.Columns[5].ColumnType);
            ExpandAllRows(gvDangky);
        }


        private void checkeditDK_CheckStateChanged(object sender, EventArgs e)
        {

        }
        
        private void btnThemkhach_Click(object sender, EventArgs e)
        {
            List<int> row = gvPhong.GetSelectedRows().Where(m => m >= 0).ToList();
            List<Room> lstRoom = new List<Room>();
            lstDK = new List<DK_Customer>();
            if(txtSo.Text!="")
            {
                var iddk = Convert.ToInt32(txtSo.Text);
                var list = db.DangKyPhong.Where(m => m.IDDK == iddk).ToList();
                var listP = db.Rooms.ToList();
                foreach(var item in list)
                {
                    foreach(var item2 in listP)
                    {
                        if(item.SoPhong==item2.Sophong)
                        {
                            lstRoom.Add(new Room()
                            {
                                Sophong = item2.Sophong,
                                Sogiuong = item2.Sogiuong,
                                Songuoi = item2.Songuoi,
                            });
                        }
                    }
                }
            }
            foreach (var item in row)
            {
                lstRoom.Add(new Room() { Sophong = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[0])),
                                        Sogiuong = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[2])),
                                        Songuoi = Convert.ToInt32(gvPhong.GetRowCellValue(item, gvPhong.Columns[3])),
                                         });
                
            }
            gcDangky.DataSource = lstRoom;
            t = 1;
            ExpandAllRows(gvDangky);
        }
        public void ExpandAllRows(GridView view)
        {
            view.BeginUpdate();
            try
            {
                int dataRowCount = view.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    view.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                view.EndUpdate();
            }
        }

        private void gvDangky_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void gvDangky_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            List<DK_Customer> lst = new List<DK_Customer>();
            BindingSource source = new BindingSource();
            if (p == 0)
            {
                for (int i = 0; i < Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[3])); i++)
                {
                    source.AllowNew = true;
                    lst.Add(new DK_Customer() { Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[0])) });
                }
            }
            else if(p==1)
            {
                var iddk = Convert.ToInt32(txtSo.Text);
                var sophong = Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[0]));
                var listkhach = db.DK_Customers.Where(m=>m.IdDK==iddk&&m.Sophong==sophong);
                source.AllowNew = true;
                foreach (var item in listkhach.ToList())
                {
                   lst.Add(new DK_Customer() { CMND = item.CMND, Hoten = item.Hoten, Gioitinh = item.Gioitinh, Quoctich = item.Quoctich, Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[0])),Id=item.Id });
                }
                int t = Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[3])) - listkhach.Count();
                for (int i=0;i<t;i++)
                {
                    lst.Add(new DK_Customer() {  Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(e.RowHandle, gvDangky.Columns[0])) });
                }
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
            tam = 2;
        }
        List<DangKyPhong> lstdkp = new List<DangKyPhong>();
        List<DK_Customer> lstdkk = new List<DK_Customer>();
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
            if(txtSo.Text!="")
            {
                var id= Convert.ToInt32(dView.GetRowCellValue(dView.FocusedRowHandle, dView.Columns[5]));
                var dkk = db.DK_Customers.FirstOrDefault(m => m.Id == id);
                lstdkk.Add(dkk);
            }
            tam = 2;

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
                if (txtSo.Text != "")
                {
                    var sophong = Convert.ToInt32(gvDangky.GetRowCellValue(gvDangky.FocusedRowHandle, gvDangky.Columns[0]));
                    var dkp = db.DangKyPhong.FirstOrDefault(m => m.SoPhong == sophong);
                    lstdkp.Add(dkp);
                }
                t = 2;
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
            string phong = "";
            if (glueDoitac.Text=="")
            {
                MessageBox.Show("Vui lòng chọn khách hàng hoặc đối tác!");
                glueDoitac.Focus();
                return;
            }
            else
            {
                var idkhach = Convert.ToInt32(glueDoitac.EditValue);
                if (t == 1)
                {
                    if (txtSo.Text == "")
                    {
                        if (gcDangky.DataSource == null)
                        {
                            MessageBox.Show("Vui lòng chọn phòng để đăng ký");
                            return;
                        }
                        Dangky dk = new Dangky();
                        dk.NgayDK = Convert.ToDateTime(dateNgay.EditValue.ToString());
                        dk.NgayCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                        dk.NgayCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                        dk.SotienUT = Convert.ToDouble(tbDattruoc.Text.ToString());
                        dk.Sokhach = Convert.ToInt32(gvDangky.Columns[2].SummaryItem.SummaryValue);
                        dk.Sophong = Convert.ToInt32(gvDangky.Columns[3].SummaryItem.SummaryValue);
                        dk.DaCheckin = false;
                        dk.Ghichu = tbNoidung.Text.ToString();
                        dk.HinhthucTT = cbHinhthuc.EditValue.ToString();
                        dk.Loaitien = cbxLoai.EditValue.ToString();
                        if (dk.HinhthucTT == "Tiền mặt")
                        {
                            dk.SoATM = "";
                        }
                        else
                        {
                            dk.SoATM = tbSoTK.EditValue.ToString();
                        }
                        dk.Tygia = Convert.ToInt32(tbTygia.Text.ToString());
                        dk.MaBank = glueNganhang.EditValue.ToString();
                        dk.NgayUT = Convert.ToDateTime(dtDattruoc.EditValue.ToString());
                        db.Dangky.Add(dk);
                        db.SaveChanges();
                        var id = db.Dangky.Where(m => m.DaCheckin == false).OrderByDescending(m => m.Id).First();
                        for (int j = 0; j < gvDangky.RowCount; j++)
                        {
                            GridView dView = gvDangky.GetDetailView(j, 0) as GridView;
                            if (dView == null)
                            {
                                MessageBox.Show("Vui lòng nhập thông tin khách hàng đăng ký!");
                                return;
                            }
                            phong.Trim();
                            phong += gvDangky.GetRowCellValue(j, gvDangky.Columns[0]).ToString();
                            if (j < gvDangky.RowCount - 1)
                                phong += ",";
                            DK_Customer dk_khach = new DK_Customer();
                            Khach khach = new Khach();
                            DangKyPhong dk_phong = new DangKyPhong();
                            for (int i = 0; i < dView.RowCount; i++)
                            {
                                if (dView.GetRowCellValue(i, dView.Columns[0]) != null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                                {
                                    khach.HoTen = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                    khach.SoCMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                    khach.GioiTnh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                    khach.MaQT = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                    khach.NgaySinh = DateTime.Now;
                                    khach.DonVi = "Khách hàng";
                                    if (edtDienThoai.Text == "Nhập số điện thoại")
                                    {
                                        khach.Phone = "";
                                    }
                                    else
                                    {
                                        khach.Phone = edtDienThoai.Text.ToString();
                                    }
                                    db.Khach.Add(khach);
                                    db.SaveChanges();
                                    var idkh = db.Khach.OrderByDescending(m => m.Id).First();
                                    dk_khach.IdDK = id.Id;
                                    dk_khach.IdKH = idkhach;
                                    dk_khach.Hoten = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                    dk_khach.CMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                    dk_khach.Gioitinh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                    dk_khach.Quoctich = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                    dk_khach.Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[0]));
                                    dk_khach.DateCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                    dk_khach.DateCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                    dk_khach.GioCheckin = DateTime.Now.ToShortTimeString();
                                    dk_khach.GioCheckout = "12:00";
                                    db.DK_Customers.Add(dk_khach);
                                    db.SaveChanges();
                                    dk_phong.IDDK = id.Id;
                                    dk_phong.SoPhong = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[0]));
                                    dk_phong.NgayCheckIn = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                    dk_phong.NgayCheckOut = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                    dk_phong.LoaiTien = id.Loaitien;
                                    dk_phong.TyGia = id.Tygia;
                                    dk_phong.GhiChu = id.Ghichu;
                                    dk_phong.DaCheckIn = id.DaCheckin;
                                    dk_phong.DonGia = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[1]));
                                    db.DangKyPhong.Add(dk_phong);
                                }
                            }
                        }
                        txtSo.Text = id.ToString();
                        var update = db.Dangky.FirstOrDefault(m => m.Id == id.Id);
                        update.Phong = phong.ToString();
                        db.SaveChanges();
                        t = 0;
                    }
                    else
                    {
                        var id = Convert.ToInt32(txtSo.Text);
                        var dk = db.Dangky.FirstOrDefault(m => m.Id == id);
                        dk.NgayDK = Convert.ToDateTime(dateNgay.EditValue.ToString());
                        dk.NgayCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                        dk.NgayCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                        dk.SotienUT = Convert.ToDouble(tbDattruoc.Text.ToString());
                        dk.Sokhach = Convert.ToInt32(gvDangky.Columns[2].SummaryItem.SummaryValue);
                        dk.Sophong = Convert.ToInt32(gvDangky.Columns[3].SummaryItem.SummaryValue);
                        dk.DaCheckin = false;
                        dk.Ghichu = tbNoidung.Text.ToString();
                        dk.HinhthucTT = cbHinhthuc.EditValue.ToString();
                        dk.Loaitien = cbxLoai.EditValue.ToString();
                        if (dk.HinhthucTT == "Tiền mặt")
                        {
                            dk.SoATM = "";
                        }
                        else
                        {
                            dk.SoATM = tbSoTK.EditValue.ToString();
                        }
                        dk.Tygia = Convert.ToInt32(tbTygia.Text.ToString());
                        dk.MaBank = glueNganhang.EditValue.ToString();
                        dk.NgayUT = Convert.ToDateTime(dtDattruoc.EditValue.ToString());
                        phong = dk.Phong.ToString();
                        db.SaveChanges();
                        var dkphong = db.DangKyPhong.Where(m => m.IDDK == id).Count();
                        if (gvDangky.RowCount > dkphong)
                        {
                            for (int j = dkphong; j < gvDangky.RowCount; j++)
                            {
                                GridView dView = gvDangky.GetDetailView(j, 0) as GridView;
                                phong.Trim();
                                phong += gvDangky.GetRowCellValue(j, gvDangky.Columns[0]).ToString();
                                if (j < gvDangky.RowCount - 1)
                                    phong += ",";
                                DK_Customer dk_khach = new DK_Customer();
                                Khach khach = new Khach();
                                DangKyPhong dk_phong = new DangKyPhong();
                                for (int i = 0; i < dView.RowCount; i++)
                                {
                                    if (dView.GetRowCellValue(i, dView.Columns[0]) != null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                                    {
                                        khach.HoTen = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                        khach.SoCMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                        khach.GioiTnh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                        khach.MaQT = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                        khach.NgaySinh = DateTime.Now;
                                        khach.DonVi = "Khách hàng";
                                        if (edtDienThoai.Text == "Nhập số điện thoại")
                                        {
                                            khach.Phone = "";
                                        }
                                        else
                                        {
                                            khach.Phone = edtDienThoai.Text.ToString();
                                        }
                                        db.Khach.Add(khach);
                                        db.SaveChanges();
                                        dk_khach.IdDK = id;
                                        dk_khach.IdKH = idkhach;
                                        dk_khach.Hoten = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                        dk_khach.CMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                        dk_khach.Gioitinh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                        dk_khach.Quoctich = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                        dk_khach.Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[0]));
                                        dk_khach.DateCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                        dk_khach.DateCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                        dk_khach.GioCheckin = DateTime.Now.ToShortTimeString();
                                        dk_khach.GioCheckout = "12:00";
                                        db.DK_Customers.Add(dk_khach);
                                        db.SaveChanges();
                                        dk_phong.IDDK = id;
                                        dk_phong.SoPhong = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[0]));
                                        dk_phong.NgayCheckIn = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                        dk_phong.NgayCheckOut = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                        dk_phong.LoaiTien = cbxLoai.EditValue.ToString();
                                        dk_phong.TyGia = Convert.ToInt32(tbTygia.Text.ToString());
                                        dk_phong.GhiChu = tbNoidung.Text.ToString();
                                        dk_phong.DaCheckIn = false;
                                        dk_phong.DonGia = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[1]));
                                        db.DangKyPhong.Add(dk_phong);
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int j = 0; j < gvDangky.RowCount; j++)
                            {
                                var sophong = Convert.ToInt32(gvDangky.GetRowCellValue(j, gvDangky.Columns[0]));
                                var dkkhach = db.DK_Customers.Where(m => m.IdDK == id && m.Sophong == sophong).Count();
                                GridView dView = gvDangky.GetDetailView(j, 0) as GridView;
                                DK_Customer dk_khach = new DK_Customer();
                                Khach khach = new Khach();
                                DangKyPhong dk_phong = new DangKyPhong();
                                int dem = 0;
                                for (int i = 0; i < dView.RowCount; i++)
                                {
                                    if (dView.GetRowCellValue(i, dView.Columns[0]) != null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                                    {
                                        dem++;
                                    }
                                }
                                if (dem > dkkhach)
                                {
                                    for (int i = dkkhach; i < dView.RowCount; i++)
                                    {
                                        if (dView.GetRowCellValue(i, dView.Columns[0]) != null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                                        {
                                            khach.HoTen = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                            khach.SoCMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                            khach.GioiTnh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                            khach.MaQT = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                            khach.NgaySinh = DateTime.Now;
                                            khach.DonVi = "Khách hàng";
                                            if (edtDienThoai.Text == "Nhập số điện thoại")
                                            {
                                                khach.Phone = "";
                                            }
                                            else
                                            {
                                                khach.Phone = edtDienThoai.Text.ToString();
                                            }
                                            db.Khach.Add(khach);
                                            db.SaveChanges();
                                            var idkh = db.Khach.OrderByDescending(m => m.Id == idkhach).First();
                                            dk_khach.IdDK = id;
                                            dk_khach.IdKH = idkhach;
                                            dk_khach.Hoten = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                            dk_khach.CMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                            dk_khach.Gioitinh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                            dk_khach.Quoctich = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]));
                                            dk_khach.Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(i, gvDangky.Columns[0]));
                                            dk_khach.DateCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                            dk_khach.DateCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                            dk_khach.GioCheckin = DateTime.Now.ToShortTimeString();
                                            dk_khach.Sophong = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[4]));
                                            dk_khach.GioCheckout = "12:00";
                                            db.DK_Customers.Add(dk_khach);
                                            db.SaveChanges();
                                        }

                                    }
                                }
                                else if (dem <= dkkhach)
                                {
                                    for (int i = 0; i < dkkhach; i++)
                                    {
                                        if (dView.GetRowCellValue(i, dView.Columns[0]) != null && dView.GetRowCellValue(i, dView.Columns[1]) != null)
                                        {
                                            var iddk = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[5]).ToString());
                                            var editkhach = db.Khach.FirstOrDefault(m => m.Id == idkhach);
                                            if (edtDienThoai.Text == "Nhập số điện thoại")
                                            {
                                                editkhach.Phone = "";
                                            }
                                            else
                                            {
                                                editkhach.Phone = edtDienThoai.Text.ToString();
                                            }
                                            db.SaveChanges();
                                            DK_Customer edit_dkkhach = (from dkcus in db.DK_Customers
                                                                        where dkcus.Id == iddk
                                                                        select dkcus).DefaultIfEmpty().Single();
                                            DK_Customer dkcustomer = new DK_Customer();
                                            dkcustomer.IdKH = idkhach;
                                            dkcustomer.Hoten = dView.GetRowCellValue(i, dView.Columns[1]).ToString();
                                            dkcustomer.CMND = dView.GetRowCellValue(i, dView.Columns[0]).ToString();
                                            dkcustomer.Gioitinh = Convert.ToBoolean(dView.GetRowCellValue(i, dView.Columns[2]));
                                            dkcustomer.Quoctich = Convert.ToInt32(dView.GetRowCellValue(i, dView.Columns[3]).ToString());
                                            dkcustomer.Sophong = Convert.ToInt32(gvDangky.GetRowCellValue(i, gvDangky.Columns[0]));
                                            dkcustomer.DateCheckin = Convert.ToDateTime(dateCheckin.EditValue.ToString());
                                            dkcustomer.DateCheckout = Convert.ToDateTime(dateCheckout.EditValue.ToString());
                                            dkcustomer.GioCheckin = DateTime.Now.ToShortTimeString();
                                            dkcustomer.GioCheckout = "12:00";
                                            edit_dkkhach.CMND = dkcustomer.CMND;
                                            edit_dkkhach.Hoten = dkcustomer.Hoten;
                                            edit_dkkhach.Gioitinh = dkcustomer.Gioitinh;
                                            edit_dkkhach.Quoctich = dkcustomer.Quoctich;
                                            edit_dkkhach.DateCheckin = dkcustomer.DateCheckin;
                                            edit_dkkhach.DateCheckout = dkcustomer.DateCheckout;
                                            edit_dkkhach.IdKH = dkcustomer.IdKH;
                                            db.SaveChanges();
                                        }
                                    }
                                }

                            }
                        }
                        var update = db.Dangky.FirstOrDefault(m => m.Id == id);
                        update.Phong = phong.ToString();
                        db.SaveChanges();
                        t = 0;
                    }

                }
                if (tam == 2)
                {
                    if (txtSo.Text != null)
                    {
                        var id = Convert.ToInt32(txtSo.Text);
                        if (gcDangky.DataSource == null)
                        {
                            var delid = db.Dangky.FirstOrDefault(m => m.Id == id);
                            db.Dangky.Remove(delid);
                            db.SaveChanges();
                            var deldk = db.DK_Customers.FirstOrDefault(m => m.IdDK == id);
                            db.DK_Customers.Remove(deldk);
                            var deldkp = db.DangKyPhong.Where(m => m.IDDK == id).ToList();
                            foreach (var item in deldkp)
                            {
                                db.DangKyPhong.Remove(item);
                            }
                            var listdkp = db.DangKyPhong.Where(m => m.IDDK == id).ToList();
                            foreach (var item in listdkp)
                            {
                                var room = db.Rooms.Where(m => m.Sophong == item.SoPhong).First();
                                room.Status = 1;
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            var dkp = db.DangKyPhong.Where(m => m.IDDK == id).OrderBy(m => m.SoPhong).ToList();
                            if (lstdkp.Count != 0)
                            {
                                foreach (var item in lstdkp)
                                {
                                    db.DangKyPhong.Remove(item);
                                    var deldkk = db.DK_Customers.Where(m => m.Sophong == item.SoPhong).First();
                                    db.DK_Customers.Remove(deldkk);
                                    var room = db.Rooms.Where(m => m.Sophong == item.SoPhong).First();
                                    room.Status = 1;
                                }
                                for (int i = 0; i < gvDangky.RowCount; i++)
                                {
                                    phong.Trim();
                                    phong += gvDangky.GetRowCellValue(i, gvDangky.Columns[0]).ToString();
                                    if (i < gvDangky.RowCount - 1)
                                        phong += ",";
                                }
                                var update = db.Dangky.FirstOrDefault(m => m.Id == id);
                                update.Phong = phong.ToString();
                                db.SaveChanges();
                            }
                            else
                            {
                                foreach (var item in lstdkk)
                                {
                                    db.DK_Customers.Remove(item);
                                }
                                db.SaveChanges();
                            }
                        }
                    }
                }
                MessageBox.Show("Lưu thành công!");
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

        private void tbNoidung_Enter(object sender, EventArgs e)
        {
            if (tbNoidung.Text == "Nội dung đăng kí")
            {
                tbNoidung.Text = "";
            }
        }

        private void tbNoidung_Leave(object sender, EventArgs e)
        {
            if (tbNoidung.Text == "")
            {
                tbNoidung.Text = "Nội dung đăng kí";
            }
        }

        private void PhieuDatPhongMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DanhSachPhieuDP dp = new DanhSachPhieuDP();
            ////dp.LoadData();
            //dp.DanhSachPhieuDP_Load(sender, e);
            
        }
    }
}