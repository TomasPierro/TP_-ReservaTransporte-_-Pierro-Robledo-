using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Interfaz.Usuario
{
    public partial class RegistrarReserva : Form
    {
        private readonly IGenericRepository<Chofer> _choferRepository;
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IGenericRepository<Reserva> _reservaRepository;
        private readonly IFormNavigation _navigation;

        public RegistrarReserva(
            IGenericRepository<Chofer> choferRepository,
            IGenericRepository<Vehiculo> vehiculoRepository,
            IGenericRepository<Reserva> reservaRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _choferRepository = choferRepository;
            _vehiculoRepository = vehiculoRepository;
            _reservaRepository = reservaRepository;
            _navigation = navigation;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar choferes
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            foreach (var chofer in _choferRepository.ObtenerTodos())
            {
                listBox2.Items.Add(
                    $"ID: {chofer.Id}, Nombre: {chofer.Nombre}, Apellido: {chofer.Apellido}, Cédula: {chofer.Tipo_Licencia}");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar vehículos disponibles
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Estado == true)
                {
                    listBox3.Items.Add($"ID: {vehiculo.Id},Precio por dia: {vehiculo.CosteXdia}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Placa: {vehiculo.Patente}");
                }
            }
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        // Registrar reserva
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Complete el vehículo, los días y el seguro.");
                return;
            }

            int clienteId = SesionActual.ClienteId;

            // El chofer es opcional
            int? choferId = null;

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (!int.TryParse(textBox2.Text, out int idChofer))
                {
                    MessageBox.Show("Ingrese un ID de chofer válido.");
                    return;
                }

                bool choferEncontrado = false;

                foreach (var chofer in _choferRepository.ObtenerTodos())
                {
                    if (chofer.Id == idChofer)
                    {
                        choferEncontrado = true;
                        choferId = idChofer;
                        break;
                    }
                }

                if (!choferEncontrado)
                {
                    MessageBox.Show("No se encontró el chofer seleccionado.");
                    return;
                }
            }

            // Validar vehículo
            if (!int.TryParse(textBox3.Text, out int vehiculoId))
            {
                MessageBox.Show("Ingrese un ID de vehículo válido.");
                return;
            }

            Vehiculo vehiculoSeleccionado = null;

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == vehiculoId)
                {
                    vehiculoSeleccionado = vehiculo;
                    break;
                }
            }

            if (vehiculoSeleccionado == null)
            {
                MessageBox.Show("No se encontró el vehículo seleccionado.");
                return;
            }

            if (!vehiculoSeleccionado.Estado)
            {
                MessageBox.Show("El vehículo ya no está disponible.");
                return;
            }

            // Validar días
            if (!int.TryParse(textBox4.Text, out int diasReserva) ||
                diasReserva <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de días válida.");
                return;
            }

            // Obtener precio del seguro
            string seguroSeleccionado = comboBox1.SelectedItem.ToString();

            string[] partesSeguro = seguroSeleccionado.Split('$');

            if (partesSeguro.Length < 2 ||
                !double.TryParse(
                    partesSeguro[1].Trim(),
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out double seguro))
            {
                MessageBox.Show("No se pudo obtener el precio del seguro.");
                return;
            }

            // Calcular costo y seña
            double costeTotal =
                (vehiculoSeleccionado.CosteXdia * diasReserva) + seguro;

            double seña = costeTotal * 0.5;

            textBox6.Text = seña.ToString();

            // Crear reserva
            _reservaRepository.Agregar(new Reserva
            {
                ClienteId = clienteId,
                ChoferId = choferId,
                VehiculoId = vehiculoId,
                DiasReserva = diasReserva,
                Seguro = seguro,
                Seña = seña,
                Estado = true
            });

            // Marcar vehículo como no disponible
            vehiculoSeleccionado.Estado = false;
            _vehiculoRepository.Modificar(vehiculoSeleccionado);

            MessageBox.Show("Reserva registrada exitosamente.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Volver al menú del cliente
        private void button5_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuCliente>(this);
        }
    }
}
