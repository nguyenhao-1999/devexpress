using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("PhongDV")]
    public class PhongDV
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaDV { get; set; }
        [Required]
        public int IdPhong { get; set; }
        [Required]
        public int Soluong { get; set; }
        [Required]
        public int DonGia { get; set; }
        [Required]
        public string Loaitien { get; set; }
        [Required]
        public int Thanhtien { get; set; }
        [Required]
        public int Tygia { get; set; }
        [Required]
        public DateTime Ngay { get; set; }
        [Required]
        public string Gio { get; set; }
        public string Ghichu { get; set; }
    }
}
