namespace DATA_SETS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdBibliotecaDataSet = new DATA_SETS.bdBibliotecaDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codEjemplarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLibro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejemplaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejemplaresTableAdapter = new DATA_SETS.bdBibliotecaDataSetTableAdapters.ejemplaresTableAdapter();
            this.autoresTableAdapter = new DATA_SETS.bdBibliotecaDataSetTableAdapters.autoresTableAdapter();
            this.librosTableAdapter = new DATA_SETS.bdBibliotecaDataSetTableAdapters.librosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejemplares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAutorDataGridViewTextBoxColumn,
            this.nombreAutorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 224);
            this.dataGridView1.TabIndex = 4;
            // 
            // codAutorDataGridViewTextBoxColumn
            // 
            this.codAutorDataGridViewTextBoxColumn.DataPropertyName = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.HeaderText = "codAutor";
            this.codAutorDataGridViewTextBoxColumn.Name = "codAutorDataGridViewTextBoxColumn";
            // 
            // nombreAutorDataGridViewTextBoxColumn
            // 
            this.nombreAutorDataGridViewTextBoxColumn.DataPropertyName = "nombreAutor";
            this.nombreAutorDataGridViewTextBoxColumn.HeaderText = "nombreAutor";
            this.nombreAutorDataGridViewTextBoxColumn.Name = "nombreAutorDataGridViewTextBoxColumn";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "autores";
            this.autoresBindingSource.DataSource = this.bdBibliotecaDataSet;
            // 
            // bdBibliotecaDataSet
            // 
            this.bdBibliotecaDataSet.DataSetName = "bdBibliotecaDataSet";
            this.bdBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEjemplarDataGridViewTextBoxColumn,
            this.codLibroDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.tipoMonedaDataGridViewTextBoxColumn,
            this.nombreLibro});
            this.dataGridView2.DataSource = this.ejemplaresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(425, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(582, 224);
            this.dataGridView2.TabIndex = 5;
            // 
            // codEjemplarDataGridViewTextBoxColumn
            // 
            this.codEjemplarDataGridViewTextBoxColumn.DataPropertyName = "codEjemplar";
            this.codEjemplarDataGridViewTextBoxColumn.HeaderText = "codEjemplar";
            this.codEjemplarDataGridViewTextBoxColumn.Name = "codEjemplarDataGridViewTextBoxColumn";
            this.codEjemplarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codLibroDataGridViewTextBoxColumn
            // 
            this.codLibroDataGridViewTextBoxColumn.DataPropertyName = "codLibro";
            this.codLibroDataGridViewTextBoxColumn.HeaderText = "codLibro";
            this.codLibroDataGridViewTextBoxColumn.Name = "codLibroDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // tipoMonedaDataGridViewTextBoxColumn
            // 
            this.tipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "tipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.HeaderText = "tipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.Name = "tipoMonedaDataGridViewTextBoxColumn";
            // 
            // nombreLibro
            // 
            this.nombreLibro.DataPropertyName = "nombreLibro";
            this.nombreLibro.DataSource = this.librosBindingSource;
            this.nombreLibro.DisplayMember = "nombreLibro";
            this.nombreLibro.HeaderText = "nombreLibro";
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nombreLibro.ValueMember = "nombreLibro";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.bdBibliotecaDataSet;
            // 
            // ejemplaresBindingSource
            // 
            this.ejemplaresBindingSource.DataMember = "ejemplares";
            this.ejemplaresBindingSource.DataSource = this.bdBibliotecaDataSet;
            // 
            // ejemplaresTableAdapter
            // 
            this.ejemplaresTableAdapter.ClearBeforeFill = true;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdBibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private bdBibliotecaDataSet bdBibliotecaDataSet;
        private System.Windows.Forms.BindingSource ejemplaresBindingSource;
        private bdBibliotecaDataSetTableAdapters.ejemplaresTableAdapter ejemplaresTableAdapter;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private bdBibliotecaDataSetTableAdapters.autoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private bdBibliotecaDataSetTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEjemplarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nombreLibro;
        private System.Windows.Forms.Button button1;
    }
}

