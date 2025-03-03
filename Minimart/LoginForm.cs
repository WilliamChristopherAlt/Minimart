using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart
{
    public partial class LoginForm : Form
    {
        private readonly AdminService _serviceAdmin;
        public Admin _admin;

        public LoginForm(AdminService serviceAdmin)
        {
            InitializeComponent();
            _serviceAdmin = serviceAdmin;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            // Disable the button to prevent multiple clicks
            loginButton.Enabled = false;

            string username = usernameText.Text.Trim();
            string password = passwordText.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loginButton.Enabled = true; // Re-enable the button
                return;
            }

            try
            {
                // Find the admin by username
                Admin admin = await _serviceAdmin.GetByUsernameAsync(username);

                if (admin == null || !admin.VerifyPassword(password))
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginButton.Enabled = true; // Re-enable the button
                    return;
                }

                // Login successful
                _admin = admin;
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the LoginForm and pass control to the main form
                this.DialogResult = DialogResult.OK; // Indicate successful login
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginButton.Enabled = true; // Re-enable the button in case of error
            }
        }
    }
}
