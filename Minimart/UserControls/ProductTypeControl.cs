using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class ProductTypeControl : UserControl
    {
        private ProductTypeService _serviceProductType;
        private SupplierService _serviceSupplier;
        private CategoryService _serviceCategory;
        private MeasurementUnitService _serviceMeasurement;

        public ProductTypeControl()
        {
            InitializeComponent();
            _serviceProductType = new ProductTypeService();
            _serviceSupplier = new SupplierService();
            _serviceCategory = new CategoryService();
            _serviceMeasurement = new MeasurementUnitService();
            LoadData();
        }

        public async void LoadData()
        {
            // Get all product types with related entities loaded
            var productTypes = await _serviceProductType.GetAllWithForeignNamesAsync();

            var formattedData = productTypes.Select(pt => new
            {
                pt.ProductTypeID,
                pt.ProductName,
                pt.ProductDescription,
                Category = pt.Category?.CategoryName, // Show Category Name
                Supplier = pt.Supplier?.SupplierName, // Show Supplier Name
                MeasurementUnit = pt.MeasurementUnit?.UnitName, // Show Unit Name
                pt.Price,
                pt.StockAmount,
                pt.DateAdded,
                pt.IsActive
            }).ToList();

            datagrid.DataSource = formattedData;

            // Load Supplier Names into ComboBox
            var suppliers = await _serviceSupplier.GetAllAsync();
            supplierIDComboBox.DataSource = suppliers;
            supplierIDComboBox.DisplayMember = "SupplierName";
            supplierIDComboBox.ValueMember = "SupplierID";

            // Load Category Names into ComboBox
            var categories = await _serviceCategory.GetAllAsync();
            categoryIDComboBox.DataSource = categories;
            categoryIDComboBox.DisplayMember = "CategoryName";
            categoryIDComboBox.ValueMember = "CategoryID";

            // Load Measurement Unit Names into ComboBox
            var units = await _serviceMeasurement.GetAllAsync();
            measureUnitIDComboBox.DataSource = units;
            measureUnitIDComboBox.DisplayMember = "UnitName";
            measureUnitIDComboBox.ValueMember = "MeasurementUnitID";
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all required fields are filled
                if (string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(descText.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if a valid selection is made in ComboBoxes
                if (supplierIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (categoryIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (measureUnitIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a measurement unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the new product type object
                var newProductType = new ProductType
                {
                    ProductName = nameText.Text,
                    ProductDescription = descText.Text,
                    Price = priceNumericUpDown.Value,
                    StockAmount = stockNumericUpDown.Value,
                    DateAdded = dateAddedPicker.Value,
                    SupplierID = (int)supplierIDComboBox.SelectedValue,
                    CategoryID = (int)categoryIDComboBox.SelectedValue,
                    MeasurementUnitID = (int)measureUnitIDComboBox.SelectedValue,
                    IsActive = activeCheckbox.Checked
                };

                // Add the new product type asynchronously
                await _serviceProductType.AddAsync(newProductType);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product type to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedRow = datagrid.SelectedRows[0];
                var productTypeId = (int)selectedRow.Cells["ProductTypeID"].Value;

                var productTypeToUpdate = await _serviceProductType.GetByIdAsync(productTypeId);
                if (productTypeToUpdate == null)
                {
                    MessageBox.Show("ProductType not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if a valid selection is made in ComboBoxes
                if (supplierIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (categoryIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (measureUnitIDComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a measurement unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update product type properties
                productTypeToUpdate.ProductName = nameText.Text;
                productTypeToUpdate.ProductDescription = descText.Text;
                productTypeToUpdate.Price = priceNumericUpDown.Value;
                productTypeToUpdate.StockAmount = stockNumericUpDown.Value;
                productTypeToUpdate.DateAdded = dateAddedPicker.Value;
                productTypeToUpdate.SupplierID = (int)supplierIDComboBox.SelectedValue;
                productTypeToUpdate.CategoryID = (int)categoryIDComboBox.SelectedValue;
                productTypeToUpdate.MeasurementUnitID = (int)measureUnitIDComboBox.SelectedValue;
                productTypeToUpdate.IsActive = activeCheckbox.Checked;

                // Update product type asynchronously
                await _serviceProductType.UpdateAsync(productTypeToUpdate);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var productTypeId = (int)selectedRow.Cells["ProductTypeID"].Value;

                var confirmResult = MessageBox.Show(
                    "Deleting this product type will also remove any data that depends on it.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await _serviceProductType.DeleteAsync(productTypeId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a product type to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Debug.Print("clear button pressed");
            ClearFields();
        }

        private void ClearFields()
        {
            idText.Clear();
            nameText.Clear();
            descText.Clear();
            priceNumericUpDown.Value = 0;
            stockNumericUpDown.Value = 0;
            dateAddedPicker.Value = DateTime.Now;
            supplierIDComboBox.SelectedIndex = -1;
            categoryIDComboBox.SelectedIndex = -1;
            measureUnitIDComboBox.SelectedIndex = -1;
            activeCheckbox.Checked = false;
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["ProductTypeID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                descText.Text = selectedRow.Cells["ProductDescription"].Value?.ToString();
                priceNumericUpDown.Value = (decimal)selectedRow.Cells["Price"].Value;
                stockNumericUpDown.Value = (decimal)selectedRow.Cells["StockAmount"].Value;
                dateAddedPicker.Value = (DateTime)selectedRow.Cells["DateAdded"].Value;
                activeCheckbox.Checked = (bool)selectedRow.Cells["IsActive"].Value;

                supplierIDComboBox.SelectedIndex = supplierIDComboBox.FindStringExact(selectedRow.Cells["Supplier"].Value?.ToString());
                categoryIDComboBox.SelectedIndex = categoryIDComboBox.FindStringExact(selectedRow.Cells["Category"].Value?.ToString());
                measureUnitIDComboBox.SelectedIndex = measureUnitIDComboBox.FindStringExact(selectedRow.Cells["MeasurementUnit"].Value?.ToString());
            }
        }
    }
}
