using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.CoreMVC.Models.DI
{
    public class Student : IPerson
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
