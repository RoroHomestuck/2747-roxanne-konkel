namespace Bookstore_App.UI
{
    partial class NewProductForm
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
            cancelButton = new Button();
            saveButton = new Button();
            skuLabel = new Label();
            descriptionLabel = new Label();
            priceLabel = new Label();
            skuTextBox = new TextBox();
            priceTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(21, 139);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(102, 139);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Location = new Point(60, 21);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new Size(28, 15);
            skuLabel.TabIndex = 2;
            skuLabel.Text = "SKU";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(21, 66);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(55, 108);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price";
            // 
            // skuTextBox
            // 
            skuTextBox.Location = new Point(94, 18);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(100, 23);
            skuTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(94, 105);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(94, 63);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 2;
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 176);
            Controls.Add(descriptionTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(priceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(skuLabel);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Name = "NewProductForm";
            Text = "Bookstore Manager: New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private Label skuLabel;
        private Label descriptionLabel;
        private Label priceLabel;
        private TextBox skuTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
    }
}