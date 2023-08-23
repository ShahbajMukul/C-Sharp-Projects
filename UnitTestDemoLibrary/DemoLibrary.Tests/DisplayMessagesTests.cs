using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


// Arrange, Act, Assert
// expected and actual are kind of key words

namespace DemoLibrary.Tests
{
	public class DisplayMessagesTests
	{
		[Fact]
		public void GreetingShouldReturnGoodMorningMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good morning, Jim";

			// Act
			string actual = messages.Greeting("Jim", 7);

			// Assert
			Assert.Equal(actual, expected);
		}

		[Fact]
		public void GreetingShouldReturnGoodAfternoonMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good afternoon, Jim";

			// Act
			string actual = messages.Greeting("Jim", 14);

			// Assert
			Assert.Equal(actual, expected);
		}

		[Theory]
		[InlineData("Jim",0 , "Good morning, Jim")]
		[InlineData("Jim", 14, "Good afternoon, Jim")]
		[InlineData("Jim", 19, "Good evening, Jim")]
		public void GreetingsShouldReturnExpectedValue
			(string firstName, int hourOfTheDay, string expected)
		{
			DisplayMessages messages = new DisplayMessages();
						
			string actual = messages.Greeting(firstName, hourOfTheDay);
	
			Assert.Equal(actual, expected);
		}


		[Fact]
		public void CalculateSumShouldReturnTheSum()
		{
			// AAA
			DisplayMessages displayMessages = new DisplayMessages();
			double expected = 64;

			double actual = displayMessages.CalculateSum(20, 44);

			Assert.Equal(actual, expected);
		}



		[Theory]
		[InlineData(3, 5, 15)]
		[InlineData(1, 5, 5)]
		[InlineData(6, 5, 30)]
		[InlineData(3, 0, 0)]
		
		public void CalculateMultiplicationShouldReturnCorrectValues(double num1, double num2, double expected)
		{
			DisplayMessages displayMessages = new DisplayMessages();

			double actual = displayMessages.CalculateMultiplication(num1, num2);

			Assert.Equal(expected, actual);
		}

	}
}
