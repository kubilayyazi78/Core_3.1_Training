using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace eShop.DataAccess.Repositories
{
    public interface IRepository <T> where T:class,new()
    {
        T Add(T entity);
        IList<T> GetAll();

        IList<T> GetWithCriteria(Expression<Func<T, bool>> expression);

        T Get(int id);

        T Update(T entity);

    }
}
