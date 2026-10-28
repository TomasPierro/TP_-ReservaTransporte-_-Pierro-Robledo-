using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class reportes : Form
    {
        private void button6_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();

            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Dni: {cliente.Dni}, Teléfono: {cliente.Telefono}, Nro de Licencia: {cliente.Nro_Licencia}");
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
                listBox3.Items.Add($"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Patente: {vehiculo.Patente}, Coste por día: {vehiculo.CosteXdia}");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Reserva> reservaRepository = new GenericRepository<Reserva>();


            foreach (var reserva in reservaRepository.ObtenerTodos())
            {
                listBox2.Items.Add($"ClienteId: {reserva.ClienteId}, VehiculoId: {reserva.VehiculoId}, DiasReserva: {reserva.DiasReserva}, Seguro: {reserva.Seguro}, Seña: {reserva.Seña}");
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericRepository<Pago> pagoRepository = new GenericRepository<Pago>();

            foreach (var pago in pagoRepository.ObtenerTodos())
            {
                listBox4.Items.Add($"Formas de pago: {pago.MetodoPago}, Pago final: {pago.PagoFinal}");
            }
        }
    }
}
