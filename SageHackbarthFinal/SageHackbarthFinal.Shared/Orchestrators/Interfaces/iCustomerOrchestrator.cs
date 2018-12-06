using SageHackbarthFinal.Shared.ViewModel;
using System.Collections.Generic;

namespace SageHackbarthFinal.Shared.Orchestrators.Interfaces
{
	public interface iCustomerOrchestrator
	{
		List<CustomerViewModel> GetAllCustomers();
	}
}
