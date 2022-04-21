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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmCrearPerfil crearPerfil = new frmCrearPerfil();
            crearPerfil.MdiParent = this;
            crearPerfil.Show();
            crearPerfil.BringToFront();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //TODO: Redirigir a Login
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmCrearCliente crearCliente = new frmCrearCliente();
            crearCliente.MdiParent = this;
            crearCliente.Show();
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

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmUpdateCliente updateCliente = new frmUpdateCliente();
            updateCliente.MdiParent = this;
            updateCliente.Show();
            updateCliente.BringToFront();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmUpdatePerfil updatePerfil = new frmUpdatePerfil();
            updatePerfil.MdiParent = this;
            updatePerfil.Show();
            updatePerfil.BringToFront();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmDeletePerfil deletePerfil = new frmDeletePerfil();
            deletePerfil.MdiParent = this;
            deletePerfil.Show();
            deletePerfil.BringToFront();
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

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmMostrarTransacciones mostrarTransacciones = new frmMostrarTransacciones();
            mostrarTransacciones.MdiParent = this;
            mostrarTransacciones.Show();
            mostrarTransacciones.BringToFront();
        }
    }
}
