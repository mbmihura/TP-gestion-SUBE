using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.AbmCliente;
using CalificacionBancariaDesktop.AbmCuenta;
using CalificacionBancariaDesktop.TransaccionEntreCuentas;
using CalificacionBancariaDesktop.ConsultaPlazoFijo;
using CalificacionBancariaDesktop.CalidadClientes;
using CalificacionBancariaDesktop.OtorgacionPrestamos;

namespace CalificacionBancariaDesktop
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void aBMDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmCliente form = new FormAbmCliente();
            form.ShowDialog(this);
        }

        private void aBMDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbmCuenta form = new FormAbmCuenta();
            form.ShowDialog(this);
        }

        private void transacciónEntreCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaccionEntreCuentas form = new FormTransaccionEntreCuentas();
            form.ShowDialog(this);
        }

        private void consultaDePlazosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaPlazoFijo form = new FormConsultaPlazoFijo();
            form.ShowDialog(this);
        }

        private void calidadDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalidadClientes form = new FormCalidadClientes();
            form.ShowDialog(this);
        }

        private void otorgaciónDePréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOtorgacionPrestamos form = new FormOtorgacionPrestamos();
            form.ShowDialog(this);
        }
    }
}