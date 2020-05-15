using devexpress.Model;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.DAO
{
    class KhachHangDAO : QLKSDbContext
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }
        public void NewKhachHang(Khach cus)
        {
            //var list = this.Khach.ToList();
            this.Khach.Add(cus);
            this.SaveChanges();
        }

        public void Xem(GridControl gvKhach)
        {
            var list = Khach.ToList();
            gvKhach.DataSource = list;
        }

        public void DelKhachHang(int id)
        {
            Khach kh = this.Khach.FirstOrDefault(c => c.Id == id);
            this.Khach.Remove(kh);
            this.SaveChanges();
        }

        public void EditKhachHang(Khach cus)
        {
            Khach kh = this.Khach.FirstOrDefault(c => c.Id == cus.Id);
            kh.HoTen = cus.HoTen;
            kh.DonVi = cus.DonVi;
            kh.NgaySinh = cus.NgaySinh;
            kh.GioiTnh = cus.GioiTnh;
            kh.MaQT = cus.MaQT;
            kh.SoCMND = cus.SoCMND;
            kh.DiaChi = cus.DiaChi;
            kh.Phone = cus.Phone;
            kh.Email = cus.Email;
            kh.GhiChu = cus.GhiChu;
            kh.MaBank = cus.MaBank;
            kh.SoATM = cus.SoATM;
            this.SaveChanges();
        }
    }
}
