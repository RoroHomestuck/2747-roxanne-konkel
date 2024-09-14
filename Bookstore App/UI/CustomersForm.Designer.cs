namespace Bookstore_App.UI
{
    partial class CustomersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customersListBox = new ListBox();
            addButton = new Button();
            deleteButton = new Button();
            exitButton = new Button();
            invoicesButton = new Button();
            SuspendLayout();
            // 
            // customersListBox
            // 
            customersListBox.FormattingEnabled = true;
            customersListBox.ItemHeight = 15;
            customersListBox.Location = new Point(12, 12);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(306, 244);
            customersListBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(324, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add Customer";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(324, 71);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete Customer";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(324, 233);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // invoicesButton
            // 
            invoicesButton.Location = new Point(324, 42);
            invoicesButton.Name = "invoicesButton";
            invoicesButton.Size = new Size(143, 23);
            invoicesButton.TabIndex = 6;
            invoicesButton.Text = "View Customer Invoices";
            invoicesButton.UseVisualStyleBackColor = true;
            invoicesButton.Click += invoicesButton_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 272);
            Controls.Add(invoicesButton);
            Controls.Add(exitButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(customersListBox);
            Name = "CustomersForm";
            Text = "Bookstore Manager: Customers";
            Load += CustomersForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox customersListBox;
        private Button addButton;
        private Button deleteButton;
        private Button exitButton;
        private Button invoicesButton;
    }
}