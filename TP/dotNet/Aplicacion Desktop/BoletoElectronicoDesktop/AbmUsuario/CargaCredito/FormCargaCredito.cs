using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.CargaCredito
{
    //TODO: los montos tienen como maximo 100, que es el default. hay que averiguar cual puede ser el maximo ya que no pueden quedar vacios
    public partial class FormCargaCredito : Form
    {
        public FormCargaCredito()
        {
            InitializeComponent();
        }

        private void FormCargaCredito_Load(object sender, EventArgs e)
        {
            fecha_dtp.Value = DateTime.Today;
        }

        private void limpiar_cmd_Click(object sender, EventArgs e)
        {
            nudNroTarjeta.Value = 0;
            fecha_dtp.Value = DateTime.Today;
            monto_nud.Value = 0;
        }

        private void cargar_cmd_Click(object sender, EventArgs e)
        {
            try 
	        {
                // public Carga(DateTime fechaCarga, Double importe, int nroTarjeta)
                new Carga(fecha_dtp.Value, Convert.ToDouble(monto_nud.Value), Convert.ToInt32(nudNroTarjeta.Value));
                MessageBox.Show("Importe cargado exitosamente!", "Carga de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cmd_Click(sender, e);

	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message, "Carga de crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

    }
}
