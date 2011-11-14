using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.TarjetasPremium
{
    public partial class FormTarjetasPremium : Form
    {
        public FormTarjetasPremium()
        {
            InitializeComponent();
        }

        private void FormTarjetasPremium_Load(object sender, EventArgs e)
        {
            anio_nud.Value = DateTime.Now.Year;
        }

        private void mostrar_cmd_Click(object sender, EventArgs e)
        {
            buscarClientePremium((int)anio_nud.Value, this.dataGridView1);
        }

        private void buscarClientePremium(int anio, DataGridView dg)
        {

            DataTable tabla;
            try
            {
                tabla = DalCliente.getClientesPremium(anio);
                dg.DataSource = tabla;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Consulta - Clientes premium", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
