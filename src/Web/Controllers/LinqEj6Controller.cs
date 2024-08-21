using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class LinqEj6Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get([FromQuery] List<string> words)
    {
        var result = words.Select(x => x.Replace("ia", "*")).ToList();
        return Ok(result);
    }
}
