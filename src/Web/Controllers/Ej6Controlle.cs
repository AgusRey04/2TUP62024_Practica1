using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6controller : ControllerBase
{
    /// <summary>
    /// Reciba el precio de un producto (valor positivo), la cantidad a comprar y la forma de pagar (efectivo o tarjeta).
    //Si la forma de pago es mediante tarjeta, debe recibir también el número de la misma(inventado), verificar que sean 16 dígitos y retornar el valor a pagar con un 10% de recargo.
    //Si la forma de pago es mediante efectivo, retorna el valor a pagar.
    //Si la forma de pago no es tarjeta ni efectivo, debe retornar un status code del grupo de los 400.

    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="ciudad"></param>
    /// <returns></returns>

    [HttpGet]
    public IActionResult Get(float price, int amount, string pay, string numerCard = "")
    {
        if (price < 0 || amount <= 0)
            return BadRequest("Los valores de precio y cantidad deben ser positivos.");

        if (pay.ToLower() == "tarjeta" && numerCard.Length != 16)
        {
            return StatusCode(400, "El número de la tarjeta debe tener 16 dígitos.");
        }

        var priceWithCharge = price * amount;
        if (pay.ToLower() == "tarjeta")
        {
            return Ok($"El valor a pagar es: ${priceWithCharge * amount * 1.10}");
        }

        if (pay.ToLower() == "efectivo")
        {
            return Ok($"El valor a pagar es: ${priceWithCharge * amount}");
        }
        return StatusCode(400, "La forma de pago debe ser 'efectivo' o 'tarjeta'.");

    }
}
