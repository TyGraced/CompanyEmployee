using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
