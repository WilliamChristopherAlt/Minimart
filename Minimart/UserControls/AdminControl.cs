using System;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class AdminControl : UserControl
    {
        private AdminService _serviceAdmin;
        private EmployeeService _serviceEmployee;
        private AdminRoleService _serviceAdminRole;

        public AdminControl()
        {
            InitializeComponent();
            _serviceAdmin = new AdminService();
            _serviceEmployee = new EmployeeService();
            _serviceAdminRole = new AdminRoleService();
            LoadData();
        }

        public async void LoadData()
        {
            var admins = await _serviceAdmin.GetAllWithForeignNamesAsync();

            var displayAdmins = admins.Select(a => new
            {
                a.AdminID,
                EmployeeName = a.Employee != null ? $"{a.Employee.FullName}" : "N/A",
                a.Username,
                PasswordHash = BitConverter.ToString(a.PasswordHash).Replace("-", ""),
                Salt = BitConverter.ToString(a.Salt).Replace("-", ""),
                AdminRoleName = a.AdminRole != null ? a.AdminRole.RoleName : "N/A",
                a.CreatedAt,
                a.LastLogin,
                a.IsActive
            }).ToList();

            datagrid.DataSource = displayAdmins;

            var employees = await _serviceEmployee.GetAllAsync();
            employeeIDCombobox.DataSource = employees;
            employeeIDCombobox.DisplayMember = "FullName"; // Assuming FullName is a property combining first and last name
            employeeIDCombobox.ValueMember = "EmployeeID";

            var roles = await _serviceAdminRole.GetAllAsync();
            adminRoleIDCombobox.DataSource = roles;
            adminRoleIDCombobox.DisplayMember = "RoleName"; // Assuming RoleName is a property of AdminRole
            adminRoleIDCombobox.ValueMember = "AdminRoleID";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrEmpty(usernameText.Text) ||
                adminRoleIDCombobox.SelectedItem == null ||
                employeeIDCombobox.SelectedItem == null ||
                string.IsNullOrEmpty(passwordText.Text)) // No need for saltText.Text check
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newAdmin = new Admin
                {
                    EmployeeID = (int)employeeIDCombobox.SelectedValue,
                    Username = usernameText.Text,
                    AdminRoleID = (int)adminRoleIDCombobox.SelectedValue,
                    CreatedAt = dateCreatedPicker.Value,
                    LastLogin = lastLoginDatePicker.Checked ? lastLoginDatePicker.Value : (DateTime?)null,
                    IsActive = activeCheckbox.Checked
                };

                // Generate hash and salt from the password field
                newAdmin.SetHashAndSalt(passwordText.Text);

                // Add admin to the database
                await _serviceAdmin.AddAsync(newAdmin);

                // Reload data and clear input fields
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(usernameText.Text) ||
                adminRoleIDCombobox.SelectedItem == null ||
                employeeIDCombobox.SelectedItem == null ||
                string.IsNullOrEmpty(passwordText.Text)) // No need for saltText.Text check
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var selectedRow = datagrid.SelectedRows[0];
                var adminId = (int)selectedRow.Cells["AdminID"].Value;
                var adminToUpdate = await _serviceAdmin.GetByIdAsync(adminId);

                if (adminToUpdate != null)
                {
                    adminToUpdate.EmployeeID = (int)employeeIDCombobox.SelectedValue;
                    adminToUpdate.Username = usernameText.Text;
                    adminToUpdate.AdminRoleID = (int)adminRoleIDCombobox.SelectedValue;
                    adminToUpdate.CreatedAt = dateCreatedPicker.Value;
                    adminToUpdate.LastLogin = lastLoginDatePicker.Checked ? lastLoginDatePicker.Value : (DateTime?)null;
                    adminToUpdate.IsActive = activeCheckbox.Checked;

                    // If a new password is provided, generate a new hash and salt
                    if (!string.IsNullOrEmpty(passwordText.Text))
                    {
                        adminToUpdate.SetHashAndSalt(passwordText.Text);
                    }

                    // Update admin in the database
                    await _serviceAdmin.UpdateAsync(adminToUpdate);

                    // Reload data
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var adminId = (int)selectedRow.Cells["AdminID"].Value;

                var confirmResult = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await _serviceAdmin.DeleteAsync(adminId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select an admin to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            usernameText.Clear();
            passwordText.Clear();
            adminRoleIDCombobox.SelectedIndex = -1;
            employeeIDCombobox.SelectedIndex = -1;
            dateCreatedPicker.Value = DateTime.Now;
            lastLoginDatePicker.Value = DateTime.Now;
            lastLoginDatePicker.Checked = false;
            activeCheckbox.Checked = false;
        }

        private async void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                var admin = selectedRow.DataBoundItem as dynamic;

                if (admin != null)
                {
                    idText.Text = admin.AdminID.ToString();
                    employeeIDCombobox.SelectedIndex = employeeIDCombobox.FindStringExact(admin.EmployeeName);
                    usernameText.Text = admin.Username;
                    adminRoleIDCombobox.SelectedIndex = adminRoleIDCombobox.FindStringExact(admin.AdminRoleName);
                    dateCreatedPicker.Value = admin.CreatedAt;

                    var lastLogin = admin.LastLogin;
                    if (lastLogin != null)
                    {
                        lastLoginDatePicker.Value = lastLogin;
                        lastLoginDatePicker.Checked = true;
                    }
                    else
                    {
                        lastLoginDatePicker.Checked = false;
                    }

                    activeCheckbox.Checked = admin.IsActive;

                    var adminId = admin.AdminID;
                    var adminToUpdate = await _serviceAdmin.GetByIdAsync(adminId);
                    passwordText.Clear();
                }
            }
        }
    }
}
