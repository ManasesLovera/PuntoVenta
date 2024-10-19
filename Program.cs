using Business.Interfaces.Repositories;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using PuntoVenta.Business.Services;
using PuntoVenta.Views;
using System.Runtime.Versioning;

namespace PuntoVenta
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //// Carga el formulario inicial a través del contenedor de DI
            //var mainForm = ServiceProvider.GetRequiredService<Login>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}