using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.OtorgacionPrestamos
{
    public partial class FormOtorgacionPrestamos : Form
    {

        private String Query;

        public FormOtorgacionPrestamos()
        {
            InitializeComponent();
        }

        private void FormOtorgacionPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query = "";

            if (string.IsNullOrEmpty(tbDNI.Text) | string.IsNullOrEmpty(tbBANCO.Text))
            {
                MessageBox.Show("Faltan parametros");
            }
            else
            {
                Query = " INSERT INTO DBO.PROCESO_OTORGACION_PRESTAMOS (CLI_DNI, ID_BANCO, FEC_PROCESO, MONTO) ";

                Query += " SELECT DISTINCT CLI_DNI, BANC_CUIT, GETDATE(), DBO.MONTO_MAXIMO_PRESTAMO(CLI_DNI, BANC_CUIT) ";

                Query += " FROM CLIENTES C, SUCURSALES_BANCO SUCUS";

                Query += " WHERE C.CLI_DNI = " + tbDNI.Text + " AND c.SUC_ID = SUCUS.SUC_ID AND SUCUS.BANC_CUIT = " + tbBANCO.Text;

                //tbBANCO.Text = Query;

                SqlConnector.Instance.ejecutarSoloQuery(Query);

                tbIDPrestamo.Text = getIDProceso();
            }

        }

        private string getIDProceso()
        {
            DataTable respuesta;

            respuesta = SqlConnector.Instance.ejecutarQuery("SELECT MAX(ID_PROCESO) FROM dbo.PROCESO_OTORGACION_PRESTAMOS");

            return Convert.ToString((int.Parse(respuesta.Rows[0][0].ToString())));
        }

    }
}