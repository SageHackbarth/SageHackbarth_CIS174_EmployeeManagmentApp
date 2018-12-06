namespace SageHackbarthFinal.Domain.Migrations
{
	using SageHackbarthFinal.Domain.Entities;
	using System;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<SageHackbarthFinal.Domain.ComapnyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SageHackbarthFinal.Domain.ComapnyContext context)
        {
			context.Customers.AddOrUpdate(x => x.CustomerId,
				new Customer()
				{
					CustomerId = Guid.Parse("109e8bea-ae39-49b5-8f96-08db18c507fe"),
					Name = "Shawn Spencer",
					Username = "PsychicDetective",
					Address = new Address()
					{
						AddressId = Guid.Parse("ae4845f2-5c09-4daa-a30f-2fe06e250883"),
						City = "Santa Barbara",
						State = "California",
						Country = "USA",
						Street = "West Coast AV.",
						Zip = 51627,
						HouseNum = 1523
					}
				},
				new Customer()
				{
					CustomerId = Guid.Parse("d7b65b1c-571d-4af8-9a01-bdb25c66879f"),
					Name = "Burton Guster",
					Username = "TopPharmaceuticalRep",
					Address = new Address()
					{
						AddressId = Guid.Parse("c368a3e2-2091-456e-b291-a83d24b50234"),
						City = "Santa Barbara",
						State = "California",
						Country = "USA",
						Street = "West Coast AV.",
						Zip = 51627,
						HouseNum = 1523
					}
				}
			);
        }
    }
}
