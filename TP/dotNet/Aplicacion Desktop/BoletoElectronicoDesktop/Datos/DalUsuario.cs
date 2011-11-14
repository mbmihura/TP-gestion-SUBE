using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace BoletoElectronicoDesktop.Datos
{
    class DalUsuario
    {
        internal static string getErrores()
        {
            try
            {
                ArrayList documentos = DalGral.getListaDataColumnReader("SELECT CLIENTE_DNI FROM mozilla.Clientes WHERE CLIENTE_DNI < 0");
                if (documentos.Count > 0)
                {
                    String error = "el/Los doscumento/s {0} es/son incorrecto/s. Contáctese con su administrador DBA para resolver la situación";
                    String docs = "";
                    for (int i = 0; i < documentos.Count; i++)
                    {
                        docs = docs + documentos[i].ToString() + "; ";
                    }
                    return String.Format(error, docs);
                }
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


        internal static bool loguear(BoletoElectronicoDesktop.Model.Usuario usuario)
        {
            try{

                return DalGral.GetDataReaderBool("select * from mozilla.usuarios u where u.HABILITADO = 1 and u.USUARIO_NOMBRE = '" + usuario.User + "' and u.USUARIO_PASSWORD = '" + usuario.Pass+"'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static void intentoFallido(int idUsuario, int cant)
        {
            try{
                int intentos = DalGral.GetDataReaderInt("select USUARIO_INTENTOS_FALLIDOS from mozilla.Usuarios");
                intentos++;
                intentos = cant == 0 ? cant : intentos;
                DalGral.ExcecuteNonQuery("update mozilla.Usuarios set USUARIO_INTENTOS_FALLIDOS = "+intentos+" where USUARIO_ID = "+idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static int getId(string p)
        {
            try
            {

                return DalGral.GetDataReaderInt("select USUARIO_ID from mozilla.Usuarios where USUARIO_NOMBRE = '" + p + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static bool getEstado(int p)
        {
            return DalGral.GetDataReaderBool("select USUARIO_ID from mozilla.Usuarios where HABILITADO = 1 and USUARIO_ID = "+p);
        }

        internal static void alta(BoletoElectronicoDesktop.Model.Usuario usuario)
        {
            SqlTransaction trans = null;
            SqlConnection objCon = null;
            SqlCommand comando = null;

            try
            {
                int idIngresado = DalGral.GetDataReaderInt("select MAX(USUARIO_ID) from mozilla.Usuarios");
                idIngresado++;
                objCon = new SqlConnection(DalGral.strCon);
                objCon.Open();
                trans = objCon.BeginTransaction();
                comando = new SqlCommand(String.Format("insert into mozilla.Usuarios (USUARIO_ID,USUARIO_NOMBRE,USUARIO_PASSWORD) values ({0},'{1}','{2}')", idIngresado,usuario.User, Encriptar.sha256(usuario.Pass)), objCon, trans);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();

                foreach (Object idRol in usuario.UnosRoles)
                {
                    insertarRoles(idIngresado, Convert.ToInt32(idRol), comando);
                }

                trans.Commit();
            }
            catch (SqlException sqlex)
            {
                try
                {
                    trans.Rollback();
                }
                catch
                {
                    throw new Exception("No se pudo realizar la operación");
                }
                if (sqlex.Number == 2627)
                    throw new Exception("El rol ya existe!");
            }
            catch (Exception ex)
            {
                try
                {
                    trans.Rollback();
                }
                catch
                {
                    throw new Exception("No se pudo realizar la operación");
                }
                String a = ex.Message;
                throw new Exception("No se pudo realizar la operación");
            }
            finally
            {
                if (objCon.State == ConnectionState.Open)
                    objCon.Close();
            }
        }

        private static void insertarRoles(int idIngresado, int idRol, SqlCommand comando)
        {
            comando.CommandText = String.Format("insert into mozilla.UsuarioRol (USUARIO_ID,ROL_ID) values ('{0}','{1}')", idIngresado, idRol);
            comando.CommandType = CommandType.Text;

            comando.Parameters.Clear();

            comando.ExecuteNonQuery();
        }

        internal static DataTable getUsuarios()
        {
            return DalGral.getDataTable("select u.USUARIO_NOMBRE, u.HABILITADO, u.USUARIO_ID from mozilla.Usuarios u");
        }

        internal static ArrayList getRoles(int idUsuario)
        {
            return DalGral.getListaDataColumnReader(String.Format("select u.ROL_ID, r.ROL_NOMBRE from mozilla.usuarioRol u join mozilla.Roles r on r.ROL_ID = u.ROL_ID where USUARIO_ID = {0}",idUsuario));
        }

        internal static void actualizarUsuario(BoletoElectronicoDesktop.Model.Usuario usuario)
        {
            SqlTransaction trans = null;
            SqlConnection objCon = null;
            SqlCommand comando = null;

            try
            {
                objCon = new SqlConnection(DalGral.strCon);
                objCon.Open();
                trans = objCon.BeginTransaction();
                if (usuario.Pass != null && usuario.Pass != "")
                {
                    comando = new SqlCommand(String.Format("update mozilla.Usuarios set USUARIO_PASSWORD = '{0}', HABILITADO = {1} where USUARIO_ID = {2}", Encriptar.sha256(usuario.Pass),usuario.Estado ? 1 : 0, usuario.IdUsuario), objCon, trans);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
                else
                {
                    comando = new SqlCommand(String.Format("update mozilla.Usuarios set HABILITADO = {0} where USUARIO_ID = {1}", usuario.Estado ? 1 : 0, usuario.IdUsuario), objCon, trans);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }

                comando.CommandText = String.Format("delete mozilla.UsuarioRol where USUARIO_ID = {0}", usuario.IdUsuario);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Clear();

                comando.ExecuteNonQuery();

                foreach (Object idRol in usuario.UnosRoles)
                {
                    insertarRoles(usuario.IdUsuario, Convert.ToInt32(idRol), comando);
                }

                trans.Commit();
            }
            catch (SqlException sqlex)
            {
                try
                {
                    trans.Rollback();
                }
                catch
                {
                    throw new Exception("No se pudo realizar la operación");
                }
                if (sqlex.Number == 2627)
                    throw new Exception("El rol ya existe!");
            }
            catch (Exception ex)
            {
                try
                {
                    trans.Rollback();
                }
                catch
                {
                    throw new Exception("No se pudo realizar la operación");
                }
                String a = ex.Message;
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
