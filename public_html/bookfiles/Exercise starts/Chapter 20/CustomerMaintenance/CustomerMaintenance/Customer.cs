﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 20-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class Customer
    {
        public Customer() { }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}
