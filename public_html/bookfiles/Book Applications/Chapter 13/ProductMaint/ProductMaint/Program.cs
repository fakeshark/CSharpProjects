using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductMaint
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Comparison test
			Product p1 = new Product("JAVA", "Murach's Beginning Java 2", 49.50m);
			Product p2 = new Product("JAVA", "Murach's Beginning Java 2", 49.50m);
			if (p1 == p2)       // This evaluates to true. Without the overloaded
				Console.WriteLine("p1 equals p2");	// == operator, it would evaluate to false.

			Application.EnableVisualStyles();
			Application.Run(new frmProductMain());
		}

	}
}