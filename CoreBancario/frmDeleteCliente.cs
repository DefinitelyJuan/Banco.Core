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

namespace CoreBancario
{
    public partial class frmDeleteCliente : Form
    {
        public frmDeleteCliente()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void frmDeleteCliente_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteTableAdapter cliente = new ClienteTableAdapter();
            UsuarioTableAdapter usuario = new UsuarioTableAdapter();
            ///No cuenta, etc (Todo lo que tenga cliente de foreign key)
            SqlTransaction transaction = null;

            try
            {
                cliente.Connection.Open();              
                string nextid = cliente.idnextcliente().ToString();
                transaction = cliente.Connection.BeginTransaction();
                cliente.Transaction = transaction;
                //cliente.Delete(txtCedula.Text, txtNombre.Text, txtDireccion.Text, comboSexo.Text, DateTime.Parse(dob), idprovincia, idmunicipio, idsector, decimal.Parse(txtIngresos.Text));
                //usuario.Delete(int.Parse(nextid), txtUser.Text, "Cliente", txtPass.Text, txtPin.Text);
                //etc (EN ORDEN DE PRIORIDAD SEGUN FKs)
                transaction.Commit();
                MessageBox.Show("Cliente insertado");
                //log.Info($"Nuevo cliente y usuario insertados: {txtCedula.Text}, {txtUser}");
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
