using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Model;
using System.Data.SqlClient;
using System.Data;

namespace BoletoElectronicoDesktop.Datos
{
    class DalCarga
    {
        public static void cargarTarjeta(Carga objCarga)
        {
            SqlConnection objCon = new SqlConnection(DalGral.strCon);
            SqlCommand comando = new SqlCommand("mozilla.cargarTarjeta", objCon);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nroTarjeta", objCarga.TarjetaUsada.NroTarjeta);
            comando.Parameters.AddWithValue("@fecha", objCarga.Fecha);
            comando.Parameters.AddWithValue("@monto", objCarga.Monto);

            try
            {
                objCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (objCon.State == ConnectionState.Open)
                    objCon.Close();
            }

        }
    }
}
