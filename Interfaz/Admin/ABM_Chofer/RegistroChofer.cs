using ClasesReservaTransporte.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class RegistroChofer : Form
    {
        public RegistroChofer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text))
               
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string tipoLicencia = textBox3.Text;
            bool estado = true; //disponible por defecto
            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                if (chofer.Nombre == nombre && chofer.Apellido == apellido && chofer.Tipo_Licencia == tipoLicencia)
                {
                    MessageBox.Show("El chofer ya está registrado.");
                    return;
                }
            }
            choferRepository.Agregar(new Chofer { Nombre = nombre, Apellido = apellido, Tipo_Licencia = tipoLicencia, Estado = estado });
            MessageBox.Show("Chofer registrado exitosamente.");
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }
    }
}
