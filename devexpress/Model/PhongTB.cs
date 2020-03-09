using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("PhongTB")]
    public class PhongTB
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Sophong { get; set; }
        [Required]
        public int MaTB { get; set; }
        [Required]
        public int SL { get; set; }
        [Required]
        public string ThongsoKT { get; set; }
        [Required]
        public DateTime NgaySD { get; set; }
        [Required]
        public DateTime HanBH { get; set; }
        public string Ghichu { get; set; }


    }
}
