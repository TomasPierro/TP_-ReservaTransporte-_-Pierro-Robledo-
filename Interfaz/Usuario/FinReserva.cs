using ClasesReservaTransporte.Repositories;
using ClasesReservaTransporte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            GenericRepository<Pago> pagoRepository = new GenericRepository<Pago>();
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            int reservaId = int.Parse(textBox3.Text);
            string metodoPago = comboBox1.SelectedItem.ToString();
            int moroso = int.Parse(textBox1.Text);
            foreach (var reserva in reservaRepository.ObtenerTodos())
            {
                if (reserva.Id == reservaId)
                {
                    if (moroso == 1)
                    {
                        double pagoFinal = reserva.Seña * 0.30 ;
                        textBox1.Text = pagoFinal.ToString();
                        pagoRepository.Agregar(new Pago
                        {
                            MetodoPago = metodoPago,
                            PagoFinal = pagoFinal,
                            Estado = true
                        });
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
                    }

                    return;
                }
            }
            MessageBox.Show("Reserva no encontrada.");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();
            foreach (var reserva in reservaRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"Reserva ID: {reserva.Id}, Usuario: {reserva.ClienteId}");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
