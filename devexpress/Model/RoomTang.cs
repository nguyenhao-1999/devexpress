using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("RoomTangs")]
   public class RoomTang
    {
        [Key]
        public int Manhom { get; set; }
        [Required]
        public string Vitri { get; set; }
        [Required]
        public int Orders { get; set; }
        [Required]
        public string Mamau { get; set; }
    }
}
