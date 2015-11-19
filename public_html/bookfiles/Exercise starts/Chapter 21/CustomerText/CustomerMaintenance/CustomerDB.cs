using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 21-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
        // TODO: Add the directory and path here

        public static void SaveCustomers(List<Customer> customers)
		{
            // TODO: Add code that writes the List<> of Customer objects 
            // to a text file
		}

        public static List<Customer> GetCustomers()
		{
            List<Customer> customers = new List<Customer>();

            // TODO: Add code that reads a List<> of Customer objects 
            // from a text file
            
			return customers;
		}
	}
}
