using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		class Car : Vehicle
		{

		}

		class Boat : Vehicle
		{

		}

		class Motorcycle : Vehicle
		{

		}

		class Vehicle
		{
			bool isItOn = false;
			int fuelTankSizeInLiter = 0;

			void Start()
			{
				isItOn = true;
			}

			void Stop()
			{
				isItOn = false;
			}
		}
	}
}
