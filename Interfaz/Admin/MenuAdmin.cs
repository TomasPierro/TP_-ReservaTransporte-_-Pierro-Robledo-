using Interfaz.ABM_Vehiculo;
using Interfaz.ABM_Vehiculo.BajaVehiculo;
using Interfaz.ABM_Vehiculo.ModificacionVehiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void button4_Click(object sender, EventArgs e)
        {
            CreacionTipo creacionTipo = new CreacionTipo();
            creacionTipo.Show();
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
    }
}
