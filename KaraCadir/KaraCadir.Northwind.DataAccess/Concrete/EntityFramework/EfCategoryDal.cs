using Karacadir.Northwind.Entities.Concrete;
using KaraCadir.Core.DataAccess.EntityFramework;
using KaraCadir.Northwind.DataAccess.Abstract;

namespace KaraCadir.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
