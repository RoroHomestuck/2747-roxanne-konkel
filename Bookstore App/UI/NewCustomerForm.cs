using Bookstore_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_App.UI
{
    public partial class NewCustomerForm : Form
    {
        private Customer customer = null;
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            customer = new()
            {
                Id = rnd.Next(0, 10),
                FName = fnameTextBox.Text,
                LName = lnameTextBox.Text,
                Email = emailTextBox.Text
            };
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
