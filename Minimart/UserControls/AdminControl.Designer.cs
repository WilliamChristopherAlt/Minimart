using System.Windows.Forms;

namespace Minimart.UserControls
{
    partial class AdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastLoginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCreatedPicker = new System.Windows.Forms.DateTimePicker();
            this.activeCheckbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adminRoleIDCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeIDCombobox = new System.Windows.Forms.ComboBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.gridHeaderLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lastLoginDatePicker);
            this.groupBox1.Controls.Add(this.dateCreatedPicker);
            this.groupBox1.Controls.Add(this.activeCheckbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.adminRoleIDCombobox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.employeeIDCombobox);
            this.groupBox1.Controls.Add(this.usernameText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 731);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(134, 335);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(182, 27);
            this.passwordText.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Password";
            // 
            // lastLoginDatePicker
            // 
            this.lastLoginDatePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.lastLoginDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLoginDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastLoginDatePicker.Location = new System.Drawing.Point(115, 241);
            this.lastLoginDatePicker.Name = "lastLoginDatePicker";
            this.lastLoginDatePicker.Size = new System.Drawing.Size(196, 27);
            this.lastLoginDatePicker.TabIndex = 47;
            this.lastLoginDatePicker.TabStop = false;
            // 
            // dateCreatedPicker
            // 
            this.dateCreatedPicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateCreatedPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCreatedPicker.Location = new System.Drawing.Point(115, 208);
            this.dateCreatedPicker.Name = "dateCreatedPicker";
            this.dateCreatedPicker.Size = new System.Drawing.Size(196, 27);
            this.dateCreatedPicker.TabIndex = 46;
            this.dateCreatedPicker.TabStop = false;
            // 
            // activeCheckbox
            // 
            this.activeCheckbox.AutoSize = true;
            this.activeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckbox.Location = new System.Drawing.Point(115, 276);
            this.activeCheckbox.Name = "activeCheckbox";
            this.activeCheckbox.Size = new System.Drawing.Size(18, 17);
            this.activeCheckbox.TabIndex = 40;
            this.activeCheckbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "Is Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Last Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Created";
            // 
            // adminRoleIDCombobox
            // 
            this.adminRoleIDCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adminRoleIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRoleIDCombobox.FormattingEnabled = true;
            this.adminRoleIDCombobox.Location = new System.Drawing.Point(134, 122);
            this.adminRoleIDCombobox.Name = "adminRoleIDCombobox";
            this.adminRoleIDCombobox.Size = new System.Drawing.Size(177, 28);
            this.adminRoleIDCombobox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Role ID";
            // 
            // employeeIDCombobox
            // 
            this.employeeIDCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDCombobox.FormattingEnabled = true;
            this.employeeIDCombobox.Location = new System.Drawing.Point(134, 88);
            this.employeeIDCombobox.Name = "employeeIDCombobox";
            this.employeeIDCombobox.Size = new System.Drawing.Size(177, 28);
            this.employeeIDCombobox.TabIndex = 31;
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(134, 55);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(177, 27);
            this.usernameText.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.HideSelection = false;
            this.idText.Location = new System.Drawing.Point(134, 22);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(177, 27);
            this.idText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(163, 645);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 48);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DimGray;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(58, 645);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 48);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DimGray;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(163, 591);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 48);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DimGray;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(58, 591);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagrid);
            this.groupBox2.Controls.Add(this.gridHeaderLabel);
            this.groupBox2.Location = new System.Drawing.Point(365, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 731);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(23, 67);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(852, 643);
            this.datagrid.TabIndex = 1;
            this.datagrid.SelectionChanged += new System.EventHandler(this.datagrid_SelectionChanged);
            // 
            // gridHeaderLabel
            // 
            this.gridHeaderLabel.AutoSize = true;
            this.gridHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHeaderLabel.Location = new System.Drawing.Point(18, 27);
            this.gridHeaderLabel.Name = "gridHeaderLabel";
            this.gridHeaderLabel.Size = new System.Drawing.Size(188, 29);
            this.gridHeaderLabel.TabIndex = 0;
            this.gridHeaderLabel.Text = "Data of Admins";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(1276, 763);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label gridHeaderLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox adminRoleIDCombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox employeeIDCombobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox activeCheckbox;
        private System.Windows.Forms.DateTimePicker dateCreatedPicker;
        private System.Windows.Forms.DateTimePicker lastLoginDatePicker;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label5;
    }
}
