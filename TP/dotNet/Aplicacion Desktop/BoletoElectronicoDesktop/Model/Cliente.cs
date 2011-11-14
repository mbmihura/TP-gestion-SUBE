using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.Model
{
    class Cliente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private String tipoDni;

        public String TipoDni
        {
            get { return tipoDni; }
            set { tipoDni = value; }
        }

        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private String mail;

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private Direccion dir;

        internal Direccion Dir
        {
            get { return dir; }
            set { dir = value; }
        }

        public DataTable getClientes()
        {
            return DalCliente.getClientes(this);
        }

        public DataTable getClientesFiltradosAbmClientes()
        {
          return DalCliente.getClientesFiltradosAbmClientes(this);
        }

        public Cliente()
        {

        }

        public static Cliente getCliente(int nroId)
        {
            return DalCliente.getCliente(nroId);
        }

        public static DataTable getClientesPremium(int Anio)
        {
            return DalCliente.getClientesPremium(Anio);
        }
    }
}
