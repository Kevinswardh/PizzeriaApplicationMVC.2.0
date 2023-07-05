using Microsoft.AspNetCore.Mvc;

namespace PizzeriaApplicationMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
