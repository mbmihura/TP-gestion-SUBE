using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace BoletoElectronicoDesktop.Datos
{
    class DalGral
    {
        //Server=myServerAddress;Database=myDataBase;User ID=myUsername;Password=myPassword;Trusted_Connection=False;
        //TODO: momentaneamente cambio trusted_coneection a false para que funcione DalGral
        public static string strCon = @"Server=localhost\SQLSERVER2005; Database=GD2C2011;User ID=gd;Password=gd2011;Trusted_Connection=false;";

        public static bool GetDataReaderBool(string strConsulta)
        {
            bool resultado = false;

            SqlConnection unaConexion = new SqlConnection(strCon);
            SqlDataReader dr;

            string strSQL = strConsulta;
            SqlCommand comando = new SqlCommand(strSQL, unaConexion);
            comando.CommandType = CommandType.Text;

            try
            {
                unaConexion.Open();
                dr = comando.ExecuteReader();
                resultado = dr.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                if (unaConexion.State == ConnectionState.Open)
                    unaConexion.Close();
            }
            return resultado;
        }

        public static int GetDataReaderInt(string strConsulta)
        {
            int resultado = 0;

            SqlConnection unaConexion = new SqlConnection(strCon);
            SqlDataReader dr;

            string strSQL = strConsulta;
            SqlCommand comando = new SqlCommand(strSQL, unaConexion);
            comando.CommandType = CommandType.Text;

            try
            {
                unaConexion.Open();
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    resultado = Convert.ToInt32(dr.GetValue(0) != null ? dr.GetValue(0) : 0);
                }
                else
                {
                    resultado = 0;
                }
            }

            catch (SqlException sqlex)
            {
                throw new Exception("SQL: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (unaConexion.State == ConnectionState.Open)
                    unaConexion.Close();
            }
            return resultado;
        }

        public static ArrayList getListaDataReader(string strConsulta)
        {
            ArrayList resultado = new ArrayList();

            SqlConnection unaConexion = new SqlConnection(strCon);
            SqlDataReader dr;

            string strSQL = strConsulta;
            SqlCommand comando = new SqlCommand(strSQL, unaConexion);
            comando.CommandType = CommandType.Text;

            try
            {
                unaConexion.Open();
                dr = comando.ExecuteReader();
                int a = dr.FieldCount;
                int b = 0;

                dr.Read();
                while (b < a)
                {
                    resultado.Add(dr.GetValue(b).ToString());
                    b++;
                }
            }

            catch (SqlException sqlex)
            {
                throw new Exception("SQL: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (unaConexion.State == ConnectionState.Open)
                    unaConexion.Close();
            }

            return resultado;
        }

        public static ArrayList getListaDataColumnReader(string strConsulta)
        {
            ArrayList resultado = new ArrayList();

            SqlConnection unaConexion = new SqlConnection(strCon);
            SqlDataReader dr;

            string strSQL = strConsulta;
            SqlCommand comando = new SqlCommand(strSQL, unaConexion);
            comando.CommandType = CommandType.Text;

            try
            {
                unaConexion.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    resultado.Add(dr.GetValue(0).ToString());
                }
            }

            catch (SqlException sqlex)
            {
                throw new Exception("SQL: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (unaConexion.State == ConnectionState.Open)
                    unaConexion.Close();
            }

            return resultado;
        }

        public static DataTable getDataTable(string strConsulta)
        {
            SqlConnection unaConexion = new SqlConnection(strCon);
            SqlCommand command = new SqlCommand(strConsulta, unaConexion);
            command.CommandTimeout = 1200;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dtRespuesta = new DataTable();
                da.Fill(dtRespuesta);
                return dtRespuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                command.Dispose();
            }
        }

        public static DataSet getDataSet(string strConsulta)
        {
            DataSet dtRespuesta = new DataSet();
            string srtSQL = strConsulta;
            SqlDataAdapter da = new SqlDataAdapter(srtSQL, strCon);
            da.Fill(dtRespuesta);
            return dtRespuesta;
        }

        /// <summary>Ejecuta una sentencia SQL que no devuelve datos de por si (SqlCommand.ExecuteNonQuery). Devuelve la cantidad de filas afectadas.</summary>
        public static int ExcecuteNonQuery(string sqlStament)
        {
            int resultado;

            SqlConnection unaConexion = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(sqlStament, unaConexion);
            comando.CommandType = CommandType.Text;

            try
            {
                unaConexion.Open();
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                if (unaConexion.State == ConnectionState.Open)
                    unaConexion.Close();
            }
            return resultado;
        }
    }
}
