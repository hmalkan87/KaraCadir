using Karacadir.Northwind.Entities.Concrete;
using KaraCadir.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaraCadir.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Custom operations
    }
}
