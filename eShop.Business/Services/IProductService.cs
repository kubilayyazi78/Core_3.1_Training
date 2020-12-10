using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

    }
}
