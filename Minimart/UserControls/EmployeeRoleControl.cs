using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

namespace Minimart.UserControls
{
    public partial class EmployeeRoleControl : UserControl
    {
        private EmployeeRoleService service;

        public EmployeeRoleControl()
        {
            InitializeComponent();
            service = new EmployeeRoleService();
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
                var newRole = new EmployeeRole
                {
                    RoleName = nameText.Text,
                    RoleDescription = descText.Text
                };

                try
                {
                    await service.AddAsync(newRole);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var roleId = (int)selectedRow.Cells["RoleID"].Value;

                var roleToUpdate = await service.GetByIdAsync(roleId);
                if (roleToUpdate != null)
                {
                    roleToUpdate.RoleName = nameText.Text;
                    roleToUpdate.RoleDescription = descText.Text;

                    try
                    {
                        await service.UpdateAsync(roleToUpdate);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a role to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var roleId = (int)selectedRow.Cells["RoleID"].Value;

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this role?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    await service.DeleteAsync(roleId);
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a role to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                idText.Text = selectedRow.Cells["RoleID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["RoleName"].Value?.ToString();
                descText.Text = selectedRow.Cells["RoleDescription"].Value?.ToString();
            }
        }
    }
}
