namespace Chocolate_production_version2
{
    partial class ProduceProduct
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
            this.components = new System.ComponentModel.Container();
            this.finished_productsComboBox = new System.Windows.Forms.ComboBox();
            this.finishedproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PPO3_2_versionDataSet = new Chocolate_production_version2._PPO3_2_versionDataSet();
            this.getEmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finished_productsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter();
            this.employeeTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // finished_productsComboBox
            // 
            this.finished_productsComboBox.DataSource = this.finishedproductsBindingSource;
            this.finished_productsComboBox.DisplayMember = "Name";
            this.finished_productsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finished_productsComboBox.FormattingEnabled = true;
            this.finished_productsComboBox.Location = new System.Drawing.Point(82, 15);
            this.finished_productsComboBox.Name = "finished_productsComboBox";
            this.finished_productsComboBox.Size = new System.Drawing.Size(183, 21);
            this.finished_productsComboBox.TabIndex = 0;
            this.finished_productsComboBox.ValueMember = "ID";
            // 
            // finishedproductsBindingSource
            // 
            this.finishedproductsBindingSource.DataMember = "Finished_products";
            this.finishedproductsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // _PPO3_2_versionDataSet
            // 
            this._PPO3_2_versionDataSet.DataSetName = "_PPO3_2_versionDataSet";
            this._PPO3_2_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeesComboBox
            // 
            this.getEmployeesComboBox.DataSource = this.employeeBindingSource;
            this.getEmployeesComboBox.DisplayMember = "Full_name";
            this.getEmployeesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getEmployeesComboBox.FormattingEnabled = true;
            this.getEmployeesComboBox.Location = new System.Drawing.Point(82, 42);
            this.getEmployeesComboBox.Name = "getEmployeesComboBox";
            this.getEmployeesComboBox.Size = new System.Drawing.Size(183, 21);
            this.getEmployeesComboBox.TabIndex = 1;
            this.getEmployeesComboBox.ValueMember = "ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee";
            // 
            // finished_productsTableAdapter
            // 
            this.finished_productsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRODUCE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // ProduceProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getEmployeesComboBox);
            this.Controls.Add(this.finished_productsComboBox);
            this.Name = "ProduceProduct";
            this.Text = "ProduceProduct";
            this.Load += new System.EventHandler(this.ProduceProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox finished_productsComboBox;
        private System.Windows.Forms.ComboBox getEmployeesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private _PPO3_2_versionDataSet _PPO3_2_versionDataSet;
        private System.Windows.Forms.BindingSource finishedproductsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter finished_productsTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}