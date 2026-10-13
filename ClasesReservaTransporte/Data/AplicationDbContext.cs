using Microsoft.EntityFrameworkCore;
using ClasesReservaTransporte.Models;
namespace ClasesReservaTransporte.Data
{
    public class AplicationDbContext : DbContext
    {

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculos { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TPFINAL.db");
        }
    }
}
