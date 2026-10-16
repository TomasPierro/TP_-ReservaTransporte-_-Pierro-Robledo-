using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;

namespace Interfaz.ABM_Vehiculo.BajaVehiculo
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Patente: {vehiculo.Patente}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            List<Vehiculo> vehiculos = vehiculoRepository.ObtenerTodos();

            int idVehiculo = int.Parse(textBox1.Text);

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == idVehiculo)
                {
                    vehiculoRepository.Eliminar(vehiculo);
                    MessageBox.Show($"Vehículo con ID {idVehiculo} eliminado correctamente.");
                    return;
                }
                else
                {
                    MessageBox.Show($"Vehículo con ID {idVehiculo} no encontrado.");
                    return;
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();

        }
    }
}
