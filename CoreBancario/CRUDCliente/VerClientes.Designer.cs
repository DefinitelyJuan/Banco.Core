
namespace CoreBancario
{
    partial class VerClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProvinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresosMensualesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetNB = new CoreBancario.datasetNB();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new CoreBancario.datasetNBTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.cedulaClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.direccionClienteDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.iDProvinciaDataGridViewTextBoxColumn,
            this.iDMunicipioDataGridViewTextBoxColumn,
            this.iDSectorDataGridViewTextBoxColumn,
            this.ingresosMensualesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaClienteDataGridViewTextBoxColumn
            // 
            this.cedulaClienteDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.HeaderText = "Cedula_Cliente";
            this.cedulaClienteDataGridViewTextBoxColumn.Name = "cedulaClienteDataGridViewTextBoxColumn";
            this.cedulaClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre_Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionClienteDataGridViewTextBoxColumn
            // 
            this.direccionClienteDataGridViewTextBoxColumn.DataPropertyName = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.HeaderText = "Direccion_Cliente";
            this.direccionClienteDataGridViewTextBoxColumn.Name = "direccionClienteDataGridViewTextBoxColumn";
            this.direccionClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDProvinciaDataGridViewTextBoxColumn
            // 
            this.iDProvinciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Provincia";
            this.iDProvinciaDataGridViewTextBoxColumn.HeaderText = "ID_Provincia";
            this.iDProvinciaDataGridViewTextBoxColumn.Name = "iDProvinciaDataGridViewTextBoxColumn";
            this.iDProvinciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDMunicipioDataGridViewTextBoxColumn
            // 
            this.iDMunicipioDataGridViewTextBoxColumn.DataPropertyName = "ID_Municipio";
            this.iDMunicipioDataGridViewTextBoxColumn.HeaderText = "ID_Municipio";
            this.iDMunicipioDataGridViewTextBoxColumn.Name = "iDMunicipioDataGridViewTextBoxColumn";
            this.iDMunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSectorDataGridViewTextBoxColumn
            // 
            this.iDSectorDataGridViewTextBoxColumn.DataPropertyName = "ID_Sector";
            this.iDSectorDataGridViewTextBoxColumn.HeaderText = "ID_Sector";
            this.iDSectorDataGridViewTextBoxColumn.Name = "iDSectorDataGridViewTextBoxColumn";
            this.iDSectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresosMensualesDataGridViewTextBoxColumn
            // 
            this.ingresosMensualesDataGridViewTextBoxColumn.DataPropertyName = "IngresosMensuales";
            this.ingresosMensualesDataGridViewTextBoxColumn.HeaderText = "IngresosMensuales";
            this.ingresosMensualesDataGridViewTextBoxColumn.Name = "ingresosMensualesDataGridViewTextBoxColumn";
            this.ingresosMensualesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.datasetNB;
            // 
            // datasetNB
            // 
            this.datasetNB.DataSetName = "datasetNB";
            this.datasetNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 33);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ver Clientes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerClientes";
            this.Text = "VerClientes";
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private datasetNBTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProvinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresosMensualesDataGridViewTextBoxColumn;
    }
}