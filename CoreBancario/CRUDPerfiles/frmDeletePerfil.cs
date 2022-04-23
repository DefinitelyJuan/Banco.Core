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
    public partial class frmDeletePerfil : Form
    {
        public frmDeletePerfil()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosTableAdapter usuario = new UsuariosTableAdapter();
            try
            {
                var confirmResult = MessageBox.Show($"Desea eliminar al usuario {txtUser.Text} de la base de datos?", "Confirmar Delete",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    usuario.Connection.Open();
                    int response = usuario.Delete(txtUser.Text, txtPass.Text); //TODO: Confirmation window (ver caja)
                    if (response > 0)
                    {
                        MessageBox.Show("Perfil eliminado");
                        log.Info($"Perfil eliminado: {txtUser}");
                        Helpers.ClearFormControls(this);


                    }
                    else
                    {
                        MessageBox.Show("Perfil No Encontrado o contraseña incorrecta");
                    }
                }
                else
                {
                    // If 'No', do something here.
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

        private void frmDeletePerfil_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
