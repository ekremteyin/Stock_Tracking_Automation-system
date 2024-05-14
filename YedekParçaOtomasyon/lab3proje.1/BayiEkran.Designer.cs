namespace lab3proje._1
{
    partial class BayiEkran
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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipDataSet21 = new lab3proje._1.StokTakipDataSet2();
            this.carsTableAdapter1 = new lab3proje._1.StokTakipDataSet2TableAdapters.CarsTableAdapter();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPartsCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new lab3proje._1.StokTakipDataSet2TableAdapters.PartsTableAdapter();
            this.fKPartsCarsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPartsCarsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.bindingSource1;
            this.comboBox5.DisplayMember = "Brand";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(186, 78);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cars";
            this.bindingSource1.DataSource = this.stokTakipDataSet21;
            // 
            // stokTakipDataSet21
            // 
            this.stokTakipDataSet21.DataSetName = "StokTakipDataSet2";
            this.stokTakipDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.bindingSource2;
            this.comboBox6.DisplayMember = "Model";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(186, 125);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 24);
            this.comboBox6.TabIndex = 2;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Cars";
            this.bindingSource2.DataSource = this.stokTakipDataSet21;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.bindingSource3;
            this.comboBox7.DisplayMember = "Hardware";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(186, 171);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 24);
            this.comboBox7.TabIndex = 3;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Cars";
            this.bindingSource3.DataSource = this.stokTakipDataSet21;
            // 
            // fKPartsCarsBindingSource
            // 
            this.fKPartsCarsBindingSource.DataMember = "FK_Parts_Cars";
            this.fKPartsCarsBindingSource.DataSource = this.bindingSource2;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // fKPartsCarsBindingSource1
            // 
            this.fKPartsCarsBindingSource1.DataMember = "FK_Parts_Cars";
            this.fKPartsCarsBindingSource1.DataSource = this.bindingSource1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Packet";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.carIdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKPartsCarsBindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(345, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(556, 298);
            this.dataGridView3.TabIndex = 5;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "PartId";
            this.partIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKPartsCarsBindingSource2
            // 
            this.fKPartsCarsBindingSource2.DataMember = "FK_Parts_Cars";
            this.fKPartsCarsBindingSource2.DataSource = this.bindingSource1;
            // 
            // BayiEkran
            // 
            this.ClientSize = new System.Drawing.Size(1111, 473);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Name = "BayiEkran";
            this.Load += new System.EventHandler(this.BayiEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartsCarsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMarkalar;
        private System.Windows.Forms.ComboBox comboBoxModeller;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private StokTakipDataSet2 stokTakipDataSet2;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private StokTakipDataSet2TableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private StokTakipDataSet2 stokTakipDataSet21;
        private System.Windows.Forms.BindingSource bindingSource1;
        private StokTakipDataSet2TableAdapters.CarsTableAdapter carsTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.BindingSource fKPartsCarsBindingSource;
        private StokTakipDataSet2TableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource fKPartsCarsBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKPartsCarsBindingSource2;
    }
}