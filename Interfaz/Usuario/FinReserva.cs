
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;
using Interfaz;
using System;
using System.Windows.Forms;

namespace Interfaz.Usuario
{
    public partial class FinReserva : Form
    {
        private readonly IGenericRepository<Pago> _pagoRepository;
        private readonly IGenericRepository<Reserva> _reservaRepository;
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IFormNavigation _navigation;

        public FinReserva(
            IGenericRepository<Pago> pagoRepository,
            IGenericRepository<Reserva> reservaRepository,
            IGenericRepository<Vehiculo> vehiculoRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _pagoRepository = pagoRepository;
            _reservaRepository = reservaRepository;
            _vehiculoRepository = vehiculoRepository;
            _navigation = navigation;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Finalizar reserva y registrar el pago
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int reservaId))
            {
                MessageBox.Show("Ingrese un ID de reserva válido.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int moroso) ||
                (moroso != 0 && moroso != 1))
            {
                MessageBox.Show("Ingrese 1 si es moroso o 0 si no lo es.");
                return;
            }

            // Buscar la reserva
            Reserva reservaEncontrada = null;

            foreach (var reserva in _reservaRepository.ObtenerTodos())
            {
                if (reserva.Id == reservaId)
                {
                    reservaEncontrada = reserva;
                    break;
                }
            }

            if (reservaEncontrada == null)
            {
                MessageBox.Show("Reserva no encontrada.");
                return;
            }

            if (reservaEncontrada.Estado == false)
            {
                MessageBox.Show("Esta reserva ya fue finalizada.");
                return;
            }

            string metodoPago = comboBox1.SelectedItem.ToString();

            double pagoFinal;

            if (moroso == 1)
            {
                pagoFinal = reservaEncontrada.Seña * 0.30
                            + reservaEncontrada.Seña;
            }
            else
            {
                pagoFinal = reservaEncontrada.Seña;
            }

            textBox1.Text = pagoFinal.ToString();

            // Registrar el pago
            _pagoRepository.Agregar(new Pago
            {
                MetodoPago = metodoPago,
                PagoFinal = pagoFinal + reservaEncontrada.Seña,
                Estado = true
            });

            // Liberar el vehículo
            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == reservaEncontrada.VehiculoId)
                {
                    vehiculo.Estado = true;
                    _vehiculoRepository.Modificar(vehiculo);
                    break;
                }
            }

            // Cambiar el estado de la reserva
            reservaEncontrada.Estado = false;
            _reservaRepository.Modificar(reservaEncontrada);

            MessageBox.Show("Reserva finalizada y pago registrado correctamente.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Mostrar las reservas activas del cliente
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var reserva in _reservaRepository.ObtenerTodos())
            {
                if (reserva.ClienteId == SesionActual.ClienteId &&
                    reserva.Estado == true)
                {
                    foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
                    {
                        if (vehiculo.Id == reserva.VehiculoId)
                        {
                            listBox1.Items.Add(
                                $"Reserva ID: {reserva.Id}, Marca: {vehiculo.Marca}, Placa: {vehiculo.Patente}");
                            break;
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Volver al menú del cliente
        private void button3_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuCliente>(this);
        }
    }
}
