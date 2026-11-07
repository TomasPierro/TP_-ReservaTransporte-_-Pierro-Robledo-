using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz.ABM_Vehiculo.BajaVehiculo
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                listBox1.Items.Add($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Patente: {vehiculo.Patente}");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
              
            {
                MessageBox.Show("El id es obligatorio para proceder.");
                return;
            }
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            List<Vehiculo> vehiculos = vehiculoRepository.ObtenerTodos();

            int idVehiculo = int.Parse(textBox1.Text);

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == idVehiculo)
                {
                    vehiculoRepository.Eliminar(vehiculo);
                    MessageBox.Show($"Vehículo con ID {idVehiculo} eliminado correctamente.");
                    listBox1.Items.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show($"Vehículo con ID {idVehiculo} no encontrado.");
                    return;
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Hide();

        }
    }
}
