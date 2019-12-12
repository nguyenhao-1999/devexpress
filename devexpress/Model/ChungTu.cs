using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("ChungTu")]
    public class ChungTu
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int SoCT { get; set; }
        [Required]
        public DateTime NgayCT { get; set; }
        [Required]
        public int IdKH { get; set; }
        public float VAT { get; set; }
        [Required]
        public string MaNV { get; set; }
        [Required]
        public string Loai { get; set; }
        public string TraHang { get; set; }
        public float TongCong { get; set; }
        public float ChietKhau { get; set; }
    }
}
