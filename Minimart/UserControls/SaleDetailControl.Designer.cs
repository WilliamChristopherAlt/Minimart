using System.Windows.Forms;

namespace Minimart.UserControls
{
    partial class SaleDetailControl
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
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productTypeIDCombobox = new System.Windows.Forms.ComboBox();
            this.saleIDCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantityNumericUpDown);
            this.groupBox1.Controls.Add(this.productTypeIDCombobox);
            this.groupBox1.Controls.Add(this.saleIDCombobox);
            this.groupBox1.Controls.Add(this.label4);
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
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DecimalPlaces = 2;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(163, 134);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(148, 27);
            this.quantityNumericUpDown.TabIndex = 34;
            // 
            // productTypeIDCombobox
            // 
            this.productTypeIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTypeIDCombobox.FormattingEnabled = true;
            this.productTypeIDCombobox.Location = new System.Drawing.Point(163, 96);
            this.productTypeIDCombobox.Name = "productTypeIDCombobox";
            this.productTypeIDCombobox.Size = new System.Drawing.Size(148, 28);
            this.productTypeIDCombobox.TabIndex = 33;
            this.productTypeIDCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // saleIDCombobox
            // 
            this.saleIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleIDCombobox.FormattingEnabled = true;
            this.saleIDCombobox.Location = new System.Drawing.Point(163, 62);
            this.saleIDCombobox.Name = "saleIDCombobox";
            this.saleIDCombobox.Size = new System.Drawing.Size(148, 28);
            this.saleIDCombobox.TabIndex = 32;
            this.saleIDCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.HideSelection = false;
            this.idText.Location = new System.Drawing.Point(163, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(148, 27);
            this.idText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Type ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sale ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
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
            this.gridHeaderLabel.Size = new System.Drawing.Size(243, 29);
            this.gridHeaderLabel.TabIndex = 0;
            this.gridHeaderLabel.Text = "Data of Sale Details";
            // 
            // SaleDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleDetailControl";
            this.Size = new System.Drawing.Size(1276, 763);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productTypeIDCombobox;
        private System.Windows.Forms.ComboBox saleIDCombobox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}
