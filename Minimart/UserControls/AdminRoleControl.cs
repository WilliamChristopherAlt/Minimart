using System;
using System.Linq;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.DatabaseAccess;

namespace Minimart.UserControls
{
    public partial class AdminRoleControl : UserControl
    {
        private AdminRoleService service;

        public AdminRoleControl()
        {
            InitializeComponent();
            service = new AdminRoleService();
            LoadData();
        }

        public async void LoadData()
        {
            var roles = await service.GetAllAsync();
            datagrid.DataSource = roles;
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameText.Text) && !string.IsNullOrEmpty(descText.Text))
            {
                var newRole = new AdminRole
                {
                    RoleName = nameText.Text,
                    RoleDescription = descText.Text,
                    CanViewCategories = viewChecklist.GetItemChecked(0),
                    CanEditCategories = editChecklist.GetItemChecked(0),
                    CanViewSuppliers = viewChecklist.GetItemChecked(1),
                    CanEditSuppliers = editChecklist.GetItemChecked(1),
                    CanViewMeasurementUnits = viewChecklist.GetItemChecked(2),
                    CanEditMeasurementUnits = editChecklist.GetItemChecked(2),
                    CanViewProductTypes = viewChecklist.GetItemChecked(3),
                    CanEditProductTypes = editChecklist.GetItemChecked(3),
                    CanViewCustomers = viewChecklist.GetItemChecked(4),
                    CanEditCustomers = editChecklist.GetItemChecked(4),
                    CanViewEmployeeRoles = viewChecklist.GetItemChecked(5),
                    CanEditEmployeeRoles = editChecklist.GetItemChecked(5),
                    CanViewEmployees = viewChecklist.GetItemChecked(6),
                    CanEditEmployees = editChecklist.GetItemChecked(6),
                    CanViewPaymentMethods = viewChecklist.GetItemChecked(7),
                    CanEditPaymentMethods = editChecklist.GetItemChecked(7),
                    CanViewSales = viewChecklist.GetItemChecked(8),
                    CanEditSales = editChecklist.GetItemChecked(8),
                    CanViewSaleDetails = viewChecklist.GetItemChecked(9),
                    CanEditSaleDetails = editChecklist.GetItemChecked(9),
                    CanViewAdminRoles = viewChecklist.GetItemChecked(10),
                    CanEditAdminRoles = editChecklist.GetItemChecked(10),
                    CanViewAdmins = viewChecklist.GetItemChecked(11),
                    CanEditAdmins = editChecklist.GetItemChecked(11)
                };

                await service.AddAsync(newRole);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in both Role Name and Description fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                var selectedRow = datagrid.SelectedRows[0];
                var roleId = (int)selectedRow.Cells["AdminRoleID"].Value;
                var roleToUpdate = await service.GetByIdAsync(roleId);

                if (roleToUpdate != null)
                {
                    roleToUpdate.RoleName = nameText.Text;
                    roleToUpdate.RoleDescription = descText.Text;
                    roleToUpdate.CanViewCategories = viewChecklist.GetItemChecked(0);
                    roleToUpdate.CanEditCategories = editChecklist.GetItemChecked(0);
                    roleToUpdate.CanViewSuppliers = viewChecklist.GetItemChecked(1);
                    roleToUpdate.CanEditSuppliers = editChecklist.GetItemChecked(1);
                    roleToUpdate.CanViewMeasurementUnits = viewChecklist.GetItemChecked(2);
                    roleToUpdate.CanEditMeasurementUnits = editChecklist.GetItemChecked(2);
                    roleToUpdate.CanViewProductTypes = viewChecklist.GetItemChecked(3);
                    roleToUpdate.CanEditProductTypes = editChecklist.GetItemChecked(3);
                    roleToUpdate.CanViewCustomers = viewChecklist.GetItemChecked(4);
                    roleToUpdate.CanEditCustomers = editChecklist.GetItemChecked(4);
                    roleToUpdate.CanViewEmployeeRoles = viewChecklist.GetItemChecked(5);
                    roleToUpdate.CanEditEmployeeRoles = editChecklist.GetItemChecked(5);
                    roleToUpdate.CanViewEmployees = viewChecklist.GetItemChecked(6);
                    roleToUpdate.CanEditEmployees = editChecklist.GetItemChecked(6);
                    roleToUpdate.CanViewPaymentMethods = viewChecklist.GetItemChecked(7);
                    roleToUpdate.CanEditPaymentMethods = editChecklist.GetItemChecked(7);
                    roleToUpdate.CanViewSales = viewChecklist.GetItemChecked(8);
                    roleToUpdate.CanEditSales = editChecklist.GetItemChecked(8);
                    roleToUpdate.CanViewSaleDetails = viewChecklist.GetItemChecked(9);
                    roleToUpdate.CanEditSaleDetails = editChecklist.GetItemChecked(9);
                    roleToUpdate.CanViewAdminRoles = viewChecklist.GetItemChecked(10);
                    roleToUpdate.CanEditAdminRoles = editChecklist.GetItemChecked(10);
                    roleToUpdate.CanViewAdmins = viewChecklist.GetItemChecked(11);
                    roleToUpdate.CanEditAdmins = editChecklist.GetItemChecked(11);

                    await service.UpdateAsync(roleToUpdate);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Admin role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var roleId = (int)selectedRow.Cells["AdminRoleID"].Value;

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
            for (int i = 0; i < 12; i++)
            {
                viewChecklist.SetItemChecked(i, false);
                editChecklist.SetItemChecked(i, false);
            }
        }

        private void datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow != null && datagrid.CurrentRow.Index >= 0)
            {
                var selectedRow = datagrid.CurrentRow;
                idText.Text = selectedRow.Cells["AdminRoleID"].Value?.ToString();
                nameText.Text = selectedRow.Cells["RoleName"].Value?.ToString();
                descText.Text = selectedRow.Cells["RoleDescription"].Value?.ToString();

                var role = selectedRow.DataBoundItem as AdminRole;

                if (role != null)
                {
                    // Manually set the checkboxes to match the correct properties
                    viewChecklist.SetItemChecked(0, role.CanViewCategories);
                    editChecklist.SetItemChecked(0, role.CanEditCategories);

                    viewChecklist.SetItemChecked(1, role.CanViewSuppliers);
                    editChecklist.SetItemChecked(1, role.CanEditSuppliers);

                    viewChecklist.SetItemChecked(2, role.CanViewMeasurementUnits);
                    editChecklist.SetItemChecked(2, role.CanEditMeasurementUnits);

                    viewChecklist.SetItemChecked(3, role.CanViewProductTypes);
                    editChecklist.SetItemChecked(3, role.CanEditProductTypes);

                    viewChecklist.SetItemChecked(4, role.CanViewCustomers);
                    editChecklist.SetItemChecked(4, role.CanEditCustomers);

                    viewChecklist.SetItemChecked(5, role.CanViewEmployeeRoles);
                    editChecklist.SetItemChecked(5, role.CanEditEmployeeRoles);

                    viewChecklist.SetItemChecked(6, role.CanViewEmployees);
                    editChecklist.SetItemChecked(6, role.CanEditEmployees);

                    viewChecklist.SetItemChecked(7, role.CanViewPaymentMethods);
                    editChecklist.SetItemChecked(7, role.CanEditPaymentMethods);

                    viewChecklist.SetItemChecked(8, role.CanViewSales);
                    editChecklist.SetItemChecked(8, role.CanEditSales);

                    viewChecklist.SetItemChecked(9, role.CanViewSaleDetails);
                    editChecklist.SetItemChecked(9, role.CanEditSaleDetails);

                    viewChecklist.SetItemChecked(10, role.CanViewAdminRoles);
                    editChecklist.SetItemChecked(10, role.CanEditAdminRoles);

                    viewChecklist.SetItemChecked(11, role.CanViewAdmins);
                    editChecklist.SetItemChecked(11, role.CanEditAdmins);
                }
            }
        }
    }
}
