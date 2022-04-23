
namespace CoreBancario
{
    partial class frmMostrarTipoTransacciones
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
            this.datasetNB = new CoreBancario.datasetNB();
            this.datasetNBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTransaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTransaccionesTableAdapter = new CoreBancario.datasetNBTableAdapters.TipoTransaccionesTableAdapter();
            this.iDTipoTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTipoTransaccionDataGridViewTextBoxColumn,
            this.codigoTransaccionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipoTransaccionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 33);
            this.label4.TabIndex = 110;
            this.label4.Text = "Mostrar TipoTransaccion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tipoTransaccionesBindingSource
            // 
            this.tipoTransaccionesBindingSource.DataMember = "TipoTransacciones";
            this.tipoTransaccionesBindingSource.DataSource = this.datasetNBBindingSource;
            // 
            // tipoTransaccionesTableAdapter
            // 
            this.tipoTransaccionesTableAdapter.ClearBeforeFill = true;
            // 
            // iDTipoTransaccionDataGridViewTextBoxColumn
            // 
            this.iDTipoTransaccionDataGridViewTextBoxColumn.DataPropertyName = "ID_TipoTransaccion";
            this.iDTipoTransaccionDataGridViewTextBoxColumn.HeaderText = "ID_TipoTransaccion";
            this.iDTipoTransaccionDataGridViewTextBoxColumn.Name = "iDTipoTransaccionDataGridViewTextBoxColumn";
            this.iDTipoTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoTransaccionDataGridViewTextBoxColumn
            // 
            this.codigoTransaccionDataGridViewTextBoxColumn.DataPropertyName = "CodigoTransaccion";
            this.codigoTransaccionDataGridViewTextBoxColumn.HeaderText = "CodigoTransaccion";
            this.codigoTransaccionDataGridViewTextBoxColumn.Name = "codigoTransaccionDataGridViewTextBoxColumn";
            this.codigoTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMostrarTipoTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarTipoTransacciones";
            this.Text = "frmMostrarTipoTransacciones";
            this.Load += new System.EventHandler(this.frmMostrarTipoTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource datasetNBBindingSource;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource tipoTransaccionesBindingSource;
        private datasetNBTableAdapters.TipoTransaccionesTableAdapter tipoTransaccionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}