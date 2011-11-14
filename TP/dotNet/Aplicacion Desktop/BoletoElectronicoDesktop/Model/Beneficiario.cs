using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.Model
{
    public class Beneficiario
    {
        public static Beneficiario Alta(string razon, string calle, int numero, int piso, string depto, List <Postnet> postnets, Rubro rubro)
        {
            Beneficiario nuevo =  new Beneficiario(razon, calle, numero, piso, depto, postnets, rubro);
            foreach (Postnet pn in nuevo.getPostnet ())
            {
            //    Postnet.Alta(pn.Marca , pn.Modelo , pn.Codigo , nuevo);
            }
            //TODO: DalBeneficiarios.Alta(nuevo.RazonSocial , nuevo.Calle, nuevo.Numero, nuevo.Piso, nuevo.Departamento, nuevo.Rubro.Nombre );
            return  nuevo ;
        }

        // Obj. BENEFICIARIOS -------------------------------------------------------------------
        string razon;
        string calle;
        int numero;
        int piso;
        string depto;
        List<Postnet> postnets;
        Rubro rubro;

        public string RazonSocial { get { return razon; } set { if (value != "") razon = value; else throw new FaltaRazonBeneficiarioException(); } }
        public string Calle { get { return calle; } set { if (value != "") calle = value; else throw new FaltaCalleBeneficiarioException(); } }
        public int Numero { get { return numero; } set { if (value != 0) numero = value; else throw new FaltaNumeroBeneficiarioException(); } }
        public int Piso { get { return piso; } set { piso = value; } }
        public string Departamento { get { return depto; } set { depto = value; } }
        public Rubro Rubro { get { return rubro; } set { if (value != null) rubro = value; else throw new FaltaRubroException(); } }

        private Beneficiario(string razon, string calle, int numero, int piso, string depto, List <Postnet> postnets, Rubro rubro)
        {
            this.razon = razon;
            this.calle  = calle;
            this.numero  = numero;
            this.piso  = piso;
            this.depto  = depto;
            if (postnets.Count >= 1) 
                this.postnets = postnets;
            else
                throw new SeRequiereAlMenosUnPostnetException();
            this.rubro = rubro;
        }
        public void AddPostnet(Postnet postnet) {
            //registrar cambio en bd
            postnets.Add(postnet); 
        }
        public void DeletePostnet(Postnet postnet) {
            //registrar cambio en bd
            postnets.Remove(postnet); 
        }
        public List<Postnet > getPostnet() { 
            //registrar cambio en bd
            return postnets;
        }
        public void Baja() { }
    }
}

[global::System.Serializable]
public class SeRequiereAlMenosUnPostnetException : Exception
{
 //
 // For guidelines regarding the creation of new exception types, see
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
 // and
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public SeRequiereAlMenosUnPostnetException() { }
  public SeRequiereAlMenosUnPostnetException( string message ) : base( message ) { }
  public SeRequiereAlMenosUnPostnetException( string message, Exception inner ) : base( message, inner ) { }
  protected SeRequiereAlMenosUnPostnetException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

[global::System.Serializable]
public class FaltaRubroException : Exception
{
 //
 // For guidelines regarding the creation of new exception types, see
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
 // and
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public FaltaRubroException() { }
  public FaltaRubroException( string message ) : base( message ) { }
  public FaltaRubroException( string message, Exception inner ) : base( message, inner ) { }
  protected FaltaRubroException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

[global::System.Serializable]
public class FaltaNumeroBeneficiarioException : Exception
{
 //
 // For guidelines regarding the creation of new exception types, see
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
 // and
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public FaltaNumeroBeneficiarioException() { }
  public FaltaNumeroBeneficiarioException( string message ) : base( message ) { }
  public FaltaNumeroBeneficiarioException( string message, Exception inner ) : base( message, inner ) { }
  protected FaltaNumeroBeneficiarioException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

[global::System.Serializable]
public class FaltaCalleBeneficiarioException : Exception
{
 //
 // For guidelines regarding the creation of new exception types, see
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
 // and
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public FaltaCalleBeneficiarioException() { }
  public FaltaCalleBeneficiarioException( string message ) : base( message ) { }
  public FaltaCalleBeneficiarioException( string message, Exception inner ) : base( message, inner ) { }
  protected FaltaCalleBeneficiarioException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

[global::System.Serializable]
public class FaltaRazonBeneficiarioException : Exception
{
 //
 // For guidelines regarding the creation of new exception types, see
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
 // and
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public FaltaRazonBeneficiarioException() { }
  public FaltaRazonBeneficiarioException( string message ) : base( message ) { }
  public FaltaRazonBeneficiarioException( string message, Exception inner ) : base( message, inner ) { }
  protected FaltaRazonBeneficiarioException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}