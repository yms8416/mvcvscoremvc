﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Northwind.NetData.Dtos
{
    public class CustomerDto
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
