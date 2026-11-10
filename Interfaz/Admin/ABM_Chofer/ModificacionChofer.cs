
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;
using System;
using System.Windows.Forms;

namespace Interfaz.Admin
{
    public partial class ModificacionChofer : Form
    {
        private readonly IGenericRepository<Chofer> _choferRepository;
        private readonly IFormNavigation _navigation;

        public ModificacionChofer(
            IGenericRepository<Chofer> choferRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _choferRepository = choferRepository;
            _navigation = navigation;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Mostrar todos los choferes
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var chofer in _choferRepository.ObtenerTodos())
            {
                listBox1.Items.Add(
                    $"ID: {chofer.Id} - Nombre: {chofer.Nombre} - Apellido: {chofer.Apellido} - Nro_Licencia: {chofer.Tipo_Licencia}");
            }
        }

        // Buscar chofer por ID
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El ID es obligatorio.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int choferId))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            foreach (var chofer in _choferRepository.ObtenerTodos())
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

        // Guardar modificación
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int choferId))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            foreach (var chofer in _choferRepository.ObtenerTodos())
            {
                if (chofer.Id == choferId)
                {
                    chofer.Nombre = textBox2.Text;
                    chofer.Apellido = textBox3.Text;
                    chofer.Tipo_Licencia = textBox4.Text;

                    _choferRepository.Modificar(chofer);

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

        // Volver al menú
        private void button4_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
        }
    }
}
