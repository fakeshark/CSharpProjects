using System;
using System.Collections.Generic;

namespace CustomerMaintenance
{
    // This is the solution to exercise 14-2 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class CustomerList : List<Customer>
	{
        public delegate void ChangeHandler(CustomerList customers);
        public event ChangeHandler Changed;

		public new Customer this[int i]
		{
			get
			{
				return base[i];
			}
			set
			{
				base[i] = value;
				Changed(this);
			}
		}

		public void Fill()
		{
			List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
            {
                base.Add(c);
            }
		}

		public void Save()
		{
			CustomerDB.SaveCustomers(this);
		}

		public new void Add(Customer customer)
		{
			base.Add(customer);
			Changed(this);
		}

		public new void Remove(Customer customer)
		{
			base.Remove(customer);
			Changed(this);
		}

		public static CustomerList operator + (CustomerList c1, Customer c)
		{
			c1.Add(c);
			return c1;
		}

		public static CustomerList operator - (CustomerList c1, Customer c)
		{
			c1.Remove(c);
			return c1;
		}

	}
}
