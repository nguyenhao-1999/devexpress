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
   public class DichVuBUS
    {
        private static DichVuBUS instance;
        public static DichVuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuBUS();
                return instance;
            }
        }
        public void NewDichVu(DichVu cus)
        {
            DichVuDAO.Instance.NewDichVu(cus);
        }

        public void Xem(GridControl gcDichVu)
        {
            DichVuDAO.Instance.Xem(gcDichVu);
        }

        public void EditDichVu(DichVu cus)
        {
            DichVuDAO.Instance.EditDichVu(cus);
        }

        public void DelDichVu(int id)
        {
            DichVuDAO.Instance.DelDichVu(id);
        }
    }
}
