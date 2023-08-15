using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PersonModel person1 = new PersonModel();

			/*		// 1. instead of repeating these lines, we can use an extension method
						Console.Write("What is your first name? : ");
						person1.FirstName = Console.ReadLine();

						Console.Write("What is your last name? : ");
						person1.LastName = Console.ReadLine();*/

			person1.FirstName = "What is your first name? :".RequestString();
			person1.LastName = "What is your last name? :".RequestString();

			person1.Age = "What is your age? :".RequestInt();
			person1.Age = "What is your age? :".RequestInt(18,50);
			

			Console.ReadLine();
		}
	}
}
