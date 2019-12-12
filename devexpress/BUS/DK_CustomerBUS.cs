using devexpress.DAO;
using devexpress.Model;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devexpress.BUS
{
    
    public class DK_CustomerBUS
    {
        private static DK_CustomerBUS instance;
        public static DK_CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DK_CustomerBUS();
                return instance;
            }
        }
        private DK_CustomerBUS()
        {

        }
        DK_CustomerDAO dao = new DK_CustomerDAO();
        public void NewCustomer(DK_Customer cus)
        {
            dao.NewCustomer(cus);
        }

        public void Xem(GridControl gcDataCheckin,int sophong)
        {
            dao.Xem(gcDataCheckin,sophong);
        }

        public void EditCustomer(DK_Customer cus)
        {
            dao.Edit(cus);
        }

        public void Xoa(int id)
        {
            dao.Xoa(id);
        }
    }
}
