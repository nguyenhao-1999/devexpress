using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("BangGiaDV")]
    public class BangGiaDV
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaDV { get; set; }
        [Required]
        public string DVTien { get; set; }
        [Required]
        public float DonGia { get; set; }
    }
}
