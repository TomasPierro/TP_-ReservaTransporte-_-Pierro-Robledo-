using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class RegistroUsu : Form
    {
        public RegistroUsu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicioSecion = new Inicio();
            inicioSecion.Show();
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
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();

            string Nombre = textBox2.Text;
            string Apellido = textBox3.Text;
            string Dni = textBox4.Text.Trim();

            if (!long.TryParse(Dni, out _))
            {
                MessageBox.Show("El DNI debe contener solamente números.");
                return;
            }
            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                if (cliente.Dni == Dni)
                {
                    MessageBox.Show("El DNI ya está registrado. Por favor, ingrese un DNI diferente.");
                    return;
                }
            }
            string Telefono = textBox5.Text.Trim();

            if (!long.TryParse(Telefono, out _))
            {
                MessageBox.Show("El teléfono debe contener solamente números.");
                return;
            }
            string Nro_Licencia = textBox6.Text;
            string Contrasenia = textBox7.Text;
            string Confirmar_Contrasenia = textBox8.Text;
            int Rol = 0; // Rol de usuario normal

            if (Contrasenia == Confirmar_Contrasenia)
            {
                clienteRepository.Agregar(new Cliente { Nombre = Nombre, Apellido = Apellido, Dni = Dni, Telefono = Telefono, Nro_Licencia = Nro_Licencia, Contrasenia = Contrasenia, Rol = Rol });
                MessageBox.Show("Usuario registrado correctamente");
                Inicio inicioSecion = new Inicio();
                inicioSecion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }


        }
    }
}
