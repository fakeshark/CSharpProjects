using System;

namespace FinancialCalculations
{
    // This is the starting point for exercise 1-1 from
    // "Murach's C# 2005" by Joel Murach
    // (c) 2006 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class Calculations
	{

		public static decimal CalculateFutureValue(decimal monthlyInvestment, 
			decimal monthlyInterestRate, int months)
		{
            double dMonthlyInvestment = Convert.ToDouble(monthlyInvestment);
            double dMonthlyInterestRate = Convert.ToDouble(monthlyInterestRate);
            double dMonths = Convert.ToDouble(months);
            double dFutureValue = 
                dMonthlyInvestment * 
                (Math.Pow(1 + dMonthlyInterestRate, dMonths) - 1) /
                dMonthlyInterestRate;

            decimal futureValue = Convert.ToDecimal(dFutureValue);

			return futureValue;
		}

		public static decimal CalculateMonthlyInvestment(decimal futureValue, 
			decimal monthlyInterestRate, int months)
		{
			double dFutureValue = Convert.ToDouble(futureValue);
			double dMonthlyInterestRate = Convert.ToDouble(monthlyInterestRate);
			double dMonths = Convert.ToDouble(months);
			double dMonthlyInvestment = 
				dFutureValue * dMonthlyInterestRate /
				(Math.Pow(1+dMonthlyInterestRate, dMonths) - 1);

			decimal monthlyInvestment = 
				Convert.ToDecimal(dMonthlyInvestment);

			return monthlyInvestment;
		}

		public static double CalculateSYDDepreciation(double cost, 
			double salvage, double life, double period)
		{
			double SYDValue = 
				(cost-salvage) * (life-period+1) * 2 / 
					((life)*(life+1));
			return SYDValue;
		}

	}
}
