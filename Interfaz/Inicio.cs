using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;

namespace Interfaz
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Cliente> clienteRepository = new GenericRepository<Cliente>();
            string nombreUsuario = textBox1.Text;
            string contraseña = textBox2.Text;
            foreach (var cliente in clienteRepository.ObtenerTodos())
            {
                if (cliente.Nombre == nombreUsuario && cliente.Contraseña == contraseña && cliente.Rol == 1)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    MenuCliente menuC = new MenuCliente();
                    menuC.Show();
                    this.Hide();
                    return;
                }
                else if (cliente.Nombre == nombreUsuario && cliente.Contraseña == contraseña && cliente.Rol == 2)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.Show();
                    this.Hide();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsu registroUsu = new RegistroUsu();
            registroUsu.Show();
            this.Hide();
        }
    }
}
