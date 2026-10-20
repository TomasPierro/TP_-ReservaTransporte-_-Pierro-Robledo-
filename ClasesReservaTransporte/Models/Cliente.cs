namespace ClasesReservaTransporte.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Telefono { get; set; }
        public int Nro_Licencia { get; set; }
        public int Rol { get; set; }
        public string Contraseña { get; set; }
    }
}
