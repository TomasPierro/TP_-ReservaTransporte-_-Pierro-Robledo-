using System;
using System.Windows.Forms;
using Interfaz.Services;

using Interfaz.ABM_Vehiculo;
using Interfaz.ABM_Vehiculo.BajaVehiculo;
using Interfaz.ABM_Vehiculo.ModificacionVehiculo;
using Interfaz.Admin.ABM_Chofer;

namespace Interfaz.Admin
{
    public partial class MenuAdmin : Form
    {
        private readonly IFormNavigation _navigation;

        public MenuAdmin(IFormNavigation navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<AltaVehiculo>(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Baja>(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Modificacion>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Reportes>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<RegistroChofer>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Inicio>(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<ModificacionChofer>(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<BajaChofer>(this);
        }
    }
}


