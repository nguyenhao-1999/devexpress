using devexpress.Model;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.DAO
{
    public class DanhsachnhomphongDAO:QLKSDbContext
    {
        private static DanhsachnhomphongDAO instance;
        public static DanhsachnhomphongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhsachnhomphongDAO();
                return instance;
            }
        }
        public void NewDanhsachnhomphong(RoomTang cus)
        {
            var list = this.RoomTangs.ToList();
            this.RoomTangs.Add(cus);
            this.SaveChanges();
        }

        public void Xem(GridControl gcNhomphong)
        {
            var list = RoomTangs.ToList();
            gcNhomphong.DataSource = list;
        }

        public void DelDanhsachnhomphong(int id)
        {
            RoomTang kh = this.RoomTangs.FirstOrDefault(c => c.Manhom == id);
            this.RoomTangs.Remove(kh);
            this.SaveChanges();
        }

        public void EditDanhsachnhomphong(RoomTang cus)
        {
            RoomTang kh = this.RoomTangs.FirstOrDefault(c => c.Manhom == cus.Manhom);
            var mamau = cus.Mamau;
            kh.Vitri = cus.Vitri;
            kh.Mamau = mamau;
            this.SaveChanges();
        }
    }
}
