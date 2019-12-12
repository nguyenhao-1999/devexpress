using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("BangGia")]
    public class BangGia
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int SoPhong { get; set; }
        [Required]
        public string DVTien { get; set; }
        [Required]
        public float DonGia { get; set; }
        [Required]
        public string LoaiGia { get; set; }
    }
}
