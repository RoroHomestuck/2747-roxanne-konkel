namespace Bookstore_App.UI
{
    partial class NewCustomerForm
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
            lnameTextBox = new TextBox();
            emailTextBox = new TextBox();
            fnameTextBox = new TextBox();
            emailLabel = new Label();
            lnameLabel = new Label();
            fnameLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // lnameTextBox
            // 
            lnameTextBox.Location = new Point(94, 61);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(100, 23);
            lnameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(94, 103);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 3;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(94, 16);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(100, 23);
            fnameTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(52, 106);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email";
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new Point(25, 64);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(63, 15);
            lnameLabel.TabIndex = 11;
            lnameLabel.Text = "Last Name";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new Point(24, 19);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(64, 15);
            fnameLabel.TabIndex = 10;
            fnameLabel.Text = "First Name";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(102, 137);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(21, 137);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 176);
            Controls.Add(lnameTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(fnameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(lnameLabel);
            Controls.Add(fnameLabel);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Name = "NewCustomerForm";
            Text = "Bookstore Manager: New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lnameTextBox;
        private TextBox emailTextBox;
        private TextBox fnameTextBox;
        private Label emailLabel;
        private Label lnameLabel;
        private Label fnameLabel;
        private Button saveButton;
        private Button cancelButton;
    }
}