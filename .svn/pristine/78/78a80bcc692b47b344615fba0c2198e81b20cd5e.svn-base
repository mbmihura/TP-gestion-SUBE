using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Login;
using BoletoElectronicoDesktop.CargaCredito;
using BoletoElectronicoDesktop.EfectuarCompra;
using BoletoElectronicoDesktop.TarjetasPremium;
using BoletoElectronicoDesktop.PagoEmpresas;
using BoletoElectronicoDesktop.AbmTarjetas;
using BoletoElectronicoDesktop.AbmBeneficiarios;
using BoletoElectronicoDesktop.AbmUsuario;
using BoletoElectronicoDesktop.AbmRol;
using BoletoElectronicoDesktop.AbmClientes;

namespace BoletoElectronicoDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.ShowDialog(this); 
        }

        private void carrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog(this);
        }

        private void cargarCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargaCredito form = new FormCargaCredito();
            form.ShowDialog(this);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarjetasPremium form = new FormTarjetasPremium();
            form.ShowDialog();
        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEfectuarCompra form = new FormEfectuarCompra();
            form.ShowDialog(this);
        }

        private void pagoFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagoEmpresas form = new FormPagoEmpresas();
            form.ShowDialog(this);
        }


        private void abmBeneficiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmBeneficiarioIngresodatos().ShowAlta(this);
        }
        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmBeneficiariosSeleccion().ShowModificacion(this);
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmBeneficiariosSeleccion().ShowBaja(this);
        }
        private void altaPostnetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BoletoElectronicoDesktop.AbmPost_Net.FormAltaPostnet().ShowDialog(this);
        }

        private void tarjetasPremiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarjetasPremium form = new FormTarjetasPremium();
            form.ShowDialog(this);
        }

        private void altaDeTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaTarjeta().ShowDialog(this);
        }

        private void modificarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new FiltroBusquedaTarjeta().ShowDialog(this);
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FiltroBusquedaTarjeta buscador = new FiltroBusquedaTarjeta();
            buscador.TipoUso = FiltroBusquedaTarjeta.Eliminacion;
            buscador.ShowDialog(this);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAltaRol().ShowDialog(this);
        }

        private void altaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmClientesIngresodatos().ShowDialog(this);
        }

        private void modificaciónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmClientesSeleccion().ShowModificacionClientes(this);
        }

        private void eliminarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbmClientesSeleccion().ShowBajaClientes(this);
        }

        private void modificarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmBuscadorRol buscador = new frmBuscadorRol();
            buscador.ShowDialog(this);
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBuscadorRol buscador = new frmBuscadorRol();
            buscador.TipoUso = frmBuscadorRol.Eliminacion;
            buscador.ShowDialog(this);
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmAltaUsuario().ShowDialog(this);
        }

        private void modificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmBuscadorUsuario().ShowDialog(this);
        }

        private void bajaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmBuscadorUsuario buscador = new FrmBuscadorUsuario();
            buscador.TipoUso = FrmBuscadorUsuario.Eliminacion;
            buscador.ShowDialog(this);
        }

    }
}
