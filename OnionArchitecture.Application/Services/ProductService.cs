using OnionArchitecture.Application.DTOs;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repo;
    public ProductService(IProductRepository repo) => _repo = repo;

    public async Task<IEnumerable<Product>> GetAllAsync() => await _repo.GetAllAsync();

    public async Task<Product?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

    public async Task AddAsync(ProductDto dto)
    {
        var product = new Product { Name = dto.Name, Price = dto.Price };
        await _repo.AddAsync(product);
    }

    public async Task UpdateAsync(int id, ProductDto dto)
    {
        var product = await _repo.GetByIdAsync(id);
        if (product == null) return;
        product.Name = dto.Name;
        product.Price = dto.Price;
        await _repo.UpdateAsync(product);
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _repo.GetByIdAsync(id);
        if (product != null)
            await _repo.DeleteAsync(product);
    }
}