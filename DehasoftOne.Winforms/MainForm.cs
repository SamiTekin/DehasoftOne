using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DehasoftOne.Business.Customers;
using DehasoftOne.Entity.Users;
using Microsoft.Extensions.DependencyInjection;

namespace DehasoftOne.Winforms
{
    public partial class MainForm : Form
    {
        private readonly User _loggedUser;
        private readonly IServiceProvider _serviceProvider;
        public MainForm(User loggedUser,IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _loggedUser = loggedUser;
            InitializeComponent();
            this.Text = _loggedUser.Name.ToString() + " Hoşgeldin | DehasoftOne";
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = _serviceProvider.GetRequiredService<CustomersForm>();
            customersForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var productsForm = _serviceProvider.GetRequiredService<ProductsForm>();
            productsForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = _serviceProvider.GetRequiredService<OrderForm>();
            ordersForm.Show();
        }
    }
}
