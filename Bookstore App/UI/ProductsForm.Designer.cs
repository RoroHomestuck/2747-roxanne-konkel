namespace Bookstore_App.UI
{
    partial class ProductsForm
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
            addButton = new Button();
            exitButton = new Button();
            deleteButton = new Button();
            productsListBox = new ListBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(324, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(324, 233);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(324, 41);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(95, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Product";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // productsListBox
            // 
            productsListBox.FormattingEnabled = true;
            productsListBox.ItemHeight = 15;
            productsListBox.Location = new Point(12, 12);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(306, 244);
            productsListBox.TabIndex = 3;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 272);
            Controls.Add(productsListBox);
            Controls.Add(deleteButton);
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Name = "ProductsForm";
            Text = "Bookstore Manager: Products";
            Load += ProductsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button exitButton;
        private Button deleteButton;
        private ListBox productsListBox;
    }
}