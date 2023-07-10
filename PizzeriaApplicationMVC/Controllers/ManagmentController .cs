using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzeriaApplicationMVC.Data;
using PizzeriaApplicationMVC.Data.Services;
using PizzeriaApplicationMVC.Models;
using System.Configuration;

namespace PizzeriaApplicationMVC.Controllers
{
    public class ManagmentController : Controller
    {
        private readonly IProdukterService _service;
        
     
        public ManagmentController(IProdukterService service)
        {
           _service = service;
        }
     

        public async Task<IActionResult> Index()
        {

            var data = await _service.GetAllAsync();

            return View(data);
        }
        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PizzaName,PizzaIngre,Price,Category")]Products produkt)
        {
            if(!ModelState.IsValid)
            {
                return View(produkt);
            }
            await _service.AddAsync(produkt);
            return RedirectToAction(nameof(Index));

        }
        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            var getItems = await _service.GetByIdAsync(id);
           if(getItems == null) { return View("NotFound"); }
           return View(getItems);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,PizzaName,PizzaIngre,Price,Category")] Products produkt)
        {
            if (!ModelState.IsValid)
            {
                return View(produkt);
            }
           await _service.UpdateAsync(id, produkt);
            return RedirectToAction(nameof(Index));

        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var getItems = await _service.GetByIdAsync(id);
            if (getItems == null) { return View("NotFound"); }
            return View(getItems);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var getItems = await _service.GetByIdAsync(id);
            if (getItems == null) { return View("NotFound"); }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
