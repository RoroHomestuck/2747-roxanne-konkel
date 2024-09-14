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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerDatabase.GetCustomers();
            List<Invoice> invoices = InvoicesDatabase.GetInvoices();

            var customerInvoices = from invoice in invoices
                                   join customer in customers
                                   on invoice.CustomerId equals customer.Id
                                   select new
                                   {
                                       customer.FullName,
                                       invoice.Id,
                                       invoice.InvoiceDate,
                                       invoice.InvoiceTotal
                                   };
            int i = 0;

            foreach (var invoice in customerInvoices)
            {
                if (invoice != null)
                {
                    listView1.Items.Add(invoice.FullName);
                    listView1.Items[i].SubItems.Add(invoice.Id.ToString());
                    listView1.Items[i].SubItems.Add(invoice.InvoiceDate.ToString());
                    listView1.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString());
                }
                i += 1;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
