
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    private static List<string> dayWeek = new List<string> { "lunes", "martes", "miércoles", "jueves", "viernes", "sabado", "domingo" };


    [HttpGet]
    public IActionResult Get(string dayName)
    {
        foreach (var day in dayWeek)
        {
            if (day == dayName.ToLower().Trim())
            {
                if (dayName.ToLower().Trim() == "domingo" || dayName.ToLower().Trim() == "sabado")
                {
                    return Ok("Fin de semana");
                }
                return Ok("Es dia de semana");
            }
        }

        return StatusCode(400, "Datos incorrectos");
    }
}

