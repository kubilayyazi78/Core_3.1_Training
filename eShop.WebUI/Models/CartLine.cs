﻿using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Models
{
    public class CartLine
    {
        public Product  Product { get; set; }

        public int Quantity { get; set; }
    }
}
