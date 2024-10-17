using Business.Interfaces.Repositories;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using PuntoVenta.Business.Services;
using PuntoVenta.Views;

namespace PuntoVenta
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

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
        private static void ConfigureServices(ServiceCollection services)
        {
            // Aquí registras los servicios y repositorios que necesitas
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ProductService>();
            services.AddScoped<SaleService>();
            services.AddScoped<UserService>();

            // Registrar los formularios (por ejemplo, LoginForm)
            services.AddScoped<Login>();
            services.AddScoped<Admin>();  // El formulario principal después del login
            services.AddScoped<Cashier>();
            // Agrega otros formularios si los necesitas
        }
    }
}