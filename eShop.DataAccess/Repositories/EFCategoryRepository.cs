using eShop.DataAccess.Data;
using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace eShop.DataAccess.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private AcibademShopContext acibademShopContext;

        public EFCategoryRepository(AcibademShopContext acibademShopContext)
        {
            this.acibademShopContext = acibademShopContext;
        }
        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return acibademShopContext.Categories.ToList();
        }

        public IList<Category> GetWithCriteria(Expression<Func<Category, bool>> expression)
        {

            return acibademShopContext.Categories.Where(expression).ToList();
        }
    }
}
