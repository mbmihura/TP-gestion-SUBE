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
using BoletoElectronicoDesktop.AbmPost_Net;

namespace BoletoElectronicoDesktop.AbmBeneficiarios
{
    public partial class FormAbmBeneficiarioIngresodatos : Form
    {
        List<Postnet> susPostnetIniciales = new List<Postnet> ();
        BindingList<Postnet> susPostnetFinales = new BindingList<Postnet>();
        Validador Validacion;
        int idBeneficiario;
        private delegate void Accion();
        Action accionBeneficiario;

        private void altaBeneficiario()
        {
            DalGral.ExcecuteNonQuery("INSERT mozilla.Beneficiarios(BENEFICIARIO_NOMBRE,RUBRO_ID,BENEFICIARIO_CALLE,BENEFICIARIO_NRO,BENEFICIARIO_PISO,BENEFICIARIO_DEPTO)VALUES('" + Razon_txt.Text + "'," + Rubro_cmb.SelectedValue + ",'" + Calle_txt.Text + "'," + Numero_nud.Value + "," + Piso_nud.Value + ",'" + Depto_txt.Text + "')");
            idBeneficiario = Convert.ToInt32(DalGral.getDataTable("SELECT mozilla.Beneficiarios.BENEFICIARIO_ID FROM mozilla.Beneficiarios WHERE BENEFICIARIO_NOMBRE = '" + Razon_txt.Text + "'").Rows[0][0]);
        }
        private void modBeneficiario()
        {
            DalGral.ExcecuteNonQuery("UPDATE mozilla.Beneficiarios SET BENEFICIARIO_NOMBRE = '" + Razon_txt.Text + "',BENEFICIARIO_CALLE = '" + Calle_txt.Text + "',BENEFICIARIO_NRO = " + Numero_nud.Value + ", BENEFICIARIO_PISO = " + Piso_nud.Value + ", BENEFICIARIO_DEPTO = '" + Depto_txt.Text + "',RUBRO_ID = " + Rubro_cmb.SelectedValue + ",HABILITADO = "+Convert.ToInt32(Habilitado_chk.Checked)+" WHERE BENEFICIARIO_ID = " + idBeneficiario);
        }

        //Mostrar formulario en algun modo (Alta/Modificacion)
        public void ShowAlta(IWin32Window owner)
        {
            Text = "Alta Beneficiario";
            Descripcion_lbl.Text = "Ingrese los datos del nuevo beneficiario";
            Habilitado_chk.Visible = false;
            Habilitado_chk.Enabled = false;
            Habilitado_chk.Checked = true;
            // Asigana el COMPORTAMIENTO de ALTA a los BOTONES GUARDAR, MODIFICAR POSTNETS y a los de la LISTA DE POSTNETs.
            accionBeneficiario = altaBeneficiario;
            ShowDialog(owner);
        }
        public void ShowModificacion(IWin32Window owner, int idBeneficiario)
        {
            Text = "Modificar Beneficiario: ";
            Descripcion_lbl.Text = "Edite los datos del beneficiario";
            this.idBeneficiario = idBeneficiario;
            // Asigana el COMPORTAMIENTO de MODIFICACION a los BOTONES GUARDAR, MODIFICAR POSTNETS y a los de la LISTA DE POSTNETs.
            accionBeneficiario = modBeneficiario;

            try
            {
                // Define que la lista muestre los postnets del beneficiario en la BD.
                foreach (DataRow fila in DalGral.getDataTable("SELECT POSTNET_NRO_SERIE AS 'N° Serie', POSTNET_MARCA AS 'Marca', POSTNET_MODELO AS 'Modelo' FROM mozilla.Postnets WHERE BENEFICIARIO_ID = " + idBeneficiario + " AND HABILITADO = 1").Rows)
                {
                    Postnet existente = new Postnet(fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[0]));
                    susPostnetIniciales.Add(existente);
                    susPostnetFinales.Add(existente);
                }


                //Cargar datos desde beneficiarios
                DataTable datosBeneficiario = DalGral.getDataTable("SELECT TOP 1 BENEFICIARIO_NOMBRE, BENEFICIARIO_CALLE, BENEFICIARIO_NRO, BENEFICIARIO_PISO,BENEFICIARIO_DEPTO, RUBRO_ID,HABILITADO FROM mozilla.Beneficiarios WHERE BENEFICIARIO_ID = " + idBeneficiario);
                Razon_txt.Text = datosBeneficiario.Rows[0][0].ToString();
                Calle_txt.Text = datosBeneficiario.Rows[0][1].ToString();
                Numero_nud.Value = Convert.ToDecimal(datosBeneficiario.Rows[0][2]);
                Piso_nud.Value = Convert.ToDecimal(datosBeneficiario.Rows[0][3]);
                Depto_txt.Text = datosBeneficiario.Rows[0][4].ToString();
                Rubro_cmb.SelectedValue = datosBeneficiario.Rows[0][5];
                Habilitado_chk.Checked = Convert.ToBoolean(datosBeneficiario.Rows[0][6]);

                ShowDialog(owner);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PostnetModificar_btn_Click(object sender, EventArgs e)
        {
            Postnet devuelto;
            if (accionBeneficiario == altaBeneficiario)
                devuelto = new FormSeleccionPostnet().ShowDialogLibres(this);
            else
                devuelto = new FormSeleccionPostnet().ShowDialogParaBeneficiarioYLibres(this, idBeneficiario);              
            if (devuelto != null)
            {
                if (susPostnetFinales.Any(item => item.Codigo == devuelto.Codigo))
                    MessageBox.Show("Ya agregó este postnet.", "Falla asignar postnet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    susPostnetFinales.Add(devuelto);
            }
        }

        //BOTONES ELIMINAR en lista de POSTNET: posibles compotamientos
        private void Postnet_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != Postnet_dgv.Columns["desasignar_clm"].Index) return;
            susPostnetFinales.RemoveAt(e.RowIndex);
        }

