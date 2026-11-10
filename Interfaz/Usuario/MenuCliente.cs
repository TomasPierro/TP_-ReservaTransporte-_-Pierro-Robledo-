using Interfaz.Services;
using Interfaz.Usuario;
using Interfaz.Usuario.ABMCliente;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuCliente : Form
    {
        private readonly IFormNavigation _navigation;

        public MenuCliente(IFormNavigation navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<RegistrarReserva>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<FinReserva>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<Inicio>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _navigation.Mostrar<ModificacionCliente>(this);
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

