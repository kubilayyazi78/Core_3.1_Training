using eShop.DataAccess.Data;
using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace eShop.DataAccess.Repositories
{



    public class EFProductRepository : IProductRepository
    {

        private AcibademShopContext acibademShopContext;
        public EFProductRepository(AcibademShopContext acibademShopContext)
        {
            this.acibademShopContext = acibademShopContext;
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return acibademShopContext.Products.ToList();
        }

        public IList<Product> GetWithCriteria(Expression<Func<Product, bool>> expression)
        {
            return acibademShopContext.Products.Where(expression).ToList();
        }
    }
}
