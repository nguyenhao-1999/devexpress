using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("PhongS")]
    public class PhongS
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Sophong { get; set; }
        [Required]
        public int MaStatus { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }
    }
}
