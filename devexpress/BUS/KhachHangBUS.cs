using devexpress.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using devexpress.Model;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using devexpress.DAO;

namespace devexpress.BUS
{
    class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }
        public void NewKhachHang(Khach cus)
        {
            KhachHangDAO.Instance.NewKhachHang(cus);
        }

        public void Xem(GridControl gcKhachHang)
        {
            KhachHangDAO.Instance.Xem(gcKhachHang);
        }

        public void EditKhachHang(Khach cus)
        {
            KhachHangDAO.Instance.EditKhachHang(cus);
        }

        public void DelKhachHang(int id)
        {
            KhachHangDAO.Instance.DelKhachHang(id);
        }
    }
}
