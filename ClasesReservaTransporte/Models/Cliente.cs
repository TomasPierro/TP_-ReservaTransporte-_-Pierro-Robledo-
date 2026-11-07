namespace ClasesReservaTransporte.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Nro_Licencia { get; set; }
        public int Rol { get; set; }
        public string Contrasenia { get; set; }
    }
}
