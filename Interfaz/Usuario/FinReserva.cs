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
    public partial class FinReserva : Form
    {
        public FinReserva()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))

            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            GenericRepository<Pago> pagoRepository = new GenericRepository<Pago>();
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();
            int reservaId = int.Parse(textBox3.Text);
            foreach (var reserva in reservaRepository.ObtenerTodos())
            {
                if (reserva.Id != reservaId)
                {
                    MessageBox.Show("Reserva no encontrada.");
                    break;
                }
            }
            string metodoPago = comboBox1.SelectedItem.ToString();
            int moroso = int.Parse(textBox2.Text);
            foreach (var reserva in reservaRepository.ObtenerTodos())
            {
                if (reserva.Id == reservaId)
                {
                    if (moroso == 1)
                    {
                        double pagoFinal = reserva.Seña * 0.30 + reserva.Seña;
                        textBox1.Text = pagoFinal.ToString();
                        pagoRepository.Agregar(new Pago
                        {
                            MetodoPago = metodoPago,
                            PagoFinal = pagoFinal,
                            Estado = true
                        });
                        foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
                        {
                            if (vehiculo.Id == reserva.VehiculoId)
                            {
                                vehiculo.Estado = true;
                                vehiculoRepository.Modificar(vehiculo);
                            }
                        }
                        if (reserva.Estado == true)
                        {
                            reserva.Estado = false;
                            reservaRepository.Modificar(reserva);
                        }
                    }
                    else
                    {
                        double pagoFinal = reserva.Seña;
                        textBox1.Text = pagoFinal.ToString();
                        pagoRepository.Agregar(new Pago
                        {
                            MetodoPago = metodoPago,
                            PagoFinal = pagoFinal,
                            Estado = true
                        });
                        foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
                        {
                            if (vehiculo.Id == reserva.VehiculoId)
                            {
                                vehiculo.Estado = true;
                                vehiculoRepository.Modificar(vehiculo);
                            }
                        }
                        if (reserva.Estado == true)
                        {
                            reserva.Estado = false;
                            reservaRepository.Modificar(reserva);
                        }
                    }

                    return;
                }
            }
            MessageBox.Show("Reserva no encontrada.");
            listBox1.Items.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Vehiculo> genericRepository = new GenericRepository<Vehiculo>();
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            foreach (var reserva in reservaRepository.ObtenerTodos())
            {

                if (reserva.ClienteId == SesionActual.ClienteId)
                {
                    if (reserva.Estado == true)
                    {
                        foreach (var vehiculo in genericRepository.ObtenerTodos())
                        {
                            if (vehiculo.Id == reserva.VehiculoId)
                            {
                                listBox1.Items.Add($"Reserva ID: {reserva.Id}, Marca: {vehiculo.Marca}, Placa: {vehiculo.Patente}");
                            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.Show();
            this.Hide();
        }
    }
}
