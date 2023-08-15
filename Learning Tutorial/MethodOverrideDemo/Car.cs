using System;

namespace MethodOverrideDemo
{
	internal partial class Program
	{
		public abstract class Car
		{
			public void StartCar()
			{
                Console.WriteLine("Car is started");
			}

			//newer cars have different types of radios than older cars
			//so we use this abstract class to force other children of this class to have this method
			public abstract void TurnOnRadio();
		}
	}
}
