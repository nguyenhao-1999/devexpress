using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DichVuPhong")]
    public class DichVuPhong
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaDV { get; set; }
        [Required]
        public int IdPhong { get; set; }
        [Required]
        public int IdKH { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public string LoaiTien { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public int TiGia { get; set; }
        public DateTime Ngay { get; set; }
        public DateTime Gio { get; set; }
        public string GhiChu { get; set; }
    }
}
