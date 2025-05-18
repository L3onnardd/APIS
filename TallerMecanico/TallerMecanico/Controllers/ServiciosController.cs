using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private static readonly List<Servicio> _servicios = new List<Servicio>
        {
            new Servicio
            {
                Id = 1,
                Nombre = "Servicio Mayor",
                Descripcion = "Cambio de aceite, filtros y revision general",
                Precio = 1200.00M,
                TiempoEstimado = 4
            },
            new Servicio
            {
                Id = 2,
                Nombre = "Alineacion y Balanceo",
                Descripcion = "Alineacion computarizada y balanceo de llantas",
                Precio = 400.00M,
                TiempoEstimado = 2
            },
            new Servicio
            {
                Id = 3,
                Nombre = "Diagnostico Electronico",
                Descripcion = "Revision completa del sistema electronico",
                Precio = 350.00M,
                TiempoEstimado = 1
            },
            new Servicio
            {
                Id = 4,
                Nombre = "Frenos Completos",
                Descripcion = "Cambio de pastillas y discos de freno",
                Precio = 800.00M,
                TiempoEstimado = 3
            },
            new Servicio
            {
                Id = 5,
                Nombre = "Cambio de Suspension",
                Descripcion = "Cambio de amortiguadores y revision",
                Precio = 1500.00M,
                TiempoEstimado = 5
            },
            new Servicio
            {
                Id = 6,
                Nombre = "Servicio Menor",
                Descripcion = "Cambio de aceite y revision basica",
                Precio = 500.00M,
                TiempoEstimado = 2
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Servicio>> Get()
        {
            return Ok(_servicios);
        }
    }
}