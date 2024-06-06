using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DehasoftOne.Business.Products;
using DehasoftOne.Entity.Enums;
using DehasoftOne.Entity.Products;

namespace DehasoftOne.Winforms
{
    public partial class ProductsForm : Form
    {
        private readonly IProductService _productService;
        public ProductsForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            cbProductUnit.DataSource = Enum.GetNames(typeof(Unit));
            cbProductUnit.SelectedIndex = 0;
        }

        private async void ProductsForm_Load(object sender, EventArgs e)
        {
            await FillProductDataGrid();
        }

        private void ClearTextBoxInputs()
        {
            tbProductName.Text = string.Empty;
            tbProductBarcode.Text = string.Empty;
            tbProductPrice.Text = string.Empty;
            tbProductQuantity.Text = string.Empty;
            cbProductUnit.SelectedIndex = 0;
        }

        private async Task FillProductDataGrid()
        {
            dgvProducts.DataSource = await _productService.GetProducts();
            dgvProducts.Columns["id"].Visible = false;
            dgvProducts.AutoResizeColumns();
        }

        private void CheckInputsNotNull()
        {
            if (tbProductName.Text == string.Empty || tbProductBarcode.Text == string.Empty || tbProductPrice.Text == string.Empty || tbProductQuantity.Text == string.Empty)
                throw new Exception("Girdi Değerleri Boş Olamaz.");
        }
        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputsNotNull();
                await _productService.AddProduct(new Product() { Name = tbProductName.Text, Barcode = tbProductBarcode.Text, Price = Convert.ToDecimal(tbProductPrice.Text), Unit = (Unit)Enum.Parse(typeof(Unit), cbProductUnit.SelectedValue.ToString()), Quantity = Convert.ToDecimal(tbProductQuantity.Text) });
                ClearTextBoxInputs();
                await FillProductDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata");
            }
        }

        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputsNotNull();
                await _productService.UpdateProduct(new Product() { Id = new Guid(dgvProducts.SelectedRows[0].Cells[5].Value.ToString()), Name = tbProductName.Text, Barcode = tbProductBarcode.Text, Price = Convert.ToDecimal(tbProductPrice.Text), Unit = (Unit)Enum.Parse(typeof(Unit), cbProductUnit.SelectedValue.ToString()), Quantity = Convert.ToDecimal(tbProductQuantity.Text) });
                ClearTextBoxInputs();
                await FillProductDataGrid();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            await _productService.DeleteProduct(new Guid(dgvProducts.SelectedRows[0].Cells[5].Value.ToString()));
            await FillProductDataGrid();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Id5-Barkod1-Birim2-Fiyat3-Quantity4
            cbProductUnit.Text = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
            try
            {
                tbProductName.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                tbProductBarcode.Text = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                tbProductPrice.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
                tbProductQuantity.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
