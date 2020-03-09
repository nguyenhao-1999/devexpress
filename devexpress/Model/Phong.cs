using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("Phong")]
    public class Phong
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Sophong { get; set; }
        [Required]
        public DateTime NgayIn { get; set; }
        [Required]
        public string GioIn { get; set; }
        [Required]
        public DateTime NgayOut { get; set; }
        [Required]
        public string GioOut { get; set; }
        [Required]
        public int StatusP { get; set; }
        public string Ghichu { get; set; }
        public bool Baothuc { get; set; }
        public string Loaitien { get; set; }
        public int Tygia { get; set; }
        public int Dongia { get; set; }
        public int Songay { get; set; }
        public decimal TienP { get; set; }
        public decimal TienDV { get; set; }
        public decimal TienDT { get; set; }
        public decimal TienNH { get; set; }
        public decimal TienU { get; set; }
        public decimal Tong { get; set; }
        public decimal Dathu { get; set; }
        public decimal Tiencon { get; set; }
        public bool Daidien { get; set; }
        public int MaNV { get; set; }
        public int IdChuyen { get; set; }
    }
}
