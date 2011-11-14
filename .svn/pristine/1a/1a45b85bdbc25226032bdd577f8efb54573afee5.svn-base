using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.CalidadClientes
{
    public partial class FormCalidadClientes : Form
    {
        public FormCalidadClientes()
        {
            InitializeComponent();
        }

			private void button1_Click(object sender, EventArgs e)
			{
				txtId.Text = "";
				txtId.Text += (DateTime.Now.Hour).ToString();
				txtId.Text += (DateTime.Now.Minute).ToString();
				txtId.Text += (DateTime.Now.Second).ToString();
				txtId.Text += (DateTime.Now.Millisecond).ToString();

				if (txtDni.Text == "") txtDni.Text = "0";

				string query = "exec proc_calidad_clientes "
											+ txtId.Text + ", "
											+ txtDni.Text;

				try
				{
					SqlConnector.Instance.ejecutarSoloQuery(query);
					MessageBox.Show("Proceso Calidad Clientes Finalizado");

				}
				catch (Exception err)
				{
					MessageBox.Show("error!" + err.ToString());
					return;
				}

			}

			private void button2_Click(object sender, EventArgs e)
			{

				string query = "UPDATE cuentas SET CUE_SALDO = dbo.calcular_saldo(CUE_NRO)";

				try
				{
					SqlConnector.Instance.ejecutarSoloQuery(query);
					MessageBox.Show("Saldo de cuentas actualizado");

				}
				catch (Exception err)
				{
					MessageBox.Show("error!" + err.ToString());
					return;
				}

			}
    }
}