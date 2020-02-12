using devexpress.Model;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class DanhSachPhieuDP : Form
    {
        public DanhSachPhieuDP()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        public void DanhSachPhieuDP_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var list = (from dkkhach in db.DK_Customers
                        join khach in db.Khach on dkkhach.IdKH equals khach.Id
                        join dk in db.Dangky on dkkhach.IdDK equals dk.Id
                        select new { dk.Id, dk.DaCheckin, dk.Loaitien, dk.MaBank, dk.HinhthucTT, dk.NgayCheckin, dk.Ghichu, dk.NgayCheckout, dk.NgayDK, dk.NgayUT, dk.Phong, dk.SoATM, dk.Sokhach, dk.Sophong, dk.SotienUT, dk.Tygia, khach.HoTen, khach.Phone }).Distinct();
            gcDanhSachPhieuDP.DataSource = list.ToList();
        }
        private void gvDanhsachPhieuDP_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = gvDanhsachPhieuDP.CalcHitInfo(ea.Location);
            if(info.InRow||info.InRowCell)
            {
                PhieuDatPhongMoi pdp = new PhieuDatPhongMoi();
                pdp.StartPosition = FormStartPosition.CenterScreen;
                pdp.txtSo.Text = gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[0]).ToString();
                pdp.dateCheckin.EditValue= Convert.ToDateTime(gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[4])).ToShortDateString();
                pdp.dateCheckout.EditValue= Convert.ToDateTime(gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[5])).ToShortDateString();
                pdp.dateNgay.EditValue= Convert.ToDateTime(gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[1])).ToShortDateString();
                pdp.spSoKhach.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[13]).ToString();
                pdp.spinPhong.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[14]).ToString();
                pdp.edtDienThoai.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[18]).ToString();
                pdp.tbNoidung.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[15]).ToString();
                pdp.tbDattruoc.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[8]).ToString();
                pdp.tbSoTK.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[11]).ToString();
                pdp.tbTygia.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[16]).ToString();
                pdp.glueNganhang.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[10]).ToString();
                pdp.dtDattruoc.EditValue= Convert.ToDateTime(gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[6])).ToShortDateString();
                pdp.cbHinhthuc.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[17]).ToString();
                pdp.cbxLoai.EditValue= gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[9]).ToString();
                var khach = db.Khach.ToList();
                foreach(var item in khach)
                {
                    if(item.HoTen== gvDanhsachPhieuDP.GetRowCellValue(gvDanhsachPhieuDP.FocusedRowHandle, gvDanhsachPhieuDP.Columns[2]).ToString())
                    {
                        pdp.glueDoitac.EditValue =item.Id;
                    }
                }
                var listroom = (from dkp in db.DangKyPhong
                               from dk in db.Dangky
                               where dkp.IDDK==dk.Id
                               select new {dkp.SoPhong,dkp.IDDK}).ToList();
                BindingList<Room> room = new BindingList<Room>();
                foreach(var item in listroom)
                {
                    if(item.IDDK==Convert.ToInt32(pdp.txtSo.Text))
                    {
                        var list = (from r in db.Rooms
                                        where item.SoPhong == r.Sophong 
                                        select new { r.Sophong, r.Sogiuong, r.Songuoi, r.Giaphong}).First();
                        room.Add(new Room() { Sophong=list.Sophong,Sogiuong=list.Sogiuong,Songuoi=list.Songuoi,Giaphong=list.Giaphong});
                    }
                }
                pdp.gcDangky.DataSource = room;
                pdp.p = 1;
                pdp.t = 1;
                pdp.ShowDialog();
                DanhSachPhieuDP_Load(sender, e);
            }
        }
    }
}
