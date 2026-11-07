using ClasesReservaTransporte.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Diagnostics;
namespace ClasesReservaTransporte.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Basep.db");
        }
    }
}
