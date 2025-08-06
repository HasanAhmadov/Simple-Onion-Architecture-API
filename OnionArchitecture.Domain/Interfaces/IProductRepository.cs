using OnionArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Interfaces;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}