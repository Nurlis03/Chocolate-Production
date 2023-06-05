namespace Chocolate_production_version2
{
    partial class buying__raw_materials
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rawmaterialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._PPO3_2_versionDataSet = new Chocolate_production_version2._PPO3_2_versionDataSet();
            this.rawmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.raw_materialTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Raw_materialTableAdapter();
            this.employeeTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseofrawmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_of_raw_materialsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Purchase_of_raw_materialsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseofrawmaterialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rawmaterialBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // rawmaterialBindingSource1
            // 
            this.rawmaterialBindingSource1.DataMember = "Raw_material";
            this.rawmaterialBindingSource1.DataSource = this._PPO3_2_versionDataSet;
            // 
            // _PPO3_2_versionDataSet
            // 
            this._PPO3_2_versionDataSet.DataSetName = "_PPO3_2_versionDataSet";
            this._PPO3_2_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawmaterialBindingSource
            // 
            this.rawmaterialBindingSource.DataMember = "Raw_material";
            this.rawmaterialBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.employeeBindingSource;
            this.comboBox2.DisplayMember = "Full_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(90, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox2, "The \"Cost amount\" field means the sum of the total amount of \"raw materials\"");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // raw_materialTableAdapter
            // 
            this.raw_materialTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cost amount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchaseofrawmaterialsBindingSource
            // 
            this.purchaseofrawmaterialsBindingSource.DataMember = "Purchase_of_raw_materials";
            this.purchaseofrawmaterialsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // purchase_of_raw_materialsTableAdapter
            // 
            this.purchase_of_raw_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raw material:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee:";
            // 
            // buying__raw_materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "buying__raw_materials";
            this.Text = "buying_raw_materials";
            this.Load += new System.EventHandler(this.buying__raw_materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseofrawmaterialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private _PPO3_2_versionDataSet _PPO3_2_versionDataSet;
        private System.Windows.Forms.BindingSource rawmaterialBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Raw_materialTableAdapter raw_materialTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource purchaseofrawmaterialsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Purchase_of_raw_materialsTableAdapter purchase_of_raw_materialsTableAdapter;
        private System.Windows.Forms.BindingSource rawmaterialBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}