using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesReservaTransporte.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public double CosteXdia { get; set; }
        public int TipoVehiculoId { get; set; }
    }
}
