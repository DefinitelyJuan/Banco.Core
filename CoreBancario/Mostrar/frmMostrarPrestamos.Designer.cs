
namespace CoreBancario
{
    partial class frmMostrarPrestamos
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
            this.datasetNB = new CoreBancario.datasetNB();
            this.datasetNBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetNBBackup = new CoreBancario.datasetNBBackup();
            this.datasetNBBackupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter = new CoreBancario.datasetNBBackupTableAdapters.PrestamoTableAdapter();
            this.iDPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPlazoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPrestamoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.montoPlazoMaxDataGridViewTextBoxColumn,
            this.iDTipoPrestamoDataGridViewTextBoxColumn,
            this.noCuentaDataGridViewTextBoxColumn,
            this.tasaDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // datasetNB
            // 
            this.datasetNB.DataSetName = "datasetNB";
            this.datasetNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasetNBBindingSource
            // 
            this.datasetNBBindingSource.DataSource = this.datasetNB;
            this.datasetNBBindingSource.Position = 0;
            // 
            // datasetNBBackup
            // 
            this.datasetNBBackup.DataSetName = "datasetNBBackup";
            this.datasetNBBackup.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasetNBBackupBindingSource
            // 
            this.datasetNBBackupBindingSource.DataSource = this.datasetNBBackup;
            this.datasetNBBackupBindingSource.Position = 0;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.datasetNBBackupBindingSource;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // iDPrestamoDataGridViewTextBoxColumn
            // 
            this.iDPrestamoDataGridViewTextBoxColumn.DataPropertyName = "ID_Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.HeaderText = "ID_Prestamo";
            this.iDPrestamoDataGridViewTextBoxColumn.Name = "iDPrestamoDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // montoPlazoMaxDataGridViewTextBoxColumn
            // 
            this.montoPlazoMaxDataGridViewTextBoxColumn.DataPropertyName = "MontoPlazoMax";
            this.montoPlazoMaxDataGridViewTextBoxColumn.HeaderText = "MontoPlazoMax";
            this.montoPlazoMaxDataGridViewTextBoxColumn.Name = "montoPlazoMaxDataGridViewTextBoxColumn";
            // 
            // iDTipoPrestamoDataGridViewTextBoxColumn
            // 
            this.iDTipoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoPrestamo";
            this.iDTipoPrestamoDataGridViewTextBoxColumn.HeaderText = "ID_TipoPrestamo";
            this.iDTipoPrestamoDataGridViewTextBoxColumn.Name = "iDTipoPrestamoDataGridViewTextBoxColumn";
            // 
            // noCuentaDataGridViewTextBoxColumn
            // 
            this.noCuentaDataGridViewTextBoxColumn.DataPropertyName = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.HeaderText = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.Name = "noCuentaDataGridViewTextBoxColumn";
            // 
            // tasaDataGridViewTextBoxColumn
            // 
            this.tasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa";
            this.tasaDataGridViewTextBoxColumn.HeaderText = "Tasa";
            this.tasaDataGridViewTextBoxColumn.Name = "tasaDataGridViewTextBoxColumn";
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 33);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ver Prestamos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMostrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarPrestamos";
            this.Text = "frmMostrarPrestamos";
            this.Load += new System.EventHandler(this.frmMostrarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBackupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource datasetNBBindingSource;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource datasetNBBackupBindingSource;
        private datasetNBBackup datasetNBBackup;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private datasetNBBackupTableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPlazoMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}