
namespace CoreBancario
{
    partial class frmUpdateCliente
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
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboSector = new System.Windows.Forms.ComboBox();
            this.comboMunicipio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.birthSelector = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datasetNB = new CoreBancario.datasetNB();
            this.sectorTableAdapter = new CoreBancario.datasetNBTableAdapters.SectorTableAdapter();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiarioTableAdapter = new CoreBancario.datasetNBTableAdapters.BeneficiarioTableAdapter();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciaTableAdapter = new CoreBancario.datasetNBTableAdapters.ProvinciaTableAdapter();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipioTableAdapter = new CoreBancario.datasetNBTableAdapters.MunicipioTableAdapter();
            this.sectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(605, 223);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(101, 20);
            this.txtIngresos.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 19);
            this.label13.TabIndex = 82;
            this.label13.Text = "Ingreso Mensual";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboSector
            // 
            this.comboSector.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectorBindingSource, "Nombre_Sector", true));
            this.comboSector.DataSource = this.sectorBindingSource;
            this.comboSector.DisplayMember = "Nombre_Sector";
            this.comboSector.FormattingEnabled = true;
            this.comboSector.Location = new System.Drawing.Point(605, 187);
            this.comboSector.Name = "comboSector";
            this.comboSector.Size = new System.Drawing.Size(101, 21);
            this.comboSector.TabIndex = 81;
            this.comboSector.ValueMember = "Nombre_Sector";
            // 
            // comboMunicipio
            // 
            this.comboMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.municipioBindingSource, "Nombre_Municipio", true));
            this.comboMunicipio.DataSource = this.municipioBindingSource;
            this.comboMunicipio.DisplayMember = "Nombre_Municipio";
            this.comboMunicipio.FormattingEnabled = true;
            this.comboMunicipio.Location = new System.Drawing.Point(605, 154);
            this.comboMunicipio.Name = "comboMunicipio";
            this.comboMunicipio.Size = new System.Drawing.Size(101, 21);
            this.comboMunicipio.TabIndex = 80;
            this.comboMunicipio.ValueMember = "Nombre_Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(516, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 79;
            this.label12.Text = "Sector";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(491, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 78;
            this.label11.Text = "Municipio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboProvincia
            // 
            this.comboProvincia.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provinciaBindingSource, "Nombre_Provincia", true));
            this.comboProvincia.DataSource = this.provinciaBindingSource;
            this.comboProvincia.DisplayMember = "Nombre_Provincia";
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(605, 118);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(101, 21);
            this.comboProvincia.TabIndex = 77;
            this.comboProvincia.ValueMember = "Nombre_Provincia";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(126, 215);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(100, 21);
            this.comboSexo.TabIndex = 76;
            this.comboSexo.Text = "Seleccione...";
            // 
            // birthSelector
            // 
            this.birthSelector.CustomFormat = "yyyy-mm-dd";
            this.birthSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthSelector.Location = new System.Drawing.Point(126, 252);
            this.birthSelector.Name = "birthSelector";
            this.birthSelector.Size = new System.Drawing.Size(100, 20);
            this.birthSelector.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 74;
            this.label8.Text = "Provincia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 73;
            this.label9.Text = "DOB";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "Sexo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(126, 179);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 68;
            this.label6.Text = "Nombre";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cedula";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(126, 100);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 33);
            this.label4.TabIndex = 65;
            this.label4.Text = "Update Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(605, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 85;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datasetNB
            // 
            this.datasetNB.DataSetName = "datasetNB";
            this.datasetNB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectorTableAdapter
            // 
            this.sectorTableAdapter.ClearBeforeFill = true;
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataMember = "Beneficiario";
            this.beneficiarioBindingSource.DataSource = this.datasetNB;
            // 
            // beneficiarioTableAdapter
            // 
            this.beneficiarioTableAdapter.ClearBeforeFill = true;
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "Provincia";
            this.provinciaBindingSource.DataSource = this.datasetNB;
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataMember = "Municipio";
            this.municipioBindingSource.DataSource = this.datasetNB;
            // 
            // municipioTableAdapter
            // 
            this.municipioTableAdapter.ClearBeforeFill = true;
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataMember = "Sector";
            this.sectorBindingSource.DataSource = this.datasetNB;
            // 
            // frmUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboSector);
            this.Controls.Add(this.comboMunicipio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboProvincia);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.birthSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Name = "frmUpdateCliente";
            this.Text = "frmUpdateCliente";
            this.Load += new System.EventHandler(this.frmUpdateCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboSector;
        private System.Windows.Forms.ComboBox comboMunicipio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.DateTimePicker birthSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private datasetNB datasetNB;
        private datasetNBTableAdapters.SectorTableAdapter sectorTableAdapter;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private datasetNBTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private datasetNBTableAdapters.ProvinciaTableAdapter provinciaTableAdapter;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private datasetNBTableAdapters.MunicipioTableAdapter municipioTableAdapter;
        private System.Windows.Forms.BindingSource sectorBindingSource;
    }
}