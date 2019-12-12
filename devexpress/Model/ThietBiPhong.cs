using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("ThietBiPhong")]
   public class ThietBiPhong
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int SoPhong { get; set; }
        [Required]
        public string MaTB { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public string ThongSoKT { get; set; }
        public int NgaySD { get; set; }
        public string HangSD { get; set; }
        public string GhiChu { get; set; }
        public int Status { get; set; }
    }
}
