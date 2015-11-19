using System;

namespace CustomerMaintenance
{
    // This is the solution to exercise 14-2 from
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
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 50 characters.");
                }
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
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 50 characters.");
                }
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
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of email address is 50 characters.");
                }
                email = value;
			}
		}

		public virtual string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}
