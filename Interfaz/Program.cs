using ClasesReservaTransporte.Data;
using ClasesReservaTransporte.Repositories;
using Interfaz.ABM_Vehiculo;
using Interfaz.ABM_Vehiculo.BajaVehiculo;
using Interfaz.ABM_Vehiculo.ModificacionVehiculo;
using Interfaz.Admin;
using Interfaz.Admin.ABM_Chofer;
using Interfaz.Services;
using Interfaz.Usuario;
using Interfaz.Usuario.ABMCliente;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using System.IO;

namespace Interfaz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Crear el contenedor
            var services = new ServiceCollection();

            // 2. Registrar el contexto de Entity Framework
            services.AddDbContext<AplicationDbContext>(options =>options.UseSqlite(@"Data Source=C:\DATABASE\DATABASE.db"));

            // 3. Registrar el repositorio genérico
            services.AddScoped(
                typeof(IGenericRepository<>),
                typeof(GenericRepository<>)
            );

            // 4. Registrar los servicios
            services.AddScoped<AdminInicio>();
            services.AddScoped<IFormNavigation, FormNavigation>();

            // 5. Registrar los formularios
            services.AddTransient<Inicio>();
            
            services.AddTransient<MenuCliente>();
            services.AddTransient<RegistroUsu>();
            services.AddTransient<RegistrarReserva>();
            services.AddTransient<FinReserva>();
            services.AddTransient<ModificacionCliente>();

            services.AddTransient<MenuAdmin>();
            services.AddTransient<AltaVehiculo>();
            services.AddTransient<Baja>();
            services.AddTransient<Modificacion>();
            services.AddTransient<Reportes>();
            services.AddTransient<RegistroChofer>();
            services.AddTransient<ModificacionChofer>();
            services.AddTransient<BajaChofer>();

            // 6. Construir el proveedor
            var serviceProvider = services.BuildServiceProvider();

            // 7. Crear un ámbito
            using (var scope = serviceProvider.CreateScope())
            {
                // 8. Crear el administrador si no existe
                var adminInicio = scope.ServiceProvider
                    .GetRequiredService<AdminInicio>();

                adminInicio.CrearAdmin();

                // 9. Iniciar el formulario
                var inicio = scope.ServiceProvider .GetRequiredService<Inicio>();
               
                var context = scope.ServiceProvider.GetRequiredService<AplicationDbContext>();

                MessageBox.Show( Path.GetFullPath(context.Database.GetDbConnection().DataSource));
                Application.Run(inicio);
            }
        }
    }
}
