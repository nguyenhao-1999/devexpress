using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("NganHang")]
    public class NganHang
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Ma { get; set; }
        public string Macha { get; set; }
        [Required]
        public string TenBank { get; set; }
        [Required]
        [CreditCard]
        public int STT { get; set; }
        public int Indent { get; set; }
    }
}
