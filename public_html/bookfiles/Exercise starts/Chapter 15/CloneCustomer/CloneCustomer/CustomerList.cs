using System;
using System.Collections.Generic;

namespace CloneCustomer
{
    // This is the starting point for exercise 15-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class CustomerList
	{
        private List<Customer> customers = new List<Customer>();

		public int Count
		{
			get
			{
				return customers.Count;
			}
		}

		public Customer this[int i]
		{
			get
			{
				return customers[i];
			}
		}

		public void Add(Customer customer)
		{
			customers.Add(customer);
		}

	}
}
