using Microsoft.Extensions.DependencyInjection;

namespace Interfaz.Services
{
    public class FormNavigation : IFormNavigation
    {
        private readonly IServiceProvider _provider;

        public FormNavigation(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Mostrar<T>(Form actual) where T : Form
        {
            var siguiente = _provider.GetRequiredService<T>();

            siguiente.Show();
            actual.Hide();
        }
    }
}