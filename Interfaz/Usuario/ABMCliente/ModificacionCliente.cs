using System;
using System.Windows.Forms;
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;

namespace Interfaz.Usuario.ABMCliente
{
    public partial class ModificacionCliente : Form
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;
        private readonly IFormNavigation _navigation;

        public ModificacionCliente(
            IGenericRepository<Cliente> clienteRepository,
            IFormNavigation navigation)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Cargar los datos del cliente
        private void button1_Click(object sender, EventArgs e)
        {

            int clienteId = SesionActual.ClienteId;

            var clientes = _clienteRepository.ObtenerTodos();

            MessageBox.Show(
                $"ID de sesión: {clienteId}\nClientes encontrados: {clientes.Count}"
            );

            foreach (var cliente in _clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == clienteId)
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

        // Mostrar los datos del cliente
        private void button2_Click(object sender, EventArgs e)
        {
            int clienteId = SesionActual.ClienteId;

            foreach (var cliente in _clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == clienteId)
                {
                    listBox1.Items.Clear();

                    listBox1.Items.Add(
                        $"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Dni: {cliente.Dni}," +
                        $" Telefono: {cliente.Telefono}, Nro_Licencia: {cliente.Nro_Licencia}");

                    return;
                }
            }
        }

        // Volver al menú del cliente
        private void button3_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuCliente>(this);
        }

        // Modificar los datos del cliente
        private void button4_Click(object sender, EventArgs e)
        {
            int clienteId = SesionActual.ClienteId;

            foreach (var cliente in _clienteRepository.ObtenerTodos())
            {
                if (cliente.Id == clienteId)
                {
                    cliente.Nombre = textBox1.Text;
                    cliente.Apellido = textBox2.Text;
                    cliente.Dni = textBox3.Text;
                    cliente.Telefono = textBox4.Text;
                    cliente.Nro_Licencia = textBox5.Text;

                    _clienteRepository.Modificar(cliente);

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
