using Microsoft.EntityFrameworkCore;
using PizzeriaApplicationMVC.Models;

namespace PizzeriaApplicationMVC.Data.Services
{
    public class ProdukterService : IProdukterService
    {
        private readonly AppDbContext _context;
        public ProdukterService(AppDbContext context)
        {
            _context = context; 
        }


        public async Task AddAsync(Products produkt)
        {
           await _context.Produkter.AddAsync(produkt);
           await  _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Produkter.FirstOrDefaultAsync(n => n.Id == id);
            _context.Produkter.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            var data = await _context.Produkter.ToListAsync();
            return data;
        }

        public async Task<Products> GetByIdAsync(int id)
        {
            var result = await _context.Produkter.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Products> UpdateAsync(int id, Products newProduct)
        {

            _context.Update(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }
    }
}
