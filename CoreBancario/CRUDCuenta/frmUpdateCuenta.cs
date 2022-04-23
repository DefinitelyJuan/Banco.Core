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
    public partial class frmUpdateCuenta : Form
    {
        public frmUpdateCuenta()
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
            b.NoCuentaTableAdapter nocuentaB = new b.NoCuentaTableAdapter();
            int idCliente = (int)cliente.getClienteByCedula(txtCedula.Text);
            int idTipoCuenta = (int)tipoCuenta.getIDTipoCuentaByName(comboBox1.Text);
            noCuenta.Update(idCliente, idTipoCuenta,int.Parse(txtNoCuenta.Text));
            nocuentaB.Update(idCliente, idTipoCuenta,int.Parse(txtNoCuenta.Text));
            MessageBox.Show("Cuenta actualizada");
            log.Info($"Cuenta actualizada: {txtNoCuenta.Text}");
        }

        private void frmUpdateCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.TipoCuenta' Puede moverla o quitarla según sea necesario.
            this.tipoCuentaTableAdapter.Fill(this.datasetNB.TipoCuenta);
            Helpers.WindowProperties(this);

            Helpers.LimitComboBox(comboBox1);
        }
    }
}
