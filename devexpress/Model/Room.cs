using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("Rooms")]
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Manhom { get; set; }
        [Required]
        public int Maloai { get; set; }
        [Required]
        public int Sophong { get; set; }
        [Required]
        public int Sogiuong { get; set; }
        [Required]
        public int Songuoi { get; set; }
        [Required]
        [Phone]
        public string Sophone { get; set; }
        [Required]
        public int Status { get; set; }

    }
}
