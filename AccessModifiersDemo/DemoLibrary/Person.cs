using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

	public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        protected string FormerLastName = ""; //protected allows this private variable to be accessible by a children of this class

		private protected string FormerFirstName = ""; //allows only classes from this file to access this method using inheritance 

        private string _ssn;

		public string SSN
        {
            get { return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; }
            set { _ssn = value; }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, {FirstName}");
        }

        public void ChangeLastName(string newLastName)
        {
            FormerLastName = LastName;
            LastName = newLastName;
		}
    }
}
