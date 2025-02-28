using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

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

        public void LoadData()
        {
            var rows = service.GetAll();
            datagrid.DataSource = rows;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(phoneText.Text))
            {
                var newSupplier = new Supplier
                {
                    Name = nameText.Text,
                    PhoneNumber = phoneText.Text,
                    Address = addressText.Text,
                    Email = emailText.Text
                };

                service.Add(newSupplier);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in Name and Phone fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var supplierId = (int)selectedRow.Cells["SupplierID"].Value;

                var supplierToUpdate = service.GetById(supplierId);
                if (supplierToUpdate != null)
                {
                    supplierToUpdate.Name = nameText.Text;
                    supplierToUpdate.PhoneNumber = phoneText.Text;
                    supplierToUpdate.Address = addressText.Text;
                    supplierToUpdate.Email = emailText.Text;

                    service.Update(supplierToUpdate);
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
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
                    service.Delete(supplierId);
                    LoadData();
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

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["SupplierID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["Name"].Value?.ToString();
                phoneText.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                addressText.Text = selectedRow.Cells["Address"].Value?.ToString();
                emailText.Text = selectedRow.Cells["Email"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            idText.Clear();
            nameText.Clear();
            phoneText.Clear();
            addressText.Clear();
            emailText.Clear();
        }
    }
}
