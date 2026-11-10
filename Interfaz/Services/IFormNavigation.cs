using System.Windows.Forms;

namespace Interfaz.Services
    {
        public interface IFormNavigation
        {
            void Mostrar<T>(Form actual) where T : Form;
        }
    }


