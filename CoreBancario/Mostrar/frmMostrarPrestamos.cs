﻿using CoreBancario.Utilidades;
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
    public partial class frmMostrarPrestamos : Form
    {
        public frmMostrarPrestamos()
        {
            InitializeComponent();
        }

        private void frmMostrarPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetNBBackup.Prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter.Fill(this.datasetNBBackup.Prestamo);
            Helpers.WindowProperties(this);
        }
    }
}
