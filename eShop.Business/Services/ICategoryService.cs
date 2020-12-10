using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
   public interface ICategoryService
    {
        public IList<Category> GetCategories();
    }
}
