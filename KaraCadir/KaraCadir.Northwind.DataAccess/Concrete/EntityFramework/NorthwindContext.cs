using Karacadir.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaraCadir.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PJQC6VC\SQLEXPRESS; Database=Northwind; Integrated Security=True;");
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
