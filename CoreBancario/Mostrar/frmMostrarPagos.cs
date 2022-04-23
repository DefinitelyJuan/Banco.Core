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
    public partial class frmMostrarPagos : Form
    {
        public frmMostrarPagos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmMostrarPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetNBBackup.Pago' Puede moverla o quitarla según sea necesario.
            this.pagoTableAdapter.Fill(this.datasetNBBackup.Pago);
            Helpers.WindowProperties(this);
        }
    }
}
