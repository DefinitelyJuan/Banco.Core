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
using b = CoreBancario.datasetNBBackupTableAdapters;
namespace CoreBancario
{
    public partial class frmCrearTipoTransaccion : Form
    {
        public frmCrearTipoTransaccion()
        {
            InitializeComponent();
        }

        private void frmCrearTipoTransaccion_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoTransaccionesTableAdapter tipotransaccion = new TipoTransaccionesTableAdapter();
            b.TipoTransaccionesTableAdapter tipotransaccionB = new b.TipoTransaccionesTableAdapter();
            tipotransaccion.Insert(int.Parse(txtCodigo.Text),txtDescripcion.Text,txtStatus.Text);
            tipotransaccionB.Insert(int.Parse(txtCodigo.Text),txtDescripcion.Text,txtStatus.Text);

        }
    }
}
