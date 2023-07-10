using PizzeriaApplicationMVC.Models;

namespace PizzeriaApplicationMVC.Data.Services
{
    public interface IProdukterService
    {
        Task<IEnumerable<Products>> GetAllAsync();

        Task<Products> GetByIdAsync(int id);
        Task AddAsync(Products produkt);
        Task<Products> UpdateAsync(int id, Products newProduct);
        Task DeleteAsync(int id);

    }
}
