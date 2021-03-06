﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devexpress.Model
{
    [Table("BaoThuc")]
    public class BaoThuc
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdPhong { get; set; }
        [Required]
        public DateTime Ngay { get; set; }
        [Required]
        public string Gio { get; set; }
        [Required]
        public string NoiDung { get; set; }
        [Required]
        public string Lap { get; set; }
    }
}
