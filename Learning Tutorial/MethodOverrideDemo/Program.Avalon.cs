using System;

namespace MethodOverrideDemo
{
	internal partial class Program
	{
		public class Avalon : Car
		{
			public override void TurnOnRadio()
			{
                Console.WriteLine("Clicked on Mechanical wheel to turn on the radio");
            }
		}
	}
}
