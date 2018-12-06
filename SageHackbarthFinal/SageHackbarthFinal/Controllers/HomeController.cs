using SageHackbarthFinal.Models;
using SageHackbarthFinal.Shared.Orchestrators;
using System.Web.Mvc;
/** =========================================================
 Sage Hackbarth

 Windows 10
 Microsoft Visual Studio 2017 Enterprise
 CIS 174

 Final "Group" Project

 Program Description: Use car insurance and give rates

 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
namespace SageHackbarthFinal.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var customerOrchestrator = new CustomerOrchestrator();

			var customerModel = new CustomerModel
			{
				Customers = customerOrchestrator.GetAllCustomers()
			};
		
			return View(customerModel);
		}
		
	}
}