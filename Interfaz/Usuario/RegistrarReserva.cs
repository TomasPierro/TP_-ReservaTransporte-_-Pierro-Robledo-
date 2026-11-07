using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz.Usuario
{
    public partial class RegistrarReserva : Form
    {
        public RegistrarReserva()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                //if (chofer.Estado == true) // Solo mostrar choferes disponibles
                //{
                    listBox2.Items.Add($"ID: {chofer.Id}, Nombre: {chofer.Nombre},Apellido:{chofer.Apellido} Cédula: {chofer.Tipo_Licencia}");
               // }
                
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();
            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Estado == true) // Solo mostrar vehículos disponibles
                {
                    listBox3.Items.Add($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Placa: {vehiculo.Patente}");
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

        private void button4_Click(object sender, EventArgs e)
        {
            if ( 
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            int clienteId = SesionActual.ClienteId;
            int choferId = int.Parse(textBox2.Text);
            foreach(var chofer in new GenericRepository<Chofer>().ObtenerTodos())
            {
                if (chofer.Id != choferId)
                {
                    MessageBox.Show("No se encontró el chofer seleccionado.");
                    return;
                }
            } 
            int vehiculoId = int.Parse(textBox3.Text);
            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id != vehiculoId)
                {
                    MessageBox.Show("No se encontró el vehículo seleccionado.");
                    return;
                }
            }
            
            if (!int.TryParse(textBox4.Text, out int diasReserva))
            {
                MessageBox.Show("El número de días debe contener solamente números.");
                return;
            }
            string seguroSeleccionado = comboBox1.SelectedItem.ToString();

            string precioTexto = seguroSeleccionado.Split('$')[1];

            double seguro = Convert.ToDouble(precioTexto);

            bool reservaExistente = true;//osea esta vigente
            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == vehiculoId)
                {
                    double costeTotal = (vehiculo.CosteXdia * diasReserva) + seguro;
                    double seña = costeTotal * 0.5; // 50% del coste total
                    textBox6.Text = seña.ToString();
                    reservaRepository.Agregar(new Reserva { ClienteId = clienteId, ChoferId = choferId, VehiculoId = vehiculoId, DiasReserva = diasReserva, Seguro = seguro, Seña = seña , Estado = reservaExistente});
                    vehiculo.Estado = false;
                    MessageBox.Show("Reserva registrada exitosamente.");
                    return; 
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.Show();
            this.Hide();
        }
    }
}
