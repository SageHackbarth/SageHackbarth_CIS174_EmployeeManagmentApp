using System.Collections.Generic;
using SageHackbarthFinal.Shared.Orchestrators.Interfaces;
using SageHackbarthFinal.Shared.ViewModel;

namespace SageHackbarthFinal.Shared.Orchestrators
{
	public class CustomerOrchestrator : iCustomerOrchestrator
	{
		public List<CustomerViewModel> GetAllCustomers()
		{
			var customer = new List<CustomerViewModel>
			{
				new CustomerViewModel
				{
					Name = "Shawn Spencer",
					Username = "Spychicdetective"
				},
				new CustomerViewModel
				{
					Name = "Butron Guster",
					Username = "TopPharmaceutical"
				}
			};
			return customer;
		}
	}
}
