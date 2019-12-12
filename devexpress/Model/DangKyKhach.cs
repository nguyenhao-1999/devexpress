using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DangKyKhach")]
   public class DangKyKhach
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IDDK { get; set; }
        [Required]
        public int IDKhach { get; set; }
        [Required]
        public int SoCMND { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        [Required]
        public string MaQT { get; set; }
        public string GhiChu { get; set; }
        public bool DaiDien { get; set; }
        public int SọPhong { get; set; }
    }
}
