using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class LinqEj7Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get([FromQuery] string cadena)
    {
        List<string> result = cadena.Split(' ').Where(x => x == x.ToUpper()).ToList();
        return result;
    }
}
