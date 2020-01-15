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
            }
            else if(e.Page==tabPhucvuphong)
            {
                btnThemnguoi.Enabled = false;
                btnDichvu.Enabled = true;
                btnCheckout.Enabled = false;
                btnThietbi.Enabled = false;
                dropbtnCapnhat.Enabled = false;
                btnTinhtien.Enabled = false;
                btnIn.Enabled = false;
                panelControlThemnguoi.Hide();
                gridControl4.Height = 276;
            }
            else if(e.Page==tabCheckout)
            {
                btnCheckout.Enabled = true;
                dropbtnCapnhat.Enabled = true;
                btnTinhtien.Enabled = true;
                btnThemnguoi.Enabled = false;
                btnDichvu.Enabled = false;
                panelControlThemnguoi.Hide();
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
            }
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
            //int k = 0;
            //for (int i = 0; i < gvDataCheckin.RowCount; i++)
            //{
            //    if (Convert.ToInt32(gvDataCheckin.GetRowCellValue(gvDataCheckin.FocusedRowHandle,"Id")) > k)
            //        k = Convert.ToInt32(gvDataCheckin.GetRowCellValue(gvDataCheckin.FocusedRowHandle, "Id"));
            //}
            //k = k + 1;
            if(txtCmnd.Text=="")
            {
                MessageBox.Show("CMND không được để trống!");
                return;
            }
            var list = db.DK_Customers.ToList();
            DK_Customer khachhang = new DK_Customer();
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
            khachhang.DateCheckin =Convert.ToDateTime(dateEditCheckin.EditValue);
            khachhang.GioCheckin = txtGioCheckin.Text.ToString().Trim();
            khachhang.DateCheckout = Convert.ToDateTime(dateEditCheckout.EditValue);
            khachhang.GioCheckout = txtGioCheckout.Text.ToString().Trim();
            khachhang.Ghichu = memoEditGhichu.Text.ToString().Trim();
            khachhang.Sophong = Convert.ToInt32(labPhong.Text);
            //db.DK_Customers.Add(khachhang);
            if (otp==1)
            {
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
               
            }
            else
            {
                DK_CustomerBUS.Instance.EditCustomer(khachhang);
                DK_CustomerBUS.Instance.Xem(gcDataCheckin, Convert.ToInt32(labPhong.Text));
                MessageBox.Show("Sửa thành công!");
                gcDataCheckin.Enabled = true;
                btnThemnguoi.Enabled = true;
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa hay không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int id= Convert.ToInt32(gvDataCheckin.GetRowCellValue(gvDataCheckin.FocusedRowHandle, "Id"));
                DK_CustomerBUS.Instance.Xoa(id);
                DK_CustomerBUS.Instance.Xem(gcDataCheckin, Convert.ToInt32(labPhong.Text));
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
    }
}