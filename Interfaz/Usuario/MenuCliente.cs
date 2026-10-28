using Interfaz.Usuario;

namespace Interfaz
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarReserva registrarReserva = new RegistrarReserva();
            registrarReserva.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinReserva finReserva = new FinReserva();
            finReserva.Show();
            this.Hide();
        }
    }
}
