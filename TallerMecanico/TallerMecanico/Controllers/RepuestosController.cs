using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        private static readonly List<Repuesto> _repuestos = new List<Repuesto>
        {
            new Repuesto
            {
                Id = 1,
                Codigo = "FIL001",
                Nombre = "Filtro de Aceite Toyota",
                Marca = "Toyota",
                Precio = 125.00M,
                Stock = 50,
                Categoria = "Filtros"
            },
            new Repuesto
            {
                Id = 2,
                Codigo = "BAT002",
                Nombre = "Bateria 12V",
                Marca = "Bosch",
                Precio = 850.00M,
                Stock = 15,
                Categoria = "Baterias"
            },
            new Repuesto
            {
                Id = 3,
                Codigo = "FRE003",
                Nombre = "Pastillas de Freno Delanteras",
                Marca = "Brembo",
                Precio = 450.00M,
                Stock = 30,
                Categoria = "Frenos"
            },
            new Repuesto
            {
                Id = 4,
                Codigo = "AMO004",
                Nombre = "Amortiguadores Delanteros",
                Marca = "Monroe",
                Precio = 975.00M,
                Stock = 20,
                Categoria = "Suspension"
            },
            new Repuesto
            {
                Id = 5,
                Codigo = "ACE005",
                Nombre = "Aceite Sintetico 5W-30",
                Marca = "Mobil",
                Precio = 275.00M,
                Stock = 100,
                Categoria = "Lubricantes"
            },
            new Repuesto
            {
                Id = 6,
                Codigo = "BUJ006",
                Nombre = "Bujias de Iridio",
                Marca = "NGK",
                Precio = 95.00M,
                Stock = 60,
                Categoria = "Encendido"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Repuesto>> Get()
        {
            return Ok(_repuestos);
        }
    }
}