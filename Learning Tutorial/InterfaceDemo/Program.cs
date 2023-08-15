using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

	// Interface is a contract
	// Classes implement interfaces
	internal class Program
	{
		static void Main(string[] args)
		{
			// Practice
/*
			List<IComputerController> computerAccessories = new List<IComputerController>();

			foreach (var accessories in computerAccessories)
			{
				accessories.Connect();
				//we can only access the methods or properties required by the interface
				//since we are using the interface as a type in the list

				//but we can put a check and then use it
				if (accessories is GamePad gc)
				{
					gc.BatteryLevel = 50;
				}
			}

			
			using (Printer printer = new Printer())
			{
				printer.CurrentKeyPressed();
				//after the method is used, the IDispose method automatically closes the class
			}*/

		}

		//Practice
		/*
		public interface IComputerController
		{
			void Connect();
			void CurrentKeyPressed();
		}

		public class Keyboard : IComputerController
		{
			public void Connect()
			{

			}
			public void CurrentKeyPressed()
			{

			}

			public string ConnectionType{get; set; }
		}

		public class GamePad : IComputerController
		{
			public void Connect()
			{
				
			}

			public void CurrentKeyPressed()
			{
				
			}

            public int BatteryLevel { get; set; }
        }

		//IDisposable is useful when we want to shut down our class after being used
		//like when working with images since they take up large amount of RAM

		public class Printer : IComputerController, IDisposable
		{
			public void Connect()
			{
				
			}

			public void CurrentKeyPressed()
			{
				
			}

			public void Dispose()
			{
				
			}
		}*/

		// Homework
		public interface IRun
		{
            int MaxSpeedInKM { get; set; }
			int AccelerationInKM { get; set; }
			int MaxDistanceRanInKM { get; set; }

			int TimeTakesToRun(int distance);
        }

		public class Person : IRun
		{
			public int MaxSpeedInKM { get => 0; set => throw new NotImplementedException(); }
			public int AccelerationInKM { get => 5; set => throw new NotImplementedException(); }
			public int MaxDistanceRanInKM { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

			public int TimeTakesToRun(int distance)
			{
				throw new NotImplementedException();
			}
		}
	}
}
