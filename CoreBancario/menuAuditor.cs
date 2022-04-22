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
    public partial class menuAuditor : Form
    {
        public menuAuditor()
        {
            InitializeComponent();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarPerfil mostrarPerfil = new frmMostrarPerfil();
            mostrarPerfil.MdiParent = this;
            mostrarPerfil.Show();
            mostrarPerfil.BringToFront();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            VerClientes verCliente = new VerClientes();
            verCliente.MdiParent = this;
            verCliente.Show();
            verCliente.BringToFront();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarTransacciones mostrarTransacciones = new frmMostrarTransacciones();
            mostrarTransacciones.MdiParent = this;
            mostrarTransacciones.Show();
            mostrarTransacciones.BringToFront();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarCuentas mostrarCuentas = new frmMostrarCuentas();
            mostrarCuentas.MdiParent = this;
            mostrarCuentas.Show();
            mostrarCuentas.BringToFront();
        }
    }
}
