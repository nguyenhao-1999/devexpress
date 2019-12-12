using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("ThuChi")]
   public class ThuChi
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int SoCT { get; set; }
        [Required]
        public DateTime NgayCT { get; set; }
        [Required]
        public string MaKH { get; set; }
        public string Nguoi { get; set; }
        [Required]
        public string SoTien { get; set; }
        [Required]
        public string LoaiTen { get; set; }
        public string TyGia { get; set; }
        public string DienGiai { get; set; }
        public string NhanVien { get; set; }
        public string Loai { get; set; }
        [Required]
        public int IdPhong { get; set; }
        [Required]
        public int IdPhieuDK { get; set; }
        public string HinhThuc { get; set; }
    }
}
