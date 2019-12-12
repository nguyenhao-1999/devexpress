using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("Quoctich")]
    public class Quoctich
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ma { get; set; }
        [Required]
        public string TenQT { get; set; }
    }
}
