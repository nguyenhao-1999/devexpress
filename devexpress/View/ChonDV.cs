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
using DevExpress.XtraTab;

namespace devexpress.View
{
    public partial class ChonDV : DevExpress.XtraEditors.XtraForm
    {
        public ChonDV()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        List<DichVu> lstdv = new List<DichVu>();
        private void ChonDV_Load(object sender, EventArgs e)
        {
            var list = db.DichVu.ToList();
            gcDichvu.DataSource = list;
            foreach(var item in list)
            {
                DichVu dv = new DichVu();
                dv.MaDV = item.MaDV;
                dv.Id = item.Id;
                dv.MaNhom = item.MaNhom;
                dv.SoLuong = item.SoLuong;
                dv.GiaNhapCuoi = item.GiaNhapCuoi;
                dv.GiaBinhQuan = item.GiaBinhQuan;
                dv.DVT = item.DVT;
                dv.TenDV = item.TenDV;
                dv.Note = item.Note;
                lstdv.Add(dv);
            }
            for(int i=0;i<gvDichvu.RowCount;i++)
            {
                gvDichvu.SetRowCellValue(i, gvDichvu.Columns[4], 0);
            }
        }
        private void txtLoc_Enter(object sender, EventArgs e)
        {
            txtLoc.Text = "";
        }

        private void txtLoc_Leave(object sender, EventArgs e)
        {
            if (txtLoc.Text == "")
            {
                txtLoc.Text = "Chọn tên (mã) để lọc dữ liệu";
                var list = db.DichVu.ToList();
                gcDichvu.DataSource = list;
            }
        }
        private void txtLoc_KeyUp(object sender, KeyEventArgs e)
        {
            var text = txtLoc.EditValue.ToString();
            if (text == "")
            {
                ChonDV_Load(sender, e);
            }
            else
            {
                if (rgLoc.SelectedIndex == 0)
                {
                    var list = db.DichVu.Where(m => m.TenDV.ToLower().Contains(text.ToLower())).ToList();
                    gcDichvu.BeginUpdate();
                    gcDichvu.DataSource = list;
                    gcDichvu.EndUpdate();
                }
                else
                {
                    var list = db.DichVu.Where(m => m.MaDV.ToLower().Contains(text.ToLower())).ToList();
                    gcDichvu.BeginUpdate();
                    gcDichvu.DataSource = list;
                    gcDichvu.EndUpdate();
                }
            }
        }
        public int idphong;
        public string loaitien;
        public int tygia;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<int> row = gvDichvu.GetSelectedRows().Where(m => m >= 0).ToList();
            foreach (var i in lstdv)
            {
                foreach (var item in row)
                {
                    if (i.Id == Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[5])))
                    {
                        if (Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[4])) <= 0)
                        {
                            MessageBox.Show("Vui lòng chọn số lượng của dịch vụ!");
                            return;
                        }
                        Thongtin tt = new Thongtin();
                        PhongDV pdv = new PhongDV();
                        pdv.MaDV = gvDichvu.GetRowCellValue(item, gvDichvu.Columns[0]).ToString();
                        pdv.IdPhong = idphong;
                        pdv.Soluong = Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[4]));
                        pdv.Loaitien = loaitien;
                        if (pdv.Loaitien == "USD")
                        {
                            pdv.DonGia = Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[3])) * 22000;
                        }
                        else
                        {
                            pdv.DonGia = Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[3]));
                        }
                        if(Convert.ToString(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[2])) != "")
                        {
                            pdv.Thanhtien = pdv.Soluong * pdv.DonGia;
                        }
                        else
                        {
                            pdv.Thanhtien = pdv.DonGia;
                        }
                        pdv.Tygia = tygia;
                        pdv.Ngay = DateTime.Now.Date;
                        pdv.Gio = DateTime.Now.ToShortTimeString();
                        pdv.Ghichu = "";
                        var p_dv = db.PhongDVs.Where(m => m.MaDV == pdv.MaDV && m.IdPhong == pdv.IdPhong).Count();
                        if (p_dv != 0)
                        {
                            var editpdv = db.PhongDVs.Where(m => m.MaDV == pdv.MaDV && m.IdPhong == pdv.IdPhong).First();
                            editpdv.Soluong += pdv.Soluong;
                            db.SaveChanges();
                        }
                        else
                        {
                            db.PhongDVs.Add(pdv);
                            db.SaveChanges();
                        }
                        var sl = Convert.ToInt32(gvDichvu.GetRowCellValue(item, gvDichvu.Columns[4]));
                        var dv = db.DichVu.Where(m => m.Id == i.Id).First();
                        dv.SoLuong = i.SoLuong-sl;
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        var editsl = db.DichVu.Where(m => m.Id == i.Id).First();
                        editsl.SoLuong = i.SoLuong;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void spSoluong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            foreach(var item in lstdv)
            {
                if(item.Id== Convert.ToInt32(gvDichvu.GetRowCellValue(gvDichvu.FocusedRowHandle, gvDichvu.Columns[5])))
                {
                    if(Convert.ToInt32(e.NewValue)>=item.SoLuong)
                    {
                        MessageBox.Show("Số lượng trong kho đã hết!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.NewValue = item.SoLuong;
                        return;
                    }
                }
            }
        }
    }
}