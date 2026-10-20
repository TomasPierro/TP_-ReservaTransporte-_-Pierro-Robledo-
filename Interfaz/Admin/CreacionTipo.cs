using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;

namespace Interfaz.Admin
{
    public partial class CreacionTipo : Form
    {
        public CreacionTipo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<TipoVehiculo> tipoVehiculoRepository = new GenericRepository<TipoVehiculo>();
            string nombreTipo = textBox1.Text;
            tipoVehiculoRepository.Agregar(new TipoVehiculo { Tipo = nombreTipo });

            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();

        }
    }
}