        //BOTON GUARGAR: posibles compotamientos
        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarControles();
                /* HACK: La forma optima seria registar los postnets nuevos al mismo tiempo que los beneficiarios usando un stored procedure, para que en caso que falle algo automaticamente se haga un rollback al esto previo y nunca un beneficiario quede sin postnet.
                         Esta solucion requiere pasar una lista de parametros variables a la BD, ya que no es posible pasar un array de valores como parametros http://support.microsoft.com/kb/555266, se realiza de la sigueite manera: */
                accionBeneficiario();
                
                string postnetsActualizados = "";
                try
                {
                    foreach (Postnet post in susPostnetIniciales)
                    {
                        if (!susPostnetFinales.Any(item => item.Codigo == post.Codigo))
                        {
                            //TODO: Eliminar
                            DalGral.ExcecuteNonQuery("UPDATE mozilla.Postnets SET BENEFICIARIO_ID = NULL WHERE POSTNET_NRO_SERIE = " + post.Codigo);
                        }
                    }
                    foreach (Postnet post in susPostnetFinales)
                    {
                        if (!susPostnetIniciales.Any(item => item.Codigo == post.Codigo))
                        {
                            //agregar
                            DalGral.ExcecuteNonQuery("UPDATE mozilla.Postnets SET BENEFICIARIO_ID = " + idBeneficiario + " WHERE POSTNET_NRO_SERIE = "+ post.Codigo);
                            if (postnetsActualizados != "") postnetsActualizados += ", ";
                            postnetsActualizados += post.Codigo;                  
                        }
                    }
                    if (!Habilitado_chk.Checked)
                    {
                        DalGral.ExcecuteNonQuery("UPDATE mozilla.Postnets SET HABILITADO = 0 WHERE BENEFICIARIO_ID = " + idBeneficiario);
                    }
                    MessageBox.Show("Datos se guardaron correctamente", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("El beneficia se registro correctamente, pero hubo un problema con los postnets." + Environment.NewLine + postnetsActualizados + " han sido actualizados correctamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falla alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Comportamientos Fijos ___________________________________________________________________________________________________________
        public FormAbmBeneficiarioIngresodatos()
        {
            InitializeComponent();
            Postnet_dgv.CellClick += new DataGridViewCellEventHandler(Postnet_dgv_CellClick);
            // Define que la lista muestre los postnets en susPosnets
            Postnet_dgv.DataSource = susPostnetFinales;
            limpiarBotones();
        }

        private void FormAbmBeneficiarioIngresodatos_Load(object sender, EventArgs e)
        {
            //Carga parametros de Validacion
            Validacion = new Validador(false,
                new Requerido(Razon_txt, "razon Social"),
                new Requerido(Calle_txt, "calle"),
                new Requerido(Numero_nud, "numero"),
                new Requerido(Postnet_dgv, "postnet"),
                new Requerido(Rubro_cmb, "rubro"),
                new LongitudMaxima(Razon_txt, 200, "razon Social"),
                new LongitudMaxima(Calle_txt, 200, "calle"),
                new LongitudMaxima(Depto_txt, 20, "departamento")
            );
            // Cargar valores combo Rubros
            Rubro_cmb.DataSource = DalGral.getDataTable("SELECT mozilla.Rubros.RUBRO_NOMBRE, mozilla.Rubros.RUBRO_ID FROM mozilla.Rubros");
            Rubro_cmb.ValueMember = "RUBRO_ID";
            Rubro_cmb.DisplayMember = "RUBRO_NOMBRE";
        }
        private void ValidarControles()
        {
            string fallaValidacion = ""; //String para agregar los mensajes de los errores de validacion.
            Validacion.Resetear();//resetea el fondo del control para no interferir con la validacion de validador, ni beneficiario repetido.         
            try
            {
                //HACK: La mejor forma de implementar la solucion seria que la apliacacion se encargue de las validaciones que no necesiten informacion actual de la DB, tal como que el usuario ingreso una razon social para el beneficiario o que la calle no es demasiado larga
                // Dejando para la BD el trabajo de validar datos que requieran informacion de la misma, tales como que la razon social sea unica. Esto ultimo se lograria con un Store Proc, llamemosle MODIFICAR_BENEFICIARIO que permitiria agregar un beneficiario, pero que en caso de exitir una ya con la misma razon social,
                // aborte la transaccion y que levante un error, el cual seria atrapado por la aplicacion e informado al usuario de manera amigable.
                // El problema con esto es que no podemos informar, como es requisito del enunciado, TODAS las validacion fallidas juntas en caso que sucedan ambos errores, es decir, la aplicacion va a validar primero que los tipos de datos esten bien, y luego va a asegurarse que la razon social sea unica y grbar los datos.
                // Es decir, si el usuario dejo vacio el campo calle e ingreso una razon social repetida la validacion realizada por la aplicacion deberia avisar primero del error en el campo calle y una ves correjido deberia llamar a MODIFICAR_BENEFICIARIO que informaria del error de razon social duplicada.
                // La alternativa elejida fue que cuando el usuario selecciona guargar datos, la aplicacion se encargue tambien de validar la unicidad mediante una consulta a la base de datos, y que en caso de que esten todos los datos bien se realiza se impacta la BD, por ejemplo realizando un alta del beneficiario.
                // Como existe la posibilidad de que durante ese minimo tiempo entre que la aplicacion consulta que la razon social sea unica en la bd y que reliza el alta del baneficiario, se realize el alta de otro beneficiario que tiene la misma razon social, se indica que la razono social debe ser unica. 
                // Si llegara a suceder esta situacion, al usuario se le informaria la fallas de validaciones en dos situaciones distintas, pero nuevamente esta situacion no es la normal.  
                if (DalGral.GetDataReaderBool("SELECT BENEFICIARIO_NOMBRE FROM mozilla.Beneficiarios WHERE BENEFICIARIO_NOMBRE = '" + Razon_txt.Text + "'") && accionBeneficiario == altaBeneficiario)
                {
                    fallaValidacion = "El Beneficiario " + Razon_txt.Text + " ya existe, y no puede volver a ingresarse." + Environment.NewLine;
                    Razon_txt.BackColor = System.Drawing.Color.MistyRose;
                }
                Validacion.Validar();
                if (fallaValidacion != "") throw new Exception("");
            }
            catch (Exception ex)
            {
                throw new Exception(fallaValidacion + ex.Message);
            }
        }
        private void Limpiar_cmd_Click(object sender, EventArgs e)
        {
            limpiarBotones();
        }
        private void limpiarBotones()
        {
            Razon_txt.Text = "";
            Calle_txt.Text = "";
            Numero_nud.Text = "";
            Piso_nud.Text = "";
            Depto_txt.Text = "";
            susPostnetFinales.Clear();
        }

  


    }
}
