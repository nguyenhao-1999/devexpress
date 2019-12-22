using devexpress.DAO;
using devexpress.Model;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.BUS
{
    class ThietBiTienNghiBUS
    {
        private static ThietBiTienNghiBUS instance;
        public static ThietBiTienNghiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThietBiTienNghiBUS();
                return instance;
            }
        }
        public void NewThietBiTienNghi(ThietBi cus)
        {
            ThietBiTienNghiDAO.Instance.NewThietBiTienNghi(cus);
        }

        public void Xem(GridControl gvThietBi)
        {
            ThietBiTienNghiDAO.Instance.Xem(gvThietBi);
        }

        public void EditThietBiTienNghi(ThietBi cus)
        {
            ThietBiTienNghiDAO.Instance.EditThietBiTienNghi(cus);
        }

        public void DelThietBiTienNghi(int id)
        {
            ThietBiTienNghiDAO.Instance.DelThietBiTienNghi(id);
        }
    }
}
