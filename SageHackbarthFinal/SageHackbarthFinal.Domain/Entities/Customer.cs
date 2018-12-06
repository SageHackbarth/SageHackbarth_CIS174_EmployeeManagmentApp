using System;

namespace SageHackbarthFinal.Domain.Entities
{
	public class Customer
	{
		public Guid CustomerId { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public DateTime? DOB { get; set; }
		public Address Address { get; set; }
	}
}
