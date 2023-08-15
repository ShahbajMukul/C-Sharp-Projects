using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 2. so we can use it like this

			InventoryItem book1 = new Book();

			Console.ReadLine();
		}

		//  1. abstract classes are foundation for other classes , but you can't extenuate them by themselves
		public abstract class InventoryItem
		{
			public string ProductName { get; set; }
            public int QuantityAvailable { get; set; }
        }

		public class Book : InventoryItem
		{

		}

		
	}
}
