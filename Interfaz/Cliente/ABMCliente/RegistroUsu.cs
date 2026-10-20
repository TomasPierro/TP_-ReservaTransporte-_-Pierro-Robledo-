using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;

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
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();

            string Nombre = textBox2.Text;
            string Apellido = textBox3.Text;
            int Dni = int.Parse(textBox4.Text);
            int Telefono = int.Parse(textBox5.Text);
            int Nro_Licencia = int.Parse(textBox6.Text);
            string Contraseña = textBox7.Text;
            string Confirmar_Contraseña = textBox8.Text;

            if (Contraseña == Confirmar_Contraseña)
            {
                clienteRepository.Agregar(new Cliente { Nombre = Nombre, Apellido = Apellido, Dni = Dni, Telefono = Telefono, Nro_Licencia = Nro_Licencia, Contraseña = Contraseña });
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
