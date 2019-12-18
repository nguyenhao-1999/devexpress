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
    public class DanhsachnhomphongBUS
    {
        private static DanhsachnhomphongBUS instance;
        public static DanhsachnhomphongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhsachnhomphongBUS();
                return instance;
            }
        }
        public void NewDanhsachnhomphong(RoomTang cus)
        {
            DanhsachnhomphongDAO.Instance.NewDanhsachnhomphong(cus);
        }

        public void Xem(GridControl gcNhomphong)
        {
            DanhsachnhomphongDAO.Instance.Xem(gcNhomphong);
        }

        public void EditDanhsachnhomphong(RoomTang cus)
        {
            DanhsachnhomphongDAO.Instance.EditDanhsachnhomphong(cus);
        }

        public void DelDanhsachnhomphong(int id)
        {
            DanhsachnhomphongDAO.Instance.DelDanhsachnhomphong(id);
        }
    }
}
