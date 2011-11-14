using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BoletoElectronicoDesktop.Model
{
    class Tarjeta
    {
        int idTarjeta;
        public int IdTarjeta
        {
            get { return idTarjeta; }
            set { idTarjeta = value; }
        }

        int nroTarjeta;
        public int NroTarjeta
        {
            get { return nroTarjeta; }
            set { nroTarjeta = value; }
        }

        Cliente clienteResponsable;

        internal Cliente ClienteResponsable
        {
            get { return clienteResponsable; }
            set { clienteResponsable = value; }
        }

        DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        Boolean estado;
        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Tarjeta(int nro)
        {
            nroTarjeta = nro;
        }

        public Tarjeta()
        {
        }

        public void AltaTarjeta()
        {
            if(this.ClienteResponsable == null)
                throw new Exception("Debe selecionar un Cliente!");
            Datos.DalTarjeta.AltaTarjeta(this);
        }

        public static int nuevoId()
        {
            return Datos.DalTarjeta.nuevoId();
        }

        public static int ultimoId()
        {
            return Datos.DalTarjeta.ultimoId();
        }

        public DataTable getTarjetas()
        {
            if (clienteResponsable != null)
            {
                this.Fecha = DateTime.MinValue;
                this.nroTarjeta = 0;
            }
            return Datos.DalTarjeta.getTarjetas(this);
        }

        public void actualizarTarjeta()
        {
            Datos.DalTarjeta.updateTarjeta(this);
        }

        public void eliminarTarjeta()
        {
            estado = false;
            Datos.DalTarjeta.updateTarjeta(this);
        }
    }
}
