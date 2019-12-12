using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    public class QLKSDbContext:DbContext
    {
        public QLKSDbContext() : base("name=ChuoiKN") { }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<DK_Customer> DK_Customers { get; set; }
        public virtual DbSet<RoomCategory> RoomCategorys { get; set; }
        public virtual DbSet<RoomTang> RoomTangs { get; set; }
        public virtual DbSet<RoomStatus> RoomStatus { get; set; }
        public virtual DbSet<Quoctich> Quoctich { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NganHang> NganHang { get; set; }
        public virtual DbSet<LoaiTien> LoaiTien { get; set; }
        public virtual DbSet<DichVuPhong> DichVuPhong { get; set; }
        public virtual DbSet<DichVu> DichVu { get; set; }
        public virtual DbSet<ChungTuCT> ChungTuCT { get; set; }
        public virtual DbSet<ChungTu> ChungTu { get; set; }
        public virtual DbSet<BaoThuc> BaoThuc { get; set; }
        public virtual DbSet<BangGiaDV> BangGiaDV { get; set; }
        public virtual DbSet<BangGia> BangGia { get; set; }
        public virtual DbSet<Khach> Khach { get; set; }
        public virtual DbSet<DangKyKhach> DangKyKhach { get; set; }
        public virtual DbSet<DangKyPhong> DangKyPhong { get; set; }
        public virtual DbSet<ThuChi> ThuChi { get; set; }
        public virtual DbSet<ThietBiPhong> ThietBiPhong { get; set; }
        public virtual DbSet<ThietBi> ThietBi { get; set; }
        public virtual DbSet<BoPhan> BoPhan { get; set; }
    }
}
