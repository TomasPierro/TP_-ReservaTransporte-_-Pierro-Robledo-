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
{
    
}

namespace Interfaz.Admin
{
    public partial class ModificacionChofer : Form
    {
        public ModificacionChofer()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            foreach (var Chofer in choferRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"ID: {Chofer.Id} - Nombre: {Chofer.Nombre} - Apellido: {Chofer.Apellido} - Nro_Licencia: {Chofer.Tipo_Licencia}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) 
               
            {
                MessageBox.Show("El ID es obligatorio.");
                return;
            }
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            int choferId = int.Parse(textBox1.Text);

            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                if (chofer.Id == choferId)
                {
                    textBox2.Text = chofer.Nombre;
                    textBox3.Text = chofer.Apellido;
                    textBox4.Text = chofer.Tipo_Licencia;
                    return;
                }
            }
            MessageBox.Show("Chofer no encontrado.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            int choferId = int.Parse(textBox1.Text);
            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                if (chofer.Id == choferId)
                {
                    chofer.Nombre = textBox2.Text;
                    chofer.Apellido = textBox3.Text;
                    chofer.Tipo_Licencia = textBox4.Text;
                    choferRepository.Modificar(chofer);
                    MessageBox.Show("Chofer actualizado correctamente.");
                    listBox1.Items.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                    return;
                }
            }
            MessageBox.Show("Chofer no encontrado.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }
    }
}
