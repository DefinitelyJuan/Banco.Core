
namespace CoreBancario
{
    partial class frmMostrarTransacciones
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datasetNB = new CoreBancario.datasetNB();
            this.transaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionesTableAdapter = new CoreBancario.datasetNBTableAdapters.TransaccionesTableAdapter();
            this.iDTransaccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbCrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 33);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ver Transacciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTransaccionesDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.iDTipoTransaccionDataGridViewTextBoxColumn,
            this.dbCrDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.noCuentaDataGridViewTextBoxColumn,
            this.fechaTransaccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaccionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 362);
            this.dataGridView1.TabIndex = 48;
            // 
            // datasetNB
            // 
            this.datasetNB.DataSetName = "datasetNB";
            this.datasetNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionesBindingSource
            // 
            this.transaccionesBindingSource.DataMember = "Transacciones";
            this.transaccionesBindingSource.DataSource = this.datasetNB;
            // 
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // iDTransaccionesDataGridViewTextBoxColumn
            // 
            this.iDTransaccionesDataGridViewTextBoxColumn.DataPropertyName = "ID_Transacciones";
            this.iDTransaccionesDataGridViewTextBoxColumn.HeaderText = "ID_Transacciones";
            this.iDTransaccionesDataGridViewTextBoxColumn.Name = "iDTransaccionesDataGridViewTextBoxColumn";
            this.iDTransaccionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // iDTipoTransaccionDataGridViewTextBoxColumn
            // 
            this.iDTipoTransaccionDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoTransaccion";
            this.iDTipoTransaccionDataGridViewTextBoxColumn.HeaderText = "ID_TipoTransaccion";
            this.iDTipoTransaccionDataGridViewTextBoxColumn.Name = "iDTipoTransaccionDataGridViewTextBoxColumn";
            // 
            // dbCrDataGridViewTextBoxColumn
            // 
            this.dbCrDataGridViewTextBoxColumn.DataPropertyName = "DbCr";
            this.dbCrDataGridViewTextBoxColumn.HeaderText = "DbCr";
            this.dbCrDataGridViewTextBoxColumn.Name = "dbCrDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // noCuentaDataGridViewTextBoxColumn
            // 
            this.noCuentaDataGridViewTextBoxColumn.DataPropertyName = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.HeaderText = "NoCuenta";
            this.noCuentaDataGridViewTextBoxColumn.Name = "noCuentaDataGridViewTextBoxColumn";
            // 
            // fechaTransaccionDataGridViewTextBoxColumn
            // 
            this.fechaTransaccionDataGridViewTextBoxColumn.DataPropertyName = "FechaTransaccion";
            this.fechaTransaccionDataGridViewTextBoxColumn.HeaderText = "FechaTransaccion";
            this.fechaTransaccionDataGridViewTextBoxColumn.Name = "fechaTransaccionDataGridViewTextBoxColumn";
            // 
            // frmMostrarTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "frmMostrarTransacciones";
            this.Text = "frmMostrarTransacciones";
            this.Load += new System.EventHandler(this.frmMostrarTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private datasetNBTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTransaccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbCrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaTransaccionDataGridViewTextBoxColumn;
    }
}