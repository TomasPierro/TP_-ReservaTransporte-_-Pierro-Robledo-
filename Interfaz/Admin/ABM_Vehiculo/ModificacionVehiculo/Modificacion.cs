using ClasesReservaTransporte.Models;
using ClasesReservaTransporte.Repositories;
using Interfaz.Admin;

namespace Interfaz.ABM_Vehiculo.ModificacionVehiculo
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();
            List<Vehiculo> vehiculos = vehiculoRepository.ObtenerTodos();
            foreach (var vehiculo in vehiculos)
            {
                listBox1.Items.Add($"ID: {vehiculo.Id}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Patente: {vehiculo.Patente}, CosteXdia: {vehiculo.CosteXdia}");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            int idVehiculo = int.Parse(textBox1.Text);

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == idVehiculo)
                {
                    textBox2.Text = vehiculo.Marca;
                    textBox3.Text = vehiculo.Modelo;
                    textBox4.Text = vehiculo.Patente;
                    textBox5.Text = vehiculo.CosteXdia.ToString();

                    return;
                }
            }

            MessageBox.Show("Vehículo no encontrado");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericRepository<Vehiculo> vehiculoRepository = new GenericRepository<Vehiculo>();

            int id = int.Parse(textBox1.Text);

            foreach (var vehiculo in vehiculoRepository.ObtenerTodos())
            {
                if (vehiculo.Id == id)
                {
                    vehiculo.Marca = textBox2.Text;
                    vehiculo.Modelo = textBox3.Text;
                    vehiculo.Patente = textBox4.Text;
                    vehiculo.CosteXdia = float.Parse(textBox5.Text);

                    vehiculoRepository.Modificar(vehiculo);

                    MessageBox.Show("Vehículo modificado correctamente");
                    listBox1.Items.Clear();
                    return;
                }
            }

            MessageBox.Show("Vehículo no encontrado");
        }
    }
}
