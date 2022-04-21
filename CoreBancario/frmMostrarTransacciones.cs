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
    public partial class frmMostrarTransacciones : Form
    {
        public frmMostrarTransacciones()
        {
            InitializeComponent();
        }

        private void frmMostrarTransacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.Transacciones' Puede moverla o quitarla según sea necesario.
            this.transaccionesTableAdapter.Fill(this.datasetNB.Transacciones);
            Helpers.WindowProperties(this);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
