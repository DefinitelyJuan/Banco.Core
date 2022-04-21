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

namespace CoreBancario
{
    public partial class frmUpdatePerfil : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmUpdatePerfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosTableAdapter usuario = new UsuariosTableAdapter();
            try
            {
                usuario.Connection.Open();
                int response = usuario.Update(txtPass.Text, comboBox1.Text, txtUser.Text , txtUser.Text);
                if (response > 0)
                {
                    MessageBox.Show("Perfil Actualizado");
                    log.Info($"Perfil Actualizado: {txtUser}");
                    Helpers.ClearFormControls(this);


                }
                else
                {
                    MessageBox.Show("Perfil No Encontrado");
                }
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

        private void frmUpdatePerfil_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Helpers.LimitComboBox(comboBox1);
        }
    }
}
