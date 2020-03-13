using Karacadir.Northwind.Entities.Concrete;
using KaraCadir.Core.DataAccess;

namespace KaraCadir.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom operations
    }
}
