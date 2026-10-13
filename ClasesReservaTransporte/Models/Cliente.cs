using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesReservaTransporte.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Telefono { get; set; }
        public int Nro_Licencia { get; set; }
    }
}
