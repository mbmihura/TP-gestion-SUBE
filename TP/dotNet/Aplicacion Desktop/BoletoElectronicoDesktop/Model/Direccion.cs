using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoletoElectronicoDesktop.Model
{
    class Direccion
    {
        private String calle;

        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private int nro;

        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }

        private int piso;

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        private String dpto;

        public String Dpto
        {
            get { return dpto; }
            set { dpto = value; }
        }

        private string provincia;
        
        public String Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public Direccion()
        {
        }

        public Direccion(String strCalle, int nNro, int nPiso, String strDpto)
        {
            calle = strCalle;
            nro = nNro;
            piso = nPiso;
            dpto = strDpto;
        }

        public Direccion(String strCalle, int nNro, int nPiso, String strDpto, String pcia)
        {
            calle = strCalle;
            nro = nNro;
            piso = nPiso;
            dpto = strDpto;
            pcia = provincia;
        }
    }
}
