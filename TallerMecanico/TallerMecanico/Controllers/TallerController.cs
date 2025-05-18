using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        private static readonly List<Taller> _taller = new List<Taller>
        {
            new Taller
            {
                Id = 1,
                Nombre = "Taller Mecanico El Experto",
                Direccion = "12 Calle 15-23 Zona 10, Guatemala Ciudad",
                Telefono = "2222-5555",
                Email = "contacto@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            },
            new Taller
            {
                Id = 2,
                Nombre = "Taller Mecanico El Experto Sucursal 2",
                Direccion = "15 Avenida 20-25 Zona 14, Guatemala Ciudad",
                Telefono = "2222-6666",
                Email = "sucursal2@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            },
            new Taller
            {
                Id = 3,
                Nombre = "Taller Mecanico El Experto Sucursal 3",
                Direccion = "10 Calle 10-15 Zona 9, Guatemala Ciudad",
                Telefono = "2222-7777",
                Email = "sucursal3@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            },
            new Taller
            {
                Id = 4,
                Nombre = "Taller Mecanico El Experto Sucursal 4",
                Direccion = "20 Avenida 25-30 Zona 15, Guatemala Ciudad",
                Telefono = "2222-8888",
                Email = "sucursal4@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            },
            new Taller
            {
                Id = 5,
                Nombre = "Taller Mecanico El Experto Sucursal 5",
                Direccion = "5 Calle 5-10 Zona 13, Guatemala Ciudad",
                Telefono = "2222-9999",
                Email = "sucursal5@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            },
            new Taller
            {
                Id = 6,
                Nombre = "Taller Mecanico El Experto Sucursal 6",
                Direccion = "25 Avenida 30-35 Zona 16, Guatemala Ciudad",
                Telefono = "2222-0000",
                Email = "sucursal6@tallerexperto.com.gt",
                Horario = "Lunes a Sabado 8:00 - 18:00",
                NIT = "12345678-9"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Taller>> Get()
        {
            return Ok(_taller);
        }
    }
}