using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			"England is your city?!".PrintToConsole();

			HotelRoomModel room1 = new HotelRoomModel();
			// 2. static methods also allow us to stack methods
			room1.SetTemperature(68).CloseShades().TurnOnAir();



			Person person1 = new Person();
			person1.SetDefautAge(21).PrintInfo();


			Console.ReadLine();
		}

		
	}

	public class HotelRoomModel
	{
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }


	// Homework
	public class Person
	{
        public int Age { get; set; }	
    }




	// 1. Extension methods have to be in a static class and method
	public static class ExtensionSamples
	{
		public static void PrintToConsole(this string message)
		{
			Console.WriteLine(message);
		}

		public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
		{
			room.IsAirRunning = true;
			return room;
		}


		public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temp)
		{
			room.Temperature = temp;
			return room;
		}

		public static HotelRoomModel OpenShades(this HotelRoomModel roomModel)
		{
			roomModel.AreShadesOpen = true;
			return roomModel;
		}

		public static HotelRoomModel CloseShades(this HotelRoomModel room)
		{
			room.AreShadesOpen = false;
			return room;
		}

		public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
		{
			room.IsAirRunning = false;
			return room;
		}



		// Homework

		public static Person SetDefautAge(this Person person, int age)
		{
			person.Age = age;
			return person;
		}

		public static Person PrintInfo(this Person person)
		{
            Console.WriteLine($"The person's age is {person.Age}");
			return person;
        }
	}
}


