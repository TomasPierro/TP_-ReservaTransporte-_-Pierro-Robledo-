using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.ABM_Vehiculo;
using Interfaz.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Interfaz.Services;
using Interfaz.Usuario.ABMCliente;

namespace Interfaz
{
    public partial class Inicio : Form
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;
        private readonly IFormNavigation _navigation;

        public Inicio(IGenericRepository<Cliente> clienteRepository, IFormNavigation navigation)
        {
            InitializeComponent();
            _clienteRepository = clienteRepository;
            _navigation = navigation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contrasenia = textBox2.Text;

            var clienteEncontrado = _clienteRepository
                .ObtenerTodos()
                .FirstOrDefault(c => c.Nombre == nombreUsuario &&
                                     c.Contrasenia == contrasenia);

            if (clienteEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            if (clienteEncontrado.Rol == 0)
            {
                SesionActual.ClienteId = clienteEncontrado.Id;
                MessageBox.Show("Inicio de sesión exitoso");
                _navigation.Mostrar<MenuCliente>(this);
            }
            else if (clienteEncontrado.Rol == 1)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                _navigation.Mostrar<MenuAdmin>(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           _navigation.Mostrar<RegistroUsu>(this);
        }
    }
}
