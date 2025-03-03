using System.Windows.Forms;

namespace Minimart.UserControls
{
    partial class EmployeeControl
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
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.citizenIDText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateHiredPicker = new System.Windows.Forms.DateTimePicker();
            this.roleIDCombobox = new System.Windows.Forms.ComboBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birthdatePicker);
            this.groupBox1.Controls.Add(this.genderCombobox);
            this.groupBox1.Controls.Add(this.citizenIDText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateHiredPicker);
            this.groupBox1.Controls.Add(this.roleIDCombobox);
            this.groupBox1.Controls.Add(this.salaryNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.lastNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.firstNameText);
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
            // birthdatePicker
            // 
            this.birthdatePicker.CustomFormat = "dd/MM/yyyy";
            this.birthdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdatePicker.Location = new System.Drawing.Point(123, 313);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(188, 27);
            this.birthdatePicker.TabIndex = 45;
            this.birthdatePicker.TabStop = false;
            // 
            // genderCombobox
            // 
            this.genderCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary",
            "Prefer not to say"});
            this.genderCombobox.Location = new System.Drawing.Point(123, 279);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(188, 28);
            this.genderCombobox.TabIndex = 44;
            this.genderCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // citizenIDText
            // 
            this.citizenIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenIDText.Location = new System.Drawing.Point(123, 346);
            this.citizenIDText.Name = "citizenIDText";
            this.citizenIDText.Size = new System.Drawing.Size(188, 27);
            this.citizenIDText.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Citizen ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Birthdate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 38;
            this.label11.Text = "Gender";
            // 
            // dateHiredPicker
            // 
            this.dateHiredPicker.CustomFormat = "dd/MM/yyyy";
            this.dateHiredPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHiredPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHiredPicker.Location = new System.Drawing.Point(123, 430);
            this.dateHiredPicker.Name = "dateHiredPicker";
            this.dateHiredPicker.Size = new System.Drawing.Size(188, 27);
            this.dateHiredPicker.TabIndex = 37;
            this.dateHiredPicker.TabStop = false;
            // 
            // roleIDCombobox
            // 
            this.roleIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleIDCombobox.FormattingEnabled = true;
            this.roleIDCombobox.Location = new System.Drawing.Point(123, 463);
            this.roleIDCombobox.Name = "roleIDCombobox";
            this.roleIDCombobox.Size = new System.Drawing.Size(188, 28);
            this.roleIDCombobox.TabIndex = 36;
            this.roleIDCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.DecimalPlaces = 2;
            this.salaryNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryNumericUpDown.Location = new System.Drawing.Point(123, 497);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(188, 27);
            this.salaryNumericUpDown.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date hired";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 29;
            this.label8.Text = "Role ID";
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(123, 202);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(188, 27);
            this.phoneText.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(123, 169);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(188, 27);
            this.emailText.TabIndex = 26;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(123, 93);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(188, 27);
            this.lastNameText.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(123, 60);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(188, 27);
            this.firstNameText.TabIndex = 22;
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.HideSelection = false;
            this.idText.Location = new System.Drawing.Point(123, 27);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(188, 27);
            this.idText.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 19;
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
            this.gridHeaderLabel.Size = new System.Drawing.Size(232, 29);
            this.gridHeaderLabel.TabIndex = 0;
            this.gridHeaderLabel.Text = "Data of Employees";
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1276, 763);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.ComboBox roleIDCombobox;
        private System.Windows.Forms.DateTimePicker dateHiredPicker;
        private System.Windows.Forms.TextBox citizenIDText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.ComboBox genderCombobox;
    }
}
