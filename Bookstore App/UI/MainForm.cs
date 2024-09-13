namespace Bookstore_App.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new();
            productForm.StartPosition = FormStartPosition.CenterParent;
            productForm.ShowDialog();
        }

        private void productsLabel_MouseHover(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Blue;
        }

        private void productsLabel_MouseLeave(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Black;
        }
        private void customerLabel_MouseHover(object sender, EventArgs e)
        {
            customersLabel.ForeColor = Color.Blue;
        }

        private void customerLabel_MouseLeave(object sender, EventArgs e)
        {
            customersLabel.ForeColor = Color.Black;
        }

        private void customersLabel_Click(object sender, EventArgs e)
        {
            CustomersForm customerForm = new();
            customerForm.StartPosition = FormStartPosition.CenterParent;
            customerForm.ShowDialog();
        }
    }
}