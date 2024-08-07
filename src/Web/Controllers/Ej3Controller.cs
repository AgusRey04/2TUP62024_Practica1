
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public string Get(string nombre, int edad)
    {
        return $"Te llamas {nombre} y tienes {edad}";
    }
}