using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("ThietBi")]
  public  class ThietBi
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaNhom { get; set; }
        [Required]
        public string MaTB { get; set; }
        [Required]
        public string TenTB { get; set; }
        public string DVT { get; set; }
        public string NoiSX { get; set; }
        public string GhiChu { get; set; }
    }
}
