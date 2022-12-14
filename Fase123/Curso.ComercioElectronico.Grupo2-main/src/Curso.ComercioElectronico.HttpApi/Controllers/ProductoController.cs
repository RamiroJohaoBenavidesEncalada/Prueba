

using Curso.ComercioElectronico.Application;
using Microsoft.AspNetCore.Mvc;

namespace Curso.ComercioElectronico.HttpApi.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{

    private readonly IProductoAppService productoAppService;

    public ProductoController(IProductoAppService productoAppService)
    {
        this.productoAppService = productoAppService;
    }

    [HttpGet]
    public ListaPaginada<ProductoDto> GetAll(int limit=10,int offset=0)
    {

        return productoAppService.GetAll(limit,offset);

    }

    [HttpPost]
    public async Task<ProductoDto> CreateAsync(ProductoCrearActualizarDto marca)
    {

        return await productoAppService.CreateAsync(marca);

    }

    [HttpPut]
    public async Task UpdateAsync(int id, ProductoCrearActualizarDto marca)
    {

        await productoAppService.UpdateAsync(id, marca);

    }

    [HttpDelete]
    public async Task<bool> DeleteAsync(int marcaId)
    {

        return await productoAppService.DeleteAsync(marcaId);

    }

}