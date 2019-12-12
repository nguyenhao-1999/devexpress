using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.BUS
{
    public class RoomBUS
    {
        private static RoomBUS instance;
        public static RoomBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomBUS();
                return instance;
            }
        }
        private RoomBUS()
        {

        }
        public void Load(int id)
        {

        }

    }
}
