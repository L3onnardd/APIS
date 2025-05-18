using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static readonly List<Cliente> _clientes = new List<Cliente>
        {
            new Cliente
            {
                Id = 1,
                Nombre = "Maria",
                Apellido = "Rodriguez",
                DPI = "1234567890101",
                Telefono = "4789-1234",
                Direccion = "Zona 10, Guatemala",
                Email = "maria.rodriguez@email.com"
            },
            new Cliente
            {
                Id = 2,
                Nombre = "Jose",
                Apellido = "Mendez",
                DPI = "2345678901201",
                Telefono = "4789-5678",
                Direccion = "Zona 14, Guatemala",
                Email = "jose.mendez@email.com"
            },
            new Cliente
            {
                Id = 3,
                Nombre = "Ana",
                Apellido = "Lopez",
                DPI = "3456789012301",
                Telefono = "4789-9012",
                Direccion = "Zona 15, Guatemala",
                Email = "ana.lopez@email.com"
            },
            new Cliente
            {
                Id = 4,
                Nombre = "Francisco",
                Apellido = "Garcia",
                DPI = "4567890123401",
                Telefono = "4789-3456",
                Direccion = "Zona 16, Guatemala",
                Email = "francisco.garcia@email.com"
            },
            new Cliente
            {
                Id = 5,
                Nombre = "Sofia",
                Apellido = "Martinez",
                DPI = "5678901234501",
                Telefono = "4789-7890",
                Direccion = "Zona 9, Guatemala",
                Email = "sofia.martinez@email.com"
            },
            new Cliente
            {
                Id = 6,
                Nombre = "Diego",
                Apellido = "Hernandez",
                DPI = "6789012345601",
                Telefono = "4789-4321",
                Direccion = "Zona 13, Guatemala",
                Email = "diego.hernandez@email.com"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Ok(_clientes);
        }
    }
}