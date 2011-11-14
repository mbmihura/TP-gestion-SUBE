using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Model;
using BoletoElectronicoDesktop.Datos;
using System.Collections;
using System.Data;

namespace BoletoElectronicoDesktop.Model
{
    class Usuario
    {
        private Boolean estado;
        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private String user;
        public String User
        {
            get { return user; }
            set { user = value; }
        }

        private String pass;
        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private ArrayList unosRoles;
        public ArrayList UnosRoles
        {
            get { return unosRoles; }
            set { unosRoles = value; }
        }

        public String getErrores()
        {
            foreach (int idRol in unosRoles)
            {
                if (idRol == Rol._ROL_ADMIN)
                {
                    return DalUsuario.getErrores();
                }
            }

            return "";
        }

        internal bool loguear()
        {
            bool resultado = DalUsuario.loguear(this);

            idUsuario = DalUsuario.getId(this.user);

            return resultado;
        }

        internal bool intentoFallido()
        {
            try
            {
                DalUsuario.intentoFallido(this.idUsuario,-1);
                return DalUsuario.getEstado(this.IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        internal void intentoFallido(int p)
        {
            try
            {
                DalUsuario.intentoFallido(this.idUsuario,0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void alta()
        {
            DalUsuario.alta(this);
        }

        internal static DataTable getUsuarios()
        {
            return DalUsuario.getUsuarios();
        }

        internal void getRoles()
        {
            unosRoles = DalUsuario.getRoles(idUsuario);
        }

        internal bool tieneRol(int p)
        {
            for (int i = 0; i < unosRoles.Count; i++)
            {
                if (Convert.ToInt32(unosRoles[i]) == p)
                {
                    return true;
                }
            }

            return false;
        }

        internal void actualizarUsuario()
        {
            try
            {
                DalUsuario.actualizarUsuario(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void eliminarUsuario()
        {
            this.Estado = false;
            this.actualizarUsuario();
        }
    }
}
