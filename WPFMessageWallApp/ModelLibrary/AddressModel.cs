using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
	public class AddressModel
	{
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }

		public string GetFullAddress()
		{
			return $"{StreetAddress} {City} {State} {ZipCode}";
		}
	}
}
