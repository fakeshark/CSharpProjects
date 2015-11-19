using System;

namespace CloneCustomer
{
    // This is the solution to exercise 15-2 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class Customer : ICloneable
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
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

        #region ICloneable Members

        public object Clone()
        {
            return new Customer(this.FirstName, this.LastName, this.Email);
        }

        #endregion
    }
}
