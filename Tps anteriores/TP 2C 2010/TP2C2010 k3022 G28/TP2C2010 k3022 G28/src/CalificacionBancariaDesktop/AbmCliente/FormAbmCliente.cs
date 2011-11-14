using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CalificacionBancariaDesktop.Connector;

namespace CalificacionBancariaDesktop.AbmCliente
{
	public partial class FormAbmCliente : Form
	{
		public FormAbmCliente()
		{
			InitializeComponent();
		}

		private void FormAbmCliente_Load(object sender, EventArgs e)
		{

		}

		private void botonAlta_Click(object sender, EventArgs e)
		{
			FormAbmClienteAlta form = new FormAbmClienteAlta();
			form.ShowDialog(this);
		}

		private void botonBaja_Click(object sender, EventArgs e)
		{
			FormAbmClienteBaja form = new FormAbmClienteBaja();
			form.ShowDialog(this);
		}

		private void botonModificacion_Click(object sender, EventArgs e)
		{
			FormAbmClienteMod form = new FormAbmClienteMod();
			form.ShowDialog(this);
		}

	}
}
