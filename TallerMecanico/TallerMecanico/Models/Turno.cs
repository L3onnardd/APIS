namespace TallerMecanico.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Placa { get; set; }
        public int MecanicoId { get; set; }
        public string Estado { get; set; }
        public string Servicio { get; set; }
    }
}