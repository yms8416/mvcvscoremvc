using BilgeAdam.Northwind.NetData.Context;
using BilgeAdam.Northwind.NetData.Dtos;
using BilgeAdam.Northwind.NetData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.NetData.Repositories
{
    public class ProductRepository
    {
        private readonly NorthwindContext context;
        public ProductRepository()
        {
            context = new NorthwindContext();
        }

        public IEnumerable<ProductDto> GetAvailableProducts()
        {
            //SELECT ProductID AS Id, ProductName AS Name, UnitPrice AS Price, UnitsInStock FROM Products WHERE UnitsInStock > 0
            var products = context.Products
                                  .Where(i => i.UnitsInStock > 0)
                                  .OrderByDescending(i => i.ProductId)
                                  .Select(i => new ProductDto
                                  {
                                      Id = i.ProductId,
                                      Name = i.ProductName,
                                      Price = i.UnitPrice,
                                      UnitsInStock = i.UnitsInStock
                                  })
                                  
                                  .ToList();
            return products;
        }

        public void SaveProduct(ProductDto product)
        {
            var p = new Product
            {
                ProductName = product.Name,
                UnitPrice = product.Price,
                UnitsInStock = product.UnitsInStock
            };

            context.Products.Add(p);
            context.SaveChanges();
        }
    }
}
