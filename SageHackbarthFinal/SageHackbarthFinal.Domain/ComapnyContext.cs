using SageHackbarthFinal.Domain.Entities;
using System.Data.Entity;

namespace SageHackbarthFinal.Domain
{
	public class ComapnyContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
	}
}
