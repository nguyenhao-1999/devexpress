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
    public partial class Danhsachnhomphong : DevExpress.XtraEditors.XtraForm
    {
        public Danhsachnhomphong()
        {
            InitializeComponent();
        }
        QLKSDbContext db = new QLKSDbContext();
        private void Danhsachnhomphong_Load(object sender, EventArgs e)
        {
            var list = db.RoomTangs.ToList();
            gcNhomphong.DataSource = list;
            
        }

        private void skColor_ColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("" + gvNhomphong.GetRowCellValue(gvNhomphong.FocusedRowHandle,"Mamau"));
        }

        private void gvNhomphong_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //Color c=(Color)gvNhomphong.GetRowCellValue(e.RowHandle, "Mamau");
            if (e.RowHandle == gvNhomphong.FocusedRowHandle && e.Column == colMa)
            {
                txtMa.Text = gvNhomphong.GetRowCellValue(e.RowHandle, "Manhom").ToString().Trim();
                txtVitri.Text = gvNhomphong.GetRowCellValue(e.RowHandle, "Vitri").ToString().Trim();
                
            }
            //MessageBox.Show("" + c);
        }

        private void cpeMau_TextChanged(object sender, EventArgs e)
        {
            Color c = cpeMau.Color;
        }
    }
}