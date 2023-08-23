using System;
using System.Collections.Generic;

namespace GenEveWrapUpDemo
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			List<PersonModel> people = new List<PersonModel> {
				new PersonModel{FirstName = "Tim", LastName = "Johnson", Email = "timj@gmail.com"},
				new PersonModel{FirstName = "Mary", LastName = "Wilson", Email = "maryw@gmail.com"},
				new PersonModel{FirstName = "Karl", LastName = "JacobsHeck", Email = "karljgmail.com"},
				new PersonModel{FirstName = "John", LastName = "Smith", Email = "johnsmithgmail.com"}
			};


			List<CarModel> cars = new List<CarModel>
			{
				new CarModel{Manufacturer = "Toyota", Model = "Avalon"},
				new CarModel{Manufacturer = "Ford", Model = "Mustang"},
				new CarModel{Manufacturer = "Toyota", Model = "Camry"}

			};

			DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
			peopleData.BadEntryFound += PeopleData_BadEntryFound;
			peopleData.SaveToCSV(people, @"D:\temp\people.csv");


			DataAccess<CarModel> carData = new DataAccess<CarModel>();
			carData.BadEntryFound += carData_BadEntryFound;
			carData.SaveToCSV(cars, @"D:\temp\cars.csv");

			Console.ReadLine();
		}

		private static void carData_BadEntryFound(object sender, CarModel e)
		{
            Console.WriteLine($"Bad Entry found for {e.Manufacturer} {e.Model}");
        }

		private static void PeopleData_BadEntryFound(object sender, PersonModel e)
		{
			Console.WriteLine($"Bad Entry found for {e.FirstName} {e.LastName}");
		}
	}
}
