using Microsoft.AspNetCore.Mvc;

namespace RealTimeDisplay.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
