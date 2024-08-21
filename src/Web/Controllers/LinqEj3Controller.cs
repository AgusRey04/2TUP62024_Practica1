
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj3Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        List<string> numbers = ["ventilador", "reloj", "buscador", "bartender", "BUscAdOr", ""];
        var result = numbers.Select(x => x.ToLower()).Where(x => x.StartsWith("b") && x.EndsWith("r")).ToList();
        return result;

    }
}
