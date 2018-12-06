using SageHackbarthFinal.Api.Models;
using SageHackbarthFinal.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace SageHackbarthFinal.Api.Controllers
{
	[Route("api/v1/customer")]
	public class CustomerController : ApiController
    {
		private ComapnyContext _companyContext;

		public CustomerController()
		{
			_companyContext = new ComapnyContext();
		}

		public async Task<ICollection<CustomerModel>> GetAllCustomers()
		{
			var customers = await _companyContext.Customers.Select(x => new CustomerModel
			{
				CustomerId = x.CustomerId,
				Name = x.Name,
				Username = x.Username,
				DOB = x.DOB
			}).ToListAsync();

			return customers;
		}
    }
}
