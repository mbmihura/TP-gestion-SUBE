using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Model;
using System.Collections;
using System.Data.SqlClient;

namespace BoletoElectronicoDesktop.Datos
{
    class DalCliente
    {
        public static Cliente getCliente(int nroId)
        {
            ArrayList cliente = Datos.DalGral.getListaDataReader("select CLIENTE_NOMBRE, CLIENTE_APELLIDO, CLIENTE_DNI, CLIENTE_MAIL, CLIENTE_TELEFONO, CLIENTE_CALLE, CLIENTE_NRO, CLIENTE_PISO, CLIENTE_DEPTO, CLIENTE_ID, PROVINCIA_ID, HABILITADO from mozilla.Clientes where CLIENTE_ID = " + nroId);
            Cliente unCliente = new Cliente();

            unCliente.Nombre = cliente[0].ToString();
            unCliente.Apellido = cliente[1].ToString();
            unCliente.Dni = Convert.ToInt32(cliente[2]);
            unCliente.Mail = cliente[3].ToString();
            unCliente.Telefono = cliente[4].ToString();

            Direccion unaDireccion = new Direccion();

            unaDireccion.Calle = cliente[5].ToString();
            unaDireccion.Nro = Convert.ToInt32(cliente[6]);
            unaDireccion.Piso = Convert.ToInt32(cliente[7]);
            unaDireccion.Dpto = cliente[8].ToString();
            unCliente.Dir = unaDireccion;

            unCliente.Id = Convert.ToInt32(cliente[9]);

            return unCliente;

        }

        public static DataTable getClientes(Cliente unCliente)
        {
            //String strConsulta = "select CLIENTE_NOMBRE Nombre,CLIENTE_APELLIDO Apellido,CLIENTE_TIPO_DNI [Tipo DNI],CLIENTE_DNI DNI,CLIENTE_MAIL Mail,CLIENTE_TELEFONO Telefono,CLIENTE_CALLE Calle,CLIENTE_NRO Nro,CLIENTE_PISO Piso,CLIENTE_DEPTO Departamento,CLIENTE_ID from mozilla.Clientes where {0} like '{1}%'";
            String strConsulta = "select CLIENTE_NOMBRE Nombre,CLIENTE_APELLIDO Apellido,CLIENTE_TIPO_DNI [Tipo DNI],CLIENTE_DNI DNI,CLIENTE_MAIL Mail,CLIENTE_TELEFONO Telefono,CLIENTE_CALLE Calle,CLIENTE_NRO Nro,CLIENTE_PISO Piso,CLIENTE_DEPTO Departamento,CLIENTE_ID from mozilla.Clientes ";
           
            return DalGral.getDataTable(strConsulta+ generarWhere(unCliente));
        }

        private static String generarWhere(Cliente unCliente)
        {
            String where = " where CLIENTE_NOMBRE like '{0}%' and CLIENTE_APELLIDO like'{1}%' and CLIENTE_DNI like'{2}%' and CLIENTE_MAIL like'{3}%' and CLIENTE_TELEFONO like'{4}%' and CLIENTE_CALLE like'{5}%' and CLIENTE_NRO like'{6}%' and CLIENTE_PISO like'{7}%' and CLIENTE_DEPTO like'{8}%' and CLIENTE_TIPO_DNI like'{9}%' and PROVINCIA_ID like'{10}%' and HABILITADO = 1";
            return String.Format(where, unCliente.Nombre, unCliente.Apellido, unCliente.Dni==0 ? "":unCliente.Dni.ToString(), unCliente.Mail, unCliente.Telefono, unCliente.Dir.Calle, unCliente.Dir.Nro==0 ? "":unCliente.Dir.Nro.ToString(), unCliente.Dir.Piso==0 ? "":unCliente.Dir.Piso.ToString(), unCliente.Dir.Dpto, unCliente.TipoDni, unCliente.Dir != null && unCliente.Dir.Provincia !=null ? unCliente.Dir.Provincia : "");

        }

        public static DataTable getClientesFiltradosAbmClientes(Cliente unCliente)
        {
            String strConsulta = "select c.CLIENTE_NOMBRE Nombre,c.CLIENTE_APELLIDO Apellido,c.CLIENTE_TIPO_DNI [Tipo DNI],c.CLIENTE_DNI DNI,c.CLIENTE_MAIL Mail,c.CLIENTE_TELEFONO Telefono,c.CLIENTE_CALLE Calle,c.CLIENTE_NRO Nro,c.CLIENTE_PISO Piso,c.CLIENTE_DEPTO Departamento,c.CLIENTE_ID, p.PROVINCIA_DESC, c.HABILITADO from mozilla.Clientes c, mozilla.Provincias p ";
            return DalGral.getDataTable(strConsulta + generarWhereClientes(unCliente));
        }
        private static String generarWhereClientes(Cliente unCliente)
        {
            String where = " where CLIENTE_NOMBRE like '{0}%' and CLIENTE_APELLIDO like'{1}%' and CLIENTE_TIPO_DNI like '{2}%' and CLIENTE_DNI like'{3}%' and c.PROVINCIA_ID = p.PROVINCIA_ID";
            return String.Format(where, unCliente.Nombre, unCliente.Apellido, unCliente.TipoDni, unCliente.Dni==0 ? "" : unCliente.Dni.ToString(), unCliente.Dir != null && unCliente.Dir.Provincia !=null ? unCliente.Dir.Provincia : "");

        }

        internal static DataTable getClientesPremium(int Anio)
        {
            SqlConnection objCon = null;
            try
            {
                ArrayList resultado = new ArrayList();

                objCon = new SqlConnection(DalGral.strCon);

                SqlCommand comando = new SqlCommand("mozilla.ClientesPremium", objCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@year", Anio);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dtRespuesta = new DataTable();
                da.Fill(dtRespuesta);
                return dtRespuesta;
            }
            catch
            {
                throw new Exception("No se pudo realizar la operación");
            }
            finally
            {
                if (objCon != null && objCon.State == ConnectionState.Open)
                    objCon.Close();
            }
        }
    }
}
