using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Utils;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.Model
{
    public class Rubro
    {
        
        //public static Rubro Alta(string nombre)
        //{
        //    if (nombre != "")
        //    {
        //        DalRubros.Alta(nobre);
        //        return new Rubro(nombre); 
        //    }
        //    else
        //        throw new FaltaNombreRubroException();
        //}
        
        public static List<Rubro> getRubros() 
        {
            return DalRubros.getRubros();
        }
        // Obj. RUBRO ---------------------------------------------------------------------------
        string nombre;
        public string Nombre { get { return nombre; } }

        public Rubro(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
