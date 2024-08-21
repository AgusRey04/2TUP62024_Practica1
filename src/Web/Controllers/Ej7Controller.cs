
using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase

{
    [HttpGet]
    //Reciba un número entero de inicio y un número entero de fin.
    //Debe verificar que la diferencia entre inicio y fin sea menor a 1000.
    //Debe retornar una lista de número que inicie en el valor de inicio y termine en el valor de fin.
    //Usar un bucle for.
    public IActionResult Get(int numerStart, int end)
    {
        if (numerStart > end)
        {
            return BadRequest("El número de inicio no puede ser mayor al número de fin");
        }
        if (numerStart == end)
        {
            return Ok(numerStart);
        }
        if (numerStart < 0 || end < 0)
        {
            return BadRequest("Los valores deben ser enteros positivos");
        }
        if (end - numerStart > 1000)
        {
            return BadRequest("La diferencia entre el número de inicio y el de fin es mayor a 1000");
        }

        List<int> elements = [numerStart];

        for (int i = numerStart; i < end - 1; i++)
        {
            if (i >= numerStart)
            {
                elements.Add(i + 1);

            }
        }

        return Ok(elements);
    }
}
