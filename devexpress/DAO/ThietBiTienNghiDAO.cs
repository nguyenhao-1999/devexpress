using devexpress.Model;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.DAO
{
    class ThietBiTienNghiDAO: QLKSDbContext
    {
        private static ThietBiTienNghiDAO instance;
        public static ThietBiTienNghiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThietBiTienNghiDAO();
                return instance;
            }
        }
        public void NewThietBiTienNghi(ThietBi cus)
        {
            var list = this.ThietBi.ToList();
            this.ThietBi.Add(cus);
            this.SaveChanges();
        }

        public void Xem(GridControl gvThietBi)
        {
            var list = ThietBi.ToList();
            gvThietBi.DataSource = list;
        }

        public void DelThietBiTienNghi(int id)
        {
            ThietBi kh = this.ThietBi.FirstOrDefault(c => c.Id == id);
            this.ThietBi.Remove(kh);
            this.SaveChanges();
        }

        public void EditThietBiTienNghi(ThietBi cus)
        {
            ThietBi kh = this.ThietBi.FirstOrDefault(c => c.Id == cus.Id);
            kh.Id = cus.Id;
            kh.TenTB = cus.TenTB;
            kh.NoiSX =cus.NoiSX;
            kh.DVT = cus.DVT;
            kh.GhiChu = cus.GhiChu;
            this.SaveChanges();
        }
    }
}
