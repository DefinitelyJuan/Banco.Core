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

        private void mostrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarTipoTransacciones mostrarTTransacciones = new frmMostrarTipoTransacciones();
            mostrarTTransacciones.MdiParent = this;
            mostrarTTransacciones.Show();
            mostrarTTransacciones.BringToFront();
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarPrestamos mostrarPrestamos = new frmMostrarPrestamos();
            mostrarPrestamos.MdiParent = this;
            mostrarPrestamos.Show();
            mostrarPrestamos.BringToFront();
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarPagos pagos = new frmMostrarPagos();
            pagos.MdiParent = this;
            pagos.Show();
            pagos.BringToFront();
        }
    }
}
