using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Utils;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.Datos
{
    class DalRubros
    {
        public static List<Rubro> getRubros()
        {
            List<Rubro> rubroList = new List<Rubro>();
            DataTable rubros = DalGral.getDataTable("SELECT mozilla.Rubros.RUBRO_NOMBRE FROM mozilla.Rubros");
            for (int i = 0; i < rubros.Rows.Count ;i++)
			{
                rubroList.Add(new Rubro(rubros.Rows[i][0].ToString()));
			}
            return rubroList;
        }

        //Excepciones nombre muy largo, id repetido, id requerido
        //public static void Alta(string marca, string modelo, int codigo)
        //{
        //    // TODO: DalGral.getDataTable("INSERT mozilla.Rubros( RUBRO_NOMBRE ) VALUES ('"+nombre+"')");
        //}
    }
}
