namespace CalculatorLibrary
{
	public class Calculator
	{
		public double Addition(double x, double y)
		{
			return x + y;
		}

		public double Subtraction(double x, double y)
		{
			return x - y;
		}

		public double Multiplication(double x, double y)
		{
			return x * y;
		}

		public double Division(double x, double y)
		{
			double result = 0;

			if (y != 0)
			{
				result = x / y;
			}
			return result;
		}
	}
}