namespace Chocolate_production_version2
{
    partial class Sale_product
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getEmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PPO3_2_versionDataSet = new Chocolate_production_version2._PPO3_2_versionDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.finished_productsComboBox = new System.Windows.Forms.ComboBox();
            this.finishedproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.employeeTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter();
            this.finished_productsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.getEmployeesComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.finished_productsComboBox);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 162);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Смена:";
            // 
            // getEmployeesComboBox
            // 
            this.getEmployeesComboBox.DataSource = this.employeeBindingSource;
            this.getEmployeesComboBox.DisplayMember = "Full_name";
            this.getEmployeesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getEmployeesComboBox.FormattingEnabled = true;
            this.getEmployeesComboBox.Location = new System.Drawing.Point(80, 46);
            this.getEmployeesComboBox.Name = "getEmployeesComboBox";
            this.getEmployeesComboBox.Size = new System.Drawing.Size(119, 21);
            this.getEmployeesComboBox.TabIndex = 45;
            this.getEmployeesComboBox.ValueMember = "ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // _PPO3_2_versionDataSet
            // 
            this._PPO3_2_versionDataSet.DataSetName = "_PPO3_2_versionDataSet";
            this._PPO3_2_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Продукт:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Продать продукцию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // finished_productsComboBox
            // 
            this.finished_productsComboBox.DataSource = this.finishedproductsBindingSource;
            this.finished_productsComboBox.DisplayMember = "Name";
            this.finished_productsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.finished_productsComboBox.FormattingEnabled = true;
            this.finished_productsComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.finished_productsComboBox.Location = new System.Drawing.Point(81, 19);
            this.finished_productsComboBox.Name = "finished_productsComboBox";
            this.finished_productsComboBox.Size = new System.Drawing.Size(118, 21);
            this.finished_productsComboBox.TabIndex = 43;
            this.finished_productsComboBox.ValueMember = "ID";
            // 
            // finishedproductsBindingSource
            // 
            this.finishedproductsBindingSource.DataMember = "Finished_products";
            this.finishedproductsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(143, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // finished_productsTableAdapter
            // 
            this.finished_productsTableAdapter.ClearBeforeFill = true;
            // 
            // SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaleProduct";
            this.Text = "SaleProduct";
            this.Load += new System.EventHandler(this.SaleProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox getEmployeesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox finished_productsComboBox;
        private _PPO3_2_versionDataSet _PPO3_2_versionDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource finishedproductsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter finished_productsTableAdapter;
    }
}