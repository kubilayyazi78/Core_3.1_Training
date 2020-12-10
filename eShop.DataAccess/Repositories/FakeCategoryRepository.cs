using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace eShop.DataAccess.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return new List<Category>
            {
                new Category
                {
                     Id=1,
                      CategoryName="Laptop"
                },
                 new Category
                {
                     Id=2,
                      CategoryName="Tablet"
                },
                  new Category
                {
                     Id=3,
                      CategoryName="Telefon"
                }
            };
        }

        public IList<Category> GetWithCriteria(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
