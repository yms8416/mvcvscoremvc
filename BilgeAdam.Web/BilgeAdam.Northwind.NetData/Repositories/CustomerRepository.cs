using BilgeAdam.Northwind.NetData.Context;
using BilgeAdam.Northwind.NetData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.NetData.Repositories
{
    public class CustomerRepository
    {
        private readonly NorthwindContext context;

        public CustomerRepository()
        {
            context = new NorthwindContext();
        }

        public IEnumerable<CustomerDto> GetCustomers()
        {
            return context.Customers.Where(i => i.Country == "USA").Select(i => new CustomerDto
            {
                City = i.City,
                Country = i.Country,
                Company = i.CompanyName,
                CustomerId = i.CustomerId,
                FullName = i.ContactName
            }).ToList();
        }
    }
}
