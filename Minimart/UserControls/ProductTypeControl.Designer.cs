using System.Windows.Forms;

namespace Minimart.UserControls
{
    partial class ProductTypeControl
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
            this.activeCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.measureUnitIDComboBox = new System.Windows.Forms.ComboBox();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.dateAddedPicker = new System.Windows.Forms.DateTimePicker();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activeCheckbox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.measureUnitIDComboBox);
            this.groupBox1.Controls.Add(this.supplierIDComboBox);
            this.groupBox1.Controls.Add(this.categoryIDComboBox);
            this.groupBox1.Controls.Add(this.dateAddedPicker);
            this.groupBox1.Controls.Add(this.stockNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.priceNumericUpDown);
            this.groupBox1.Controls.Add(this.descText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.label3);
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
            // activeCheckbox
            // 
            this.activeCheckbox.AutoSize = true;
            this.activeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckbox.Location = new System.Drawing.Point(128, 487);
            this.activeCheckbox.Name = "activeCheckbox";
            this.activeCheckbox.Size = new System.Drawing.Size(18, 17);
            this.activeCheckbox.TabIndex = 35;
            this.activeCheckbox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "Is Active";
            // 
            // measureUnitIDComboBox
            // 
            this.measureUnitIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measureUnitIDComboBox.FormattingEnabled = true;
            this.measureUnitIDComboBox.Location = new System.Drawing.Point(163, 381);
            this.measureUnitIDComboBox.Name = "measureUnitIDComboBox";
            this.measureUnitIDComboBox.Size = new System.Drawing.Size(148, 28);
            this.measureUnitIDComboBox.TabIndex = 32;
            this.measureUnitIDComboBox.SelectedIndexChanged += new System.EventHandler(this.measureUnitIDComboBox_SelectedIndexChanged);
            this.measureUnitIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(128, 131);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(183, 28);
            this.supplierIDComboBox.TabIndex = 31;
            this.supplierIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(128, 97);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(183, 28);
            this.categoryIDComboBox.TabIndex = 30;
            this.categoryIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // dateAddedPicker
            // 
            this.dateAddedPicker.CustomFormat = "dd/MM/yyyy";
            this.dateAddedPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAddedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAddedPicker.Location = new System.Drawing.Point(128, 448);
            this.dateAddedPicker.Name = "dateAddedPicker";
            this.dateAddedPicker.Size = new System.Drawing.Size(183, 27);
            this.dateAddedPicker.TabIndex = 29;
            this.dateAddedPicker.TabStop = false;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DecimalPlaces = 2;
            this.stockNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNumericUpDown.Location = new System.Drawing.Point(163, 348);
            this.stockNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(148, 27);
            this.stockNumericUpDown.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Date Added";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Measurement ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stock left";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(163, 315);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(148, 27);
            this.priceNumericUpDown.TabIndex = 19;
            // 
            // descText
            // 
            this.descText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descText.Location = new System.Drawing.Point(128, 165);
            this.descText.Multiline = true;
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(183, 87);
            this.descText.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Supplier ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category ID";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(128, 62);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(183, 27);
            this.nameText.TabIndex = 8;
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.HideSelection = false;
            this.idText.Location = new System.Drawing.Point(128, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(183, 27);
            this.idText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 22);
            this.label1.TabIndex = 4;
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
            this.gridHeaderLabel.Size = new System.Drawing.Size(271, 29);
            this.gridHeaderLabel.TabIndex = 0;
            this.gridHeaderLabel.Text = "Data of Product Types";
            // 
            // ProductTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductTypeControl";
            this.Size = new System.Drawing.Size(1276, 763);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateAddedPicker;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.ComboBox measureUnitIDComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox activeCheckbox;
    }
}
