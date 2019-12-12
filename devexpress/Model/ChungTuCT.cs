using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("ChungTuCT")]
    public class ChungTuCT
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int MaPhieu { get; set; }
        [Required]
        public int MaVT { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public float ChietKhau { get; set; }
        [Required]
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public string Loai { get; set; }
        public DateTime NgayCT { get; set; }
        [Required]
        public string IdKH { get; set; }
        public int IdPhong { get; set; }
        public string LoaiTien { get; set; }
        public int TiGia { get; set; }
    }
}
