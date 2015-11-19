using System;
using System.Collections.Generic;

namespace CloneCustomer
{
    // This is the solution to exercise 15-2 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class CustomerList : IEnumerable<Customer>
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

        #region IEnumerable<Customer> Members

        IEnumerator<Customer> IEnumerable<Customer>.GetEnumerator()
        {
            foreach (Customer c in customers)
            {
                yield return c;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

    }
}
