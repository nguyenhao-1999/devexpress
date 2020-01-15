using devexpress.Model;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.DAO
{
   public class DichVuDAO: QLKSDbContext
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuDAO();
                return instance;
            }
        }
        public void NewDichVu(DichVu cus)
        {
            var list = this.DichVu.ToList();
            this.DichVu.Add(cus);
            this.SaveChanges();
        }

        public void Xem(GridControl gcDichVu)
        {
            var list = DichVu.ToList();
            gcDichVu.DataSource = list;
        }

        public void DelDichVu(int id)
        {
            DichVu kh = this.DichVu.FirstOrDefault(c => c.Id == id);
            this.DichVu.Remove(kh);
            this.SaveChanges();
        }

        public void EditDichVu(DichVu cus)
        {
            DichVu kh = this.DichVu.FirstOrDefault(c => c.Id == cus.Id);
            kh.MaDV = cus.MaNhom;
            kh.MaNhom = cus.MaNhom;
            kh.TenDV = cus.TenDV;
            kh.DVT = cus.DVT;
            kh.SoLuong = cus.SoLuong;
            kh.GiaNhapCuoi = cus.GiaNhapCuoi;
            this.SaveChanges();
        }
    
    }
}
