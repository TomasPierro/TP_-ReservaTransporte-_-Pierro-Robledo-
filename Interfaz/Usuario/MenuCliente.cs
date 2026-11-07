using Interfaz.ABM_Vehiculo.ModificacionVehiculo;
using Interfaz.Usuario;
using Interfaz.Usuario.ABMCliente;

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

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicioSecion = new Inicio();
            inicioSecion.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificacionCliente modificacionCliente = new ModificacionCliente();
            modificacionCliente.Show();
            this.Hide();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
