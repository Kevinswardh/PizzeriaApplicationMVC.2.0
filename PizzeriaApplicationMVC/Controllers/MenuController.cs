using Microsoft.AspNetCore.Mvc;
using PizzeriaApplicationMVC.Data.Services;

namespace PizzeriaApplicationMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProdukterService _service;


        public MenuController(IProdukterService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {

            var data = await _service.GetAllAsync();

            return View(data);
        }
    }
}
