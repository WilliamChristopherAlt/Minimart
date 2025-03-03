using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class CategoryControl : UserControl
    {
        private CategoryService service;

        // Updated constructor to pass context to CategoryService
        public CategoryControl()
        {
            InitializeComponent();
            service = new CategoryService(); // Pass context to the CategoryService constructor
            LoadData();
        }

        // Method to load data into the DataGridView
        public async void LoadData()
        {
            var rows = await service.GetAllAsync();  // Call async method for fetching all categories
            datagrid.DataSource = rows;
        }

        // Method to add a new category
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(descText.Text))
            {
                var newCategory = new Category
                {
                    CategoryName = nameText.Text,
                    CategoryDescription = descText.Text
                };

                try
                {
                    await service.AddAsync(newCategory);  // Use the async method for adding
                    LoadData();  // Refresh data grid after adding
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in both Name and Description fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var categoryId = (int)selectedRow.Cells["CategoryID"].Value;

                try
                {
                    var categoryToUpdate = await service.GetByIdAsync(categoryId);
                    if (categoryToUpdate != null)
                    {
                        // Validate input before modifying the object
                        if (string.IsNullOrWhiteSpace(nameText.Text))
                        {
                            MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Stop execution
                        }

                        categoryToUpdate.CategoryName = nameText.Text;
                        categoryToUpdate.CategoryDescription = descText.Text;

                        await service.UpdateAsync(categoryToUpdate);  // Update asynchronously

                        LoadData();  // Refresh UI only if update is successful
                    }
                    else
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to delete a category
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var categoryId = (int)selectedRow.Cells["CategoryID"].Value;

                var confirmResult = MessageBox.Show(
                    "Deleting this category will also remove any data that depends on it.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(categoryId);  // Delete asynchronously
                    LoadData();  // Refresh data grid after deletion
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear the input fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Helper method to clear text fields
        private void ClearFields()
        {
            idText.Clear();
            nameText.Clear();
            descText.Clear();
        }

        // Method to update the text fields when a row is selected in the DataGridView
        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["CategoryID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["CategoryName"].Value?.ToString();  // Make sure column name is correct
                descText.Text = selectedRow.Cells["CategoryDescription"].Value?.ToString();
            }
        }
    }
}
