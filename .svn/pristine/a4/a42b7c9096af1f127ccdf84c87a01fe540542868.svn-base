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
	public partial class FormAbmClienteMod : Form
	{
		private string cliDniMod = "";
		private string sucNuevaId = "";
		
		public FormAbmClienteMod()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable tabla;
			string query = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, per.CLI_MAIL, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
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
					query += "AND per.CLI_NOMB = " + "'" + txtNombre.Text + "' ";
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
			cliDniMod = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);

			txtNombreMod.Text = (Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value)).Trim();
			txtApellidoMod.Text = (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value)).Trim();
			txtDniMod.Text = cliDniMod;
			txtMailMod.Text = (Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value)).Trim();

			//OBS: este query es para mostrar aquellas sucursales donde NO esta el cliente
			string query = "SELECT s.BANC_NOM, s.BANC_DIR, s.BANC_DIR_NRO, s.SUC_ID "
										+"FROM sucursales_banco s "
										+"EXCEPT "
										+"SELECT s.BANC_NOM, s.BANC_DIR, s.BANC_DIR_NRO, s.SUC_ID "
										+"FROM sucursales_banco s, clientes c "
										+"WHERE c.CLI_ESTADO = 1 "
										+"AND c.SUC_ID = s.SUC_ID "
										+ "AND c.CLI_DNI = " + cliDniMod;
			
			DataTable tabla;
			try
			{
				tabla = SqlConnector.Instance.ejecutarQuery(query);
				dataGridView2.DataSource = tabla;
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}

			
		}

		private void FormAbmClienteMod_Load(object sender, EventArgs e)
		{
			DataTable tabla;
			string query = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, per.CLI_MAIL, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
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

		private void button2_Click(object sender, EventArgs e)
		{
			if (cliDniMod == "")
			{
				MessageBox.Show("No se ha seleccionado ningun cliente");
				return;
			}
			
			if (txtNombreMod.Text == "" || txtApellidoMod.Text=="" ||
					txtMailMod.Text == ""	)
			{
				MessageBox.Show("Algun campo de modificar esta vacio");
				return;
			}

			string query = "UPDATE personas SET "
									 + "CLI_NOMB = '" + txtNombreMod.Text + "',"
									 + "CLI_APELLIDO = '" + txtApellidoMod.Text + "',"
									 + "CLI_MAIL = '" + txtMailMod.Text + "' "
									 + "WHERE CLI_DNI = " + cliDniMod;

			try
			{
				SqlConnector.Instance.ejecutarSoloQuery(query);
				MessageBox.Show("El cliente ha sido modificado");
				
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}


			//OBS: REFRESCA EL DATAGRID CON LOS DATOS MODIFICADOS
			DataTable tabla;
			string query2 = "SELECT per.CLI_NOMB, per.CLI_APELLIDO, cl.CLI_DNI, per.CLI_MAIL, suc.BANC_NOM, suc.BANC_DIR, suc.BANC_DIR_NRO, cl.SUC_ID, suc.BANC_CUIT, cl.CLI_ID "
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
				dataGridView2.DataSource = null;
				dataGridView2.Refresh();
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}
			
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string sucNueva="";
			sucNueva += (Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value)).Trim();
			sucNueva += " --- ";
			sucNueva += (Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value)).Trim();
			sucNueva += " ";
			sucNueva += Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value);
			//sucNueva += " ";
			//sucNueva += Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);

			txtSucNueva.Text = sucNueva;

			sucNuevaId = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (sucNuevaId == "")
			{
				MessageBox.Show("Seleccione Sucursal Nueva");
				return;
			}

			string query = "";

			query += "INSERT INTO clientes ";
			query += "(CLI_DNI, CLI_COD, SUC_ID)";
			query += "values (" + txtDniMod.Text + "," + "0000" + "," + sucNuevaId + ")";
			//TODO: VER COMO ASIGNARLE UN CLI_COD AL CLIENTE!!!!

			try
			{
				SqlConnector.Instance.ejecutarSoloQuery(query);
				MessageBox.Show("Sucursal Agregada con exito");
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}

			//OBS: este query es para mostrar aquellas sucursales donde NO esta el cliente
			string query2 = "SELECT s.BANC_NOM, s.BANC_DIR, s.BANC_DIR_NRO, s.SUC_ID "
										+ "FROM sucursales_banco s "
										+ "EXCEPT "
										+ "SELECT s.BANC_NOM, s.BANC_DIR, s.BANC_DIR_NRO, s.SUC_ID "
										+ "FROM sucursales_banco s, clientes c "
										+ "WHERE c.CLI_ESTADO = 1 "
										+ "AND c.SUC_ID = s.SUC_ID "
										+ "AND c.CLI_DNI = " + cliDniMod;

			DataTable tabla;
			try
			{
				tabla = SqlConnector.Instance.ejecutarQuery(query2);
				dataGridView2.DataSource = tabla;
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString());
				return;
			}
			txtSucNueva.Text = "";
			sucNuevaId = "";
		}

	}
}