using ClasesReservaTransporte.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClasesReservaTransporte.Models;
using Interfaz.Admin;

namespace Interfaz.ABM_Vehiculo
{
    public partial class AltaVehiculo : Form
    {
        public AltaVehiculo()
        {
            InitializeComponent();
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
            

            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();
            string Marca = textBox1.Text;
            string Modelo = textBox2.Text;
            string Patente = textBox3.Text;
            if (!double.TryParse(textBox4.Text, out double CosteXdia))
            {
                MessageBox.Show("El coste por día debe contener solamente números.");
                return;
            }
            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Patente == Patente)
                {
                    MessageBox.Show("Ya existe un vehículo con la misma patente.");
                    return;
                }
            }
            string TipoVehiculo = textBox5.Text;
            bool Estado = true; // Asignar el estado como disponible al crear un nuevo vehículo
            vehiculoRepository.Agregar(new Vehiculo { Marca = Marca, Modelo = Modelo, Patente = Patente, CosteXdia = CosteXdia, TipoVehiculo = TipoVehiculo, Estado = Estado });

            MessageBox.Show("Vehiculo agregado correctamente");
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();
            return;

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
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
