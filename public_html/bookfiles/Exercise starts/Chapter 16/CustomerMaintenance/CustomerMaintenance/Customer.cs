using System;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 16-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

        public Customer()
		{
		}

        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}

        public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
                firstName = value;
			}
		}

        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}