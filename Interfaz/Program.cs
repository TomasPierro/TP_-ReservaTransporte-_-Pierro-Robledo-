using ClasesReservaTransporte.Data;
using ClasesReservaTransporte.Repositories;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows.Forms;
using ClasesReservaTransporte.Data;
namespace Interfaz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            AdminInicio.CrearAdmin();

            Application.Run(new Inicio());
        }
    }
}