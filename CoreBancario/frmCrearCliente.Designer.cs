
namespace CoreBancario
{
    partial class frmCrearCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.birthSelector = new System.Windows.Forms.DateTimePicker();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.provinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coreDataSet = new CoreBancario.CoreDataSet();
            this.provinciaTableAdapter = new CoreBancario.CoreDataSetTableAdapters.ProvinciaTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboMunicipio = new System.Windows.Forms.ComboBox();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboSector = new System.Windows.Forms.ComboBox();
            this.sectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipioTableAdapter = new CoreBancario.CoreDataSetTableAdapters.MunicipioTableAdapter();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sectorTableAdapter = new CoreBancario.CoreDataSetTableAdapters.SectorTableAdapter();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(579, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(609, 157);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(609, 106);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crear Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 170);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cedula";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(151, 91);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Provincia";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "DOB";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sexo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // birthSelector
            // 
            this.birthSelector.CustomFormat = "yyyy-mm-dd";
            this.birthSelector.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthSelector.Location = new System.Drawing.Point(151, 243);
            this.birthSelector.Name = "birthSelector";
            this.birthSelector.Size = new System.Drawing.Size(100, 20);
            this.birthSelector.TabIndex = 26;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(151, 206);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(100, 21);
            this.comboSexo.TabIndex = 27;
            this.comboSexo.Text = "Seleccione...";
            // 
            // comboProvincia
            // 
            this.comboProvincia.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provinciaBindingSource, "Nombre_Provincia", true));
            this.comboProvincia.DataSource = this.provinciaBindingSource;
            this.comboProvincia.DisplayMember = "Nombre_Provincia";
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(151, 279);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(100, 21);
            this.comboProvincia.TabIndex = 28;
            this.comboProvincia.ValueMember = "Nombre_Provincia";
            // 
            // provinciaBindingSource
            // 
            this.provinciaBindingSource.DataMember = "Provincia";
            this.provinciaBindingSource.DataSource = this.coreDataSetBindingSource;
            // 
            // coreDataSetBindingSource
            // 
            this.coreDataSetBindingSource.DataSource = this.coreDataSet;
            this.coreDataSetBindingSource.Position = 0;
            // 
            // coreDataSet
            // 
            this.coreDataSet.DataSetName = "CoreDataSet";
            this.coreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciaTableAdapter
            // 
            this.provinciaTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Municipio";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Sector";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboMunicipio
            // 
            this.comboMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.municipioBindingSource, "Nombre_Municipio", true));
            this.comboMunicipio.DataSource = this.municipioBindingSource1;
            this.comboMunicipio.DisplayMember = "Nombre_Municipio";
            this.comboMunicipio.FormattingEnabled = true;
            this.comboMunicipio.Location = new System.Drawing.Point(151, 315);
            this.comboMunicipio.Name = "comboMunicipio";
            this.comboMunicipio.Size = new System.Drawing.Size(100, 21);
            this.comboMunicipio.TabIndex = 31;
            this.comboMunicipio.ValueMember = "Nombre_Municipio";
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataMember = "Municipio";
            this.municipioBindingSource.DataSource = this.coreDataSetBindingSource;
            // 
            // municipioBindingSource1
            // 
            this.municipioBindingSource1.DataMember = "Municipio";
            this.municipioBindingSource1.DataSource = this.coreDataSetBindingSource;
            // 
            // comboSector
            // 
            this.comboSector.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectorBindingSource, "Nombre_Sector", true));
            this.comboSector.DataSource = this.sectorBindingSource;
            this.comboSector.DisplayMember = "Nombre_Sector";
            this.comboSector.FormattingEnabled = true;
            this.comboSector.Location = new System.Drawing.Point(151, 348);
            this.comboSector.Name = "comboSector";
            this.comboSector.Size = new System.Drawing.Size(100, 21);
            this.comboSector.TabIndex = 32;
            this.comboSector.ValueMember = "Nombre_Sector";
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataMember = "Sector";
            this.sectorBindingSource.DataSource = this.coreDataSetBindingSource;
            // 
            // municipioTableAdapter
            // 
            this.municipioTableAdapter.ClearBeforeFill = true;
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(151, 384);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresos.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ingreso Mensual";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(616, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Usuario";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(159, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cliente";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sectorTableAdapter
            // 
            this.sectorTableAdapter.ClearBeforeFill = true;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(609, 203);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(562, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Pin";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.button1);
            this.Name = "frmCrearCliente";
            this.Text = "frmCrearCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCrearCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birthSelector;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.BindingSource coreDataSetBindingSource;
        private CoreDataSet coreDataSet;
        private System.Windows.Forms.BindingSource provinciaBindingSource;
        private CoreDataSetTableAdapters.ProvinciaTableAdapter provinciaTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboMunicipio;
        private System.Windows.Forms.ComboBox comboSector;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private CoreDataSetTableAdapters.MunicipioTableAdapter municipioTableAdapter;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource sectorBindingSource;
        private CoreDataSetTableAdapters.SectorTableAdapter sectorTableAdapter;
        private System.Windows.Forms.BindingSource municipioBindingSource1;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label16;
    }
}