using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("RoomCategorys")]
    public class RoomCategory
    {
        [Key]
        public int Maloai { get; set; }
        [Required]
        public string Tenloai { get; set; }
    }
}
