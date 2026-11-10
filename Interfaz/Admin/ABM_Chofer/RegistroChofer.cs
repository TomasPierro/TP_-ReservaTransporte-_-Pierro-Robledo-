using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using Interfaz.Services;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class RegistroChofer : Form
    {
        private readonly IGenericRepository<Chofer> _choferRepository;
        private readonly IFormNavigation _navigation;

        public RegistroChofer(
            IGenericRepository<Chofer> choferRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _choferRepository = choferRepository;
            _navigation = navigation;
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

            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string tipoLicencia = textBox3.Text;

            bool estado = true; // Disponible por defecto

            foreach (var chofer in _choferRepository.ObtenerTodos())
            {
                if (chofer.Nombre == nombre &&
                    chofer.Apellido == apellido &&
                    chofer.Tipo_Licencia == tipoLicencia)
                {
                    MessageBox.Show("El chofer ya está registrado.");
                    return;
                }
            }

            _choferRepository.Agregar(new Chofer
            {
                Nombre = nombre,
                Apellido = apellido,
                Tipo_Licencia = tipoLicencia,
                Estado = estado
            });

            MessageBox.Show("Chofer registrado exitosamente.");

            _navigation.Mostrar<MenuAdmin>(this);
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
            _navigation.Mostrar<MenuAdmin>(this);
        }
    }
}
