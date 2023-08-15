using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementWithMethodOverloading
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EmployeeModel Jobbar = new EmployeeModel(1254);
			Jobbar.SSN = "123-45-6789";
            Console.WriteLine(Jobbar.SSN);

			EmployeeModel x = new EmployeeModel(1234);
			x.SSN = "123-45-6789";
            Console.WriteLine(x.SSN);

            Console.ReadLine();
        }
	}
}
