
namespace CoreBancario
{
    partial class frmMostrarPagos
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
            this.label4 = new System.Windows.Forms.Label();
            this.datasetNBBackup = new CoreBancario.datasetNBBackup();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new CoreBancario.datasetNBBackupTableAdapters.PagoTableAdapter();
            this.noCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTransaccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noCuentaDataGridViewTextBoxColumn,
            this.entidadDataGridViewTextBoxColumn,
            this.iDTipoEntidadDataGridViewTextBoxColumn,
            this.iDTransaccionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 33);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ver Pagos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // datasetNBBackup
            // 
            this.datasetNBBackup.DataSetName = "datasetNBBackup";
            this.datasetNBBackup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "Pago";
            this.pagoBindingSource.DataSource = this.datasetNBBackup;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // noCuentaDataGridViewTextBoxColumn
            // 
            this.noCuentaDataGridViewTextBoxColumn.DataPropertyName = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.HeaderText = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.Name = "noCuentaDataGridViewTextBoxColumn";
            this.noCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entidadDataGridViewTextBoxColumn
            // 
            this.entidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad";
            this.entidadDataGridViewTextBoxColumn.HeaderText = "Entidad";
            this.entidadDataGridViewTextBoxColumn.Name = "entidadDataGridViewTextBoxColumn";
            this.entidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoEntidadDataGridViewTextBoxColumn
            // 
            this.iDTipoEntidadDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoEntidad";
            this.iDTipoEntidadDataGridViewTextBoxColumn.HeaderText = "ID_TipoEntidad";
            this.iDTipoEntidadDataGridViewTextBoxColumn.Name = "iDTipoEntidadDataGridViewTextBoxColumn";
            this.iDTipoEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTransaccionesDataGridViewTextBoxColumn
            // 
            this.iDTransaccionesDataGridViewTextBoxColumn.DataPropertyName = "ID_Transacciones";
            this.iDTransaccionesDataGridViewTextBoxColumn.HeaderText = "ID_Transacciones";
            this.iDTransaccionesDataGridViewTextBoxColumn.Name = "iDTransaccionesDataGridViewTextBoxColumn";
            this.iDTransaccionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMostrarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarPagos";
            this.Text = "frmMostrarPagos";
            this.Load += new System.EventHandler(this.frmMostrarPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private datasetNBBackup datasetNBBackup;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private datasetNBBackupTableAdapters.PagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoEntidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTransaccionesDataGridViewTextBoxColumn;
    }
}