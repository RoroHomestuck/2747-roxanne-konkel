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
            SuspendLayout();
            // 
            // customersListBox
            // 
            customersListBox.FormattingEnabled = true;
            customersListBox.ItemHeight = 15;
            customersListBox.Location = new Point(12, 12);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(306, 244);
            customersListBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(324, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(103, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add Customer";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(324, 41);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(103, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete Customer";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(324, 233);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 272);
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
    }
}