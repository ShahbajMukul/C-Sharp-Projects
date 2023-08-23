using PeopleModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
	public class DataHandler
	{
		private List<PersonModel> people = new List<PersonModel>();

		public List<PersonModel> People
		{
			get { return people; }
			set { people = value; } 
		}

		public DataHandler()
		{
			people = new List<PersonModel>()
			{
				/* //test data
				 * new PersonModel{FirstName = "Neymar", LastName =  "Jr."},
				new PersonModel{FirstName = "Christiano", LastName =  "Ronaldo"},
				new PersonModel{FirstName = "Leonel", LastName =  "Messi"}
				*/

			};
		}
	}
}
