namespace Minimart
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.formContainer = new System.Windows.Forms.Panel();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminRoleButton = new System.Windows.Forms.Button();
            this.paymentMethodButton = new System.Windows.Forms.Button();
            this.employeeRoleButton = new System.Windows.Forms.Button();
            this.saleDetailButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.productTypeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.supplierButton = new System.Windows.Forms.Button();
            this.measureUnitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Azure;
            this.usernameLabel.Location = new System.Drawing.Point(119, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(103, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "<username>";
            // 
            // formContainer
            // 
            this.formContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formContainer.Location = new System.Drawing.Point(223, 0);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(1289, 757);
            this.formContainer.TabIndex = 2;
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryButton.Location = new System.Drawing.Point(17, 80);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(205, 43);
            this.categoryButton.TabIndex = 3;
            this.categoryButton.Text = "Categories";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.measureUnitButton);
            this.panel1.Controls.Add(this.adminRoleButton);
            this.panel1.Controls.Add(this.paymentMethodButton);
            this.panel1.Controls.Add(this.employeeRoleButton);
            this.panel1.Controls.Add(this.saleDetailButton);
            this.panel1.Controls.Add(this.saleButton);
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.adminButton);
            this.panel1.Controls.Add(this.productTypeButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.roleLabel);
            this.panel1.Controls.Add(this.supplierButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 757);
            this.panel1.TabIndex = 5;
            // 
            // adminRoleButton
            // 
            this.adminRoleButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRoleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminRoleButton.Location = new System.Drawing.Point(17, 570);
            this.adminRoleButton.Name = "adminRoleButton";
            this.adminRoleButton.Size = new System.Drawing.Size(205, 43);
            this.adminRoleButton.TabIndex = 16;
            this.adminRoleButton.Text = "Admin Roles";
            this.adminRoleButton.UseVisualStyleBackColor = false;
            this.adminRoleButton.Click += new System.EventHandler(this.adminRoleButton_Click);
            // 
            // paymentMethodButton
            // 
            this.paymentMethodButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paymentMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentMethodButton.Location = new System.Drawing.Point(17, 423);
            this.paymentMethodButton.Name = "paymentMethodButton";
            this.paymentMethodButton.Size = new System.Drawing.Size(205, 43);
            this.paymentMethodButton.TabIndex = 15;
            this.paymentMethodButton.Text = "Payment Methods";
            this.paymentMethodButton.UseVisualStyleBackColor = false;
            this.paymentMethodButton.Click += new System.EventHandler(this.paymentMethodButton_Click);
            // 
            // employeeRoleButton
            // 
            this.employeeRoleButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.employeeRoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRoleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeRoleButton.Location = new System.Drawing.Point(17, 325);
            this.employeeRoleButton.Name = "employeeRoleButton";
            this.employeeRoleButton.Size = new System.Drawing.Size(205, 43);
            this.employeeRoleButton.TabIndex = 14;
            this.employeeRoleButton.Text = "Employee Roles";
            this.employeeRoleButton.UseVisualStyleBackColor = false;
            this.employeeRoleButton.Click += new System.EventHandler(this.employeeRoleButton_Click);
            // 
            // saleDetailButton
            // 
            this.saleDetailButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleDetailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDetailButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saleDetailButton.Location = new System.Drawing.Point(17, 521);
            this.saleDetailButton.Name = "saleDetailButton";
            this.saleDetailButton.Size = new System.Drawing.Size(205, 43);
            this.saleDetailButton.TabIndex = 13;
            this.saleDetailButton.Text = "SaleDetails";
            this.saleDetailButton.UseVisualStyleBackColor = false;
            this.saleDetailButton.Click += new System.EventHandler(this.saleDetailButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saleButton.Location = new System.Drawing.Point(17, 472);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(205, 43);
            this.saleButton.TabIndex = 12;
            this.saleButton.Text = "Sales";
            this.saleButton.UseVisualStyleBackColor = false;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeButton.Location = new System.Drawing.Point(17, 374);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(205, 43);
            this.employeeButton.TabIndex = 11;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerButton.Location = new System.Drawing.Point(17, 276);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(205, 43);
            this.customerButton.TabIndex = 10;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminButton.Location = new System.Drawing.Point(17, 619);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(205, 43);
            this.adminButton.TabIndex = 9;
            this.adminButton.Text = "Admins";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // productTypeButton
            // 
            this.productTypeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTypeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productTypeButton.Location = new System.Drawing.Point(17, 227);
            this.productTypeButton.Name = "productTypeButton";
            this.productTypeButton.Size = new System.Drawing.Size(205, 43);
            this.productTypeButton.TabIndex = 7;
            this.productTypeButton.Text = "Product Types";
            this.productTypeButton.UseVisualStyleBackColor = false;
            this.productTypeButton.Click += new System.EventHandler(this.productTypeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.Azure;
            this.roleLabel.Location = new System.Drawing.Point(119, 38);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(57, 20);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "<role>";
            // 
            // supplierButton
            // 
            this.supplierButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.supplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supplierButton.Location = new System.Drawing.Point(17, 129);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(205, 43);
            this.supplierButton.TabIndex = 4;
            this.supplierButton.Text = "Suppliers";
            this.supplierButton.UseVisualStyleBackColor = false;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // measureUnitButton
            // 
            this.measureUnitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.measureUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measureUnitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.measureUnitButton.Location = new System.Drawing.Point(17, 178);
            this.measureUnitButton.Name = "measureUnitButton";
            this.measureUnitButton.Size = new System.Drawing.Size(205, 43);
            this.measureUnitButton.TabIndex = 17;
            this.measureUnitButton.Text = "Measurement Units";
            this.measureUnitButton.UseVisualStyleBackColor = false;
            this.measureUnitButton.Click += new System.EventHandler(this.measureUnitButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 757);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel formContainer;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button saleDetailButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button productTypeButton;
        private System.Windows.Forms.Button employeeRoleButton;
        private System.Windows.Forms.Button adminRoleButton;
        private System.Windows.Forms.Button paymentMethodButton;
        private System.Windows.Forms.Button measureUnitButton;
    }
}

