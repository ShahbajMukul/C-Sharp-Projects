using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementWithMethodOverloading
{
	public class EmployeeModel
	{
		private double _hourlyPayRate;

		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
        public double HourlyPayRate { get; set; }

		private string _ssn;

		public string SSN
		{
			get { return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; }
			set
			{
				if (value.Contains("-"))
					value = value.Replace("-", "");
				_ssn = value;
			}
		}



        public EmployeeModel(string firstName, string lastName)
        {
            FirstName = firstName;
			LastName = lastName;
        }

        public EmployeeModel(int id)
        {
			ID = id;
        }

        public EmployeeModel(int id, string title, string email)
        {
			ID = id;
			Title = title;
			Email = email;
        }

		public EmployeeModel(int id, string ssn)
		{
			ID = id;
			SSN = ssn;
		}
    }
}
