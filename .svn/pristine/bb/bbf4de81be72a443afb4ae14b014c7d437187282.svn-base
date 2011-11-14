using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Model;
using System.Data.SqlClient;
using System.Data;

namespace BoletoElectronicoDesktop.Datos
{
    class DalTarjeta
    {
        public static int nuevoId()
        {
            return (1 + Datos.DalGral.GetDataReaderInt("select max(TARJETA_NRO) from mozilla.Tarjetas"));
        }

        public static int ultimoId()
        {
            return (Datos.DalGral.GetDataReaderInt("select max(TARJETA_NRO) from mozilla.Tarjetas"));
        }

        public static void AltaTarjeta(Tarjeta unaTarjeta)
        {
            SqlConnection objCon = new SqlConnection(DalGral.strCon);
            SqlCommand comando = new SqlCommand("mozilla.AltaTarjeta", objCon);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nroTarjeta", unaTarjeta.NroTarjeta);
            comando.Parameters.AddWithValue("@fecha", unaTarjeta.Fecha);
            comando.Parameters.AddWithValue("@clienteId", unaTarjeta.ClienteResponsable.Id);

            try
            {
                objCon.Open();
                comando.ExecuteNonQuery();
            }
                catch (SqlException sqlex)
            {
                if (sqlex.Number == 2627)
                    throw new Exception("El cliente ya tiene asociado una tarjeta.");
            }
            catch
            {
                throw new Exception("No se pudo realizar la operación");
            }
            finally
            {
                if (objCon.State == ConnectionState.Open)
                    objCon.Close();
            }
        }

        public static DataTable getTarjetas(Tarjeta unaTarjeta)
        {
            String strConsulta = "select t.TARJETA_NRO [Nro tarjeta], t.TARJETA_FECHA_ALTA [Fecha Alta], t.CLIENTE_ID [Id de cliente], t.HABILITADA [Estado], t.TARJETA_ID from mozilla.tarjetas t ";
            return DalGral.getDataTable(strConsulta + generarWhere(unaTarjeta));
        }

        private static String generarWhere(Tarjeta unaTarjeta)
        {
            String where = " where TARJETA_NRO like '{0}%' and TARJETA_FECHA_ALTA like {1} and CLIENTE_ID like '{2}'";
            return String.Format(where, unaTarjeta.NroTarjeta == 0 ? "" : unaTarjeta.NroTarjeta.ToString(), unaTarjeta.Fecha != DateTime.MinValue ? ("convert(datetime,'" + unaTarjeta.Fecha.ToString("dd/MM/yyyy") + "')") : "'%'", unaTarjeta.ClienteResponsable != null ? unaTarjeta.ClienteResponsable.Id.ToString() : "%");
            //convert(datetime,'01/01/2005')
        }

        public static void updateTarjeta(Tarjeta tarjeta)
        {
            SqlConnection objCon = new SqlConnection(DalGral.strCon);
            SqlCommand comando = new SqlCommand("mozilla.editarTarjeta", objCon);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idTarjeta", tarjeta.IdTarjeta);
            comando.Parameters.AddWithValue("@nroTarjeta", tarjeta.NroTarjeta);
            comando.Parameters.AddWithValue("@clienteId", tarjeta.ClienteResponsable.Id);
            comando.Parameters.AddWithValue("@estado", tarjeta.Estado);

            try
            {
                objCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                if (sqlex.Number == 2627)
                throw new Exception("nro de tarjeta repetido / el cliente ya posee tarjeta");
            }
            catch
            {
                throw new Exception("No se pudo realizar la operación");
            }
            finally
            {
                if (objCon.State == ConnectionState.Open)
                    objCon.Close();
            }

        }
    }
}
