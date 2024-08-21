
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj4Controller : ControllerBase
{
    [HttpGet]
    public List<int> Get()
    {
        List<int> numbers = [78, -9, 0, 23, 54, 21, 7, 86];
        var result = numbers.OrderByDescending(x => x).Take(5).ToList();
        return result;

    }
}
