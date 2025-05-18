namespace TallerMecanico.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public string NIT { get; set; }
        public string Direccion { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}