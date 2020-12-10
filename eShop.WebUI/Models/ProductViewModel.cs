using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Product>  Products { get; set; }

        public PagingInfo  PagingInfo { get; set; }
    }
}
