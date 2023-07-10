using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzeriaApplicationMVC.Data;
using PizzeriaApplicationMVC.Data.Services;
using PizzeriaApplicationMVC.Models;
using System.Configuration;

namespace PizzeriaApplicationMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProdukterService _service;
        
     
        public OrderController(IProdukterService service)
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
