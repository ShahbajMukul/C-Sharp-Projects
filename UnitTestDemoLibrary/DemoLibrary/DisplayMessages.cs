namespace DemoLibrary
{
	public class DisplayMessages
	{
		public string Greeting(string firstName, int hourOfTheDay)
		{
			string output = "";

			if (hourOfTheDay < 12)
			{
				output = "Good morning, " + firstName;
			}
			else if (hourOfTheDay < 18) 
			{
				output = "Good afternoon, " + firstName;

			}
			else
			{
				output = "Good evening, " + firstName;
			}

			return output;
		}

		public double CalculateSum(int firstNum, int lastNum)
		{
			return firstNum + lastNum;
		}

		public double CalculateMultiplication(double firstNum, double lastNum)
		{
			return firstNum * lastNum;
		}


		public decimal CalculateSchwarzschildRadius(decimal mass)
		{
			decimal radius = 0m;
			const decimal LIGHTSPEED = 2.9979e10m; 
			const decimal GRAV = 6.6720e-08m;

			radius = 2 * mass * GRAV;

			radius = radius / (LIGHTSPEED * LIGHTSPEED);

			

			return radius;

	}
	}
}