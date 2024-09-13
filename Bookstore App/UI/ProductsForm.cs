using Bookstore_App.DataAccess;
using Bookstore_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_App.UI
{
    public partial class ProductsForm : Form
    {
        private List<Product> products = null;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new();
            newProductForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            products = ProductDatabase.GetProducts();

            productsListBox.Items.Clear();

            foreach (Product product in products)
            {
                productsListBox.Items.Add(product);
            }
        }
    }
}
