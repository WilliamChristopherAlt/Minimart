using System;
using System.Diagnostics;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

namespace Minimart.UserControls
{
    public partial class SupplierControl : UserControl
    {
        private SupplierService service;

        public SupplierControl()
        {
            InitializeComponent();
            service = new SupplierService();
            LoadData();
        }

        public async void LoadData()
        {
            var rows = await service.GetAllAsync();
            datagrid.DataSource = rows;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(emailText.Text) &&
                !string.IsNullOrEmpty(phoneText.Text) && !string.IsNullOrEmpty(addressText.Text))
            {
                var newSupplier = new Supplier
                {
                    SupplierName = nameText.Text,
                    SupplierEmail = emailText.Text,
                    SupplierPhoneNumber = phoneText.Text,
                    SupplierAddress = addressText.Text
                };

                try
                {
                    await service.AddAsync(newSupplier);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                var supplierId = (int)selectedRow.Cells["SupplierID"].Value;

                try
                {
                    var supplierToUpdate = await service.GetByIdAsync(supplierId);
                    if (supplierToUpdate != null)
                    {
                        supplierToUpdate.SupplierName = nameText.Text;
                        supplierToUpdate.SupplierEmail = emailText.Text;
                        supplierToUpdate.SupplierPhoneNumber = phoneText.Text;
                        supplierToUpdate.SupplierAddress = addressText.Text;

                        await service.UpdateAsync(supplierToUpdate);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var supplierId = (int)selectedRow.Cells["SupplierID"].Value;

                var confirmResult = MessageBox.Show(
                    "Deleting this supplier will also remove any data that depends on it.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(supplierId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            nameText.Clear();
            emailText.Clear();
            phoneText.Clear();
            addressText.Clear();
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["SupplierID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["SupplierName"].Value?.ToString();
                emailText.Text = selectedRow.Cells["SupplierEmail"].Value?.ToString();
                phoneText.Text = selectedRow.Cells["SupplierPhoneNumber"].Value?.ToString();
                addressText.Text = selectedRow.Cells["SupplierAddress"].Value?.ToString();
            }
        }
    }
}
