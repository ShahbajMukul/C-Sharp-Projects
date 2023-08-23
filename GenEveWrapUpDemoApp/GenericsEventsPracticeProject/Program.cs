using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenericsEventsPracticeProject
{
	internal class Program
	{
		static void Main(string[] args)
		{


			List<PersonModel> people = new List<PersonModel>
			{ 
			new PersonModel { FirstName = "Rahim", LastName = "Sterling", Email = "rahims@gmail.com" },
			new PersonModel { FirstName = "Nico", LastName = "Gonzalez", Email = "nicog@gmail.com"},
			new PersonModel { FirstName = "Pablo", LastName = "Gavi", Email ="Pablog@gmail.com"}
			};

			DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
			peopleData.SaveAsCSV(people, @"D:\temp\people.csv");
			

		}
	}

	public class DataAccess <T> where T : new()
	{
		public void SaveAsCSV(List<T> list, string filePath)
		{
			string thingsToWrite = "";

			var properties = typeof(T).GetProperties();
			

			foreach (var property in properties)
			{
				thingsToWrite += property.Name + " - ";
			}
			thingsToWrite = thingsToWrite.TrimEnd(' ', '-');

			foreach (T item in list)
			{
				string itemString = "";

				foreach (var property in properties)
				{
					itemString += property.GetValue(item) + " ";
				}
				thingsToWrite += "\n" + itemString.Trim();
			}

			File.WriteAllText(filePath, thingsToWrite);
		}


//practice
/*
		public void NewSaveAsCSV(List<T> list, string filePath)
		{
			string thingsToWrite = "";

			var properties = typeof(T).GetProperties();

			foreach (var property in properties)
			{
				thingsToWrite += property.Name + " - ";
			}

			thingsToWrite = thingsToWrite.TrimEnd(' ', '-');


			foreach (var item in list)
			{
				string line = "";
				foreach (var val in properties)
				{
					line += val.GetValue(item) + " ";
				}
			
				thingsToWrite += "\n" + line.Trim();
			}
			File.WriteAllText(filePath, thingsToWrite);
			
		}


		public void LastSaveToCSV(List<T> list, string filePath)
		{
			string thingsToWrite = "";
			var properties = typeof(T).GetProperties();

			foreach (var property in properties)
			{
				thingsToWrite += property.Name + "    -    ";
			}
			thingsToWrite = thingsToWrite.TrimEnd(' ', '-');

			foreach (var item in list)
			{
				string line = "";
				foreach (var val in properties)
				{
					line += val.GetValue(item) + " ";
				}
				thingsToWrite += "\n" + line.Trim();
			}

			File.WriteAllText(filePath, thingsToWrite);

		}


		public void SaveToCSV(List<T> list, string filePath)
		{
			string thingsToWrite = "";

			var properties = typeof(T).GetProperties();

			foreach (var property in properties)
			{
				thingsToWrite += property.Name + " - ";
			}
			thingsToWrite = thingsToWrite.TrimEnd(' ', '-');

			foreach (var item in list)
			{
				string line = "";
				foreach (var property in properties)
				{
					line += property.GetValue(item) + " ";
				}

				thingsToWrite += "\n" + line.Trim();

			}

			File.WriteAllText(filePath, thingsToWrite);
		}
*/


	}


	
}
