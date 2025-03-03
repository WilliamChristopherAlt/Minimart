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
            // Enable Visual Styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set up Dependency Injection
            var serviceProvider = ConfigureServices();

            //var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            //Application.Run(loginForm);

            // Resolve LoginForm with the AdminService
            using (var loginForm = serviceProvider.GetRequiredService<LoginForm>())
            {
                // Show the login form as a modal dialog
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the logged-in Admin instance from the LoginForm
                    var admin = loginForm._admin;

                    // Manually create and pass the Admin instance to MainForm
                    var mainForm = new MainForm(admin);

                    // Run the MainForm
                    Application.Run(mainForm);
                }
            }

            //// Resolve the main form through DI
            //var mainForm = serviceProvider.GetRequiredService<MainForm>();

            //// Run your MainForm
            //Application.Run(mainForm);
        }

        // Configure services for Dependency Injection
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register DbContext
            services.AddDbContext<MinimartDbContext>(options =>
                options.UseSqlServer("Server=DESKTOP-0BQ9RBN\\SQLEXPRESS;Database=Minimart;Integrated Security=True;"),
                ServiceLifetime.Scoped);

            // Register business logic services
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

            services.AddScoped<MainForm>();
            services.AddScoped<LoginForm>();

            return services.BuildServiceProvider();
        }
    }
}
