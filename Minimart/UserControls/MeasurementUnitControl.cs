using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;

namespace Minimart.UserControls
{
    public partial class MeasurementUnitControl : UserControl
    {
        private MeasurementUnitService service;

        public MeasurementUnitControl()
        {
            InitializeComponent();
            service = new MeasurementUnitService();
            LoadData();
        }

        public async void LoadData()
        {
            var rows = await service.GetAllAsync();
            datagrid.DataSource = rows;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameText.Text) || string.IsNullOrWhiteSpace(descText.Text))
                {
                    MessageBox.Show("Please fill in both Name and Description fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUnit = new MeasurementUnit
                {
                    UnitName = nameText.Text,
                    UnitDescription = descText.Text,
                    IsContinuous = continuousCheckbox.Checked  // Use the checkbox to set IsContinuous
                };

                await service.AddAsync(newUnit);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding measurement unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a measurement unit to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = datagrid.SelectedRows[0];
            var unitId = (int)selectedRow.Cells["MeasurementUnitID"].Value;

            try
            {
                var unitToUpdate = await service.GetByIdAsync(unitId);
                if (unitToUpdate == null)
                {
                    MessageBox.Show("Measurement unit not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(nameText.Text) || string.IsNullOrWhiteSpace(descText.Text))
                {
                    MessageBox.Show("Please fill in both Name and Description fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                unitToUpdate.UnitName = nameText.Text;
                unitToUpdate.UnitDescription = descText.Text;
                unitToUpdate.IsContinuous = continuousCheckbox.Checked;

                await service.UpdateAsync(unitToUpdate);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating measurement unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var unitId = (int)selectedRow.Cells["MeasurementUnitID"].Value;

                var confirmResult = MessageBox.Show(
                    "Deleting this unit will also remove any data that depends on it.\n\nAre you sure you want to continue?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(unitId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a measurement unit to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            descText.Clear();
            continuousCheckbox.Checked = false;  // Clear the checkbox
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["MeasurementUnitID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["UnitName"].Value?.ToString();
                descText.Text = selectedRow.Cells["UnitDescription"].Value?.ToString();

                // Set the checkbox based on IsContinuous value
                continuousCheckbox.Checked = (bool)selectedRow.Cells["IsContinuous"].Value;
            }
        }
    }
}
