using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        IEnumerable<Product> GetProductsByCategoryId(int categoryId);

        Product GetProductById(int id);
        Product UpdateProduct(Product product);
    }
}
