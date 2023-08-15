using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Tutorial__2
{
	public class IntroducePerson
	{

		public void welcomeUser()
		{
			Console.WriteLine("Hello and welcome!");
		}
		public (string, string) GetFullName()
		{
			Console.WriteLine("What is your first name: ");
			string firstName = Console.ReadLine();

			Console.WriteLine("What is your last name: ");
			string lastName = Console.ReadLine();

			return (firstName, lastName);
		}
		public void  greetUser(string firstName, string lastName)
		{
			Console.WriteLine("Hello, " + firstName + " " + lastName);
		}


	}
}
