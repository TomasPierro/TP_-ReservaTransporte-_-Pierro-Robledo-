
using System;
using System.Windows.Forms;
using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Services;

namespace Interfaz
{
    public partial class RegistroUsu : Form
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;
        private readonly IFormNavigation _navigation;

        public RegistroUsu(
            IGenericRepository<Cliente> clienteRepository,
            IFormNavigation navigation)
        {
            InitializeComponent();

            _clienteRepository = clienteRepository;
            _navigation = navigation;
        }

        // Volver al inicio de sesión
        private void button2_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Inicio>(this);
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        // Registrar usuario
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string dni = textBox4.Text.Trim();

            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe contener solamente números.");
                return;
            }

            foreach (var cliente in _clienteRepository.ObtenerTodos())
            {
                if (cliente.Dni == dni)
                {
                    MessageBox.Show("El DNI ya está registrado. Por favor, ingrese un DNI diferente.");
                    return;
                }
            }

            string telefono = textBox5.Text.Trim();

            if (!long.TryParse(telefono, out _))
            {
                MessageBox.Show("El teléfono debe contener solamente números.");
                return;
            }

            string nroLicencia = textBox6.Text;
            string contrasenia = textBox7.Text;
            string confirmarContrasenia = textBox8.Text;

            int rol = 0;

            if (contrasenia == confirmarContrasenia)
            {
                _clienteRepository.Agregar(new Cliente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    Telefono = telefono,
                    Nro_Licencia = nroLicencia,
                    Contrasenia = contrasenia,
                    Rol = rol
                });

                MessageBox.Show("Usuario registrado correctamente");

                _navigation.Mostrar<Inicio>(this);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
