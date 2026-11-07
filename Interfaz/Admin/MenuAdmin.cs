using Interfaz.ABM_Vehiculo;
using Interfaz.ABM_Vehiculo.BajaVehiculo;
using Interfaz.ABM_Vehiculo.ModificacionVehiculo;
using Interfaz.Admin.ABM_Chofer;

namespace Interfaz.Admin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaVehiculo altaVehiculo = new AltaVehiculo();
            altaVehiculo.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Modificacion modificacion = new Modificacion();
            modificacion.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes Reportes = new Reportes();
            Reportes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroChofer registroChofer = new RegistroChofer();
            registroChofer.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionChofer modificacionChofer = new ModificacionChofer();
            modificacionChofer.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BajaChofer bajaChofer = new BajaChofer();
            bajaChofer.Show();
            this.Hide();
        }
    }
}
