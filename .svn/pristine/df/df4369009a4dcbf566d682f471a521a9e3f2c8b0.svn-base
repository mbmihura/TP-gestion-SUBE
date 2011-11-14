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
    public partial class FormAbmClientesIngresodatos : Form
    {
        Validador Validacion;
        int idCliente;
        private delegate void Action();
        Action accionCliente;

        private void altaCliente()
        {
            Datos.DalGral.ExcecuteNonQuery("INSERT mozilla.Clientes(CLIENTE_NOMBRE,CLIENTE_APELLIDO,CLIENTE_TIPO_DNI,CLIENTE_DNI,CLIENTE_MAIL,CLIENTE_TELEFONO,CLIENTE_CALLE,CLIENTE_NRO,CLIENTE_PISO,CLIENTE_DEPTO,PROVINCIA_ID)VALUES('" + tbNombre.Text + "','" + tbApellido.Text + "','" + comboDNI.Text + "'," + tbDNI.Text + ",'" + tbCorreo.Text + "','" + tbTelefono.Text + "','" + tbCalle.Text + "'," + tbNro.Text + "," + tbPiso.Text + ",'" + tbDpto.Text + "'," + comboProvincia.SelectedValue + ")");
            idCliente = Convert.ToInt32(DalGral.getDataTable("SELECT mozilla.Clientes.CLIENTE_ID FROM mozilla.Clientes WHERE CLIENTE_TIPO_DNI = '" + comboDNI.Text + "' AND CLIENTE_DNI = " + tbDNI.Text).Rows[0][0]);
        }
        private void modCliente()
        {
            DalGral.ExcecuteNonQuery("UPDATE mozilla.Clientes SET CLIENTE_NOMBRE = '" + tbNombre.Text + "',CLIENTE_APELLIDO = '" + tbApellido.Text + "',PROVINCIA_ID = " + comboProvincia.ValueMember + ",CLIENTE_MAIL = '" + tbCorreo.Text + "', CLIENTE_TELEFONO = '" + tbTelefono.Text + "', CLIENTE_CALLE = '" + tbCalle.Text + "',CLIENTE_NRO = " + tbNro.Text + ",CLIENTE_PISO = " + tbPiso.Text + ", CLIENTE_DEPTO = '" + tbDpto.Text + "', HABILITADO =" + Convert.ToInt32(checkHabilitado.Checked) + " WHERE CLIENTE_ID = " + idCliente);
        }
        
        //Mostrar formulario en algun modo (Alta/Modificacion).
        public void ShowAltaCliente(IWin32Window owner)
        {
            Text = "Alta Cliente";
            gbClientes.Text = "Datos del Nuevo Cliente";
            checkHabilitado.Visible = false;
            checkHabilitado.Enabled = false;
            checkHabilitado.Checked = true;
                        
            // Asigna el COMPORTAMIENTO de ALTA al BOTON GUARDAR.
            accionCliente = altaCliente;
            ShowDialog(owner);
        }
        public void ShowModificacionClientes(IWin32Window owner, int idCliente)
        {
            Text = "Modificar Cliente: ";
            gbClientes.Text = "Edite los datos del Cliente";
            this.idCliente = idCliente;
            // Asigna el COMPORTAMIENTO de MODIFICACION al BOTON GUARDAR.
            accionCliente = modCliente;

            try
            {
                //Cargar datos desde Clientes
                DataTable datosCliente = DalGral.getDataTable("SELECT TOP 1 CLIENTE_NOMBRE, CLIENTE_APELLIDO, CLIENTE_TIPO_DNI, CLIENTE_DNI, PROVINCIA_DESC, CLIENTE_MAIL, CLIENTE_TELEFONO, CLIENTE_CALLE, CLIENTE_NRO, CLIENTE_PISO, CLIENTE_DEPTO, HABILITADO FROM mozilla.Clientes LEFT OUTER JOIN mozilla.Provincias ON mozilla.Clientes.PROVINCIA_ID = mozilla.Provincias.PROVINCIA_ID WHERE mozilla.Clientes.CLIENTE_ID = " + idCliente);
                tbNombre.Text =  datosCliente.Rows[0][0].ToString();
                tbNombre.Text = tbNombre.Text.TrimEnd();
                tbApellido.Text = datosCliente.Rows[0][1].ToString();
                tbApellido.Text = tbApellido.Text.TrimEnd();
                comboDNI.Text = datosCliente.Rows[0][2].ToString();
                comboDNI.Enabled = false;
                tbDNI.Text = datosCliente.Rows[0][3].ToString();
                tbDNI.Enabled = false;
                comboProvincia.Text = datosCliente.Rows[0][4].ToString();
                tbCorreo.Text = datosCliente.Rows[0][5].ToString();
                tbTelefono.Text = datosCliente.Rows[0][6].ToString();
                tbCalle.Text = datosCliente.Rows[0][7].ToString();
                tbNro.Text = datosCliente.Rows[0][8].ToString();
                tbPiso.Text = datosCliente.Rows[0][9].ToString();
                tbDpto.Text = datosCliente.Rows[0][10].ToString();
                checkHabilitado.Checked = Convert.ToBoolean(datosCliente.Rows[0][11]);
                ShowDialog(owner);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //BOTON GUARDAR: posibles compotamientos
        private void bGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
            ValidarControlesClientes();
            accionCliente();
            
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falla alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Comportamientos Fijos ___________________________________________________________________________________________________________
        public FormAbmClientesIngresodatos()
        {
            InitializeComponent();
            limpiarBotones();
        }

        private void FormAbmClientesIngresodatos_Load(object sender, EventArgs e)
        {
            //Carga parametros de Validacion
            Validacion = new Validador(false,
                new Requerido(tbNombre, "nombre"),
                new Requerido(tbApellido, "apellido"),
                new Requerido(comboDNI, "tipo dni"),
                new Requerido(tbDNI, "dni"),
                new Requerido(comboProvincia, "provincia"),
                new Requerido(tbCorreo, "correo electronico"),
                new Requerido(tbTelefono, "telefono"),
                new Requerido(tbCalle, "calle"),
                new Requerido(tbNro, "numero"),
                new Requerido(tbPiso, "piso"),
                new LongitudMaxima(tbNombre, 200, "nombre"),
                new LongitudMaxima(tbApellido, 200, "apellido"),
                new LongitudMaxima(tbDNI, 9, "dni"),
                new LongitudMaxima(tbCorreo, 200, "correo electronico"),
                new LongitudMaxima(tbCalle, 200, "calle"),
                new LongitudMaxima(tbNro, 10, "numero"),
                new LongitudMaxima(tbPiso, 5, "piso")
            );
            // Cargar valores combo Provincias
            comboProvincia.DataSource = DalGral.getDataTable("SELECT mozilla.Provincias.PROVINCIA_DESC, mozilla.Provincias.PROVINCIA_ID FROM mozilla.Provincias");
            comboProvincia.ValueMember = "PROVINCIA_ID";
            comboProvincia.DisplayMember = "PROVINCIA_DESC";
            comboProvincia.SelectedValue = 24;
          }
        private void ValidarControlesClientes()
        {
            string fallaValidacion = ""; //String para agregar los mensajes de los errores de validacion.
            Validacion.Resetear();//resetea el fondo del control para no interferir con la validacion de validador, ni beneficiario repetido.         
            try
            {
                if (DalGral.GetDataReaderBool("SELECT CLIENTE_NOMBRE, CLIENTE_APELLIDO FROM mozilla.Clientes WHERE CLIENTE_TIPO_DNI = '" + comboDNI.Text + "' AND CLIENTE_DNI = '" + tbDNI.Text + "'") && accionCliente == altaCliente)
                {
                    fallaValidacion = "El Cliente " + tbApellido.Text + " , " + tbNombre.Text + " ya existe, y no puede volver a ingresarse." + Environment.NewLine;
                    comboDNI.BackColor = System.Drawing.Color.MistyRose;
                    tbDNI.BackColor = System.Drawing.Color.MistyRose;
                    
                }
                Validacion.Validar();
                if (fallaValidacion != "") throw new Exception("");
            }
           catch (Exception ex)
            {
              throw new Exception(fallaValidacion + ex.Message);
            }
        }

        private void limpia_camposCli_Click(object sender, EventArgs e)
        {
            limpiarBotones();
        }

        private void limpiarBotones()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            comboDNI.SelectedItem = null;
            tbDNI.Text = "";
            tbCorreo.Text = "";
            tbTelefono.Text = "";
            tbCalle.Text = "";
            tbNro.Text = "";
            tbPiso.Text = "";
            tbDpto.Text = "";
            comboProvincia.SelectedValue = 24;
        }

        //Habilita la tarjeta si se habilita el cliente.
        private void checkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHabilitado.Checked == true)
                DalGral.ExcecuteNonQuery("UPDATE mozilla.Tarjetas SET HABILITADA = 1 WHERE CLIENTE_ID = " + idCliente);
        }
    }
}
