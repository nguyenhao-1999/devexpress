using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("Khach")]
   public class Khach
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string HoTen { get; set; }
        public string DonVi { get; set; }
        public DateTime NgaySinh { get; set; }
        [Required]
        public bool GioiTnh { get; set; }
        [Required]
        public int MaQT { get; set; }
        [Required]
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GhhiChu { get; set; }
        public int SoATM { get; set; }
        public string MaBank { get; set; }
    }
}
