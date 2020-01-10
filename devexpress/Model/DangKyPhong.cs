using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DangKyPhong")]
  public  class DangKyPhong
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IDDK { get; set; }
        [Required]
        public int SoPhong { get; set; }
        [Required]
        public DateTime NgayDK { get; set; }
        [Required]
        public DateTime NgayCheckIn { get; set; }
        public DateTime NgayCheckOut { get; set; }
        [Required]
        public bool DaCheckIn { get; set; }
        public string GhiChu { get; set; }
        public float DonGia { get; set; }
        public string LoaiTien { get; set; }
        public int TyGia { get; set; }
    }
}
