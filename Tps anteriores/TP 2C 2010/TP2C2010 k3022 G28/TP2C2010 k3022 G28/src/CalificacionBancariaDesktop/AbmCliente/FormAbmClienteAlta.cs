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
	public partial class FormAbmClienteAlta : Form
	{
		private string SUC_ID="";

		public FormAbmClienteAlta()
		{
			InitializeComponent();
			
		}


		private void button1_Click(object sender, EventArgs e)
		{
			string query="";

			if (txtApellido.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" ||
				 txtMail.Text == "" || SUC_ID == "")
			{
				MessageBox.Show("Alguno de los campos está vacio");
				return;
			}

			query += "INSERT INTO " + "personas ";
			query += "(CLI_DNI, CLI_NOMB, CLI_APELLIDO, CLI_MAIL)";
			query += "values (" + txtDNI.Text +",'"+ txtNombre.Text +"','";
			query += txtApellido.Text + "','" + txtMail.Text + "')";

			query += "; ";
			query += "INSERT INTO " + "clientes ";
			query += "(CLI_DNI, CLI_COD, SUC_ID)";
			query += "values (" + txtDNI.Text +","+ "0000" +","+ SUC_ID + ")";
			//TODO: VER COMO ASIGNARLE UN CLI_COD AL CLIENTE!!!!

			
			try
			{
				SqlConnector.Instance.ejecutarSoloQuery(query);
			}
			catch (Exception err)
			{
				MessageBox.Show("error!" + err.ToString() );
				return;
			}
			
			MessageBox.Show("Cliente agregado con exito!");
			return;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string datosSuc = "";

			datosSuc += Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
			datosSuc += " ";
			datosSuc += (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value)).Trim();
			datosSuc += " ";
			datosSuc += Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
			datosSuc += " ";
			datosSuc += Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
			datosSuc += " ";
			datosSuc += Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
			datosSuc += " ";

			txtSucursal.Text = datosSuc;
			SUC_ID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

			//Variable = DataGrid1[DataGrid1.CurrentRowIndex, NumeroColumna].ToString();
		}

		

		private void FormAbmClienteAlta_Load(object sender, EventArgs e)
		{
			DataTable tabla;

			//OBS: Select de prueba
			tabla = SqlConnector.Instance.ejecutarQuery("SELECT * from sucursales_banco");

			//OBS: Vuelco los datos del select en el datagrid
			dataGridView1.DataSource = tabla;
			
		}




	}
}