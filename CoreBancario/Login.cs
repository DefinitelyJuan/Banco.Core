using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreBancario.dsPerfilesTableAdapters;
namespace CoreBancario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosTableAdapter profile = new UsuariosTableAdapter();
            DataTable profiles = profile.GetData();
            DataRow[] selectedProfile = profiles.Select($"Usuario = '{txtUser.Text}' and Contraseña = '{txtPass.Text}'");
            if (selectedProfile.Length > 0)
            {
                if(selectedProfile[0][2].ToString() == "Admin")
                {
                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    menu.Show();
                }
                if (selectedProfile[0][2].ToString() == "Auditor")
                {
                    menuAuditor menu = new menuAuditor();
                    this.Hide();
                    menu.Show();
                }

            }
        }
    }
}
