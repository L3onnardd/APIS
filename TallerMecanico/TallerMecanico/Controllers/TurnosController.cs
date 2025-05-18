using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private static readonly List<Turno> _turnos = new List<Turno>
        {
            new Turno
            {
                Id = 1,
                Fecha = DateTime.Parse("2024-01-20 09:00:00"),
                Placa = "P123ABC",
                MecanicoId = 1,
                Estado = "Programado",
                Servicio = "Servicio Mayor"
            },
            new Turno
            {
                Id = 2,
                Fecha = DateTime.Parse("2024-01-20 11:00:00"),
                Placa = "P456DEF",
                MecanicoId = 2,
                Estado = "En Proceso",
                Servicio = "Alineacion y Balanceo"
            },
            new Turno
            {
                Id = 3,
                Fecha = DateTime.Parse("2024-01-21 10:00:00"),
                Placa = "P789GHI",
                MecanicoId = 3,
                Estado = "Programado",
                Servicio = "Frenos Completos"
            },
            new Turno
            {
                Id = 4,
                Fecha = DateTime.Parse("2024-01-21 14:00:00"),
                Placa = "P234JKL",
                MecanicoId = 4,
                Estado = "Programado",
                Servicio = "Diagnostico Electronico"
            },
            new Turno
            {
                Id = 5,
                Fecha = DateTime.Parse("2024-01-22 09:00:00"),
                Placa = "P567MNO",
                MecanicoId = 5,
                Estado = "Programado",
                Servicio = "Cambio de Suspension"
            },
            new Turno
            {
                Id = 6,
                Fecha = DateTime.Parse("2024-01-22 11:00:00"),
                Placa = "P890PQR",
                MecanicoId = 6,
                Estado = "Programado",
                Servicio = "Servicio Menor"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Turno>> Get()
        {
            return Ok(_turnos);
        }
    }
}