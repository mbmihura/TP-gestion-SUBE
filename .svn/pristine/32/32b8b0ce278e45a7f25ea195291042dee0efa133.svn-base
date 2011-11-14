using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoletoElectronicoDesktop.PagoEmpresas
{
    public partial class FormPagoEmpresas : Form
    {
        public FormPagoEmpresas()
        {
            InitializeComponent();
        }

        private void FormPagoEmpresas_Load(object sender, EventArgs e)
        {
            fechaInicio_dtp.Value = DateTime.Today;
            fechaFin_dtp.Value = DateTime.Today;
        }

        private void fechaFin_dtp_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechas();
        }

        private void fechaInicio_dtp_ValueChanged(object sender, EventArgs e)
        {
            ValidarFechas();

        }
        private void ValidarFechas()
        {
            if (fechaInicio_dtp.Value > fechaFin_dtp.Value )
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la de finalizacion", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void seleccionar_cmd_Click(object sender, EventArgs e)
        {
            //TODO: deberia llamarse al EBMmodificar a la pantalla seleccionar?
        }

        private void generar_cmd_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Insert a la base de datos:
                //  beneficiario debe existir.
                //  fecha fin debe ser posterior a fecha inicio. Hacemos la validacion en la app?
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void registrarPago_Cmd_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("¿Registrar el pago de las ventas mostradas en el listado?","Confirmar registro de pagos",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2 )){
                //TODO: registrar pago en base de datos
            }
        }
    }
}