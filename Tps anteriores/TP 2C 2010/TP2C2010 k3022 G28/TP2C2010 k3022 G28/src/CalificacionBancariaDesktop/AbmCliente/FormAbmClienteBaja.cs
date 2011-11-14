using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.AbmCliente
{
	public partial class FormAbmClienteBaja : Form
	{
		private string cliBajaId = "";
		//private string cliBajaBancoCuil = "";

		public FormAbmClienteBaja()
		{
			InitializeComponent();
		}

		private void FormAbmClienteBaja_Load(object sender, EventArgs e)
		{
			DataTable tabla;
			string query = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
										+ "FROM clientes cl "
										+ "INNER JOIN personas per "
										+ "ON cl.CLI_DNI = per.CLI_DNI "
										+ "INNER JOIN sucursales_banco suc "
										+ "ON suc.SUC_ID = cl.SUC_ID "
										+ "WHERE cl.CLI_ESTADO = 1";

			try
			{
				tabla = SqlConnector.Instance.ejecutarQuery(query);
				dataGridView1.DataSource = tabla;
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}

		}



		private void button1_Click(object sender, EventArgs e)
		{
			DataTable tabla;
			string query = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
										+ "FROM clientes cl "
										+ "INNER JOIN personas per "
										+ "ON cl.CLI_DNI = per.CLI_DNI "
										+ "INNER JOIN sucursales_banco suc "
										+ "ON suc.SUC_ID = cl.SUC_ID "
										+ "WHERE cl.CLI_ESTADO = 1";

			if (!(txtNombre.Text == "" && txtApellido.Text == "" && txtDni.Text == "" &&
					txtBanco.Text == "" && txtBancDir.Text == "" && txtBancDirNro.Text == ""))
			{
				if (txtNombre.Text != "") 
					query += "AND per.CLI_NOMB = " +"'"+ txtNombre.Text +"' ";
				if (txtApellido.Text != "")
					query += "AND per.CLI_APELLIDO = " + "'" + txtApellido.Text + "' ";
				if (txtDni.Text != "")
					query += "AND per.CLI_DNI = " + txtDni.Text + " ";
				if (txtBanco.Text != "")
					query += "AND suc.BANC_NOM = " + "'" + txtBanco.Text + "' ";
				if (txtBancDir.Text != "")
					query += "AND suc.BANC_DIR = " + "'" + txtBancDir.Text + "' ";
				if (txtBancDirNro.Text != "")
					query += "AND suc.BANC_DIR_NRO = " + txtBancDirNro.Text + " ";
			}
		
			try
			{
				tabla = SqlConnector.Instance.ejecutarQuery(query);
				dataGridView1.DataSource = tabla;
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}
			//MessageBox.Show("Filtrado realizado con exito!");
			return;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string datosCli = "";

			datosCli += "Nombre: ";
			datosCli += (Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value)).Trim();
			datosCli += " Apellido: ";
			datosCli += (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value)).Trim();
			datosCli += " DNI: ";
			datosCli += Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
			datosCli += " --- ";
			datosCli += (Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value)).Trim();
			datosCli += " Direccion Sucursal: ";
			datosCli += " ";
			datosCli += (Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value)).Trim();
			datosCli += " ";
			datosCli += Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
			datosCli += " ";

			txtCliente.Text = datosCli;

			cliBajaId = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);			
		}

		private void button2_Click(object sender, EventArgs e)
		{			
			if (cliBajaId == "")
			{
				MessageBox.Show("No se ha seleccionado ningun cliente");
				return;
			}

			string query = "UPDATE clientes SET CLI_ESTADO = 0 WHERE CLI_ID = " + cliBajaId
									 +" UPDATE cuentas SET CUE_ESTADO = 0 WHERE CLI_ID = " + cliBajaId
									 +" UPDATE plazosfijos SET PF_ESTADO = 0 WHERE CLI_ID = " + cliBajaId;

			try
			{
				SqlConnector.Instance.ejecutarSoloQuery(query);
				MessageBox.Show("El cliente ha sido dado de baja de la sucursal");
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}


			DataTable tabla;
			string query2 = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
										+ "FROM clientes cl "
										+ "INNER JOIN personas per "
										+ "ON cl.CLI_DNI = per.CLI_DNI "
										+ "INNER JOIN sucursales_banco suc "
										+ "ON suc.SUC_ID = cl.SUC_ID "
										+ "WHERE cl.CLI_ESTADO = 1";
			try
			{
				tabla = SqlConnector.Instance.ejecutarQuery(query2);
				dataGridView1.DataSource = tabla;
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}

			txtCliente.Text = "";
			cliBajaId = "";

		}

	}
}