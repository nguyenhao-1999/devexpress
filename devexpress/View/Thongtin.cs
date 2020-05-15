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
using System.Data.Entity;
using devexpress.Model;
using DevExpress.XtraGrid.Views.Grid;
using devexpress.BUS;
using DevExpress.Office.Crypto;
using DevExpress.XtraTab;

namespace devexpress.View
{
    public partial class Thongtin : DevExpress.XtraEditors.XtraForm
    {
        public Sodophong sodophong;
        QLKSDbContext db = new QLKSDbContext();
        public Thongtin()
        {
            InitializeComponent();
            gvDataCheckin.CustomDrawRowIndicator += gvDataCheckin_CustomDrawRowIndicator;
        }
        int otp = 0;

        private void gvDataCheckin_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {   
            e.Info.DisplayText = "STT";
            if (!gvDataCheckin.IsGroupRow(e.RowHandle))
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
                    BeginInvoke(new MethodInvoker(delegate { cal(width, gvDataCheckin); }));
                }
            }
            else
            {
                e.Info.ImageIndex = -1;
                e.Info.DisplayText = string.Format("[{0}]", (e.RowHandle *-1));
                SizeF size = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 width = Convert.ToInt32(size.Width) + 0;
                BeginInvoke(new MethodInvoker(delegate { cal(width, gvDataCheckin); }));
            }
           
        }
        bool cal(Int32 width,GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < width ? width : view.IndicatorWidth;
            return true;
        }

        private void Thongtin_Load(object sender, EventArgs e)
        {
            loadData();
            DK_CustomerBUS.Instance.Xem(gcDataCheckin,Convert.ToInt32(labPhong.Text));
            //panelControlThemnguoi.Hide();
            btnCheckout.Enabled = false;
            btnThietbi.Enabled = false;
            btnDichvu.Enabled = false;
            dropbtnCapnhat.Enabled = false;
            btnTinhtien.Enabled = false;
            btnIn.Enabled = false;

        }
        private void loadData()
        {
            var listQT = db.Quoctich.ToList();
            LockupEditItemQT.DataSource = listQT;
            LockupEditItemQT.DisplayMember = "TenQT";
            LockupEditItemQT.ValueMember = "Id";
            //colQuoctich.ColumnEdit = LockupEditItemQT;
            lookUpEditQuoctich.Properties.DataSource = listQT;
            lookUpEditQuoctich.Properties.DisplayMember = "TenQT";
            lookUpEditQuoctich.Properties.ValueMember = "Id";

        }
        int t = 0;
        int idkh = 0;
        private void Imformation_Selecting(object sender, DevExpress.XtraTab.TabPageCancelEventArgs e)
        {
            if(e.Page==tabpageCheckin)
            {
                btnThemnguoi.Enabled = true;
                btnCheckout.Enabled = false;
                btnThietbi.Enabled = false;
                btnDichvu.Enabled = false;
                dropbtnCapnhat.Enabled = false;
                btnTinhtien.Enabled = false;
                btnIn.Enabled = false;
                panelControlThemnguoi.Show();
                t = 0;
            }
            else if(e.Page==tabPhucvuphong)
            {
                btnThemnguoi.Enabled = false;
                btnCheckout.Enabled = false;
                btnThietbi.Enabled = false;
                dropbtnCapnhat.Enabled = false;
                btnTinhtien.Enabled = false;
                btnIn.Enabled = false;
                btnDelete.Enabled = true;
                panelControlThemnguoi.Hide();
                gcBaothuc.Height = 276;
                var idphong = Convert.ToInt32(labPhong.Text);
                var listdk = db.DK_Customers.Where(m => m.Sophong == idphong).Count();
                if(listdk>0)
                {
                    btnDichvu.Enabled = true;
                    var listdv = (from dvs in db.DichVu
                                  from dvp in db.PhongDVs
                                  where dvs.MaDV == dvp.MaDV && dvp.IdPhong == idphong
                                  select new {dvp.Id,dvp.Ngay, dvp.Gio, dvp.MaDV, dvp.Soluong, dvp.Thanhtien, dvs.DVT, dvs.TenDV }).ToList();
                    gcListDichvu.DataSource = listdv;
                    var listbt = db.BaoThuc.Where(m => m.IdPhong == idphong).ToList();
                    gcBaothuc.DataSource = new BindingList<BaoThuc>(listbt) { AllowNew=true};
                    gvBaothuc.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                }
                else
                {
                    btnDichvu.Enabled = false;
                }
                t = 1;
            }
            else if(e.Page==tabCheckout)
            {
                btnCheckout.Enabled = true;
                dropbtnCapnhat.Enabled = true;
                btnTinhtien.Enabled = true;
                btnThemnguoi.Enabled = false;
                btnDichvu.Enabled = false;
                panelControlThemnguoi.Hide();
                gcCheckout.DataSource = lstCheckout();
                t = 2;
            }
            else if(e.Page==tabThietbi)
            {
                btnThietbi.Enabled = true;
                btnThemnguoi.Enabled = false;
                btnCheckout.Enabled = false;
                btnDichvu.Enabled = false;
                dropbtnCapnhat.Enabled = false;
                btnTinhtien.Enabled = false;
                btnIn.Enabled = false;
                panelControlThemnguoi.Hide();
                t = 3;
            }
            else
            {
                btnThemnguoi.Enabled = false;
                btnCheckout.Enabled = false;
                btnThietbi.Enabled = false;
                btnDichvu.Enabled = false;
                dropbtnCapnhat.Enabled = false;
                btnTinhtien.Enabled = false;
                btnIn.Enabled = false;
                panelControlThemnguoi.Hide();
                var roomstatus = db.RoomStatus.ToList();
                cbTrangthai.DataSource = roomstatus;
                cbTrangthai.DisplayMember = "NameStatus";
                cbTrangthai.ValueMember = "Status";
                var phongsc = db.PhongS.ToList();
                gcSuachua.DataSource = new BindingList<PhongS>(phongsc) { AllowNew = true };
                t = 4;
            }
        }
        public BindingList<Thanhtoan> lstCheckout()
        {
            BindingList<Thanhtoan> tt = new BindingList<Thanhtoan>();
            tt.Add(new Thanhtoan("Tiền phòng:", "Ngày","","",""));
            tt.Add(new Thanhtoan("Phụ thu tiền phòng:", "Giờ","","",""));
            tt.Add(new Thanhtoan("Dịch vụ:", "","","",""));
            tt.Add(new Thanhtoan("Điện thoại:", "","","",""));
            tt.Add(new Thanhtoan("Nhà hàng:", "","","",""));
            tt.Add(new Thanhtoan("Chiết khấu(%):", "","","",""));
            tt.Add(new Thanhtoan("Chiết khấu(Tiền mặt):", "","","",""));
            tt.Add(new Thanhtoan("Tổng tiền thanh toán:", "","","",""));
            tt.Add(new Thanhtoan("Đã thu:", "","","",""));
            tt.Add(new Thanhtoan("Còn lại:", "","","",""));
            tt.AllowNew = true;
            return tt;
        }
        public class Thanhtoan
        {
            public Thanhtoan() { }
            public Thanhtoan(string km, string dvt, string sl, string dg, string sotien)
            {
                Khoanmuc = km;
                DVT = dvt;
                SL = sl;
                Dongia = dg;
                Sotien = sotien;
            }
            public string Khoanmuc { get; set; }
            public string DVT { get; set; }
            public string SL { get; set; }
            public string Dongia { get; set; }
            public string Sotien { get; set; }

        }

        private void btnThemnguoi_Click(object sender, EventArgs e)
        {
            otp = 1;
            txtCmnd.Focus();
            gcDataCheckin.Enabled = false;
            btnLuu.Enabled = true;
            btnDelete.Enabled = false;
            var dt = DateTime.Now;
            txtCmnd.Text = null;
            txtHoten.Text = null;
            cbGioitinh.Checked = false;
            cbDaidien.Checked = false;
            lookUpEditQuoctich.Properties.NullText = @"Chọn quốc tịch";
            dateEditCheckin.EditValue = dt.ToShortDateString();
            txtGioCheckin.Text = dt.ToShortTimeString();
            dateEditCheckout.EditValue = dt.AddDays(1).ToShortDateString();
            txtGioCheckout.EditValue = "12:00";
            memoEditGhichu.Text = null;
            
        }

        public void PostData(Room room)
        {
            labPhong.Text = room.Sophong.ToString();
        }
        public delegate void GetData(List<DK_Customer> kh);

        private void Thongtin_FormClosing(object sender, FormClosingEventArgs e)
        {
            sodophong = new Sodophong();
            Thongtin_Load(sender, e);
            var list = db.DK_Customers.ToList();
            GetData data = new GetData(sodophong.PostData);
            data(list);
            
        }
        //public void Thongtin_RowEnter()
        //{
        //    for (int i = 0; i < gvDataCheckin.RowCount; i++)
        //    {
        //        txtCmnd.Text = gvDataCheckin.GetRowCellValue(i, "CMND").ToString();
        //        txtHoten.Text = gvDataCheckin.GetRowCellValue(i, "Hoten").ToString();
        //    }
        //}

        private void gvDataCheckin_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            var list = db.Quoctich.ToList();
            bool checkedGioitinh = (bool)gvDataCheckin.GetRowCellValue(e.RowHandle, "Gioitinh");
            bool checkedDaidien = (bool)gvDataCheckin.GetRowCellValue(e.RowHandle, "Daidien");
            idkh = Convert.ToInt32(gvDataCheckin.GetRowCellValue(e.RowHandle, "IdKH"));
            if (e.RowHandle == gvDataCheckin.FocusedRowHandle && e.Column == colCMND)
            {
                txtCmnd.Text = gvDataCheckin.GetRowCellValue(e.RowHandle, "CMND").ToString();
                txtHoten.Text = gvDataCheckin.GetRowCellValue(e.RowHandle, "Hoten").ToString();
                if (checkedGioitinh == true)
                {
                    cbGioitinh.Checked = true;
                }
                else
                {
                    cbGioitinh.Checked = false;
                }
                if(checkedDaidien==true)
                {
                    cbDaidien.Checked = true;
                }
                else
                {
                    cbDaidien.Checked = false;
                }
                foreach(var item in list)
                {
                    if(item.Id== Convert.ToInt32(gvDataCheckin.GetRowCellValue(e.RowHandle, "Quoctich").ToString()))
                    {
                        lookUpEditQuoctich.EditValue = Convert.ToInt32(gvDataCheckin.GetRowCellValue(e.RowHandle, "Quoctich").ToString());
                        lookUpEditQuoctich.Properties.NullText = item.TenQT;
                    }
                }
                DateTime dtCheckin = new DateTime();
                dtCheckin = (DateTime)gvDataCheckin.GetRowCellValue(e.RowHandle, "DateCheckin");
                dateEditCheckin.EditValue = dtCheckin.ToShortDateString();
                dateEditCheckin.DateTime.ToShortDateString();
                DateTime dtCheckout = new DateTime();
                dtCheckout = (DateTime)gvDataCheckin.GetRowCellValue(e.RowHandle, "DateCheckout");
                dateEditCheckout.EditValue = dtCheckout.ToShortDateString();
                dateEditCheckout.DateTime.ToShortDateString();
                txtGioCheckin.Text= gvDataCheckin.GetRowCellValue(e.RowHandle, "GioCheckin").ToString();
                txtGioCheckout.Text = gvDataCheckin.GetRowCellValue(e.RowHandle, "GioCheckout").ToString();
                var listKH = db.DK_Customers.ToList();
                foreach(var item in listKH)
                {
                    if(item.Id== Convert.ToInt32(gvDataCheckin.GetRowCellValue(e.RowHandle, "Id").ToString()))
                    {
                        if(item.Ghichu!=null)
                        {
                            memoEditGhichu.Text = gvDataCheckin.GetRowCellValue(e.RowHandle, "Ghichu").ToString();
                        }
                        else
                        {
                            memoEditGhichu.Text = null;
                        }
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (t == 0)
            {
                if (txtCmnd.Text == "")
                {
                    MessageBox.Show("CMND không được để trống!");
                    return;
                }
                var list = db.DK_Customers.ToList();
                DK_Customer khachhang = new DK_Customer();
                Khach khach = new Khach();
                //khachhang.Id = k;
                khachhang.Id = Convert.ToInt32(gvDataCheckin.GetRowCellValue(gvDataCheckin.FocusedRowHandle, "Id"));
                khachhang.CMND = txtCmnd.Text.ToString().Trim();
                khachhang.Hoten = txtHoten.Text.ToString().Trim();
                khachhang.Quoctich = Convert.ToInt32(lookUpEditQuoctich.EditValue);
                if (cbGioitinh.Checked == true)
                {
                    khachhang.Gioitinh = true;
                }
                else
                {
                    khachhang.Gioitinh = false;
                }
                if (cbDaidien.Checked == true)
                {
                    khachhang.Daidien = true;
                }
                else
                {
                    khachhang.Daidien = false;
                }
                khachhang.DateCheckin = Convert.ToDateTime(dateEditCheckin.EditValue);
                khachhang.GioCheckin = txtGioCheckin.Text.ToString().Trim();
                khachhang.DateCheckout = Convert.ToDateTime(dateEditCheckout.EditValue);
                khachhang.GioCheckout = txtGioCheckout.Text.ToString().Trim();
                khachhang.Ghichu = memoEditGhichu.Text.ToString().Trim();
                khachhang.Sophong = Convert.ToInt32(labPhong.Text);
                khach.DonVi = "Khách hàng";
                khach.SoCMND = khachhang.CMND;
                khach.HoTen = khachhang.Hoten;
                khach.MaQT = khachhang.Quoctich;
                khach.GioiTnh = khachhang.Gioitinh;
                khach.MaBank = "";
                khach.NgaySinh = Convert.ToDateTime("01-01-1900");
                khach.Phone = "";
                khach.SoATM = 0;
                khach.GhiChu = "";
                db.DK_Customers.Add(khachhang);
                if (otp == 1)
                {
                    KhachHangBUS.Instance.NewKhachHang(khach);
                    var idkh = db.Khach.OrderByDescending(m => m.Id).First();
                    khachhang.IdKH = idkh.Id;
                    DK_CustomerBUS.Instance.NewCustomer(khachhang);
                    DK_CustomerBUS.Instance.Xem(gcDataCheckin, Convert.ToInt32(labPhong.Text));
                    MessageBox.Show("Thêm thành công!");
                    gcDataCheckin.Enabled = true;
                    btnThemnguoi.Enabled = true;
                    sodophong = new Sodophong();
                    Thongtin_Load(sender, e);
                    GetData data = new GetData(sodophong.PostData);
                    data(list);
                    otp = 0;
                    btnDelete.Enabled = true;

                }
                else
                {
                    khach.Id = idkh;
                    DK_CustomerBUS.Instance.EditCustomer(khachhang);
                    KhachHangBUS.Instance.EditKhachHang(khach);
                    DK_CustomerBUS.Instance.Xem(gcDataCheckin, Convert.ToInt32(labPhong.Text));
                    MessageBox.Show("Sửa thành công!");
                    gcDataCheckin.Enabled = true;
                    btnThemnguoi.Enabled = true;
                }
            }
            else if(t==1)
            {
                    if (gvListDichvu.DataSource != null)
                    {
                        for (int i = 0; i < gvListDichvu.RowCount; i++)
                        {
                            int id = Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[0]));
                            var pdv = db.PhongDVs.FirstOrDefault(c => c.Id == id);
                            if (pdv.Soluong > Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6])))
                            {
                                pdv.Soluong = pdv.Soluong - Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6]));
                                if (pdv.Loaitien == "VNĐ")
                                {
                                    pdv.Thanhtien = pdv.Soluong * pdv.DonGia;
                                }
                                else
                                {
                                    pdv.Thanhtien = pdv.Soluong * pdv.DonGia * pdv.Tygia;
                                }
                                var dv = db.DichVu.FirstOrDefault(c => c.MaDV == pdv.MaDV);
                                dv.SoLuong += Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6]));
                                db.SaveChanges();
                            }
                            else if (pdv.Soluong < Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6])))
                            {
                                pdv.Soluong = pdv.Soluong + Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6]));
                                if (pdv.Loaitien == "VNĐ")
                                {
                                    pdv.Thanhtien = pdv.Soluong * pdv.DonGia;
                                }
                                else
                                {
                                    pdv.Thanhtien = pdv.Soluong * pdv.DonGia * pdv.Tygia;
                                }
                                var dv = db.DichVu.FirstOrDefault(c => c.MaDV == pdv.MaDV);
                                dv.SoLuong -= Convert.ToInt32(gvListDichvu.GetRowCellValue(i, gvListDichvu.Columns[6]));
                                db.SaveChanges();
                            }
                        }
                    }
                    if (gcBaothuc.DataSource != null)
                    {
                        for (int i = 0; i < gvBaothuc.RowCount-1; i++)
                        {
                            var id = Convert.ToInt32(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[4]));
                            var bt = db.BaoThuc.Where(m => m.Id == id).Count();
                            if(bt!=0)
                            {
                                var editbt = db.BaoThuc.FirstOrDefault(m => m.Id == id);
                                editbt.Ngay= Convert.ToDateTime(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[0]));
                                editbt.Gio= gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[1]).ToString();
                                editbt.NoiDung= gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[2]).ToString();
                                editbt.Lap= gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[3]).ToString();
                                db.SaveChanges();
                            }
                            else
                            {
                                BaoThuc addbt = new BaoThuc();
                                addbt.IdPhong = Convert.ToInt32(labPhong.Text);
                                addbt.Ngay = Convert.ToDateTime(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[0]));
                                addbt.Gio =Convert.ToString(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[1]));
                                addbt.NoiDung = Convert.ToString(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[2]));
                                addbt.Lap = Convert.ToString(gvBaothuc.GetRowCellValue(i, gvBaothuc.Columns[3]));
                                db.BaoThuc.Add(addbt);
                                db.SaveChanges();
                            }
                        }
                    }
            }
            else if(t==4)
            {
                if (gcSuachua.DataSource != null)
                {
                    for (int i = 0; i < gvSuachua.RowCount - 1; i++)
                    {
                        var id = Convert.ToInt32(gvSuachua.GetRowCellValue(i, gvSuachua.Columns[0]));
                        var sc = db.PhongS.Where(m => m.Id == id).Count();
                        if (sc != 0)
                        {
                            var editsc = db.PhongS.FirstOrDefault(m => m.Id == id);
                            editsc.MaStatus = ma;
                            editsc.Tungay = tungay;
                            editsc.Denngay = denngay;
                            db.SaveChanges();
                        }
                        else
                        {
                            PhongS addsc = new PhongS();
                            addsc.Sophong = Convert.ToInt32(labPhong.Text);
                            addsc.MaStatus = ma;
                            addsc.Tungay = tungay;
                            addsc.Denngay = denngay;
                            db.PhongS.Add(addsc);
                            db.SaveChanges();
                        }
                    }
                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa hay không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (t == 0)
                {
                    if(gvDataCheckin.FocusedRowHandle<0)
                    {
                        MessageBox.Show("Vui lòng chọn dòng để xóa");
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(gvDataCheckin.GetRowCellValue(gvDataCheckin.FocusedRowHandle, "Id"));
                        DK_CustomerBUS.Instance.Xoa(id);
                        DK_CustomerBUS.Instance.Xem(gcDataCheckin, Convert.ToInt32(labPhong.Text));
                    }
                }
                else if(t==1)
                {
                    var idphong = Convert.ToInt32(labPhong.Text);
                        if (gvListDichvu.FocusedRowHandle < 0 && gvBaothuc.FocusedRowHandle<0)
                        {
                            MessageBox.Show("Vui lòng chọn dòng để xóa");
                            return;
                        }
                        else if(mouse==1)
                        {
                            int id = Convert.ToInt32(gvListDichvu.GetRowCellValue(gvListDichvu.FocusedRowHandle, gvListDichvu.Columns[0]));
                            var pdv = db.PhongDVs.FirstOrDefault(c => c.Id == id);
                            db.PhongDVs.Remove(pdv);
                            var dv = db.DichVu.FirstOrDefault(c => c.MaDV == pdv.MaDV);
                            dv.SoLuong += pdv.Soluong;
                            db.SaveChanges();
                            var listdv = (from dvs in db.DichVu
                                          from dvp in db.PhongDVs
                                          where dvs.MaDV == dvp.MaDV && dvp.IdPhong == idphong
                                          select new { dvp.Id, dvp.Ngay, dvp.Gio, dvp.MaDV, dvp.Soluong, dvp.Thanhtien, dvs.DVT, dvs.TenDV }).ToList();
                            gcListDichvu.DataSource = listdv;
                        }
                        else if(mouse==2)
                        {
                            int id = Convert.ToInt32(gvBaothuc.GetRowCellValue(gvBaothuc.FocusedRowHandle, gvBaothuc.Columns[4]));
                            var bt = db.BaoThuc.FirstOrDefault(c => c.Id == id);
                            db.BaoThuc.Remove(bt);
                            db.SaveChanges();
                            var listbt = db.BaoThuc.Where(m => m.IdPhong == idphong).ToList();
                            gcBaothuc.DataSource = new BindingList<BaoThuc>(listbt) { AllowNew = true };
                            gvBaothuc.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                        }
                }
                else if (t == 4)
                {
                    if (gvSuachua.FocusedRowHandle < 0)
                    {
                        MessageBox.Show("Vui lòng chọn dòng để xóa");
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(gvSuachua.GetRowCellValue(gvSuachua.FocusedRowHandle, "Id"));
                        var sc = db.PhongS.FirstOrDefault(c => c.Id == id);
                        db.PhongS.Remove(sc);
                    }
                }
                MessageBox.Show("Xóa thành công!");
            }
        }
        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateCheckout.EditValue = dt.ToShortDateString();
            txtTimeCheckout.EditValue = dt.ToShortTimeString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            dateCheckout.EditValue = DateTime.Now.Date.ToShortDateString();
            txtTimeCheckout.EditValue = DateTime.Now.TimeOfDay.Hours+":"+DateTime.Now.TimeOfDay.Minutes;
            var sldate = DateTime.Now.Date - Convert.ToDateTime(dateCheckin.EditValue);
            gvCheckout.SetRowCellValue(0, gvCheckout.Columns[2], sldate.Days);
            if(txtGiaphong.Text!="")
            {
                gvCheckout.SetRowCellValue(0, gvCheckout.Columns[3], txtGiaphong.EditValue);
                gvCheckout.SetRowCellValue(0, gvCheckout.Columns[4], Convert.ToInt32(txtGiaphong.EditValue)*Convert.ToInt32(sldate.Days));
            }
            decimal tong = 0;
            for(int i=0;i<7;i++)
            {
                if(gvCheckout.GetRowCellValue(i,gvCheckout.Columns[4]).ToString()!="")
                {
                    tong += Convert.ToDecimal(Convert.ToDecimal(gvCheckout.GetRowCellValue(0, gvCheckout.Columns[4])));
                }
            }
            gvCheckout.SetRowCellValue(7, gvCheckout.Columns[4], tong);
        }

        private void cbLoaitien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoaitien.SelectedIndex==0)
            {
                txtTygia.EditValue = 1;
            }
            else
            {
                txtTygia.EditValue = 22000;
            }
        }

        private void txtGiaphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            ChonDV cdv = new ChonDV();
            cdv.StartPosition = FormStartPosition.CenterScreen;
            cdv.idphong = Convert.ToInt32(labPhong.Text);
            cdv.loaitien = cbLoaitien.Text;
            cdv.tygia = Convert.ToInt32(txtTygia.Text);
            cdv.ShowDialog();
            var idphong = Convert.ToInt32(labPhong.Text);
            var listdv = (from dvs in db.DichVu
                          from dvp in db.PhongDVs
                          where dvs.MaDV == dvp.MaDV && dvp.IdPhong == idphong
                          select new { dvp.Id,dvp.Ngay, dvp.Gio, dvp.MaDV, dvp.Soluong, dvp.Thanhtien, dvs.DVT, dvs.TenDV }).ToList();
            gcListDichvu.DataSource = listdv;
        }

        private void gvBaothuc_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvBaothuc.AddNewRow();
            gvBaothuc.SetRowCellValue(e.RowHandle, gvBaothuc.Columns[2], "Báo thức");
            gvBaothuc.SetRowCellValue(e.RowHandle, gvBaothuc.Columns[3], "Hằng ngày");
        }
        int mouse = 0;
        private void gcListDichvu_Enter(object sender, EventArgs e)
        {
            mouse = 1;
        }

        private void gcBaothuc_Enter(object sender, EventArgs e)
        {
            mouse = 2;
        }
        private void gvSuachua_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvSuachua.AddNewRow();
        }
        DateTime tungay = new DateTime();
        DateTime denngay = new DateTime();
        int ma = 0;
        private void gvSuachua_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            tungay = Convert.ToDateTime(gvSuachua.GetRowCellValue(e.RowHandle, gvSuachua.Columns[2]));
            denngay = Convert.ToDateTime(gvSuachua.GetRowCellValue(e.RowHandle, gvSuachua.Columns[3]));
            ma= Convert.ToInt32(gvSuachua.GetRowCellValue(e.RowHandle, gvSuachua.Columns[1]));
        }
    }
}