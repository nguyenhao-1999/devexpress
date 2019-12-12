using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("LoaiTien")]
    public class LoaiTien
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string KyHieu { get; set; }
        [Required]
        public int TiGia { get; set; }
    }
}
