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
using CoreBancario.datasetNBTableAdapters;
namespace CoreBancario
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
            Helpers.LimitComboBox(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioTableAdapter usuario = new UsuarioTableAdapter();
            //usuario.Insert();




        }
    }
}
