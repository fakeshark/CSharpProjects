using System;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 21-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
	{
		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string GetDisplayText()
		{
			return FirstName + " " + LastName + ", " + Email;
		}
	}
}
