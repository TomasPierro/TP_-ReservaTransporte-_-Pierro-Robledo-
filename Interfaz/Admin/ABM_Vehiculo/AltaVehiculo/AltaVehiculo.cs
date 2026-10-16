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

            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();
            string Marca = textBox1.Text;
            string Modelo = textBox2.Text;
            string Patente = textBox3.Text;
            double CosteXdia = double.Parse(textBox4.Text);
            int TipoVehiculoId = int.Parse(textBox5.Text);

            vehiculoRepository.Agregar(new Vehiculo { Marca = Marca, Modelo = Modelo, Patente = Patente, CosteXdia = CosteXdia, TipoVehiculoId = TipoVehiculoId });

            MessageBox.Show("Vehiculo agregado correctamente");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GenericRepository<TipoVehiculo> tipoVehiculoRepository = new GenericRepository<TipoVehiculo>();
            List<TipoVehiculo> tiposVehiculos = tipoVehiculoRepository.ObtenerTodos();
            foreach (TipoVehiculo tipoVehiculo in tiposVehiculos)
            {
                listBox1.Items.Add($"{tipoVehiculo.Id} - {tipoVehiculo.Tipo}");
            }

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
    }
}
