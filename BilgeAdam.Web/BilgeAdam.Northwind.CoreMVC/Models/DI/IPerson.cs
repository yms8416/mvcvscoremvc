using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.CoreMVC.Models.DI
{
    public interface IPerson
    {
        string FullName { get; set; }
        DateTime BirthDate { get; set; }
    }
}
