using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace AccessModifiersDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			person.FirstName = "Jobbar";
			person.SSN = "123-45-6789";
			person.SayHello();
			string ret = person.SSN;


			Console.WriteLine(ret);
			Console.ReadLine();

        }
	}
}
