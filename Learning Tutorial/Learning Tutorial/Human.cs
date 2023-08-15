using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Tutorial
{
	public class Human
	{
		private string _firstName;
		private string _lastName;
		private string _gender = "";
		private int _age;
		private float _heightInMeters;
		private float _widthInKG;

		public Human(string firstName, string lastName)
		{
			_firstName = firstName;
			_lastName = lastName;
		}

		public void printInfo()
		{
			Console.Clear();
			Console.WriteLine($"Hello, your name is {_firstName} {_lastName}🖥️");
		}

	}
}
