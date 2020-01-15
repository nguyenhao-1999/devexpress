using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DangKys")]
    public class Dangky
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime NgayDK { get; set; }
        [Required]
        public DateTime NgayCheckin { get; set; }
        [Required]
        public DateTime NgayCheckout { get; set; }
        public double SotienUT { get; set; }
        public string Loaitien { get; set; }
        [Required]
        public int Tygia { get; set; }
        public DateTime NgayUT { get; set; }
        public string HinhthucTT { get; set; }
        public string SoATM { get; set; }
        public string MaBank { get; set; }
        public int Sokhach { get; set; }
        public int Sophong { get; set; }
        public string Ghichu { get; set; }
        public bool DaCheckin { get; set; }
        public string Phong { get; set; }
    }
}
