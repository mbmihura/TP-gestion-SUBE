using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BoletoElectronicoDesktop.Datos
{
    class DalBeneficiarios
    {
        public static void Alta(string razon, string calle, int numero, int piso, string depto, int rubro)
        {
        }
        /// <summary>Devuelve los beneficiarios que cumpla con la mascara espeificada.
        /// <param name="campo">Nombre de la columna donde aplicar la mascara</param>
        /// <param name="value">Mascara con la cual filtrar</param>
        /// </summary>
        public static DataTable getBeneficiarios(string razonSocial, string Dirreccion )
        {
            // TODO:
            String strConsulta = "select CLIENTE_NOMBRE,CLIENTE_APELLIDO,CLIENTE_TIPO_DNI,CLIENTE_DNI,CLIENTE_MAIL,CLIENTE_TELEFONO,CLIENTE_CALLE,CLIENTE_NRO,CLIENTE_PISO,CLIENTE_DEPTO from mozilla.Clientes where {0} like '{1}%'";
            return DalGral.getDataTable(strConsulta);
        }

    }
}
