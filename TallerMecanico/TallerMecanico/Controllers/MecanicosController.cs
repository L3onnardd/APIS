using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MecanicosController : ControllerBase
    {
        private static readonly List<Mecanico> _mecanicos = new List<Mecanico>
        {
            new Mecanico
            {
                Id = 1,
                Nombre = "Carlos",
                Apellido = "Perez",
                Especialidad = "Motor",
                Telefono = "5555-1234",
                DPI = "1234567890101",
                Direccion = "Zona 10, Guatemala Ciudad"
            },
            new Mecanico
            {
                Id = 2,
                Nombre = "Juan",
                Apellido = "Garcia",
                Especialidad = "Electricidad",
                Telefono = "5555-5678",
                DPI = "2345678901201",
                Direccion = "Zona 14, Guatemala Ciudad"
            },
            new Mecanico
            {
                Id = 3,
                Nombre = "Miguel",
                Apellido = "Lopez",
                Especialidad = "Frenos",
                Telefono = "5555-9012",
                DPI = "3456789012301",
                Direccion = "Zona 9, Guatemala Ciudad"
            },
            new Mecanico
            {
                Id = 4,
                Nombre = "Roberto",
                Apellido = "Martinez",
                Especialidad = "Suspension",
                Telefono = "5555-3456",
                DPI = "4567890123401",
                Direccion = "Zona 15, Guatemala Ciudad"
            },
            new Mecanico
            {
                Id = 5,
                Nombre = "Luis",
                Apellido = "Hernandez",
                Especialidad = "Transmision",
                Telefono = "5555-7890",
                DPI = "5678901234501",
                Direccion = "Zona 11, Guatemala Ciudad"
            },
            new Mecanico
            {
                Id = 6,
                Nombre = "Pedro",
                Apellido = "Gonzalez",
                Especialidad = "Diagnostico",
                Telefono = "5555-4321",
                DPI = "6789012345601",
                Direccion = "Zona 13, Guatemala Ciudad"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mecanico>> Get()
        {
            return Ok(_mecanicos);
        }
    }
}