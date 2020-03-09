using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("DichVu")]
    public class DichVu
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string MaNhom { get; set; }
        [Required]
        public string MaDV { get; set; }
        [Required]
        public string TenDV { get; set; }
        public string DVT { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public float GiaNhapCuoi { get; set; }
        public int GiaBinhQuan { get; set; }
        public string Note { get; set; }
    }
}
