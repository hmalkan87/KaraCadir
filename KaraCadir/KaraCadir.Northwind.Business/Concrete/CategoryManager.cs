using Karacadir.Northwind.Entities.Concrete;
using KaraCadir.Northwind.Business.Abstract;
using KaraCadir.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaraCadir.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(categoryId);
        }
    }
}
