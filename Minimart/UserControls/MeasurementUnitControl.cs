using System;
using System.Diagnostics;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

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
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(descText.Text))
            {
                var newUnit = new MeasurementUnit
                {
                    UnitName = nameText.Text,
                    UnitDescription = descText.Text
                };

                await service.AddAsync(newUnit);
                LoadData();
                ClearFields();
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
                var unitId = (int)selectedRow.Cells["MeasurementUnitID"].Value;

                var unitToUpdate = await service.GetByIdAsync(unitId);
                if (unitToUpdate != null)
                {
                    unitToUpdate.UnitName = nameText.Text;
                    unitToUpdate.UnitDescription = descText.Text;

                    await service.UpdateAsync(unitToUpdate);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Measurement unit not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a measurement unit to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["MeasurementUnitID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["UnitName"].Value?.ToString();
                descText.Text = selectedRow.Cells["UnitDescription"].Value?.ToString();
            }
        }
    }
}
