namespace ClasesReservaTransporte.Models
{
    public class Chofer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo_Licencia { get; set; }
        public bool Estado { get; set; } // Nuevo atributo para indicar si el chofer está disponible o no
    }
}
