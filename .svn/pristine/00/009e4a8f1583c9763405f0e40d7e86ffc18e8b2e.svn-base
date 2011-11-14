using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CalificacionBancariaDesktop
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormPrincipal());
			
		}

	}  
	

}

namespace CalificacionBancariaDesktop.Connector
{
	class SqlConnector
	{
		static SqlConnector instance = null;

		private SqlConnection conn;

		private SqlConnection Conn
		{
			get { return this.conn; }
			set { this.conn = value; }
		}

		private string error;
		public string Error
		{
			get { return this.error; }
			set { this.error = value; }
		}

		private SqlConnector()
		{
			string strConn = "user id=gd;" +
                       "password=gd2010;server=(local)\\SQLSERVER2005;" +
												"Trusted_Connection=yes;" +
												"database=GD2C2010; " +
												//"connection timeout=900";
												"Connection Timeout=900";
			

			this.Conn = new SqlConnection(strConn);
			
			this.Conn.Open();
		}

		public static SqlConnector Instance
		{
			get
			{
				if (instance == null)
					instance = new SqlConnector();
				return instance;
			}
		}

		public DataTable ejecutarQuery(string query)
		{
			SqlCommand sqlCommand = new SqlCommand();

			sqlCommand.Connection = this.Conn;
			sqlCommand.CommandTimeout = 1200;
			sqlCommand.CommandText = query;

			SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.Conn);

			DataTable dataTable = new DataTable();
			dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

			dataAdapter.Fill(dataTable);

			return dataTable;
		}

		public void ejecutarSoloQuery(string query)
		{
			SqlCommand com = new SqlCommand();

			com.Connection = this.Conn;
			com.CommandTimeout = 1200;
			com.CommandText = query;

			com.ExecuteNonQuery();

			com.Dispose();

			com = null;
		}
	}
}
