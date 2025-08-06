using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.DTOs;
using OnionArchitecture.Application.Interfaces;
using System.Threading.Tasks;

namespace OnionArchitecture.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;
    public ProductsController(IProductService service) => _service = service;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

    [HttpGet("Get/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var product = await _service.GetByIdAsync(id);
        return product == null ? NotFound() : Ok(product);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(ProductDto dto)
    {
        await _service.AddAsync(dto);
        return Ok();
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> Update(int id, ProductDto dto)
    {
        await _service.UpdateAsync(id, dto);
        return Ok();
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}