
namespace CoreBancario
{
    partial class frmMostrarCuentas
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
            this.noCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetNB = new CoreBancario.datasetNB();
            this.label4 = new System.Windows.Forms.Label();
            this.noCuentaTableAdapter = new CoreBancario.datasetNBTableAdapters.NoCuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noCuentaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.iDTipoCuentaDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noCuentaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // noCuentaDataGridViewTextBoxColumn
            // 
            this.noCuentaDataGridViewTextBoxColumn.DataPropertyName = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.HeaderText = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.Name = "noCuentaDataGridViewTextBoxColumn";
            this.noCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoCuentaDataGridViewTextBoxColumn
            // 
            this.iDTipoCuentaDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoCuenta";
            this.iDTipoCuentaDataGridViewTextBoxColumn.HeaderText = "ID_TipoCuenta";
            this.iDTipoCuentaDataGridViewTextBoxColumn.Name = "iDTipoCuentaDataGridViewTextBoxColumn";
            this.iDTipoCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaUltimaActualizacionDataGridViewTextBoxColumn
            // 
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimaActualizacion";
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn.HeaderText = "FechaUltimaActualizacion";
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn.Name = "fechaUltimaActualizacionDataGridViewTextBoxColumn";
            this.fechaUltimaActualizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noCuentaBindingSource
            // 
            this.noCuentaBindingSource.DataMember = "NoCuenta";
            this.noCuentaBindingSource.DataSource = this.datasetNB;
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
            this.label4.Location = new System.Drawing.Point(306, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 33);
            this.label4.TabIndex = 96;
            this.label4.Text = "Update Cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noCuentaTableAdapter
            // 
            this.noCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarCuentas";
            this.Text = "frmMostrarCuentas";
            this.Load += new System.EventHandler(this.frmMostrarCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource noCuentaBindingSource;
        private datasetNBTableAdapters.NoCuentaTableAdapter noCuentaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaUltimaActualizacionDataGridViewTextBoxColumn;
    }
}