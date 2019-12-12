﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devexpress.Model;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace devexpress.DAO
{
    public class DK_CustomerDAO:QLKSDbContext
    {
        public void NewCustomer(DK_Customer cus)
        {
            var list = this.DK_Customers.ToList();
            this.DK_Customers.Add(cus);
            if (cus.Daidien == true)
            {
                foreach (var item in list)
                {
                    if (item.Daidien == true && item.Id != cus.Id)
                    {
                        item.Daidien = false;
                    }
                }
            }
            this.SaveChanges();
        }

        public void Xem(GridControl gcDataCheckin,int sophong)
        {

            var list = DK_Customers.Where(m=>m.IdKH== sophong).ToList();
            foreach (var item in list)
            {
               gcDataCheckin.DataSource = list;
            }
        }

        public void Xoa(int id)
        {
            DK_Customer kh = this.DK_Customers.FirstOrDefault(c => c.Id == id);
            this.DK_Customers.Remove(kh);
            this.SaveChanges();
        }

        public void Edit(DK_Customer cus)
        {
            DK_Customer kh = this.DK_Customers.FirstOrDefault(c => c.Id == cus.Id);
            var list = this.DK_Customers;
            if (cus.Daidien == true)
            {
                foreach (var item in list.ToList())
                {
                    if (item.Daidien == true && item.Id != cus.Id)
                    {
                        item.Daidien = false;
                    }
                }
            }
            kh.Daidien = cus.Daidien;
            kh.CMND = cus.CMND;
            kh.Hoten = cus.Hoten;
            kh.Gioitinh = cus.Gioitinh;
            kh.Quoctich = cus.Quoctich;
            kh.DateCheckin = cus.DateCheckin;
            kh.GioCheckin = cus.GioCheckin;
            kh.DateCheckout = cus.DateCheckout;
            kh.GioCheckout = cus.GioCheckout;
            kh.Ghichu = cus.Ghichu;
            this.SaveChanges();
        }
    }
}