using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Information
{
	public class CarModel
	{
		public int Year { private get; set; }
		public string Name { private get; set; }
        public string Model { private get; set; }

        //constructor - can't change those private values after setting these
        //benifits: an app might need this least amount of info to get started (ex. suggesting car parts)
        public CarModel(int year, string name, string model)
        {
			Name = name;
            Year = year;
            Model = model;

		}

        //overloading -allows multiple types of data management
        public CarModel()
        {
            //allows you to run without passing any parameters in the main method
        }

    }
}
