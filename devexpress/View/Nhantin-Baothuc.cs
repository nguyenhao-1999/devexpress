using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using devexpress.Model;

namespace devexpress.View
{
    public partial class Nhantin_Baothuc : DevExpress.XtraEditors.XtraForm
    {
        public Nhantin_Baothuc()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        private void Nhantin_Baothuc_Load(object sender, EventArgs e)
        {
            tmClock.Start();
        }
        int a = 0;
        private void tmClock_Tick(object sender, EventArgs e)
        {
            a++;
            if(a%2==1)
            {
                ptbClock.Image = global::devexpress.Properties.Resources.alarm_clock_icon__1_;
            }
            else
            {
                ptbClock.Image = global::devexpress.Properties.Resources.alarm_clock_icon;
            }
            
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            tmClock.Stop();
        }
    }
}