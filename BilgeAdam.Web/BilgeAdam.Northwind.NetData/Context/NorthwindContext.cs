using BilgeAdam.Northwind.NetData.Entities;
using System.Data.Entity;

namespace BilgeAdam.Northwind.NetData.Context
{
    class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("nthCnnStr")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
