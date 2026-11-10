
using System;
using System.Windows.Forms;

using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using Interfaz.Services;

namespace Interfaz
{
    public partial class Reportes : Form
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IGenericRepository<Reserva> _reservaRepository;
        private readonly IGenericRepository<Pago> _pagoRepository;
        private readonly IFormNavigation _navigation;

        public Reportes(
            IGenericRepository<Cliente> clienteRepository,
            IGenericRepository<Vehiculo> vehiculoRepository,
            IGenericRepository<Reserva> reservaRepository,
            IGenericRepository<Pago> pagoRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _clienteRepository = clienteRepository;
            _vehiculoRepository = vehiculoRepository;
            _reservaRepository = reservaRepository;
            _pagoRepository = pagoRepository;
            _navigation = navigation;
        }

        // Volver al menú administrador
        private void button6_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar clientes
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var cliente in _clienteRepository.ObtenerTodos())
            {
                listBox1.Items.Add(
                    $"Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Dni: {cliente.Dni}, Teléfono: {cliente.Telefono}, Nro de Licencia: {cliente.Nro_Licencia}");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar vehículos
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                listBox3.Items.Add(
                    $"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Patente: {vehiculo.Patente}, Coste por día: {vehiculo.CosteXdia}");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar reservas
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            foreach (var reserva in _reservaRepository.ObtenerTodos())
            {
                if (reserva.Estado == true)
                {
                    listBox2.Items.Add($"ClienteId: {reserva.ClienteId}, VehiculoId: {reserva.VehiculoId}, DiasReserva: {reserva.DiasReserva}, Seguro: {reserva.Seguro}, Seña: {reserva.Seña}");
                }
               
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar pagos
        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            foreach (var pago in _pagoRepository.ObtenerTodos())
            {
                listBox4.Items.Add(
                    $"Formas de pago: {pago.MetodoPago}, Pago final: {pago.PagoFinal}");
            }
        }
    }
}
