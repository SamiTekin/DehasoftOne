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
using DehasoftOne.Business.Orders;
using DehasoftOne.Entity.Customer;
using DehasoftOne.Entity.Enums;
using DehasoftOne.Entity.Order;
using DehasoftOne.Winforms.Tools;

namespace DehasoftOne.Winforms
{
    public partial class OrderForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        public OrderForm(IOrderService orderService,ICustomerService customerService)
        {
            _customerService = customerService;
            _orderService = orderService;
            InitializeComponent();
        }

        private async Task FillOrderDataGrid()
        {
            dgvOrders.DataSource = await _orderService.GetOrders();
            dgvOrders.Columns["id"].Visible = false;
            dgvOrders.AutoResizeColumns();
        }

        private async Task LoadCustomersAsync()
        {
            cbCustomer.Items.Clear();
            var customers = await _customerService.GetCustomers();

            foreach (Customer? customer in customers)
            {
                if (customer != null)
                {
                    string customerText = customer.Name + " " + customer.Surname;
                    cbCustomer.Items.Add(new ComboBoxItem(customerText, customer));
                }
            }
        }

        private void CheckInputsNotNull()
        {
            if (tbDescription.Text == string.Empty || cbCustomer.Text == string.Empty || cbStatus.Text == string.Empty || dtPickerOrder.Text == string.Empty)
                throw new Exception("Girdi Değerleri Boş Olamaz.");
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            await FillOrderDataGrid();
            await LoadCustomersAsync();
            cbStatus.DataSource=Enum.GetNames(typeof(OrderStatus));
        }

        private async void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputsNotNull();
                await _orderService.AddOrder(new Order() { OrdererId = new Guid(cbCustomer.SelectedValue.ToString()), Description=tbDescription.Text,OrderDate=dtPickerOrder.Value,Status=(OrderStatus)Enum.Parse(typeof(OrderStatus),cbStatus.SelectedValue.ToString()),TotalPrice=0});
                await FillOrderDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            await _orderService.DeleteOrder(new Guid(dgvOrders.SelectedRows[0].Cells[5].Value.ToString()));
        }

        private async void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputsNotNull();
                await _orderService.UpdateOrder(new Order() { OrdererId = new Guid(cbCustomer.SelectedValue.ToString()), Description = tbDescription.Text, OrderDate = dtPickerOrder.Value, Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), cbStatus.SelectedValue.ToString()) });
                await FillOrderDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {

        }
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbCustomer.SelectedValue = dgvOrders.SelectedRows[0].Cells[0].Value;
            cbStatus.SelectedValue = dgvOrders.SelectedRows[0].Cells[3].Value;
            tbDescription.Text=dgvOrders.SelectedRows[0].Cells[2].Value.ToString();
            dtPickerOrder.Value = (DateTime)dgvOrders.SelectedRows[0].Cells[1].Value;
        }
    }
}
