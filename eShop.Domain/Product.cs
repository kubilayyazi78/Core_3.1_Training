using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ürün Adı Boş Olamaz")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Discount { get; set; }

        public string PitcureUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
