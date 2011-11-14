using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.Datos
{
    class DalPostnet
    {
        public static void Alta(string marca, string modelo, int codigo, Beneficiario beneficiario)
        {
            //DalGral.getDataTable("INSERT mozilla.Postnets(POSTNET_NRO_SERIE,POSTNET_MODELO,POSTNET_MARCA,BENEFICIARIO_ID) VALUES (" + codigo +",'"+modelo +"','"+marca +"',"+beneficiario .RazonSocial +")");
        }

        public static List<Rubro> getPostnet(){
            List<Rubro> rubroList = new List<Rubro>();
            DataTable rubros = DalGral.getDataTable("SELECT mozilla.Rubros.RUBRO_NOMBRE, mozilla.Rubros.RUBRO_ID FROM mozilla.Rubros");
            for (int i = 0; i < rubros.Rows.Count ;i++)
			{
                //TODO: rubroList.Add(new Rubro(rubros.Rows[i][0].ToString(), rubros.Rows[i][1].ToString()));
			}
            return rubroList;
        }
    }
}
