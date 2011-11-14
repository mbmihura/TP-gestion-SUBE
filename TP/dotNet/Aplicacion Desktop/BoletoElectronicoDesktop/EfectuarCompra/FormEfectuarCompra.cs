using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.AbmBeneficiarios;
using BoletoElectronicoDesktop.Datos;
using BoletoElectronicoDesktop.Utils;

namespace BoletoElectronicoDesktop.EfectuarCompra
{
    public partial class FormEfectuarCompra : Form
    {
        int idBeneficiario;
        Validador Validacion;

        public FormEfectuarCompra()
        {
            InitializeComponent();
            //Carga parametros de Validacion
            Validacion = new Validador(true,
                new Requerido(beneficiario_txt, "beneficiario"),
                new Requerido(postnet_cmb, "postnet"),
                new Requerido(tarjeta_nud, "tarjeta"),
                new Requerido(monto_nud, "monto"),
                new ValorMinimo(monto_nud,0.05m,"monto")
            );
            limpiar();
        }
        private void limpiar() {
            beneficiario_txt.Text = "";
            postnet_cmb.Enabled = false;
            tarjeta_nud.Text = "";
            fecha_dtp.Value = DateTime.Today;
            monto_nud.Value = 0;
        }
        private void limpiar_cmd_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void aceptar_cmd_Click(object sender, EventArgs e)
        {
            Validacion.Resetear();//resetea el fondo del control para no interferir con la validacion de validador, ni beneficiario repetido.         
            try
            {
                Validacion.Validar();
                postnet_cmb.DataSource = DalGral.getDataTable("");
            }
            catch (FallaValidacionException)
            {/*Termina el flujo pero no se realizan acciones*/ }
            catch (Exception ex)
            { }
            
        }

        private void beneficiario_txt_TextChanged(object sender, EventArgs e)
        {
            if (beneficiario_txt.Text == "") 
                postnet_cmb.Items.Clear();
        }

        private void seleccionar_cmd_Click(object sender, EventArgs e)
        {
            idBeneficiario = new FormAbmBeneficiariosSeleccion().ShowSeleccion(this);
            if (idBeneficiario > -1)
            {
                beneficiario_txt.Text = DalGral.getDataTable("SELECT BENEFICIARIO_NOMBRE FROM mozilla.Beneficiarios WHERE BENEFICIARIO_ID = " + idBeneficiario).Rows[0][0].ToString();
                postnet_cmb.DataSource = DalGral.getDataTable("SELECT POSTNET_NRO_SERIE, CONVERT(varchar, POSTNET_NRO_SERIE) + ', ' + POSTNET_MARCA + ' ' + POSTNET_MODELO AS 'NOMBRE' FROM mozilla.Postnets WHERE HABILITADO = 1 AND BENEFICIARIO_ID = " + idBeneficiario);
                postnet_cmb.DisplayMember = "NOMBRE";
                postnet_cmb.ValueMember = "POSTNET_NRO_SERIE";
                postnet_cmb.Enabled = true;
            }
        }
    }
}
