using System;

namespace CustomerMaintenance
{
    // This is the solution to exercise 14-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class RetailCustomer : Customer
    {

        private string homePhone;

        public RetailCustomer()
        {
        }

        public RetailCustomer(string lastName, string firstName, 
            string email, string homePhone) : base(lastName, firstName, email)
        {
            this.homePhone = homePhone;
        }

        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                this.homePhone = value;
            }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " ph: " + this.homePhone;
        }

    }
}
