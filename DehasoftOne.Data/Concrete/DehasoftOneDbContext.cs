using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DehasoftOne.Entity.Customer;
using DehasoftOne.Entity.Order;
using DehasoftOne.Entity.Orders;
using DehasoftOne.Entity.Products;
using DehasoftOne.Entity.Users;
using Microsoft.EntityFrameworkCore;

namespace DehasoftOne.Data.Concrete;

public class DehasoftOneDbContext:DbContext
{
    public DehasoftOneDbContext() { }
    public DehasoftOneDbContext(DbContextOptions<DehasoftOneDbContext> options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Provide a default connection string or other options
            var configrationHelper = new ConfigurationHelper();
            optionsBuilder.UseSqlServer(configrationHelper.GetConnectionString("DefaultConnection"));
        }
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}
