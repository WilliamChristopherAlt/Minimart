using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class CategoryControl : UserControl
    {
        private CategoryService service;
        public CategoryControl()
        {
            InitializeComponent();
            service = new CategoryService();
            LoadData();
        }

        public void LoadData()
        {
            var rows = service.GetAll();
            datagrid.DataSource = rows;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(descText.Text))
            {
                var newCategory = new Category
                {
                    Name = nameText.Text,
                    Description = descText.Text
                };

                service.Add(newCategory);

                LoadData();

                nameText.Clear();
                descText.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in both Name and Description fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var categoryId = (int)selectedRow.Cells["CategoryID"].Value;

                var categoryToUpdate = service.GetById(categoryId);
                if (categoryToUpdate != null)
                {
                    categoryToUpdate.Name = nameText.Text;
                    categoryToUpdate.Description = descText.Text;

                    service.Update(categoryToUpdate);

                    LoadData();

                    nameText.Clear();
                    descText.Clear();
                }
                else
                {
                    MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var categoryId = (int)selectedRow.Cells["CategoryID"].Value;

                // Display confirmation message with a warning about dependent data
                var confirmResult = MessageBox.Show(
                    "Deleting this category will also remove any data that depends on it.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    service.Delete(categoryId);
                    LoadData();  // Refresh data grid after deletion
                    //MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idText.Clear();
            nameText.Clear();
            descText.Clear();
        }


        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                // Ensure the row is valid before accessing cells
                var selectedRow = datagrid.CurrentRow;

                // Transfer data from selected row to textboxes
                idText.Text = selectedRow.Cells["CategoryID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["Name"].Value?.ToString();
                descText.Text = selectedRow.Cells["Description"].Value?.ToString();
            }
        }
    }
}
