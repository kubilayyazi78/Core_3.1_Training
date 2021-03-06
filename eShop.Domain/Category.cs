﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Domain
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public virtual IList<Product>  Products { get; set; }
    }
}
