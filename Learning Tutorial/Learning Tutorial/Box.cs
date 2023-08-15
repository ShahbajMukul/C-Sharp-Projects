using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Tutorial
{
	public class Box
	{
		public int _lengthInMeters;
		public int _widthInMeters;
		public int _heightInMeters;


		//public int dimension { get => dimension; set => dimension = value < 0 ? throw new Exception("Can't have that") : value; }

		public Box(int length=0, int width=0, int height = 1)
		{
			_lengthInMeters = length;
			_widthInMeters = width;
			_heightInMeters = height;
		}
		public void printInfo()
		{

	
            Console.WriteLine($"{this.GetType().Name} has the length of {_lengthInMeters} and the height of {_heightInMeters}");

        }
	}


}
