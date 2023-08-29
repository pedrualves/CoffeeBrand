using CoffeeBrand.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBrand.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeBrandController : ControllerBase
{
    [HttpGet("GetMvc")]
    public IEnumerable<CoffeeBrand> Get()
    {
        return new CoffeeBrandService().GetCoffeeBrands();
    }
}
