using OnionArchitecture.Application.DTOs;
using OnionArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Interfaces;
public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task AddAsync(ProductDto dto);
    Task UpdateAsync(int id, ProductDto dto);
    Task DeleteAsync(int id);
}