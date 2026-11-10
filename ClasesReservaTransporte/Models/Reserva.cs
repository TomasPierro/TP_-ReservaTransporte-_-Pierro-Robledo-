namespace ClasesReservaTransporte.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int? ChoferId { get; set; }
        public int VehiculoId { get; set; }
        public int DiasReserva { get; set; }
        public double Seguro { get; set; }
        public double Seña { get; set; }
        public bool Estado { get; set; } 

    }
}
