using System;
using System.Windows.Forms;
using Minimart.UserControls;
using System.Diagnostics;

namespace Minimart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void formContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
