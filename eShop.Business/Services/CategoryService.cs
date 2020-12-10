using eShop.DataAccess.Repositories;
using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IList<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }
    }
}
