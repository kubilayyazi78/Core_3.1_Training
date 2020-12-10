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

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return productRepository.GetWithCriteria(x => x.CategoryId == categoryId);
        }
    }
}
