using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.TransaccionEntreCuentas
{
    public partial class FormTransaccionEntreCuentas : Form
    {
        public FormTransaccionEntreCuentas()
        {
            InitializeComponent();
        }

        private void FormTransaccionEntreCuentas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCuentaDestino_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxMoneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCuentaO_Click(object sender, EventArgs e)
        {
        
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarOrigen_Click(object sender, EventArgs e)
        {
            string sqlCommand;
            DataTable query;

            if (this.textDniO.Text == "" || this.textBancoO.Text == "" || this.textDirO.Text == "" || this.textDirNroO.Text == "")
            {
                MessageBox.Show("Error: todos los campos deben estar completos");
            }
            else
            {
                sqlCommand = "select CUE_NRO from cuentas cue "
                            + "where (select CLI_ID from clientes clie "
                            + "inner join sucursales_banco sucur on "
                            + "sucur.SUC_ID = clie.SUC_ID "
                            + "where sucur.BANC_DIR = '" + textDirO.Text
                            + "' and sucur.BANC_DIR_NRO= '" + textDirNroO.Text
                            + "' and sucur.BANC_NOM = '" + textBancoO.Text
                            + "' and clie.CLI_DNI = '" + textDniO.Text
                            + "' ) = cue.CLI_ID";

                try
                {

                    query = SqlConnector.Instance.ejecutarQuery(sqlCommand);
                    this.DataBuscarCuentaOrigen.DataSource = query;
                }
                catch (Exception err)
                {
                    MessageBox.Show("error!" + err.ToString());

                }
            }

        }

        private void buscarDestino_Click(object sender, EventArgs e)
        {
            string sqlCommand;
            DataTable query;

            if (this.textDniD.Text == "" || this.textBancoD.Text == "" || this.textDirD.Text == "" || this.textDirNroD.Text == "")
            {
                MessageBox.Show("Error: todos los campos deben estar completos");
            }
            else
            {
                sqlCommand = "select CUE_NRO from cuentas cue "
                            + "where (select CLI_ID from clientes clie "
                            + "inner join sucursales_banco sucur on "
                            + "sucur.SUC_ID = clie.SUC_ID "
                            + "where sucur.BANC_DIR = '" + textDirD.Text
                            + "' and sucur.BANC_DIR_NRO= '" + textDirNroD.Text
                            + "' and sucur.BANC_NOM = '" + textBancoD.Text
                            + "' and clie.CLI_DNI = '" + textDniD.Text
                            + "' ) = cue.CLI_ID";

                try
                {

                    query = SqlConnector.Instance.ejecutarQuery(sqlCommand);
                    this.dataBuscarCuentaDestino.DataSource = query;
                }
                catch (Exception err)
                {
                    MessageBox.Show("error!" + err.ToString());

                }
            }

        }

        private void DataBuscarCuentaOrigen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cue_nro = Convert.ToString(DataBuscarCuentaOrigen.CurrentRow.Cells[0].Value);
            this.textNroCuentaO.Text = cue_nro;
                       
        }

        private void dataBuscarCuentaDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cue_nro = Convert.ToString(dataBuscarCuentaDestino.CurrentRow.Cells[0].Value);
            this.textNroCuentaD.Text = cue_nro;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (textNroCuentaO.Text == "" ||
                textMonto.Text == "" || TipoOp.Text == "" || textTipoMon.Text == "")
            {
                MessageBox.Show("Falta especificar datos");
            }

            else
            {
                string query;
                if (TipoOp.Text == "Deposito")
                {
                    try
                    {

                        query = "exec dbo.deposito @CUENTA= " + textNroCuentaO.Text
                            + " , @MONTO = " + textMonto.Text + " , @MONEDA= " + textTipoMon.Text;

                        SqlConnector.Instance.ejecutarSoloQuery(query);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show("error!" + err.ToString());

                    }
                }

                
                if (TipoOp.Text == "Extraccion")
                {
                    try
                    {

                        query = "exec dbo.extraccion @CUENTA=" + textNroCuentaO.Text
                            + " ,@MONTO =" + textMonto.Text + " ,@MONEDA=" + textTipoMon.Text;
                        SqlConnector.Instance.ejecutarSoloQuery(query);

                    }

                    catch (Exception err)
                    {
                        MessageBox.Show("error!" + err.ToString());

                    }

                }

                if (TipoOp.Text == "Transferencia")
                {
                    try
                    {
                        query = "exec dbo.transferencia @CUENTA_ORIGEN=" + textNroCuentaO.Text
                            + ",@CUENTA_DEST = " + textNroCuentaD.Text +
                            " ,@MONTO =" + textMonto.Text + " ,@MONEDA=" + textTipoMon.Text;

                        SqlConnector.Instance.ejecutarSoloQuery(query);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show("error!" + err.ToString());

                    }

                }
                     MessageBox.Show("Transaccion terminada");


            }
                    
                             
        }
        
        

     }
}