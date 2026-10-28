using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz.Usuario
{
    public partial class RegistrarReserva : Form
    {
        public RegistrarReserva()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();

            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Cédula: {cliente.Nro_Licencia}");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                listBox2.Items.Add($"ID: {chofer.Id}, Nombre: {chofer.Nombre}, Cédula: {chofer.Tipo_Licencia}");
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
                listBox3.Items.Add($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Placa: {vehiculo.Patente}");
            }
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



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            int clienteId = int.Parse(textBox1.Text);
            int choferId = int.Parse(textBox2.Text);
            int vehiculoId = int.Parse(textBox3.Text);
            int diasReserva = int.Parse(textBox4.Text);
            double seguro = Convert.ToDouble(comboBox1.SelectedItem);

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == vehiculoId)
                {
                    double costeTotal = (vehiculo.CosteXdia * diasReserva) + seguro;
                    double seña = costeTotal * 0.5; // 50% del coste total
                    textBox6.Text = seña.ToString();
                    reservaRepository.Agregar(new Reserva { ClienteId = clienteId, ChoferId = choferId, VehiculoId = vehiculoId, DiasReserva = diasReserva, Seguro = seguro, Seña = seña });
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
