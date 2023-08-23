using ModelLibrary;
using System;
using System.Collections.Generic;

namespace PeopleModelLibrary
{
	public class PersonModel
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<AddressModel> addresses { get; set; }

        public PersonModel()
        {
            addresses = new List<AddressModel>();
        }

		public override string ToString()
		{
			return  $"{FirstName} {LastName}";
		}
	}
}