using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.AbmPost_Net
{
    public partial class FormAltaPostnet : Form
    {
        Utils.Validador validador = new BoletoElectronicoDesktop.Utils.Validador(false);
       
        public FormAltaPostnet()
        {
            InitializeComponent();
            limpiar();
            validador.Add(new BoletoElectronicoDesktop.Utils.Requerido(marca_txt, "marca"));
            validador.Add(new BoletoElectronicoDesktop.Utils.Requerido(modelo_txt, "modelo"));
            validador.Add(new BoletoElectronicoDesktop.Utils.Requerido(codigo_nud, "código"));
            validador.Add(new BoletoElectronicoDesktop.Utils.LongitudMaxima(marca_txt, 50, "marca"));
            validador.Add(new BoletoElectronicoDesktop.Utils.LongitudMaxima(modelo_txt, 50, "modelo"));
        }

        private void ValidarControles()
        {
            string fallaValidacion = ""; //String para agregar los mensajes de los errores de validacion.
            validador.Resetear();//resetea el fondo del control para no interferir con la validacion de validador, ni beneficiario repetido.         
            try
            {
                if (DalGral.GetDataReaderBool("SELECT top 1 POSTNET_NRO_SERIE FROM mozilla.Postnets WHERE POSTNET_NRO_SERIE = " + codigo_nud.Value))
                {
                    fallaValidacion = "El postnet " + codigo_nud.Value + " ya existe, y no puede volver a ingresarse." + Environment.NewLine;
                    codigo_nud.BackColor = System.Drawing.Color.MistyRose;
                }
                validador.Validar();
                if (fallaValidacion != "") throw new Exception("");
            }
            catch (Exception ex)
            {
                throw new Exception(fallaValidacion + ex.Message);
            }
        }

        private void guardar_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarControles();
                DalGral.ExcecuteNonQuery("INSERT mozilla.Postnets (POSTNET_NRO_SERIE,POSTNET_MODELO,POSTNET_MARCA,BENEFICIARIO_ID) VALUES ("+codigo_nud.Value+",'"+modelo_txt.Text +"','"+marca_txt.Text +"',NULL)");
                MessageBox.Show("Datos se guardaron Correctamente", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falla alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiar()
        {
            marca_txt.Text ="";
            modelo_txt.Text = "";
            codigo_nud.Value  = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
