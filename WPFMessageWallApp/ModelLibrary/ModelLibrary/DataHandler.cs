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
		private BindingList<PersonModel> people = new BindingList<PersonModel>();

		public BindingList<PersonModel> People
		{
			get { return people; }
		}

		public DataHandler()
		{
			people = new BindingList<PersonModel>()
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
