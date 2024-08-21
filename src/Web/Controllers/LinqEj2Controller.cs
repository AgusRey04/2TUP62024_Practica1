using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj2Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get()
    {
        List<string> numbers = ["computadora", "usb"];
        var result = numbers.Where(x => x.Length >= 5).Select(x => x.ToUpper()).ToList();
        return result;

    }
}
