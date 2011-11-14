using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.ConsultaPlazoFijo
{
    public partial class FormConsultaPlazoFijo : Form
    {

        private String Campos = "", Tablas = "", Condiciones = "";

        private String Query = "";

        private Boolean First;

        public DataTable tabla;


        public FormConsultaPlazoFijo()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormConsultaPlazoFijo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializacione de variables
            Query = ""; Campos = ""; Tablas = ""; Condiciones = ""; First = false;

            Campos += " cli.CLI_COD, per.CLI_NOMB, per.CLI_APELLIDO, cli.CLI_DNI, " +
                "sucus.BANC_NOM, sucus.BANC_DIR, sucus.BANC_DIR_NRO, pf.PF_IMPOR, pf.PF_FCREA, " +
                "pf.PF_FFIN, pf.PF_ESTADO, dbo.INTERESGANADO(pf.PF_FCREA, pf.PF_FFIN, pf.PF_IMPOR) ";

            Tablas += " dbo.clientes cli, dbo.sucursales_banco sucus, dbo.plazosfijos pf, dbo.personas per ";

            if (!string.IsNullOrEmpty(tbDNI.Text))
            {
                Condiciones += " cli.CLI_DNI = " + tbDNI.Text;

                Condiciones += " AND per.CLI_DNI = " + tbDNI.Text;

                First = true;
            }

            if (!string.IsNullOrEmpty(tbNOM.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " per.CLI_NOMB = " + "'" + tbNOM.Text + "'";
            }

            if (!string.IsNullOrEmpty(tbAPE.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " per.CLI_APELLIDO = " + "'" + tbAPE.Text + "'";
            }

            if (!string.IsNullOrEmpty(tbBANCO.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " sucus.BANC_NOM = " + "'" + tbBANCO.Text + "'";
            }

            if (!string.IsNullOrEmpty(tbSUCUDIR.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones +=  " sucus.BANC_DIR = " + "'" + tbSUCUDIR.Text + "'";
            }

            if (!string.IsNullOrEmpty(tbSUCUNUM.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " sucus.BANC_DIR_NRO = " + tbSUCUNUM.Text;
            }

            if (!string.IsNullOrEmpty(tbFECCREA.Text) & !string.IsNullOrEmpty(tbFECFIN.Text))
            {
                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " pf.PF_FCREA = " + tbFECCREA.Text;

                if (First) Condiciones += " AND "; else First = true;

                Condiciones += " pf.PF_FFIN = " + tbFECFIN.Text;
            }

            if (First)
            {
                if (string.IsNullOrEmpty(tbDNI.Text))
                {
                    Condiciones += " AND cli.CLI_DNI = per.CLI_DNI ";
                }

                Condiciones += " AND pf.CLI_ID = cli.CLI_ID AND cli.SUC_ID = sucus.SUC_ID AND pf.PF_ESTADO = 1 AND cli.CLI_ESTADO = 1 ";

                Query = string.Format(" SELECT {0} FROM {1} WHERE {2} ", Campos, Tablas, Condiciones);

                // Para ver el query justo antes de mandarlo a la bdd:
                //tbNOMAP.Text = Query;

                tabla = SqlConnector.Instance.ejecutarQuery(Query);

                dataGridView1.DataSource = tabla;

            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

	}

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}