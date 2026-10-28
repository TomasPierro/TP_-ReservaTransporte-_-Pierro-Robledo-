using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClasesReservaTransporte.Data;
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;

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
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string tipoLicencia = textBox3.Text;
            choferRepository.Agregar(new Chofer { Nombre = nombre, Apellido = apellido, Tipo_Licencia = tipoLicencia });
            MessageBox.Show("Chofer registrado exitosamente.");
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
