using Karacadir.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace KaraCadir.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
    }
}
