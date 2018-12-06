using System;

namespace SageHackbarthFinal.Api.Models
{
	public class CustomerModel
	{
		public Guid CustomerId { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public DateTime? DOB { get; set; }
		public AddressModel Address { get; set; }
	}
}