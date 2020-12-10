using eShop.DataAccess.Repositories;
using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository  productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }
    }
}
