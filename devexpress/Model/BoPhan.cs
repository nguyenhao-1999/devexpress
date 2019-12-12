using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("BoPhan")]
   public class BoPhan
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaNhom { get; set; }
        [Required]
        public string TenNhom { get; set; }
        public int STT { get; set; }
        public int Indent { get; set; }
    }
}
