using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoletoElectronicoDesktop.Utils
{
    /// <summary>Configuracionde colores para la CLASE validador.</summary>
    public static class Color
    {
        public static System.Drawing.Color FallaValidacion = System.Drawing.Color.MistyRose;
        public static System.Drawing.Color CampoRequerido = System.Drawing.Color.LightYellow ;
        public static System.Drawing.Color Correcto = System.Drawing.Color.White;
    }

    /// <summary>Permite cargar reglas de validacion y definir en que controles de System.Windows.Forms de aplican.</summary>
    /// <remarks>Version mayor: 5, menor: ni idea, Beta-revisar</remarks>
    public class Validador
    {
        private bool showMessageBoxWhenFail;
        private List<Requerido> requeridos = new List<Requerido>();
        private List<LongitudMaxima> longitudesMaximas = new List<LongitudMaxima>();
        private List<ValoresEntre> valoresEntre = new List<ValoresEntre>();
        private List<IRegla> todosControles = new List<IRegla>();

        /// <summary>Instancia un objeto validador, donde se cargan las reglas a validar.</summary>
        /// <param name="showMessageBoxWhenFail">Establece si se debe mostrar un MessageBox cuando falla alguna validacion</param>
        /// <param name="restricciones">Reglas que esta instancia de Validalor va a verificar.</param>
        public Validador(bool showMessageBoxWhenFail, params IRegla[] restricciones)
        {
            this.showMessageBoxWhenFail = showMessageBoxWhenFail;
            foreach (IRegla res in restricciones)
            {
                res.AddTo(this);
            }
        }

        /// <summary>Agregar una regla nueva a la lista de reglas que se van a controlar.</summary>
        /// <param name="requerido">Establece que un control DEBE completars.e</param>
        public void Add(Requerido requerido) { todosControles.Add(requerido); requeridos.Add(requerido); }
        /// <summary>Agregar una regla nueva a la lista de reglas que se van a controlar.</summary>
        /// <param name="longitudMaxima">Establece la longitud maxima que un control acepta.</param>
        public void Add(LongitudMaxima longitudMaxima) { todosControles.Add(longitudMaxima); longitudesMaximas.Add(longitudMaxima); }
        /// <summary>Agregar una regla nueva a la lista de reglas que se van a controlar.</summary>
        /// <param name="valorEntre">Establece el rango de valores numericos que un control acepta.</param>
        public void Add(ValoresEntre valorEntre) { todosControles.Add(valorEntre); valoresEntre.Add(valorEntre); }

        /// <summary>Resetea todos los controles antes de volver a ser validados.</summary>
        public void Resetear()
        {
            foreach (IRegla res in todosControles)
            {
                res.Resetear();
            }
        }
        /// <summary>Valida todas las reglas almacenadas en el objeto.
        /// <para><exception cref="FallaValidacionException">Excepcion es arrojada siempre que alguna regla falla la validacion.</exception></para>
        /// </summary>
        public void Validar() {
            string txtFallos = "";
            string longFallos = "";
            string valFallos = "";

            foreach (IRegla res in requeridos) {
                string controlFallo = res.Validar ();
                if (controlFallo != "") {
                    if (txtFallos != "") {
                        txtFallos = txtFallos + ", ";
                    }
                    txtFallos = txtFallos + controlFallo;
                }
            }
            foreach (IRegla res in longitudesMaximas) {
                string controlFallo = res.Validar();
                if (controlFallo != ""){
                    if (longFallos != "") {
                        longFallos = longFallos + ", el de " + controlFallo;
                    } else {
                        longFallos = longFallos + controlFallo + " caracteres";
                    }
                }
            }
            foreach (IRegla res in valoresEntre) {
                string controlFallo = res.Validar();
                if (controlFallo != "") {
                    if (valFallos != "")
                        valFallos = txtFallos + ", el de ";
                    valFallos = valFallos + controlFallo;
                }
            }
            if (txtFallos != "") txtFallos = "Debe ingresar " + txtFallos + "." + Environment.NewLine;
            if (longFallos != "") longFallos = "El campo de " + longFallos + "." + Environment.NewLine;
            if (valFallos != "") valFallos = "El valor de " + valFallos + "." + Environment.NewLine;

            string fallos = txtFallos + longFallos + valFallos;
            if (fallos != "")
            {
                if (showMessageBoxWhenFail) MessageBox.Show(fallos, "Datos Erroneos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new FallaValidacionException(fallos);
            }
        }

    }
    /// <summary>Interface que implementa cualquier regla para poder cargarse en validador.</summary>
    public interface IRegla {
        string Validar();
        /// <summary>Metodo usado internamente por Validador (Deberia ser private, por cuestiones porpias del lenguaje (C#) no se puede definir como tal).</summary>
        void AddTo(Validador validador);
        void Resetear();
    }
    /// <summary>Valida que un control sea completado, es una regla utilizada con la clase Validador (implementa IRegla)</summary>
    public class Requerido : IRegla
    {
        ITipoRequerido control;
        string nombre;

        /// <summary>Instancia una regla para asegurarse que determinado control sea completado.</summary>
        /// <param name="textBox">Control para el cual debe validarse que haya sido completado.</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public Requerido(TextBox textBox, string nombreControl)
        {
            textBox.BackColor = Color.CampoRequerido;
            control = new TextBoxRequerido(textBox, nombreControl);
            nombre = nombreControl;
        }
        /// <summary>Instancia una regla para asegurarse que determinado control sea completado.</summary>
        /// <param name="numericUpDown">Control para el cual debe validarse que haya sido completado.</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public Requerido(NumericUpDown numericUpDown, string nombreControl)
        {
            numericUpDown.BackColor = Color.CampoRequerido;
            control = new NumericUpDownRequerido(numericUpDown, nombreControl);
            nombre = nombreControl;
        }
        /// <summary>Instancia una regla para asegurarse que determinado control sea completado.</summary>
        /// <param name="comboBox">Control para el cual debe validarse que haya sido completado.</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
         public Requerido(ComboBox comboBox, string nombreControl)
        {
            comboBox.BackColor = Color.CampoRequerido;
            control = new ComboBoxRequerido(comboBox, nombreControl);
            nombre = nombreControl;
        }
        /// <summary>Instancia una regla para asegurarse que determinado control sea completado.</summary>
         /// <param name="dataGridView">Control para el cual debe validarse que haya sido completado.</param>
         /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public Requerido(DataGridView dataGridView, string nombreControl)
        {
            dataGridView.BackgroundColor = Color.CampoRequerido;
            control = new DataGridViewRequerido(dataGridView, nombreControl);
            nombre = nombreControl;
        }

        public void AddTo(Validador validador) {validador.Add(this);}
        public string Validar() {return control.Validar();}
        public void Resetear() {control.Resetear();}
        
        private interface ITipoRequerido
        {
            string Validar();
            void Resetear();
        }

        private class TextBoxRequerido : ITipoRequerido
        {
            TextBox text;
            string nombre;

            public TextBoxRequerido(TextBox textBox, string nombreControl)
            {
                text = textBox;
                nombre = nombreControl;
            }
            public void Resetear() { text.BackColor = Color.Correcto; }
            public string Validar()
            {
                if (text.Text == "")
                {
                    text.BackColor = Color.FallaValidacion;
                    return nombre;
                }
                return "";
            }
        }
        private class ComboBoxRequerido : ITipoRequerido
        {
            ComboBox combo;
            string nombre;

            public ComboBoxRequerido(ComboBox comboBox, string nombreControl)
            {
                combo = comboBox;
                nombre = nombreControl;
            }
            public void Resetear() { combo.BackColor  = Color.Correcto; }
            public string Validar()
            {
                if (combo.SelectedIndex == -1)
                {
                    combo.BackColor = Color.FallaValidacion;
                    return nombre;
                }
                return "";
            }

        }
        private class DataGridViewRequerido : ITipoRequerido
        {
            DataGridView dgv;
            string nombre;
            public DataGridViewRequerido(DataGridView dataGridView, string nombreControl)
            {
                dgv = dataGridView;
                nombre = nombreControl;
            }
            public void Resetear() { dgv.BackgroundColor = Color.Correcto; }
            public string Validar()
            {
                if (dgv.RowCount == 0)
                {
                    dgv.BackgroundColor = Color.FallaValidacion;
                    return "al menos 1 " + nombre;
                }
                return "";
            }
        }
        private class NumericUpDownRequerido : ITipoRequerido
        {
            NumericUpDown nud;
            string nombre;

            public NumericUpDownRequerido(NumericUpDown numericUpDown, string nombreControl)
            {
                nud = numericUpDown;
                nombre = nombreControl;
            }
            public void Resetear() { nud.BackColor = Color.Correcto; }
            public string Validar()
            {
                if (nud.Text == "")
                {
                    nud.BackColor = Color.FallaValidacion;
                    return nombre;
                }
                return "";
            }
        }
    }
    /// <summary>Valida la longitud del valor de un control, es una regla utilizada con la clase Validador (implementa IRegla)</summary>
    public class LongitudMaxima : IRegla
    {
        private TextBox text;
        private int maxValue;
        private string nombre;

        /// <summary>Instancia una regla para asegurarse que el texto introducido en determinado control no sea exceda cierta longitud.</summary>
        /// <param name="textBox">Control en el que debe validarse el texto introducido.</param>
        ///<param name="maximumValue">Maxima longitud permitida del texto</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public LongitudMaxima(TextBox textBox, int maximumValue, string nombreControl)
        {
            text = textBox;
            maxValue = maximumValue;
            nombre = nombreControl;
        }
        public void Resetear() { text.BackColor = Color.Correcto; }
        public string Validar()
        {
            if (text.Text.Length > maxValue)
            {
                text.BackColor = Color.FallaValidacion;
                return nombre + " no puede tener mas de " + maxValue;
            }
            return "";
        }
        public void AddTo(Validador validador)
        {
            validador.Add(this);
        }
    }
    /// <summary>Valida el rango de un valor de un control, es una regla utilizada con la clase Validador (implementa IRegla)</summary>
    public class ValoresEntre : IRegla
    {
        protected NumericUpDown nud;
        protected decimal minValue;
        protected decimal maxValue;
        protected string nombre;

        /// <summary>Instancia una regla para asegurarse que los valores introducidos en determinado control esten dentro de un rango especifico.
        /// <para>NOTA: Ahora puede definirse desde las propiedades.</para></summary>
        /// <param name="numericUpDown">Control en el que debe validarse el rango.</param>
        /// <param name="minimumValue">Minimo valor permitido</param>
        /// <param name="maximumValue">Maximo valor permitido</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public ValoresEntre(NumericUpDown numericUpDown, decimal minimumValue, decimal maximumValue, string nombreControl)
        { 
            nud = numericUpDown;
            minValue = minimumValue;
            maxValue = maximumValue;
            nombre = nombreControl;
        }
        public void Resetear() {nud.BackColor = Color.Correcto ;}
        public virtual string Validar()
        {
            if (nud.Value > maxValue || nud.Value < minValue)
            {
                nud.BackColor = Color.FallaValidacion;
                return nombre + " debe estar entre " + minValue + " y " + maxValue;
            }
            return "";
        }
        public void AddTo(Validador validador) { validador.Add(this); }
    }
    /// <summary>Valida que el valor de un valor de un control sea mayor a cierto valor, es una regla utilizada con la clase Validador (implementa IRegla)</summary>
    public class ValorMinimo : ValoresEntre
    {
        /// <summary>Instancia una regla para asegurarse que el valor introducido en un determinado control sea mayor a cierto valor.
        /// <para>NOTA: Ahora puede definirse desde las propiedades.</para></summary>
        /// <param name="numericUpDown">Control en el que debe validarse el rango.</param>
        /// <param name="minimumValue">Minimo valor permitido</param>
        /// <param name="nombreControl">Nombre del control mostrado al usuario (Usado en el mensaje de error, en caso que falle la validacion)</param>
        public ValorMinimo(NumericUpDown numericUpDown, decimal minimumValue, string nombreControl) : base(numericUpDown, minimumValue, 0, nombreControl)
        {
            nud = numericUpDown;
            minValue = minimumValue;
            nombre = nombreControl;
        }
        public override string Validar()
        {
            if (nud.Value < minValue)
            {
                nud.BackColor = Color.FallaValidacion;
                return nombre + " debe ser mayor a " + minValue;
            }
            return "";
        }
    }
[global::System.Serializable]
    /// <summary>Excepcion devuelta cuando valla una regla de validacion. </summary>
public class FallaValidacionException : Exception
{
 // Definicion segun:
 //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
 //

  public FallaValidacionException() { }
  public FallaValidacionException( string message ) : base( message ) { }
  public FallaValidacionException( string message, Exception inner ) : base( message, inner ) { }
  protected FallaValidacionException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}

}
