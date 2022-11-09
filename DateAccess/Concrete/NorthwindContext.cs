using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    //Context : Db tabloları ile proje class larını bağlar.
    public class NorthwindContext:DbContext
    {
        //projem hangi veri tabanı ile ilişkili 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server kullanıcaz. o zaman sql server a nasıl bağlanacagımı belirtmem lazım.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }


        //Benim hangi class ım hangi tabloya karşılık gelmeli.Aşağıda yazdıklarım veri tabanına yansıyacak olan tablolarım.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
