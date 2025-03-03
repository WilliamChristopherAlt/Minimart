using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class EmployeeControl : UserControl
    {
        private EmployeeService _serviceEmployee;
        private EmployeeRoleService _serviceRole;

        public EmployeeControl()
        {
            InitializeComponent();
            _serviceEmployee = new EmployeeService();
            _serviceRole = new EmployeeRoleService();
            LoadData();
        }
        public async void LoadData()
        {
            // Get employees with their related role names
            var employees = await _serviceEmployee.GetAllWithForeignNamesAsync();

            var formattedData = employees.Select(emp => new
            {
                emp.EmployeeID,
                emp.FirstName,
                emp.LastName,
                emp.Email,
                emp.PhoneNumber,
                emp.Gender,
                emp.BirthDate,
                emp.CitizenID,
                emp.Salary,
                emp.HireDate,
                Role = emp.Role?.RoleName, // Show Role Name instead of Role ID
            }).ToList();

            // Set the formatted data to the data grid
            datagrid.DataSource = formattedData;

            // Load Role Names into ComboBox
            var roles = await _serviceRole.GetAllAsync();
            roleIDCombobox.DataSource = roles;
            roleIDCombobox.DisplayMember = "RoleName";  // Display Role Name in the ComboBox
            roleIDCombobox.ValueMember = "RoleID";  // Use Role ID as the value
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            // Check if required fields are filled in
            if (string.IsNullOrEmpty(firstNameText.Text) || string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please fill in the required fields: First Name and Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if a valid selection is made in ComboBoxes
            if (genderCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roleIDCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new employee object
            var newEmployee = new Employee
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Email = emailText.Text,
                PhoneNumber = phoneText.Text,
                Gender = genderCombobox.SelectedItem?.ToString(),
                BirthDate = birthdatePicker.Value,
                CitizenID = citizenIDText.Text,
                Salary = salaryNumericUpDown.Value,
                HireDate = dateHiredPicker.Value,
                RoleID = (int)roleIDCombobox.SelectedValue
            };

            try
            {
                // Add the new employee asynchronously
                await _serviceEmployee.AddAsync(newEmployee);
                LoadData(); // Refresh data grid after adding
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            // Check if an employee is selected
            if (datagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = datagrid.SelectedRows[0];
            var employeeId = (int)selectedRow.Cells["EmployeeID"].Value;
            var employeeToUpdate = await _serviceEmployee.GetByIdAsync(employeeId);

            if (employeeToUpdate == null)
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if required fields are filled in
            if (string.IsNullOrEmpty(firstNameText.Text) || string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please fill in the required fields: First Name and Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if a valid selection is made in ComboBoxes
            if (genderCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roleIDCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update employee properties
            employeeToUpdate.FirstName = firstNameText.Text;
            employeeToUpdate.LastName = lastNameText.Text;
            employeeToUpdate.Email = emailText.Text;
            employeeToUpdate.PhoneNumber = phoneText.Text;
            employeeToUpdate.Gender = genderCombobox.SelectedItem?.ToString();
            employeeToUpdate.BirthDate = birthdatePicker.Value;
            employeeToUpdate.CitizenID = citizenIDText.Text;
            employeeToUpdate.Salary = salaryNumericUpDown.Value;
            employeeToUpdate.HireDate = dateHiredPicker.Value;
            employeeToUpdate.RoleID = (int)roleIDCombobox.SelectedValue;

            try
            {
                // Update the employee asynchronously
                await _serviceEmployee.UpdateAsync(employeeToUpdate);
                LoadData(); // Refresh data grid after updating
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var employeeId = (int)selectedRow.Cells["EmployeeID"].Value;

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await _serviceEmployee.DeleteAsync(employeeId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            firstNameText.Clear();
            lastNameText.Clear();
            emailText.Clear();
            phoneText.Clear();
            genderCombobox.SelectedIndex = -1;
            birthdatePicker.Value = DateTime.Now;
            citizenIDText.Clear();
            salaryNumericUpDown.Value = 0;
            dateHiredPicker.Value = DateTime.Now;
            roleIDCombobox.SelectedIndex = -1;
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;

                // Populate the textboxes with the selected employee's information
                idText.Text = selectedRow.Cells["EmployeeID"].Value?.ToString();
                firstNameText.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                lastNameText.Text = selectedRow.Cells["LastName"].Value?.ToString();
                emailText.Text = selectedRow.Cells["Email"].Value?.ToString();
                phoneText.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                genderCombobox.SelectedItem = selectedRow.Cells["Gender"].Value?.ToString();
                birthdatePicker.Value = (DateTime)selectedRow.Cells["BirthDate"].Value;
                citizenIDText.Text = selectedRow.Cells["CitizenID"].Value?.ToString();
                salaryNumericUpDown.Value = Convert.ToDecimal(selectedRow.Cells["Salary"].Value ?? 0);
                dateHiredPicker.Value = (DateTime)selectedRow.Cells["HireDate"].Value;

                // Set the ComboBox to the correct Role based on Role Name
                var selectedRoleName = selectedRow.Cells["Role"].Value?.ToString();

                // Find the matching Role object by RoleName
                var matchingRole = roleIDCombobox.Items.Cast<EmployeeRole>()
                    .FirstOrDefault(role => role.RoleName == selectedRoleName);

                if (matchingRole != null)
                {
                    roleIDCombobox.SelectedItem = matchingRole;
                }
            }
        }
    }
}
