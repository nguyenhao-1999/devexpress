using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string MaNhom { get; set; }
        [Required]
        public string MaNV { get; set; }
        [Required]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        [Required]
        public int SoCMND { get; set; }
        public string DiaChi { get; set; }
        [Required]
        public string DienThoai { get; set; }
        public string Mail { get; set; }
        public string TaiKhoan { get; set; }
        public string NganHang { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }
        public string Market { get; set; }
        public float MucLuong { get; set; }
        public string Loai { get; set; }
        public string Note { get; set; }
    }
}
