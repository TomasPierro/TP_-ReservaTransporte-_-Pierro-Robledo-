
using System;
using System.Windows.Forms;

using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using Interfaz.Services;

namespace Interfaz.ABM_Vehiculo.BajaVehiculo
{
    public partial class Baja : Form
    {
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IFormNavigation _navigation;

        public Baja(
            IGenericRepository<Vehiculo> vehiculoRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _vehiculoRepository = vehiculoRepository;
            _navigation = navigation;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Buscar y mostrar todos los vehículos
        private void Buscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                listBox1.Items.Add(
                    $"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Patente: {vehiculo.Patente}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Eliminar vehículo por ID
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El id es obligatorio para proceder.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int idVehiculo))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            var vehiculos = _vehiculoRepository.ObtenerTodos();

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.Id == idVehiculo)
                {
                    _vehiculoRepository.Eliminar(vehiculo);

                    MessageBox.Show(
                        $"Vehículo con ID {idVehiculo} eliminado correctamente.");

                    listBox1.Items.Clear();
                    textBox1.Clear();

                    return;
                }
            }

            MessageBox.Show($"Vehículo con ID {idVehiculo} no encontrado.");
        }

        // Volver al menú administrador
        private void button2_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
        }
    }
}


