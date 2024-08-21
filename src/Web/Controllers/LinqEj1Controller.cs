using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class LinqEj1Controller : ControllerBase
{
    [HttpGet]
    public List<int> Get(int min, int max)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = numbers.Where(x => x >= min && x <= max).ToList();
        return result;
    }
}
