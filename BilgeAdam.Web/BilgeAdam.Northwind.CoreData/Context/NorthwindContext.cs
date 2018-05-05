using BilgeAdam.Northwind.CoreData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.Northwind.CoreData.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
