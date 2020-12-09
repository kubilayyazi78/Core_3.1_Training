using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intro.Models
{
    public class KullaniciYanit
    {
        [Required (ErrorMessage ="Lütfen adınızı giriniz")]
        [MinLength(3,ErrorMessage ="İsim en az 3 harften oluşmalı.")]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime YanitTarihi { get; set; }

        public bool KatilimDurumu { get; set; }
    }
}
