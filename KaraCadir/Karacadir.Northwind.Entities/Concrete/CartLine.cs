using System;
using System.Text;

namespace Karacadir.Northwind.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
