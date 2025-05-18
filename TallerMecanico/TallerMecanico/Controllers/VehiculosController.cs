using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private static readonly List<Vehiculo> _vehiculos = new List<Vehiculo>
        {
            new Vehiculo
            {
                Id = 1,
                Placa = "P123ABC",
                Marca = "Toyota",
                Modelo = "Hilux",
                Anio = 2022,
                Color = "Blanco",
                PropietarioId = "1"
            },
            new Vehiculo
            {
                Id = 2,
                Placa = "P456DEF",
                Marca = "Honda",
                Modelo = "Civic",
                Anio = 2021,
                Color = "Negro",
                PropietarioId = "2"
            },
            new Vehiculo
            {
                Id = 3,
                Placa = "P789GHI",
                Marca = "Mazda",
                Modelo = "CX-5",
                Anio = 2023,
                Color = "Rojo",
                PropietarioId = "3"
            },
            new Vehiculo
            {
                Id = 4,
                Placa = "P234JKL",
                Marca = "Volkswagen",
                Modelo = "Tiguan",
                Anio = 2022,
                Color = "Gris",
                PropietarioId = "4"
            },
            new Vehiculo
            {
                Id = 5,
                Placa = "P567MNO",
                Marca = "Mitsubishi",
                Modelo = "Outlander",
                Anio = 2023,
                Color = "Azul",
                PropietarioId = "5"
            },
            new Vehiculo
            {
                Id = 6,
                Placa = "P890PQR",
                Marca = "Kia",
                Modelo = "Sportage",
                Anio = 2022,
                Color = "Plateado",
                PropietarioId = "6"
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Vehiculo>> Get()
        {
            return Ok(_vehiculos);
        }
    }
}