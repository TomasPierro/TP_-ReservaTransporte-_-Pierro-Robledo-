using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesReservaTransporte.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public string MetodoPago { get; set; }
        public double PagoFinal { get; set; }
        public bool Estado { get; set; }
    }
}
