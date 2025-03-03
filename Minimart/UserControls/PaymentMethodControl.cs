using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

namespace Minimart.UserControls
{
    public partial class PaymentMethodControl : UserControl
    {
        private PaymentMethodService service;

        public PaymentMethodControl()
        {
            InitializeComponent();
            service = new PaymentMethodService();
            LoadData();
        }

        public async void LoadData()
        {
            var rows = await service.GetAllAsync();
            datagrid.DataSource = rows;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text))
            {
                var newPaymentMethod = new PaymentMethod
                {
                    MethodName = nameText.Text
                };

                try
                {
                    await service.AddAsync(newPaymentMethod);  // Use the async method for adding
                    LoadData();  // Refresh data grid after adding
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding payment method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a method name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var methodId = (int)selectedRow.Cells["PaymentMethodID"].Value;

                var methodToUpdate = await service.GetByIdAsync(methodId);
                if (methodToUpdate != null)
                {
                    if (string.IsNullOrWhiteSpace(nameText.Text))
                    {
                        MessageBox.Show("Please enter a method name to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    methodToUpdate.MethodName = nameText.Text;

                    try
                    {
                        await service.UpdateAsync(methodToUpdate);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating payment method: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Payment method not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var methodId = (int)selectedRow.Cells["PaymentMethodID"].Value;

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this payment method?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(methodId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["PaymentMethodID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["MethodName"].Value?.ToString();
            }
        }
    }
}
