using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;

namespace Interfaz.Usuario.ABMCliente
{
    public partial class ModificacionCliente : Form
    {
        public ModificacionCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ClienteId = SesionActual.ClienteId;
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();

            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == ClienteId)
                {
                    textBox1.Text = cliente.Nombre;
                    textBox2.Text = cliente.Apellido;
                    textBox3.Text = cliente.Dni;
                    textBox4.Text = cliente.Telefono;
                    textBox5.Text = cliente.Nro_Licencia;
                    return;
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();
            int clienteId = SesionActual.ClienteId;

            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == clienteId)
                {
                    listBox1.Items.Add($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Dni: {cliente.Dni}," +
                        $" Telefono: {cliente.Telefono}, Nro_Licencia: {cliente.Nro_Licencia}");
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();
            int clienteId = SesionActual.ClienteId;

            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == clienteId)
                {
                    cliente.Nombre = textBox1.Text;
                    cliente.Apellido = textBox2.Text;
                    cliente.Dni = textBox3.Text;
                    cliente.Telefono = textBox4.Text;
                    cliente.Nro_Licencia = textBox5.Text;
                    clienteRepository.Modificar(cliente);
                    MessageBox.Show("Cliente modificado correctamente.");
                    listBox1.Items.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();

                    return;
                }
            }
        }
    }
}
