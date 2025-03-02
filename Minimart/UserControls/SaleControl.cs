using System;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class SaleControl : UserControl
    {
        private SaleService _serviceSale;
        private CustomerService _serviceCustomer;
        private EmployeeService _serviceEmployee;
        private PaymentMethodService _servicePaymentMethod;

        public SaleControl()
        {
            InitializeComponent();
            _serviceSale = new SaleService();
            _serviceCustomer = new CustomerService();
            _serviceEmployee = new EmployeeService();
            _servicePaymentMethod = new PaymentMethodService();
            LoadData();
        }

        public async void LoadData()
        {
            // Get all sales with related entities loaded
            var sales = await _serviceSale.GetAllWithForeignNamesAsync();

            var formattedData = sales.Select(s => new
            {
                s.SaleID,
                s.SaleDate,
                Customer = s.Customer != null ? $"{s.Customer.FirstName} {s.Customer.LastName} ({s.Customer.CustomerID})" : "Guest",
                Employee = $"{s.Employee.FirstName} {s.Employee.LastName} ({s.Employee.EmployeeID})",
                PaymentMethod = s.PaymentMethod?.MethodName
            }).ToList();

            datagrid.DataSource = formattedData;

            // Load Customer Names into ComboBox
            var customers = await _serviceCustomer.GetAllAsync();
            customerIDCombobox.DataSource = customers;
            customerIDCombobox.DisplayMember = "FullName";
            customerIDCombobox.ValueMember = "CustomerID";

            // Load Employee Names into ComboBox
            var employees = await _serviceEmployee.GetAllAsync();
            employeeIDCombobox.DataSource = employees;
            employeeIDCombobox.DisplayMember = "FullName";
            employeeIDCombobox.ValueMember = "EmployeeID";

            // Load Payment Methods into ComboBox
            var paymentMethods = await _servicePaymentMethod.GetAllAsync();
            payMethodIDCombobox.DataSource = paymentMethods;
            payMethodIDCombobox.DisplayMember = "MethodName";
            payMethodIDCombobox.ValueMember = "PaymentMethodID";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (employeeIDCombobox.SelectedItem != null && customerIDCombobox.SelectedItem != null && payMethodIDCombobox.SelectedItem != null)
            {
                var newSale = new Sale
                {
                    SaleDate = datePicker.Value,
                    CustomerID = (int)customerIDCombobox.SelectedValue,
                    EmployeeID = (int)employeeIDCombobox.SelectedValue,
                    PaymentMethodID = (int)payMethodIDCombobox.SelectedValue
                };

                await _serviceSale.AddAsync(newSale);
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
                var saleId = (int)selectedRow.Cells["SaleID"].Value;

                var saleToUpdate = await _serviceSale.GetByIdAsync(saleId);
                if (saleToUpdate != null)
                {
                    saleToUpdate.SaleDate = datePicker.Value;
                    saleToUpdate.CustomerID = (int)customerIDCombobox.SelectedValue;
                    saleToUpdate.EmployeeID = (int)employeeIDCombobox.SelectedValue;
                    saleToUpdate.PaymentMethodID = (int)payMethodIDCombobox.SelectedValue;

                    await _serviceSale.UpdateAsync(saleToUpdate);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sale not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a sale to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var saleId = (int)selectedRow.Cells["SaleID"].Value;

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this sale?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await _serviceSale.DeleteAsync(saleId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a sale to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            datePicker.Value = DateTime.Now;
            employeeIDCombobox.SelectedIndex = -1;
            customerIDCombobox.SelectedIndex = -1;
            payMethodIDCombobox.SelectedIndex = -1;
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;

                idText.Text = selectedRow.Cells["SaleID"].Value?.ToString();
                datePicker.Value = (DateTime)selectedRow.Cells["SaleDate"].Value;

                string customerDisplayName = selectedRow.Cells["Customer"].Value?.ToString();
                customerIDCombobox.SelectedIndex = customerIDCombobox.FindStringExact(customerDisplayName);

                string employeeDisplayName = selectedRow.Cells["Employee"].Value?.ToString();
                employeeIDCombobox.SelectedIndex = employeeIDCombobox.FindStringExact(employeeDisplayName);

                string paymentMethodName = selectedRow.Cells["PaymentMethod"].Value?.ToString();
                payMethodIDCombobox.SelectedIndex = payMethodIDCombobox.FindStringExact(paymentMethodName);
            }
        }

    }
}
