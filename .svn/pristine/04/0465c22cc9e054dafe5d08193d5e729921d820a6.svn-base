using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Model;
using System.Data.SqlClient;
using System.Collections;

namespace BoletoElectronicoDesktop.Datos
{
    class DalRol
    {
        public static DataTable getFuncionalidades()
        {
            return Datos.DalGral.getDataTable("select f.FUNCIONALIDAD_ID, f.FUNCIONALIDAD_NOMBRE from mozilla.Funcionalidades f");
        }


        public static void altaRol(Rol rol)
        {
            SqlTransaction trans = null;
            SqlConnection objCon = null;
            SqlCommand comando = null;

            try
            {
                objCon = new SqlConnection(DalGral.strCon);
                objCon.Open();
                trans = objCon.BeginTransaction();
                comando = new SqlCommand("mozilla.AltaRol", objCon, trans);
                comando.CommandType = CommandType.StoredProcedure;

                int idMax = DalGral.GetDataReaderInt("select max(r.ROL_ID) from mozilla.Roles r");
                idMax++;

                comando.Parameters.AddWithValue("@maxId", idMax);
                comando.Parameters.AddWithValue("@nombreRol", rol.Nombre);

            
                
                comando.ExecuteNonQuery();

                foreach (int idFuncionalidad in rol.Funcs.LsFuncs)
                {
                    insertarFuncionalidades(idMax, idFuncionalidad, comando, rol.Funcs);
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

        private static void insertarFuncionalidades(int idMax,int idFunc,SqlCommand comando, Funcionalidades funcionalidades)
        {
            comando.CommandText ="mozilla.AltaRolFuncionalidad";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@maxId", idMax);
            comando.Parameters.AddWithValue("@funcId", idFunc);

            comando.ExecuteNonQuery();
        }

        public static DataTable getRoles()
        {
            return DalGral.getDataTable("Select r.ROL_NOMBRE [Nombre de rol], r.HABILITADO estado, r.ROL_ID from mozilla.Roles r");
        }

        public static DataTable getRolesHabilitados()
        {
            return DalGral.getDataTable("Select r.ROL_NOMBRE Nombre, r.ROL_ID ID from mozilla.Roles r where r.HABILITADO = 1");
        }

        internal static void actualizarRol(Rol rol)
        {
            SqlTransaction trans = null;
            SqlConnection objCon = null;
            SqlCommand comando = null;

            try
            {
                objCon = new SqlConnection(DalGral.strCon);
                objCon.Open();
                trans = objCon.BeginTransaction();
                comando = new SqlCommand("mozilla.editarRol", objCon, trans);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idRol", rol.IdRol);
                comando.Parameters.AddWithValue("@rolNombre", rol.Nombre);
                comando.Parameters.AddWithValue("@estado", rol.Estado);

                comando.ExecuteNonQuery();

                eliminarFuncionalidades(rol.IdRol, comando);

                foreach (Object idFuncionalidad in rol.Funcs.LsFuncs)
                {
                    insertarFuncionalidades(rol.IdRol, Convert.ToInt32(idFuncionalidad), comando, rol.Funcs);
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

        private static void eliminarFuncionalidades(int p, SqlCommand comando)
        {
            comando.CommandText = "mozilla.borrarRolFuncionalidad";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@idRol", p);

            comando.ExecuteNonQuery();
        }

        internal static ArrayList getFuncionalidades(int idRol)
        {
            return Datos.DalGral.getListaDataColumnReader("select f.FUNCIONALIDAD_ID from mozilla.Funcionalidades f join mozilla.RolFuncionalidad rf on rf.FUNCIONALIDAD_ID = f.FUNCIONALIDAD_ID where rf.ROL_ID = " + idRol);
        }
    }
}
