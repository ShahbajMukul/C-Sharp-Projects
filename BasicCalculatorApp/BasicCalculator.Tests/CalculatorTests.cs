using CalculatorLibrary;

namespace BasicCalculator.Tests
{
	public class CalculatorTests
	{
		[Fact]
		
		public void AdditionShouldReturnCorrectSum()
		{
			Calculator calculator = new Calculator();
			double expected = 55;

			double actual = calculator.Addition(5, 50);

			Assert.Equal(expected, actual);	
		}

		[Theory]
		[InlineData(55, 5, 50)]
		[InlineData(5, 10, -5)]
		[InlineData(5, 2.5, 2.5)]

		public void SubtractionShouldReturnCorrectSub(double firstVal, double lastVal, double expected)
		{
			Calculator calculator = new Calculator();

			double actual = calculator.Subtraction(firstVal, lastVal);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(4, 3, 12)]
		public void MultiplicationShouldReturnCorrectMul(double val1, double val2, double expected)
		{
			Calculator calculator = new();

			double actual = calculator.Multiplication(val1, val2);

			Assert.Equal(expected, actual);

		}

		[Theory]
		[InlineData(9, 3, 3)]
		public void DivisionShouldReturnCorrectDiv(double val1, double val2, double expected)
		{
			Calculator calculator = new();

			double actual = calculator.Division(val1, val2);

			Assert.Equal(expected, actual);

		}
	}
}