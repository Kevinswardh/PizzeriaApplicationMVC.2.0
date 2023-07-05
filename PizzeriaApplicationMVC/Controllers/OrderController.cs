using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzeriaApplicationMVC.Data;
using PizzeriaApplicationMVC.Models;
using System.Configuration;

namespace PizzeriaApplicationMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        
     
        public OrderController(AppDbContext context)
        {
            _context = context;
        }
     

        public async Task<IActionResult> Index()
        {

            var data = await _context.Produkter.ToListAsync();

            return View(data);
        }
    }
}
