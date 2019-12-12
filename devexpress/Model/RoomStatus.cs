using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("RoomStatus")]
    public class RoomStatus
    {
        [Key]
        public int Status { get; set; }
        [Required]
        public string NameStatus { get; set; }
    }
}
