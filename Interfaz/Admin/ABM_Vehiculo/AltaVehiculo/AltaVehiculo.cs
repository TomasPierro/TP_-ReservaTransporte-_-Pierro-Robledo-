
using ClasesReservaTransporte.Repositories;
using ClasesReservaTransporte.Models;
using Interfaz.Admin;
using Interfaz.Services;
using System;
using System.Windows.Forms;

namespace Interfaz.ABM_Vehiculo
{
    public partial class AltaVehiculo : Form
    {
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IFormNavigation _navigation;

        public AltaVehiculo(
            IGenericRepository<Vehiculo> vehiculoRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _vehiculoRepository = vehiculoRepository;
            _navigation = navigation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            string Marca = textBox1.Text;
            string Modelo = textBox2.Text;
            string Patente = textBox3.Text;

            if (!double.TryParse(textBox4.Text, out double CosteXdia))
            {
                MessageBox.Show("El coste por día debe contener solamente números.");
                return;
            }

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Patente == Patente)
                {
                    MessageBox.Show("Ya existe un vehículo con la misma patente.");
                    return;
                }
            }

            string TipoVehiculo = textBox5.Text;
            bool Estado = true;

            _vehiculoRepository.Agregar(new Vehiculo
            {
                Marca = Marca,
                Modelo = Modelo,
                Patente = Patente,
                CosteXdia = CosteXdia,
                TipoVehiculo = TipoVehiculo,
                Estado = Estado
            });

            MessageBox.Show("Vehiculo agregado correctamente");

            _navigation.Mostrar<MenuAdmin>(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
