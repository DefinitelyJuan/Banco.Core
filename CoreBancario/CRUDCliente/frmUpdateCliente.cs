using CoreBancario.datasetNBTableAdapters;
using CoreBancario.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using b = CoreBancario.datasetNBBackupTableAdapters;
namespace CoreBancario
{
    public partial class frmUpdateCliente : Form
    {
        public frmUpdateCliente()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteTableAdapter cliente = new ClienteTableAdapter();
            ProvinciaTableAdapter provincia = new ProvinciaTableAdapter();
            MunicipioTableAdapter municipio = new MunicipioTableAdapter();
            SectorTableAdapter sector = new SectorTableAdapter();
            SqlTransaction transaction = null;

            b.ClienteTableAdapter clienteB = new b.ClienteTableAdapter();
            b.ProvinciaTableAdapter provinciaB = new b.ProvinciaTableAdapter();
            b.MunicipioTableAdapter municipioB = new b.MunicipioTableAdapter();
            b.SectorTableAdapter sectorB = new b.SectorTableAdapter();

            try
            {
                cliente.Connection.Open();
                int idprovincia = (int)provincia.getIDProvincia(comboProvincia.Text);
                int idmunicipio = (int)municipio.getIDMunicipio(comboMunicipio.Text);
                int idsector = (int)sector.getIDSector(comboSector.Text);
                string nextid = cliente.idnextcliente().ToString();
                transaction = cliente.Connection.BeginTransaction();
                cliente.Transaction = transaction;
                IFormatProvider format = System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat;
                var dob = (birthSelector.Value).ToString("yyyy-MM-dd", format);
                cliente.Update(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, dob, idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text), txtCedula.Text,(int)cliente.getClienteByCedula(txtCedula.Text));
                clienteB.Update(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, dob, idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text), txtCedula.Text,(int)cliente.getClienteByCedula(txtCedula.Text));
                MessageBox.Show("Cliente actualizado");
                log.Info($"Cliente actualizado: {txtCedula.Text}");
                Helpers.ClearFormControls(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                log.Error(err.Message);
            }
            finally
            {
                cliente.Connection.Close();
            }
        }
        private void frmUpdateCliente_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.Sector' Puede moverla o quitarla según sea necesario.
            this.sectorTableAdapter.Fill(this.datasetNB.Sector);
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.Municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.datasetNB.Municipio);
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.Provincia' Puede moverla o quitarla según sea necesario.
            this.provinciaTableAdapter.Fill(this.datasetNB.Provincia);
            // TODO: esta línea de código carga datos en la tabla 'datasetNB.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.datasetNB.Beneficiario);
            Helpers.LimitComboBox(comboMunicipio);
            Helpers.LimitComboBox(comboProvincia);
            Helpers.LimitComboBox(comboSector);
            Helpers.LimitComboBox(comboSexo);
        }
    }
}
