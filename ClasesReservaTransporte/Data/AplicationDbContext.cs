using ClasesReservaTransporte.Models;
using Microsoft.EntityFrameworkCore;
namespace ClasesReservaTransporte.Data
{
        public class AplicationDbContext : DbContext
        {
            public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
            {
            }

            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Chofer> Choferes { get; set; }
            public DbSet<Vehiculo> Vehiculos { get; set; }
            public DbSet<TipoVehiculo> TiposVehiculos { get; set; }
            public DbSet<Pago> Pagos { get; set; }
            public DbSet<Reserva> Reservas { get; set; }
        }
    
}

