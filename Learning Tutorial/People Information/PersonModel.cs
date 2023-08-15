using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Information
{
	public class PersonModel
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress {private get; set; }
        //public int Age { get; set; }
        public bool HasBeenGreeted { get; set; }

		public string FullName
		{
			get { return $"{FirstName} {LastName}"; }
		}

		//full properties allows us to set requirements
		//propfull +tab tab
		private int _Age;

		public int Age
		{
			get 
			{ 
				return _Age; 
			}

			set 
			{
				if (value >=0 && value <126)
				{
					_Age = value; 
				}
				else
				{
					throw new ArgumentException("value", "Age needs to be in a valid range.");
				}
			}
		}

        //public string SSN { get; set; } //we don't want to show this either.
										//so we create requirements

		private string _ssn;

		public string SSN
		{
			get
			{
				string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
				return output;
					}
			set { _ssn = value; }
		}

		private string _password;

		public string Password
		{
			set { _password = value; }
		}



	}
}
