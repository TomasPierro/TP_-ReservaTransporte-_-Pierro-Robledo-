using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesReservaTransporte.Repositories
    {
        public class AdminInicio
        {
            private readonly IGenericRepository<Cliente> _clienteRepository;

            public AdminInicio(IGenericRepository<Cliente> clienteRepository)
            {
                _clienteRepository = clienteRepository;
            }

            public void CrearAdmin()
            {
                var clientes = _clienteRepository.ObtenerTodos();

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

                    _clienteRepository.Agregar(admin);
                }
            }
        }
}







