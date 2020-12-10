using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.DataAccess.Repositories
{
    public interface IRepository <T> where T:class,new()
    {
        T Add(T entity);
        IList<T> GetAll();


    }
}
