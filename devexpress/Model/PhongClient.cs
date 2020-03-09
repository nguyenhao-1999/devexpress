using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("PhongClient")]
    public class PhongClient
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdKH { get; set; }
        [Required]
        public int IdPhong { get; set; }
        [Required]
        public DateTime Checkin { get; set; }
        [Required]
        public string GioIn { get; set; }
        [Required]
        public DateTime Checkout { get; set; }
        [Required]
        public string GioOut { get; set; }
        public string Ghichu { get; set; }
        public bool Daidien { get; set; }
        public string Lydo { get; set; }
    }
}
