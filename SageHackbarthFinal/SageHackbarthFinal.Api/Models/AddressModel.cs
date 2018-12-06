using System;

namespace SageHackbarthFinal.Api.Models
{
	public class AddressModel
	{
		public Guid AddressId { get; set; }
		public string Street { get; set; }
		public string HouseNum { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public int Zip { get; set; }
	}
}