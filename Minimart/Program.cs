using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Minimart.DatabaseAccess;
using Minimart.BusinessLogic;
using Microsoft.EntityFrameworkCore;

namespace Minimart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable Visual Styles (always comes first)
            Application.EnableVisualStyles();

            // Set the compatible text rendering before creating any window
            Application.SetCompatibleTextRenderingDefault(false);

            // Set up Dependency Injection
            var serviceProvider = ConfigureServices();

            // Resolve the main form through DI
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            // Run your MainForm
            Application.Run(mainForm);
        }

        // Configure services for Dependency Injection
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register DbContext with the service collection
            services.AddDbContext<MinimartDbContext>(options =>
                options.UseSqlServer("Server=DESKTOP-0BQ9RBN\\SQLEXPRESS;Database=Minimart;Integrated Security=True;"), ServiceLifetime.Scoped);

            // Register the services
            services.AddScoped<SupplierService>();
            services.AddScoped<ProductTypeService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<SaleService>();
            services.AddScoped<SaleDetailService>();
            services.AddScoped<AdminService>();
            services.AddScoped<EmployeeRoleService>();
            services.AddScoped<PaymentMethodService>();
            services.AddScoped<AdminRoleService>();
            services.AddScoped<MeasurementUnitService>();

            // Register MainForm and any dependencies it might have
            services.AddScoped<MainForm>();

            return services.BuildServiceProvider();
        }
    }
}
