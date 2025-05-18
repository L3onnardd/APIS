// Controllers/FacturasController.cs
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private static readonly List<Factura> _facturas = new List<Factura>
        {
            new Factura
            {
                Id = 1,
                NumeroFactura = "A-001",
                Fecha = DateTime.Parse("2024-01-15"),
                NombreCliente = "Maria Rodriguez",
                NIT = "12345678",
                Direccion = "Zona 10, Guatemala",
                Total = 1500.00M,
                Estado = "Pagada"
            },
            new Factura
            {
                Id = 2,
                NumeroFactura = "A-002",
                Fecha = DateTime.Parse("2024-01-16"),
                NombreCliente = "Jose Mendez",
                NIT = "87654321",
                Direccion = "Zona 14, Guatemala",
                Total = 2300.00M,
                Estado = "Pendiente"
            },
            new Factura
            {
                Id = 3,
                NumeroFactura = "A-003",
                Fecha = DateTime.Parse("2024-01-17"),
                NombreCliente = "Ana Lopez",
                NIT = "45678912",
                Direccion = "Zona 15, Guatemala",
                Total = 850.00M,
                Estado = "Pagada"
            },
            new Factura
            {
                Id = 4,
                NumeroFactura = "A-004",
                Fecha = DateTime.Parse("2024-01-18"),
                NombreCliente = "Francisco Garcia",
                NIT = "78912345",
                Direccion = "Zona 16, Guatemala",
                Total = 3200.00M,
                Estado = "Pagada"
            },
            new Factura
            {
                Id = 5,
                NumeroFactura = "A-005",
                Fecha = DateTime.Parse("2024-01-19"),
                NombreCliente = "Sofia Martinez",
                NIT = "32145678",
                Direccion = "Zona 9, Guatemala",
                Total = 1750.00M,
                Estado = "Pendiente"
            },
            new Factura
            {
                Id = 6,
                NumeroFactura = "A-006",
                Fecha = DateTime.Parse("2024-01-20"),
                NombreCliente = "Diego Hernandez",
                NIT = "89123456",
                Direccion = "Zona 13, Guatemala",
                Total = 950.00M,
                Estado = "Pagada"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Factura>> Get()
        {
            return Ok(_facturas);
        }
    }
}