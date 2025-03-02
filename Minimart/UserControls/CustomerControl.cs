using System;
using System.Diagnostics;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

namespace Minimart.UserControls
{
    public partial class CustomerControl : UserControl
    {
        private CustomerService service;

        public CustomerControl()
        {
            InitializeComponent();
            service = new CustomerService();
            LoadData();
        }

        public async void LoadData()
        {
            var rows = await service.GetAllAsync();
            datagrid.DataSource = rows;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNameText.Text) && !string.IsNullOrEmpty(lastNameText.Text) && !string.IsNullOrEmpty(phoneText.Text) && !string.IsNullOrEmpty(emailText.Text))
            {
                var newCustomer = new Customer
                {
                    FirstName = firstNameText.Text,
                    LastName = lastNameText.Text,
                    PhoneNumber = phoneText.Text,
                    Email = emailText.Text
                };

                await service.AddAsync(newCustomer);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var customerId = (int)selectedRow.Cells["CustomerID"].Value;

                var customerToUpdate = await service.GetByIdAsync(customerId);
                if (customerToUpdate != null)
                {
                    customerToUpdate.FirstName = firstNameText.Text;
                    customerToUpdate.LastName = lastNameText.Text;
                    customerToUpdate.PhoneNumber = phoneText.Text;
                    customerToUpdate.Email = emailText.Text;

                    await service.UpdateAsync(customerToUpdate);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var customerId = (int)selectedRow.Cells["CustomerID"].Value;

                var confirmResult = MessageBox.Show(
                    "Deleting this customer will remove all associated data.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(customerId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            phoneText.Clear();
            emailText.Clear();
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["CustomerID"].Value?.ToString();
                firstNameText.Text = selectedRow.Cells["FirstName"].Value?.ToString();
                lastNameText.Text = selectedRow.Cells["LastName"].Value?.ToString();
                phoneText.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                emailText.Text = selectedRow.Cells["Email"].Value?.ToString();
            }
        }
    }
}
