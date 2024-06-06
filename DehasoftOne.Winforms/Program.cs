using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using DehasoftOne.Data.Concrete;
using DehasoftOne.Business.Customers;
using DehasoftOne.Data.Customers;
using Microsoft.Extensions.Configuration.Json;
using DehasoftOne.Business.Users;
using DehasoftOne.Data.Users;
using DehasoftOne.Business.Products;
using DehasoftOne.Data.Products;
using DehasoftOne.Business.Orders;
using DehasoftOne.Data.Orders;

namespace DehasoftOne.Winforms
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
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// Create a host builder to build the service provider
        /// </summary>
        /// <returns></returns>
        static IHostBuilder CreateHostBuilder()
        {
            var configHelper=new ConfigurationHelper();
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<DehasoftOneDbContext>(options => options.UseSqlServer(configHelper.GetConnectionString("DefaultConnection")));
                    //services.AddScoped<TInterface, TImplementation>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<CustomersForm>();
                    services.AddTransient<ProductsForm>();
                    services.AddTransient<OrderForm>();

                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<ICustomerService, CustomerService>();
                    services.AddScoped<IOrderService, OrderService>();
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<ProductRepository>();
                    services.AddScoped<UserRepository>();
                    services.AddScoped<OrderRepository>();
                    services.AddScoped<CustomerRepository>();
                    services.AddSingleton<ConfigurationHelper>();
                });
        }
    }
}
