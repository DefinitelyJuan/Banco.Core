using CoreBancario.dsPerfilesTableAdapters;
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
    public partial class frmCrearPerfil : Form
    {
        public frmCrearPerfil()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void frmCrearPerfil_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Helpers.LimitComboBox(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosTableAdapter usuario = new UsuariosTableAdapter();
            try
            {
                usuario.Connection.Open();
                usuario.Insert(txtUser.Text, txtPass.Text, comboBox1.Text); //TODO: usar db local para los users
                MessageBox.Show("Perfil insertado");
                log.Info($"Nuevo Perfil: {txtUser}");
                Helpers.ClearFormControls(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                log.Error(err.Message);
            }
            finally
            {
                usuario.Connection.Close();
            }
        }
    }
}
