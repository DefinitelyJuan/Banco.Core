using CoreBancario.datasetNBTableAdapters;
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
    public partial class frmEditarTipoTransaccion : Form
    {
        public frmEditarTipoTransaccion()
        {
            InitializeComponent();
        }

        private void frmEditarTipoTransaccion_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoTransaccionesTableAdapter tipotransaccion = new TipoTransaccionesTableAdapter();
            tipotransaccion.Update(txtDescripcion.Text, txtStatus.Text, int.Parse(txtCodigo.Text));
        }
    }
}
