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

namespace Interfaz.Admin.ABM_Chofer
{
    public partial class BajaChofer : Form
    {
        public BajaChofer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
              
            {
                MessageBox.Show("El id es obligatorio.");
                return;
            }
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();
            
            int choferId = int.Parse(textBox1.Text);

            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                if (chofer.Id == choferId)
                {
                    choferRepository.Eliminar(chofer);
                    MessageBox.Show("Chofer eliminado exitosamente.");
                    listBox1.Items.Clear();
                    textBox1.Clear();
                    return;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenericRepository<Chofer> choferRepository = new GenericRepository<Chofer>();

            foreach (var chofer in choferRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"ID: {chofer.Id} - Nombre: {chofer.Nombre} - Apellido: {chofer.Apellido} - Nro_Licencia: {chofer.Tipo_Licencia}");
            }

        }
    }
}
