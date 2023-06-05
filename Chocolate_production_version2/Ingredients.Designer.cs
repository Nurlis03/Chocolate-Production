namespace Chocolate_production_version2
{
    partial class Ingredients
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this._PPO3_2_versionDataSet = new Chocolate_production_version2._PPO3_2_versionDataSet();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.IngredientsTableAdapter();
            this.tableAdapterManager = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.TableAdapterManager();
            this.findIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findIngredientsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.FindIngredientsTableAdapter();
            this.finishedproductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finishedproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finished_productsTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.ProductionTableAdapter();
            this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finishedproductsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.rawmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PPO3_2_versionDataSet1 = new Chocolate_production_version2._PPO3_2_versionDataSet();
            this.raw_materialTableAdapter = new Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.Raw_materialTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 170);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Raw material:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 12;
            label1.Text = "Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 197);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 13;
            label2.Text = "Amount:";
            // 
            // _PPO3_2_versionDataSet
            // 
            this._PPO3_2_versionDataSet.DataSetName = "_PPO3_2_versionDataSet";
            this._PPO3_2_versionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Finished_productsTableAdapter = null;
            this.tableAdapterManager.IngredientsTableAdapter = this.ingredientsTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.ProductionTableAdapter = null;
            this.tableAdapterManager.Purchase_of_raw_materialsTableAdapter = null;
            this.tableAdapterManager.Raw_materialTableAdapter = null;
            this.tableAdapterManager.Sale_of_productsTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chocolate_production_version2._PPO3_2_versionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // findIngredientsBindingSource
            // 
            this.findIngredientsBindingSource.DataMember = "FindIngredients";
            this.findIngredientsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // findIngredientsTableAdapter
            // 
            this.findIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // finishedproductsBindingSource1
            // 
            this.finishedproductsBindingSource1.DataMember = "Finished_products";
            this.finishedproductsBindingSource1.DataSource = this._PPO3_2_versionDataSet;
            // 
            // finishedproductsBindingSource
            // 
            this.finishedproductsBindingSource.DataMember = "Finished_products";
            this.finishedproductsBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // finished_productsTableAdapter
            // 
            this.finished_productsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.finishedproductsBindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this._PPO3_2_versionDataSet;
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsBindingSource1
            // 
            this.ingredientsBindingSource1.DataMember = "Ingredients";
            this.ingredientsBindingSource1.DataSource = this._PPO3_2_versionDataSet;
            // 
            // finishedproductsBindingSource2
            // 
            this.finishedproductsBindingSource2.DataMember = "Finished_products";
            this.finishedproductsBindingSource2.DataSource = this._PPO3_2_versionDataSet;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.AllowUserToDeleteRows = false;
            this.ingredientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(264, 37);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.ReadOnly = true;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(313, 220);
            this.ingredientsDataGridView.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(173, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataSource = this.rawmaterialBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(92, 167);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 11;
            this.nameComboBox.ValueMember = "ID";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            this.nameComboBox.SelectionChangeCommitted += new System.EventHandler(this.nameComboBox_SelectionChangeCommitted);
            // 
            // rawmaterialBindingSource
            // 
            this.rawmaterialBindingSource.DataMember = "Raw_material";
            this.rawmaterialBindingSource.DataSource = this._PPO3_2_versionDataSet1;
            // 
            // _PPO3_2_versionDataSet1
            // 
            this._PPO3_2_versionDataSet1.DataSetName = "_PPO3_2_versionDataSet";
            this._PPO3_2_versionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raw_materialTableAdapter
            // 
            this.raw_materialTableAdapter.ClearBeforeFill = true;
            // 
            // Ingredients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(604, 283);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ingredientsDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ingredients";
            this.Text = "Ingredients";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedproductsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPO3_2_versionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _PPO3_2_versionDataSet _PPO3_2_versionDataSet;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.IngredientsTableAdapter ingredientsTableAdapter;
        private _PPO3_2_versionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource findIngredientsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.FindIngredientsTableAdapter findIngredientsTableAdapter;
        private System.Windows.Forms.BindingSource finishedproductsBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Finished_productsTableAdapter finished_productsTableAdapter;
        private System.Windows.Forms.BindingSource finishedproductsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.ProductionTableAdapter productionTableAdapter;
        private System.Windows.Forms.BindingSource finishedproductsBindingSource2;
        private System.Windows.Forms.BindingSource ingredientsBindingSource1;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox nameComboBox;
        private _PPO3_2_versionDataSet _PPO3_2_versionDataSet1;
        private System.Windows.Forms.BindingSource rawmaterialBindingSource;
        private _PPO3_2_versionDataSetTableAdapters.Raw_materialTableAdapter raw_materialTableAdapter;
    }
}