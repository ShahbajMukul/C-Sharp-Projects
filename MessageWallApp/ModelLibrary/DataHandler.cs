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
		private ObservableCollection<PersonModel> people = new ObservableCollection<PersonModel>();
		public ObservableCollection<PersonModel> People
		{
			get { return people; }
		}

		public DataHandler()
		{
			people = new ObservableCollection<PersonModel>()
			{
/*				
				new PersonModel{FirstName = "Neymar", LastName =  "Jr."},
				new PersonModel{FirstName = "Christiano", LastName =  "Ronaldo"},
				new PersonModel{FirstName = "Leonel", LastName =  "Messi"}
				
*/
			};
		}
	}
}
