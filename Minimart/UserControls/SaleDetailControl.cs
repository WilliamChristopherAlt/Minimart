using System;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.DatabaseAccess;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class SaleDetailControl : UserControl
    {
        private SaleDetailService _serviceSaleDetail;
        private SaleService _serviceSale;
        private ProductTypeService _serviceProductType;

        public SaleDetailControl()
        {
            InitializeComponent();
            _serviceSaleDetail = new SaleDetailService();
            _serviceSale = new SaleService();
            _serviceProductType = new ProductTypeService();
            LoadData();
        }

        public async void LoadData()
        {
            // Get SaleDetail data with related Sale and ProductType data
            var saleDetails = await _serviceSaleDetail.GetAllWithForeignNamesAsync();

            // Format the data for displaying in the DataGridView
            var formattedData = saleDetails.Select(sd => new
            {
                sd.SaleDetailID,
                Sale = $"{sd.Sale.SaleDate:dd/MM/yyyy} ({sd.Sale.SaleID})",  // Merged SaleDate and SaleID
                ProductTypeName = sd.ProductType?.ProductName,
                sd.Quantity
            }).ToList();

            // Set the DataGridView's DataSource
            datagrid.DataSource = formattedData;

            // Hide the unnecessary columns (Sale and ProductType references)
            //datagrid.Columns["Sale"].Visible = false;
            //datagrid.Columns["ProductType"].Visible = false;

            // Load Sale IDs into saleIDComboBox with formatted display
            var sales = await _serviceSale.GetAllAsync();
            saleIDCombobox.DataSource = sales;
            saleIDCombobox.DisplayMember = "FormattedSale";  // Display SaleDate and SaleID in ComboBox
            saleIDCombobox.ValueMember = "SaleID";           // Value is the SaleID

            // Load Product Type IDs into productTypeIDComboBox
            var productTypes = await _serviceProductType.GetAllAsync();
            productTypeIDCombobox.DataSource = productTypes;
            productTypeIDCombobox.DisplayMember = "ProductName";  // Displays ProductTypeName in ComboBox
            productTypeIDCombobox.ValueMember = "ProductTypeID";      // Value is the ProductTypeID
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (productTypeIDCombobox.SelectedValue != null && saleIDCombobox.SelectedValue != null && quantityNumericUpDown.Value > 0)
            {
                var newSaleDetail = new SaleDetail
                {
                    SaleID = (int)saleIDCombobox.SelectedValue,
                    ProductTypeID = (int)productTypeIDCombobox.SelectedValue,
                    Quantity = quantityNumericUpDown.Value
                };

                try
                {
                    await _serviceSaleDetail.AddAsync(newSaleDetail);  // Attempt to add the sale detail
                    LoadData();  // Reload the data to reflect the changes
                    ClearFields();  // Clear the input fields after successful addition
                }
                catch (Exception ex)
                {
                    // Show an error message if the operation fails
                    MessageBox.Show($"Error adding SaleDetail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var saleDetailId = (int)selectedRow.Cells["SaleDetailID"].Value;

                // Check if all required fields are filled
                if (saleIDCombobox.SelectedValue != null && productTypeIDCombobox.SelectedValue != null && quantityNumericUpDown.Value > 0)
                {
                    try
                    {
                        var saleDetailToUpdate = await _serviceSaleDetail.GetByIdAsync(saleDetailId);
                        if (saleDetailToUpdate != null)
                        {
                            saleDetailToUpdate.SaleID = (int)saleIDCombobox.SelectedValue;
                            saleDetailToUpdate.ProductTypeID = (int)productTypeIDCombobox.SelectedValue;
                            saleDetailToUpdate.Quantity = quantityNumericUpDown.Value;

                            await _serviceSaleDetail.UpdateAsync(saleDetailToUpdate);  // Attempt to update the sale detail
                            LoadData();  // Reload the data to reflect the changes
                        }
                        else
                        {
                            MessageBox.Show("SaleDetail not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show an error message if the operation fails
                        MessageBox.Show($"Error updating SaleDetail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a SaleDetail to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var saleDetailId = (int)selectedRow.Cells["SaleDetailID"].Value;

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this SaleDetail?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await _serviceSaleDetail.DeleteAsync(saleDetailId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a SaleDetail to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            productTypeIDCombobox.SelectedIndex = -1;
            saleIDCombobox.SelectedIndex = -1;
            quantityNumericUpDown.Value = 0;
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                var saleDetail = selectedRow.DataBoundItem as dynamic;

                if (saleDetail != null)
                {
                    saleIDCombobox.SelectedIndex = saleIDCombobox.FindStringExact(saleDetail.Sale);
                    productTypeIDCombobox.SelectedIndex = productTypeIDCombobox.FindStringExact(saleDetail.ProductTypeName);
                    quantityNumericUpDown.Value = saleDetail.Quantity;
                }
            }
        }

    }
}
