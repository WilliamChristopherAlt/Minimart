using System;
using System.Windows.Forms;
using Minimart.BusinessLogic;
using Minimart.Entities;
using Minimart.UserControls;

namespace Minimart
{
    public partial class MainForm : Form
    {
        private Admin _admin;
        private AdminService _serviceAdmin;

        public MainForm(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
            _serviceAdmin = new AdminService();

            // Load admin data asynchronously
            LoadAdminDataAsync();
        }

        private async void LoadAdminDataAsync()
        {
            if (_admin != null)
            {
                usernameLabel.Text = _admin.Username;

                // Fetch the role name using GetRoleNameByIdAsync
                string roleName = await _serviceAdmin.GetRoleNameByIdAsync(_admin.AdminRole?.AdminRoleID ?? 0);

                // Set the role label
                roleLabel.Text = roleName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadView(UserControl view)
        {
            formContainer.Controls.Clear();
            view.Dock = DockStyle.Fill; // Make it fill the panel
            formContainer.Controls.Add(view);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            LoadView(new CategoryControl());
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            LoadView(new SupplierControl());
        }

        private void productTypeButton_Click(object sender, EventArgs e)
        {
            LoadView(new ProductTypeControl());
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            LoadView(new CustomerControl());
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            LoadView(new EmployeeControl());
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            LoadView(new SaleControl());
        }

        private void saleDetailButton_Click(object sender, EventArgs e)
        {
            LoadView(new SaleDetailControl());
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LoadView(new AdminControl());
        }

        private void employeeRoleButton_Click(object sender, EventArgs e)
        {
            LoadView(new EmployeeRoleControl());
        }

        private void paymentMethodButton_Click(object sender, EventArgs e)
        {
            LoadView(new PaymentMethodControl());
        }

        private void adminRoleButton_Click(object sender, EventArgs e)
        {
            LoadView(new AdminRoleControl());
        }

        private void measureUnitButton_Click(object sender, EventArgs e)
        {
            LoadView(new MeasurementUnitControl());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Application.Restart();
            }
        }

    }
}
