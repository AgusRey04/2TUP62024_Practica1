using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int numerStart, int end)
    {
        if (numerStart > end)
            return BadRequest("El número de inicio no puede ser mayor al número de fin");

        if (numerStart == end)
            return Ok(numerStart);

        if (numerStart < 0 || end < 0)
            return BadRequest("Los valores deben ser enteros positivos");

        if (end - numerStart > 1000)
            return BadRequest("La diferencia entre el número de inicio y el de fin es mayor a 1000");


        List<int> elements = [numerStart];

        while (numerStart < end)
        {
            numerStart++;
            if (numerStart % 2 == 0)
                elements.Add(numerStart);


        }
        return Ok(elements);
    }

}

