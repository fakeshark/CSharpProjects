using System;

namespace CustomerMaintenance
{
    // This is the solution to exercise 14-2 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class WholesaleCustomer : Customer
	{

        private string company;

		public WholesaleCustomer()
		{
		}

        public WholesaleCustomer(string lastName, string firstName, 
            string email, string company) : base(lastName, firstName, email)
        {
            this.company = company;
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " (" + this.company + ")";
        }

	}
}
