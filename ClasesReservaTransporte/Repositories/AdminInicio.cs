using ClasesReservaTransporte.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ClasesReservaTransporte.Repositories
{
    public class AdminInicio
    {
        public static void CrearAdmin()
        {
            GenericRepository<Cliente> clienteRepository =new GenericRepository<Cliente>();

            var clientes = clienteRepository.ObtenerTodos();

            bool existeAdmin = clientes.Any(c => c.Rol == 1);

            if (!existeAdmin)
            {
                Cliente admin = new Cliente()
                {
                    Nombre = "Administrador",
                    Apellido = "Sistema",
                    Dni = "00",
                    Telefono = "00",
                    Nro_Licencia = "00",
                    Rol = 1,
                    Contrasenia = "admin123"
                };

                clienteRepository.Agregar(admin);
            }
        }
    }


}
