using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CollegeClassModel history = new CollegeClassModel("History 101", 3);
			CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

			history.EnrollmentFull += CollegeClass_EnrollmentFull;

			history.SignUpStudents("Ali Uddin").PrintToConsole();
			history.SignUpStudents("Sue Jean").PrintToConsole();
			history.SignUpStudents("Martha kacy").PrintToConsole();
			history.SignUpStudents("John Smith").PrintToConsole();

            Console.WriteLine();

			math.EnrollmentFull += CollegeClass_EnrollmentFull;
			math.SignUpStudents("Ali Uddin").PrintToConsole();
			math.SignUpStudents("Sue Jean").PrintToConsole();
			math.SignUpStudents("Martha kacy").PrintToConsole();

			

			Console.ReadLine();
		}

		private static void CollegeClass_EnrollmentFull(object sender, string e)
		{
			CollegeClassModel model = (CollegeClassModel)sender;
			Console.WriteLine($"{model.CourseTitle} is full");


			//Console.WriteLine($"The enrollment is full for {e}!");
		}

		
	}

	public static class ConsoleHelpers
	{
		public static void PrintToConsole(this string message)
		{
            Console.WriteLine(message);
        }
	}

	public class CollegeClassModel
	{
		public event EventHandler<string> EnrollmentFull;

		private List<string> enrolledStudents =  new List<String>();
		private List<string> waitingList = new List<String>();

        public string CourseTitle { get; private set; }	
		public int MaximumStudents { get; private set; }

		public CollegeClassModel(string title, int maximumStudents)
		{
			CourseTitle = title;
			MaximumStudents = maximumStudents;
		}

		public string SignUpStudents(string studentName)
		{
			string output = "";
			if (enrolledStudents.Count < MaximumStudents)
			{
				enrolledStudents.Add(studentName);
				output = $"{studentName} was enrolled in {CourseTitle}";

				if (enrolledStudents.Count == MaximumStudents)
				{
					EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full");
				}
			}
			else
			{
				waitingList.Add(studentName);
				output = $"{studentName} was added to the waitlist";
			}

			return output;
		}
}
}
