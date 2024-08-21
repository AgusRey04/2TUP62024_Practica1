using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class LinqEj5Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<int> numbers)
    {

        var result = numbers.Select(x => (number: x,
square: x * x)).Where(x => x.square > 20).Select(x => $"{x.number} - {x.square}").ToArray();
        return Ok(result);

    }
}
