using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Utils;
using BoletoElectronicoDesktop.Model;
using BoletoElectronicoDesktop.Datos;

namespace BoletoElectronicoDesktop.AbmClientes
{
    public partial class FormAbmClientes : Form
    {
        Validador altaValidacion;

        public FormAbmClientes()
        {
            InitializeComponent();
        }

        private void FormAbmClientes_Load(object sender, EventArgs e)
        {
            //ALTA:
            altaValidacion = new Validador(false,
                new Requerido(tbAltaNombre, "nombre"),
                new Requerido(tbAltaApellido, "apellido"),
                new Requerido(comboDNI, "tipo dni"),
                new Requerido(tbAltaDNI, "dni"),
                new Requerido(comboAltaProvincia, "provincia"),
                new Requerido(tbAltaCorreo, "correo electronico"),
                new Requerido(tbTelefono, "telefono"),
                new Requerido(tbCalle, "calle"),
                new Requerido(tbNro, "numero"),
                new Requerido(tbPiso, "piso"),
                new Requerido(tbDpto,"depto"),
                new LongitudMaxima(tbAltaNombre, 200, "nombre"),
                new LongitudMaxima(tbAltaApellido, 200,"apellido"),
                new LongitudMaxima(tbAltaCorreo, 200, "correo electronico"),
                new LongitudMaxima(tbTelefono, 30, "telefono"),
                new LongitudMaxima(tbCalle, 200, "calle"),
                new LongitudMaxima(tbNro, 10, "numero"),
                new LongitudMaxima(tbPiso, 3, "piso"),
                new LongitudMaxima(tbDpto, 20, "departamento")
            );

            // Cargar valores combo Provincia
            comboAltaProvincia.DataSource = DalGral.getDataTable("SELECT mozilla.Provincias.PROVINCIA_DESC, mozilla.Provincias.PROVINCIA_ID FROM mozilla.Provincias");
            comboAltaProvincia.DisplayMember = "PROVINCIA_DESC";
            comboAltaProvincia.ValueMember = "PROVINCIA_ID";
            

            //MODIFICACION:________________________________________________________________________________________________

            // Agregar manejador y metodo a los manejadores de Cell click y cargar clientes en datagridview
            //dataGridModificarCliente.CellClick += new DataGridViewCellEventHandler(dataGridModificarCliente_CellClick);
            //dataGridModificarCliente.DataSource = DalGral.getDataTable("SELECT CLIENTE_NOMBRE AS 'Nombre', CLIENTE_APELLIDO AS 'Apellido', CLIENTE_TIPO_DNI AS 'Tipo DNI', CLIENTE_DNI AS 'Número', PROVINCIA_DESC AS 'Provincia' FROM mozilla.clientes LEFT OUTER JOIN  mozilla.provincias ON mozilla.Clientes.PROVINCIA_ID = mozilla.Provincias.PROVINCIA_ID");

            // Cargar valores combo Provincia
            comboModificarProvincia.DataSource = comboModificarProvincia.DataSource;
            comboAltaProvincia.DisplayMember = "PROVINCIA_DESC";
            comboAltaProvincia.ValueMember = "PROVINCIA_ID";
            
            //BAJA:________________________________________________________________________________________________________

            // Agregar manejador y metodo a los manejadores de Cell click y cargar clientes en datagridview
            dataGridBajaCliente.CellClick += new DataGridViewCellEventHandler(dataGridBajaCliente_CellClick);
           // dataGridBajaCliente.DataSource = dataGridModificarCliente.DataSource;

            // Cargar valores combo Provincia
            comboModificarProvincia.DataSource = comboModificarProvincia.DataSource;
            comboAltaProvincia.DisplayMember = "PROVINCIA_DESC";
            comboAltaProvincia.ValueMember = "PROVINCIA_ID";
            
        }

      
        //ALTA:________________________________________________________________________________________________________
        
        private void bAltaAgregar_Click(object sender, EventArgs e)
        {
            string fallaValidacion = ""; //String para agregar los mensajes de los errores de validacion.
            try
            {
                altaValidacion.Resetear();
                if (DalGral.GetDataReaderBool("SELECT CLIENTE_TIPO_DNI, CLIENTE_DNI FROM mozilla.Clientes WHERE CLIENTE_TIPO_DNI = '" + comboDNI.Text + "' AND CLIENTE_DNI = '" + tbAltaDNI.Text + "'"))
                {
                    fallaValidacion = "El Cliente " + tbAltaNombre.Text + " , " + tbAltaApellido.Text + " ya existe, y no puede volver a ingresarse." + Environment.NewLine;
                    tbAltaDNI.BackColor = System.Drawing.Color.MistyRose;
                    comboDNI.BackColor = System.Drawing.Color.MistyRose;
                }
            altaValidacion.Validar();
            if (fallaValidacion != "") throw new Exception("");

            Datos.DalGral.ExcecuteNonQuery("INSERT mozilla.Clientes(CLIENTE_NOMBRE,CLIENTE_APELLIDO,CLIENTE_TIPO_DNI,CLIENTE_DNI,PROVINCIA_ID,CLIENTE_MAIL,CLIENTE_TELEFONO,CLIENTE_CALLE,CLIENTE_NRO,CLIENTE_PISO,CLIENTE_DEPTO)VALUES('" + tbAltaNombre.Text + "','" + tbAltaApellido.Text + "','" + comboDNI.Text + "','" + tbAltaDNI.Text + "','" + comboAltaProvincia.ValueMember + "','" + tbAltaCorreo.Text + "','" + tbTelefono.Text + "','" + tbCalle.Text + "','" + tbNro.Text + "','" + tbPiso.Text + "','" + tbDpto.Text + "')");
            try            
            {            
                MessageBox.Show("Los datos del Cliente " + tbAltaNombre.Text + " , " + tbAltaApellido.Text + " han sido guardados", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "No se puede realizar el alta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          } catch (Exception exp) {
                MessageBox.Show (fallaValidacion + exp.Message, "No se puede realizar el alta",MessageBoxButtons.OK,MessageBoxIcon.Warning  );
            }
        }
        void dataGridBajaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        //BAJA Y MODIFICACION:____________________________________________________________________________________________

        //private void dataGridModificarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
          //  if (e.RowIndex < 0 || e.ColumnIndex != dataGridModificarCliente.Columns["Modificar"].Index) return;
         //   MessageBox.Show(e.RowIndex.ToString()); //TODO: Llamar a editar
       // }
   


    }
}
