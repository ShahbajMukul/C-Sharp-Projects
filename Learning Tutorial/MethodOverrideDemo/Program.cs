using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideDemo
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel();
			person.FirstName = "Jimbo";
			person.LastName = "fjvs";
			person.Email = "ayeee@gmail.com";

			Console.WriteLine(person);

			Console.ReadLine();

		}
	}
}
