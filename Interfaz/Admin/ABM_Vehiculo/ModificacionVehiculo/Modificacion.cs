
using System;
using System.Windows.Forms;

using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using Interfaz.Services;

namespace Interfaz.ABM_Vehiculo.ModificacionVehiculo
{
    public partial class Modificacion : Form
    {
        private readonly IGenericRepository<Vehiculo> _vehiculoRepository;
        private readonly IFormNavigation _navigation;

        public Modificacion(
            IGenericRepository<Vehiculo> vehiculoRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _vehiculoRepository = vehiculoRepository;
            _navigation = navigation;
        }

        // Mostrar todos los vehículos
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<Vehiculo> vehiculos = _vehiculoRepository.ObtenerTodos();

            foreach (var vehiculo in vehiculos)
            {
                listBox1.Items.Add(
                    $"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Patente: {vehiculo.Patente}, CosteXdia: {vehiculo.CosteXdia}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Volver al menú administrador
        private void button3_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
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

        // Buscar vehículo por ID y cargar sus datos
        private void button2_Click(object sender, EventArgs e)
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

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == idVehiculo)
                {
                    textBox2.Text = vehiculo.Marca;
                    textBox3.Text = vehiculo.Modelo;
                    textBox4.Text = vehiculo.Patente;
                    textBox5.Text = vehiculo.CosteXdia.ToString();

                    return;
                }
            }

            MessageBox.Show("Vehículo no encontrado");
        }

        // Guardar modificación
        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            if (!float.TryParse(textBox5.Text, out float coste))
            {
                MessageBox.Show("Ingrese un costo por día válido.");
                return;
            }

            foreach (var vehiculo in _vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == id)
                {
                    vehiculo.Marca = textBox2.Text;
                    vehiculo.Modelo = textBox3.Text;
                    vehiculo.Patente = textBox4.Text;
                    vehiculo.CosteXdia = coste;

                    _vehiculoRepository.Modificar(vehiculo);

                    MessageBox.Show("Vehículo modificado correctamente");

                    listBox1.Items.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();

                    return;
                }
            }

            MessageBox.Show("Vehículo no encontrado");
        }
    }
}
