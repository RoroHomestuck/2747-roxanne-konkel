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
    public partial class CustomersForm : Form
    {
        private List<Customer> customers = null;
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

            customers = CustomerDatabase.GetCustomers();

            renderList();
        }

        private void renderList()
        {
            customersListBox.Items.Clear();

            foreach (Customer customer in customers)
            {
                customersListBox.Items.Add(customer);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new();
            newCustomerForm.StartPosition = FormStartPosition.CenterScreen;
            customers.Add(newCustomerForm.GetNewCustomer());
            CustomerDatabase.SaveCustomers(customers);
            renderList();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = customersListBox.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedCustomer.FName + " " + selectedCustomer.LName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    customers.Remove(selectedCustomer);
                    CustomerDatabase.SaveCustomers(customers);
                    renderList();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer", "Select a Customer to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
