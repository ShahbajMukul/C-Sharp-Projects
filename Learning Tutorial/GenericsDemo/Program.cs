using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			List<string> list = new List<string>();


			string resut = FizzBuzz("Tests"); //length 5
			string result2 = FizzBuzz(123);
			string result3 = FizzBuzz(123456789012345);

			Console.WriteLine(resut);
			Console.WriteLine(result2);
			Console.WriteLine(result3);


			string resultUsingClass = FizzBuzz(new PersonModel { FirstName = "Jim", LastName = "Nain" });
			Console.WriteLine(resultUsingClass);
			*/

			/*
			GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
			peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Jim", LastName = " Corey", HasError = false });

			foreach (var item in peopleHelper.Items)
			{
                Console.WriteLine($"{item.FirstName} is a valid first name");
            }
			*/


			//Homework

			GenericTwo<VehicleModel> genericTwo = new GenericTwo<VehicleModel> ();

			genericTwo.ConvertAndPrint(new VehicleModel { ManufacturerName = "Toyota", YearManufactured = 2008, ContainsError = false });
			

			List<VehicleModel> carList = new List<VehicleModel> ();
			carList.Add(new VehicleModel { ManufacturerName = "Honda", YearManufactured = 2018, ContainsError= false });
			carList.Add(new VehicleModel { ManufacturerName = "Ford", YearManufactured = 2022, ContainsError = false });
			carList.Add(new VehicleModel { ManufacturerName = "Tesla", YearManufactured = 2018, ContainsError = true });


			foreach (var car in carList)
			{
				genericTwo.ConvertAndPrint(car);
			}

            Console.ReadLine();
			
		}

		// 1. how to use generics
		// if a number of divisible by 3, print 'Fizz'
		// 5 = 'Buzz'
		// 3 & 5 = 'FizzBuzz'
		private static string FizzBuzz<T>(T item)
		{
			int itemLength = item.ToString().Length;

			/*if (itemLength % 3 == 0 && itemLength % 5 == 0) 
			{
				return "FizzBuzz";
            }
			else if (itemLength % 3 == 0)
			{
				return "Fizz";
			}
			else if (itemLength % 5 == 0)
			{
				return "Buzz";
			}
			else
			{
				return "";
			}*/

			// Better system
			string output = "";

			if (itemLength % 3 == 0 )
			{
				output += "Fizz";
			}
			if (itemLength % 5 == 0)
			{
				output += "Buzz";
			}
			return output;
		}
			
						
	}
	/*
		public class GenericHelper<T> where T : IErrorCheck
		{
			public List<T> Items { get; set; } = new List<T>();
			public List<T> RejectedItems { get; set; } = new List<T>();

			public void CheckItemAndAdd(T item)
			{
				if (item.HasError)
				{
					RejectedItems.Add(item);
				}
				else
				{
					Items.Add(item);
				}
			}

		}

		public interface IErrorCheck
		{
			bool HasError { get; set; }
		}

		public class PersonModel : IErrorCheck
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public bool HasError { get; set; }
		}
	*/

	public class GenericTwo<T> where T : IErrorChecking
	{
		public List<string> ValidStrings { get; set; } = new List<string>();
		public List<T> InvalidItems { get; set; } = new List<T>();
		public void ConvertAndPrint(VehicleModel itemToPrint) // Use VehicleModel as the type argument
		{
			if (itemToPrint.ContainsError == false)
			{
				ValidStrings.Add(itemToPrint.ToString());
				Console.WriteLine(itemToPrint.ToString()); // Print the value to the console
			}
			else
			{
				
			}
		}
	}

	public class VehicleModel : IErrorChecking
	{
		public string ManufacturerName { get; set; }
		public int YearManufactured { get; set; }
		public bool ContainsError { get; set; }
		public override string ToString() // Override the ToString method to return a custom string
		{
			return $"{ManufacturerName} - {YearManufactured}";
		}
	}

	public interface IErrorChecking
	{
		bool ContainsError { get; set; }
	}


}
