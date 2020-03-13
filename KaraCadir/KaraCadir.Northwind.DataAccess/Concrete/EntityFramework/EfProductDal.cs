using System;
using System.Collections.Generic;
using System.Text;
using Karacadir.Northwind.Entities.Concrete;
using KaraCadir.Core.DataAccess.EntityFramework;
using KaraCadir.Northwind.DataAccess.Abstract;

namespace KaraCadir.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
