using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DichvuN")]
    public class DichvuN
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Manhom { get; set; }
        [Required]
        public string Tennhom { get; set; }
    }
}
