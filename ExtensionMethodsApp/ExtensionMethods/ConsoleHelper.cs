using System;

namespace ExtensionMethods
{
	public static class ConsoleHelper
	{
		public static string RequestString(this string question)
		{
			string output = "";

			while (string.IsNullOrEmpty(output))
			{
				Console.Write(question);
				output = Console.ReadLine();
			}
			return output;
        }

		public static int RequestInt(this string question, int minValue, int maxValue)
		{
			int output = 0;
			do
			{
				output = RequestInt(question);
			} while (output < minValue || output>maxValue);

			return output;
		}

		public static int RequestInt(this string question)
		{
			int output = 0;
			bool isValidInt = false;

        
			while (isValidInt == false)
			{
				Console.Write(question);
				isValidInt = int.TryParse(Console.ReadLine(), out output);
			}
			return output;
        }
	}
}
