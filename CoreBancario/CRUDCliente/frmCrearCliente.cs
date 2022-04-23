using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreBancario.datasetNBTableAdapters;
using b = CoreBancario.datasetNBBackupTableAdapters;
using CoreBancario.Utilidades;
namespace CoreBancario
{

    public partial class frmCrearCliente : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public frmCrearCliente()
        {
            InitializeComponent();
        }

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
                cliente.ppInsertCliente(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, DateTime.Parse(dob), idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text));
                cliente.ppInsertUsuario(int.Parse(nextid), txtUser.Text, "Cliente", txtPass.Text, txtPin.Text);
                clienteB.ppInsertCliente(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, DateTime.Parse(dob), idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text));
                clienteB.ppInsertUsuario(int.Parse(nextid), txtUser.Text, "Cliente", txtPass.Text, txtPin.Text);
                transaction.Commit();
                MessageBox.Show("Cliente insertado");
                log.Info($"Nuevo cliente y usuario insertados: {txtCedula.Text}, {txtUser}");
                Helpers.ClearFormControls(this);
            }
            catch (Exception err)
            {
                //Log.Info(err.Message);
                MessageBox.Show(err.Message);
                transaction.Rollback();
                log.Error(err.Message);
            }
            finally
            {
                cliente.Connection.Close();
            }

        }
        private void frmCrearCliente_Load_1(object sender, EventArgs e)
        {
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
            Helpers.LimitComboBox(comboBox1);

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                cliente.ppInsertCliente(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, DateTime.Parse(dob), idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text));
                cliente.ppInsertUsuario(int.Parse(nextid), txtUser.Text, comboBox1.Text, txtPass.Text, txtPin.Text);
                clienteB.ppInsertCliente(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, DateTime.Parse(dob), idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text));
                clienteB.ppInsertUsuario(int.Parse(nextid), txtUser.Text, comboBox1.Text, txtPass.Text, txtPin.Text);
                transaction.Commit();
                MessageBox.Show("Cliente insertado");
                log.Info($"Nuevo cliente y usuario insertados: {txtCedula.Text}, {txtUser}");
                Helpers.ClearFormControls(this);
            }
            catch (Exception err)
            {
                //Log.Info(err.Message);
                MessageBox.Show(err.Message);
                transaction.Rollback();
                log.Error(err.Message);
            }
            finally
            {
                cliente.Connection.Close();
            }
        }
    }
}
