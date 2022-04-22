
namespace CoreBancario
{
    partial class frmUpdateCuenta
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datasetNB = new CoreBancario.datasetNB();
            this.datasetNBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoCuentaTableAdapter = new CoreBancario.datasetNBTableAdapters.TipoCuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCuentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "Tipo de cuenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(349, 162);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "Cedula";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "NoCuenta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(349, 121);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNoCuenta.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 33);
            this.label4.TabIndex = 95;
            this.label4.Text = "Update Cuenta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(321, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 94;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoCuentaBindingSource, "Nombre_TipoCuenta", true));
            this.comboBox1.DataSource = this.tipoCuentaBindingSource;
            this.comboBox1.DisplayMember = "Nombre_TipoCuenta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.ValueMember = "Nombre_TipoCuenta";
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
            // tipoCuentaBindingSource
            // 
            this.tipoCuentaBindingSource.DataMember = "TipoCuenta";
            this.tipoCuentaBindingSource.DataSource = this.datasetNBBindingSource;
            // 
            // tipoCuentaTableAdapter
            // 
            this.tipoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "frmUpdateCuenta";
            this.Text = "frmUpdateCuenta";
            this.Load += new System.EventHandler(this.frmUpdateCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetNBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCuentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource datasetNBBindingSource;
        private datasetNB datasetNB;
        private System.Windows.Forms.BindingSource tipoCuentaBindingSource;
        private datasetNBTableAdapters.TipoCuentaTableAdapter tipoCuentaTableAdapter;
    }
}