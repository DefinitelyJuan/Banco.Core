using CoreBancario.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreBancario
{
    public partial class frmMostrarCuentas : Form
    {
        public frmMostrarCuentas()
        {
            InitializeComponent();
        }

        private void frmMostrarCuentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.NoCuenta' Puede moverla o quitarla según sea necesario.
            this.noCuentaTableAdapter.Fill(this.datasetNB.NoCuenta);
            Helpers.WindowProperties(this);
        }
    }
}
