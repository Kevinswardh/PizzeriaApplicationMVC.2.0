using Microsoft.AspNetCore.Mvc;

namespace PizzeriaApplicationMVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
