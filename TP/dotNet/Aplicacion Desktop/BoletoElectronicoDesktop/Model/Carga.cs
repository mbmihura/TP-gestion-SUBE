using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.Model
{
    class Carga
    {
        DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        Double monto;
        public Double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        Tarjeta tarjetaUsada;
        internal Tarjeta TarjetaUsada
        {
            get { return tarjetaUsada; }
            set { tarjetaUsada = value; }
        }

        public Carga(DateTime fechaCarga, Double importe, int nroTarjeta)
        {
            fecha = fechaCarga;
            monto = importe;
            tarjetaUsada = new Tarjeta(nroTarjeta);

            if (importe <= 0)
                throw new Exception("Ingrese un monto mayor que 0");
            if (nroTarjeta <= 0)
                throw new Exception("Tarjeta inexistente...");
            DalCarga.cargarTarjeta(this);
        }
    }
}
