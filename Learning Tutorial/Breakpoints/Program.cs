/*using System;

namespace Breakpoints
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");
			RunsALot();
        }
		private static void RunsALot()
		{
			long total = 0;
			int test = 0;
			for (int i = -1000; i < 1000; i++)
			{
				total += i;
				try
				{
					test = 5 / i;
				}
				catch (Exception)
				{

                    Console.WriteLine("error");
                }
			}
            Console.WriteLine($"total: {total}");
        }
	}
} 
*/

//Homework - a loop that runs from 1 to 100. throw an exception at 73
static void ASimpleLoop()
{
	for (int i = 1; i < 101; i++)
	{
        Console.WriteLine(i);
    }
}

ASimpleLoop();