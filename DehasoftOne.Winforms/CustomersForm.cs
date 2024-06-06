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
using DehasoftOne.Entity.Customer;

namespace DehasoftOne.Winforms
{
    public partial class CustomersForm : Form
    {
        private readonly ICustomerService _customerService;
        public CustomersForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            await FillCustomerDataGrid();
        }

        private async Task FillCustomerDataGrid()
        {
            dgvCustomers.DataSource = await _customerService.GetCustomers();
            dgvCustomers.Columns["id"].Visible = false;
            dgvCustomers.AutoResizeColumns();
        }

        private void ClearTextBoxInputs()
        {
            tbCustomerName.Text = string.Empty;
            tbCustomerSurname.Text = string.Empty;
            tbCustomerPhone.Text = string.Empty;
            tbCustomerTCKN.Text = string.Empty;
            tbCustomerAddress.Text = string.Empty;
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            await _customerService.AddCustomer(new Customer() { Name = tbCustomerName.Text, Surname = tbCustomerSurname.Text, Phone = tbCustomerPhone.Text, TCKN = tbCustomerTCKN.Text, Address = tbCustomerAddress.Text });
            ClearTextBoxInputs();
            await FillCustomerDataGrid();
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            await _customerService.UpdateCustomer(new Customer() { Id = new Guid(dgvCustomers.SelectedRows[0].Cells[5].Value.ToString()), Name = tbCustomerName.Text, Surname = tbCustomerSurname.Text, Phone = tbCustomerPhone.Text, TCKN = tbCustomerTCKN.Text, Address = tbCustomerAddress.Text });
            await FillCustomerDataGrid();
            ClearTextBoxInputs();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            await _customerService.DeleteCustomer(new Guid(dgvCustomers.SelectedRows[0].Cells[5].Value.ToString()));
            await FillCustomerDataGrid();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCustomerName.Text = dgvCustomers.SelectedRows[0].Cells[0].Value.ToString();
            tbCustomerSurname.Text = dgvCustomers.SelectedRows[0].Cells[1].Value.ToString();
            tbCustomerAddress.Text = dgvCustomers.SelectedRows[0].Cells[2].Value.ToString();
            tbCustomerPhone.Text = dgvCustomers.SelectedRows[0].Cells[3].Value.ToString();
            tbCustomerTCKN.Text = dgvCustomers.SelectedRows[0].Cells[4].Value.ToString();
        }


    }
}
