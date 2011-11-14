using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Datos;
using System.Data;

namespace BoletoElectronicoDesktop.Model
{
    class Rol
    {
        public const int _ROL_ADMIN = 1;

        private Boolean estado;
        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private int idRol;
        public int IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        Funcionalidades funcs;
        public Funcionalidades Funcs
        {
            get { return funcs; }
            set { funcs = value; }
        }

        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void altaRol()
        {
            try
            {
                DalRol.altaRol(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getRoles()
        {
            return DalRol.getRoles();
        }

        internal void actualizarRol()
        {
            try
            {
                DalRol.actualizarRol(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void getFuncionalidades()
        {
            Funcionalidades fns = new Funcionalidades();
            fns.LsFuncs = DalRol.getFuncionalidades(idRol);
            this.funcs = fns;
        }

        internal bool tieneFuncionalidad(int idFuncionalidad)
        {
            for (int i = 0; i < funcs.LsFuncs.Count;i++ )
            {
                if(Convert.ToInt32(funcs.LsFuncs[i]) == idFuncionalidad)
                {
                    return true;
                }
            }

            return false;
        }

        internal void eliminarRol()
        {
            this.Estado = false;
            DalRol.actualizarRol(this);
        }

        internal static DataTable getRolesHabilitados()
        {
            return DalRol.getRolesHabilitados();
        }
    }
}
