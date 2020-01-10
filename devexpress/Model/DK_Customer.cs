using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DK_Customers")]
    public class DK_Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdKH { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string Hoten { get; set; }
        [Required]
        public bool Gioitinh { get; set; }
        public bool Daidien { get; set; }
        public int Quoctich { get; set; }
        [Required]
        public DateTime DateCheckin { get; set; }
        [Required]
        public string GioCheckin { get; set; } 
        [Required]
        public DateTime DateCheckout { get; set; }
        [Required]
        public string GioCheckout { get; set; }
        public string Ghichu { get; set; }
    }
}
