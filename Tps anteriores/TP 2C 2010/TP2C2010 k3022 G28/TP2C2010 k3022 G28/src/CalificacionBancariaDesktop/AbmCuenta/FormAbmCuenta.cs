using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.AbmCuenta
{
    public partial class FormAbmCuenta : Form
    {
        public FormAbmCuenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAbmCuenta_Load(object sender, EventArgs e)
        {
            DataTable query;

            query = SqlConnector.Instance.ejecutarQuery("SELECT * FROM abm_cuentas");
            abm_cuenta.DataSource = query;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {


        }

        private void search_Click(object sender, EventArgs e)
        {
            string sqlCommand;
            DataTable query;

            if (nombre.Text == "" && apellido.Text == "" && dni.Text == "" &&
                banco.Text == "" && dir.Text == "" && num_dir.Text == "")
            {
                sqlCommand = "SELECT * FROM abm_cuentas";
            }
            else
            {
                sqlCommand = "SELECT * FROM abm_cuentas WHERE CUE_NRO is not null";
                if (nombre.Text != "") sqlCommand += " AND CLI_NOMB = '" + nombre.Text + "'";
                if (apellido.Text != "") sqlCommand += " AND CLI_APELLIDO = '" + apellido.Text + "'";
                if (dni.Text != "") sqlCommand += " AND CLI_DNI = " + dni.Text;
                if (banco.Text != "") sqlCommand += " AND BANC_NOM = '" + banco.Text + "'";
                if (dir.Text != "") sqlCommand += " AND BANC_DIR = '" + dir.Text + "'";
                if (num_dir.Text != "") sqlCommand += " AND BANC_DIR_NRO = " + num_dir.Text;
            }

            query = SqlConnector.Instance.ejecutarQuery(sqlCommand);
            abm_cuenta.DataSource = query;
        }

        private void abm_cuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[2].Value);
            apellido.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[3].Value);
            dni.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[4].Value);
            banco.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[5].Value);
            dir.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[6].Value);
            num_dir.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[7].Value);
            desde.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[0].Value);
            monto.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[8].Value);
            moneda_ori.Text = Convert.ToString(abm_cuenta.CurrentRow.Cells[9].Value);
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            string cue_nro;
            string sqlCommand;
            string confirm;
            double cot_o, cot_d;
            string proximaCuenta;
            if (abm_cuenta.RowCount != 0)
            {
                cue_nro = Convert.ToString(abm_cuenta.CurrentRow.Cells[0].Value);
                if (accion.Text == "Baja")
                {
                    confirm = "¿Desea deshabilitar la cuenta " + cue_nro + "?";
                    if (MessageBox.Show(confirm, "Deshabilitar Cuenta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        sqlCommand = "UPDATE dbo.cuentas SET CUE_ESTADO = 0 WHERE CUE_NRO = " + cue_nro;
                        abm_cuenta.DataSource = SqlConnector.Instance.ejecutarQuery(sqlCommand);
                    }

                }
                if (accion.Text == "Alta")
                {
                    if (transferir.Text != "" && moneda_dest.Text != "")
                    {
                        cot_o = get_cotizacion(moneda_ori.Text);
                        cot_d = get_cotizacion(moneda_dest.Text);

                        sqlCommand = "INSERT INTO dbo.Cuentas (CUE_SALDO, CUE_MONEDA_COD, CUE_NRO, CUE_FCREA, CLI_ID, CUE_ESTADO) VALUES ( ";
                        sqlCommand += Convert.ToString(cambio_moneda(Double.Parse(transferir.Text), cot_o, cot_d)) + " , ";
                        sqlCommand += getCodigoMoneda(moneda_dest.Text) + " , ";
                        proximaCuenta = getProximaCuenta();
                        sqlCommand += proximaCuenta + " , ";
                        sqlCommand += "GetDate() , ";
                        sqlCommand += Convert.ToString(abm_cuenta.CurrentRow.Cells[1].Value) + " , ";
                        sqlCommand += "1)";

                        SqlConnector.Instance.ejecutarQuery(sqlCommand);

                        sqlCommand = "UPDATE dbo.cuentas SET CUE_SALDO = " + Convert.ToString(Double.Parse(monto.Text) - Double.Parse(transferir.Text)) + " WHERE CUE_NRO = " + cue_nro;
                        SqlConnector.Instance.ejecutarQuery(sqlCommand);

                        MessageBox.Show("Número de cuenta creado " + proximaCuenta);
                    }
                    else
                    {
                        MessageBox.Show("Introducir un Monto Inicial y el tipo de moneda");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta primero.");
            }
        }

        private void FormAbmCuenta_Load_1(object sender, EventArgs e)
        {

        }

        private void accion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accion.Text == "Alta") transfer.Enabled = true;
            else transfer.Enabled = false;

        }

        private double get_cotizacion(string moneda)
        {

            string sqlCommand = "SELECT MONEDA_COTIZA FROM dbo.monedas WHERE MONEDA_DESC = '" + moneda + "'";
            DataTable respuesta;

            respuesta = SqlConnector.Instance.ejecutarQuery(sqlCommand);

            if (respuesta.Rows.Count == 0)
            {
                MessageBox.Show("Moneda no existente");
                return 0;
            }

            return Double.Parse(respuesta.Rows[0][0].ToString());
        }

        private double cambio_moneda(double monto, double origen, double destino)
        {
            return ((monto * origen) / destino);
        }

        private string getProximaCuenta()
        {
            DataTable respuesta;

            respuesta = SqlConnector.Instance.ejecutarQuery("SELECT MAX(CUE_NRO) FROM dbo.cuentas");

            return Convert.ToString((int.Parse(respuesta.Rows[0][0].ToString())) + 1);
        }

        private string getCodigoMoneda(string moneda)
        {

            string sqlCommand = "SELECT MONEDA_COD FROM dbo.monedas WHERE MONEDA_DESC = '" + moneda + "'";
            DataTable respuesta;

            respuesta = SqlConnector.Instance.ejecutarQuery(sqlCommand);

            if (respuesta.Rows.Count == 0)
            {
                MessageBox.Show("Moneda no existente");
                return "0";
            }

            return respuesta.Rows[0][0].ToString();
        }

    }
}