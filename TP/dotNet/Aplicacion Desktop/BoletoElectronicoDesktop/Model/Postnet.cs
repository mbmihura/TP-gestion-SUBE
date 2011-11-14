using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.Model
{
    public class Postnet
    {
        ////
        //public static Postnet Alta(string marca, string modelo, int codigo, Beneficiario beneficiario)
        //{
        //    Postnet nuevo = new Postnet();
        //    nuevo.Marca = marca;
        //    nuevo.Modelo = modelo;
        //    nuevo.Codigo = codigo;
        //    DalPostnet.Alta(nuevo.Marca , nuevo.Modelo, nuevo.Codigo, beneficiario );
        //    return nuevo;
        //}
        //public static List <Postnet> getPostnet()
        //{
        //    List<Postnet > postnetList = new List<Postnet >();
        //    DataTable postnetTable = DalGral.getDataTable("SELECT mozilla.Postnets.POSTNET_MARCA, mozilla.Postnets.POSTNET_MODELO, mozilla.Postnets.POSTNET_NRO_SERIE, mozilla.Postnets.BENEFICIARIO_ID FROM mozilla.Postnets");
        //    for (int i = 0; i < postnetTable.Rows.Count; i++)
        //    {
        //        //TODO: postnetList.Add(new Postnet(postnetTable.Rows[i][0].ToString(), postnetTable.Rows[i][1].ToString()), postnetTable.Rows[i][2].ToString());
        //    }
        //    return postnetList;
        //}
        // Obj. POSTNET -------------------------------------------------------------------------
        string marca;
        string modelo;
        int codigo;

        public Postnet() {}
        public string Marca { get { return marca; } set 
        {
                marca = value;

        } }
        public string Modelo { get { return modelo; } set 
        { 
                modelo = value;
        } }
        public int Codigo { get { return codigo; } set
        { 
                codigo = value; 
        } }

        public Postnet(string marca, string modelo, int codigo)
        {
            this.marca   = marca;
            this.modelo  = modelo;
            this.codigo  = codigo;
        }

    }
}

