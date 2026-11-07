using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Interfaz.Admin;

namespace Interfaz
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();
            string nombreUsuario = textBox1.Text;
            string contrasenia = textBox2.Text;
            var clienteEncontrado = clienteRepository.ObtenerTodos().FirstOrDefault(c => c.Nombre == nombreUsuario && c.Contrasenia == contrasenia);
            
            if (clienteEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
           
           
            if (clienteEncontrado.Rol == 0)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                SesionActual.ClienteId = clienteEncontrado.Id;
                MenuCliente menuC = new MenuCliente();
                menuC.Show();
                this.Hide();
            }
            else if (clienteEncontrado.Rol == 1)
            {
                MessageBox.Show("Inicio de sesión exitoso");

                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Hide();
            }
        }
             
        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsu registroUsu = new RegistroUsu();
            registroUsu.Show();
            this.Hide();
        }
    }
}
