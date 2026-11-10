
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;
using Interfaz.Admin;
using System;
using System.Windows.Forms;

namespace Interfaz.Admin.ABM_Chofer
{
    public partial class BajaChofer : Form
    {
        private readonly IGenericRepository<Chofer> _choferRepository;
        private readonly IFormNavigation _navigation;

        public BajaChofer(
            IGenericRepository<Chofer> choferRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _choferRepository = choferRepository;
            _navigation = navigation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<MenuAdmin>(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Eliminar chofer
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El id es obligatorio.");
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
                    _choferRepository.Eliminar(chofer);

                    MessageBox.Show("Chofer eliminado exitosamente.");

                    listBox1.Items.Clear();
                    textBox1.Clear();
                    return;
                }
            }

            MessageBox.Show("No se encontró un chofer con ese ID.");
        }

        // Mostrar choferes
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var chofer in _choferRepository.ObtenerTodos())
            {
                listBox1.Items.Add(
                    $"ID: {chofer.Id} - Nombre: {chofer.Nombre} - Apellido: {chofer.Apellido} - Nro_Licencia: {chofer.Tipo_Licencia}");
            }
        }
    }
}
