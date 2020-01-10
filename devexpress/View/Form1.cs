using devexpress.Model;
using devexpress.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Animation;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace devexpress
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLKSDbContext db = new QLKSDbContext();
        public Form1()
        {
            InitializeComponent();
            cameraControl1.Hide();
            pictureEdit1.Hide();
        }
        public void ViewChildForm(Form form)
        {
            if (!IsFormActived(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Sodophong tt = new Sodophong();
           ViewChildForm(tt);
            txtDate.EditValue = DateTime.Now.ToShortDateString();
            txtGio.EditValue = DateTime.Now.ToShortTimeString();
        }

        private void btnRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPhong tt = new DanhSachPhong();
            
            ViewChildForm(tt);
            tt.Width = this.Width;
        }
        private bool IsFormActived(Form form)
        {
            bool IsOpened = false;
            if(MdiChildren.Count()>0)
            {
                foreach(var item in MdiChildren)
                {
                    if(form.Name==item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                    }
                }
            }
            return IsOpened;
        }
        private void barsubHQKTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HieuQuaKhaiThacPhong tt = new HieuQuaKhaiThacPhong();
            ViewChildForm(tt);
        }

        private void barsubDsPDP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPhieuDP tt = new DanhSachPhieuDP();

            ViewChildForm(tt);

        }

        private void barsubDsChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachChi tt = new DanhSachChi();

            ViewChildForm(tt);

        }

        private void barsubBaoCaoCDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachThu tt = new DanhSachThu();

            ViewChildForm(tt);
        }

        private void barsubDsDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiTac tt = new DoiTac();

            ViewChildForm(tt);
        }

        private void barsubDsKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang tt = new KhachHang();

            ViewChildForm(tt);
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Show();
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanTriNguoiDung tt = new QuanTriNguoiDung();

            ViewChildForm(tt);
        }
        private void btnThietbi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietBiTienNghi tb = new ThietBiTienNghi();
            ViewChildForm(tb);
        }
        private byte[] imageData;
        private void btnKhoa_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void UpdateImageData(Image image)
        {
            DateTime dt = DateTime.Now;
            using (var stream = new System.IO.MemoryStream())
            {
                string filename = @"C:\Users\PC\Desktop\Images\" + count++.ToString()+dt.ToString()+".jpg";
                image.Save(filename);
                imageData = stream.ToArray();
            }
        }

        public byte[] ImageData
        {
            get { return imageData; }
        }

        private void btnChuphinh_Click(object sender, EventArgs e)
        {
            cameraControl1.Show();
            //Image image = cameraControl1.TakeSnapshot();
            //pictureEdit1.EditValue = image;
            //UpdateImageData(image);
        }

        private void btnDichvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuDatPhongMoi dp = new PhieuDatPhongMoi();
            dp.Show();
        }
    }
}
