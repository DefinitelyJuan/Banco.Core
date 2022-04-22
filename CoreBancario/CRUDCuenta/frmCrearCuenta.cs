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
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void button1_Click(object sender, EventArgs e)
        {
            //getid by cedula
            ClienteTableAdapter cliente = new ClienteTableAdapter();
            NoCuentaTableAdapter noCuenta = new NoCuentaTableAdapter();
            TipoCuentaTableAdapter tipoCuenta = new TipoCuentaTableAdapter();
            int idCliente = (int)cliente.getClienteByCedula(txtNombre.Text);
            int idTipoCuenta = (int)tipoCuenta.getIDTipoCuentaByName(comboBox1.Text); 
            noCuenta.Insert(idCliente, idTipoCuenta);
            MessageBox.Show("Cuenta insertada");
            log.Info($"Cuenta insertada: {txtNombre.Text}, {comboBox1.Text}");
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);

            // TODO: esta línea de código carga datos en la tabla 'datasetNB.TipoCuenta' Puede moverla o quitarla según sea necesario.
            this.tipoCuentaTableAdapter.Fill(this.datasetNB.TipoCuenta);
            Helpers.LimitComboBox(comboBox1);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
