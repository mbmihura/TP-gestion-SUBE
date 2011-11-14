using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;
using BoletoElectronicoDesktop.AbmPost_Net;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.AbmBeneficiarios
{
    public partial class FormAbmBeneficiariosSeleccion : Form
    {
        int idBeneficiario = -1;
        string origen;
        const string MOSTRAR_BENEFICIARIOS_TODOS = "SELECT BENEFICIARIO_ID AS 'Id', BENEFICIARIO_NOMBRE AS 'Razon Social',BENEFICIARIO_CALLE + ' ' + CONVERT(varchar, BENEFICIARIO_NRO) + ', ' + CONVERT(varchar, BENEFICIARIO_PISO) + BENEFICIARIO_DEPTO AS 'Dirección', RUBRO_NOMBRE AS 'Rubro', HABILITADO AS 'Habilitado' FROM mozilla.Beneficiarios LEFT OUTER JOIN mozilla.Rubros ON mozilla.Beneficiarios.RUBRO_ID = mozilla.Rubros.RUBRO_ID WHERE ";
        const string MOSTRAR_BENEFICIARIOS_HABILITADOS = "SELECT BENEFICIARIO_ID AS 'Id', BENEFICIARIO_NOMBRE AS 'Razon Social',BENEFICIARIO_CALLE + ' ' + CONVERT(varchar, BENEFICIARIO_NRO) + ', ' + CONVERT(varchar, BENEFICIARIO_PISO) + BENEFICIARIO_DEPTO AS 'Dirección', RUBRO_NOMBRE AS 'Rubro' FROM mozilla.Beneficiarios LEFT OUTER JOIN mozilla.Rubros ON mozilla.Beneficiarios.RUBRO_ID = mozilla.Rubros.RUBRO_ID WHERE HABILITADO = 1 AND ";
 
        // SHOW FORM _______________________________________________________________________________________________
        
        
        /// <summary>
        /// Abre un Form para buscar y seleccionar un beneficiario habilitado.
        /// </summary>
        /// <param name="owner">Representa la ventana de nivel superior, que es propietaria del cuadro de dialogo modal.</param>
        /// <returns>Devuelve el id (en la BD) del beneficiario seleccionado.</returns>
        public int ShowSeleccion(IWin32Window owner)
        {
            Text = "Seleccionar Beneficiario";            
            boton_clm.HeaderText = "Seleccionar";
            boton_clm.Text = "Seleccionar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar beneficiarios en datagridview
            beneficiarios_dgv.CellClick += new DataGridViewCellEventHandler(SelBeneficiarios_dgv_CellClick);
            origen = MOSTRAR_BENEFICIARIOS_HABILITADOS;
            ShowDialog(owner);
            return idBeneficiario;
        }
        public void ShowModificacion(IWin32Window owner)
        {
            Text = "Modificar Beneficiario";
            boton_clm.HeaderText = "Modificar";
            boton_clm.Text = "Modificar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar beneficiarios en datagridview
            beneficiarios_dgv.CellClick += new DataGridViewCellEventHandler(ModBeneficiarios_dgv_CellClick);
            origen = MOSTRAR_BENEFICIARIOS_TODOS;
            ShowDialog(owner);
        }
        public void ShowBaja(IWin32Window owner)
        {
            Text = "Baja Beneficiario";
            boton_clm.HeaderText = "Eliminar";
            boton_clm.Text = "Eliminar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar beneficiarios en datagridview
            beneficiarios_dgv.CellClick += new DataGridViewCellEventHandler(BajaBeneficiarios_dgv_CellClick);
            origen = MOSTRAR_BENEFICIARIOS_HABILITADOS;
            ShowDialog(owner);
        }
        // metodos CELLCLICK benficiarios_dgv ______________________________________________________________________
        private void SelBeneficiarios_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != beneficiarios_dgv.Columns["boton_clm"].Index) return;
            idBeneficiario = Convert.ToInt32(beneficiarios_dgv["Id", e.RowIndex].Value);
            Close();
        }
        private void ModBeneficiarios_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != beneficiarios_dgv.Columns["boton_clm"].Index) return;
            new FormAbmBeneficiarioIngresodatos().ShowModificacion(this, Convert.ToInt32(beneficiarios_dgv["Id", e.RowIndex].Value));
            Buscar();
        }
        private void BajaBeneficiarios_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != beneficiarios_dgv.Columns["boton_clm"].Index) return;
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea dar de baja al beneficiario: " + beneficiarios_dgv["Razon Social", e.RowIndex].Value + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DalGral.ExcecuteNonQuery("UPDATE mozilla.Beneficiarios SET HABILITADO = 0 WHERE BENEFICIARIO_ID = " + beneficiarios_dgv["Id", e.RowIndex].Value );
                DalGral.ExcecuteNonQuery("UPDATE mozilla.Postnets SET HABILITADO = 0 WHERE BENEFICIARIO_ID = " + beneficiarios_dgv["Id", e.RowIndex].Value);
                Buscar();
                //HACK: Se considero que la forma mas natural era dar de baja los postnets del beneficiario cuando este era dado de baja.
                MessageBox.Show("El beneficiario y sus postnets fueron dados de baja.","Baja Beneficiario",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // metodos COMUNES _________________________________________________________________________________________
        private void Rubro_chk_CheckedChanged(object sender, EventArgs e)
        {
            Rubro_cmb.Enabled = Rubro_chk.Checked;
        }
        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar() 
        {
            string condicionesAdicionales = "";
            if (Rubro_chk.Checked) condicionesAdicionales = "AND Rubros.RUBRO_ID = " + Rubro_cmb.SelectedValue;
            if (Postnet_txt.Text != "") {
                string idB = DalGral.getDataTable("SELECT BENEFICIARIO_ID FROM mozilla.Postnets WHERE POSTNET_NRO_SERIE = " + Postnet_txt.Text).Rows[0][0].ToString();
                if (idB == "") idB = "null";
                condicionesAdicionales += " AND BENEFICIARIO_ID = " + idB;
            }
            beneficiarios_dgv.DataSource = DalGral.getDataTable(origen + "BENEFICIARIO_CALLE + ' ' +  CONVERT(varchar, BENEFICIARIO_NRO)  + ', ' + CONVERT(varchar, BENEFICIARIO_PISO) +BENEFICIARIO_DEPTO LIKE '%" + Direccion_txt.Text + "%' AND BENEFICIARIO_NOMBRE LIKE '%" + Razon_txt.Text + "%' " + condicionesAdicionales);

        }
        private void FormAbmBeneficiariosSeleccion_Load(object sender, EventArgs e)
        {
            //Carga los beneficiarios en el data grid view
            Buscar();
            beneficiarios_dgv.Columns["Id"].Visible = false;

            // Cargar valores combo Rubros
            Rubro_cmb.DataSource = DalGral.getDataTable("SELECT RUBRO_ID, RUBRO_NOMBRE FROM mozilla.RUBROS");
            Rubro_cmb.ValueMember = "RUBRO_ID";
            Rubro_cmb.DisplayMember = "RUBRO_NOMBRE";
        }
        private void Limpiar_btn_Click(object sender, EventArgs e)
        {
            Razon_txt.Text = "";
            Direccion_txt.Text = "";
            Postnet_txt.Text = "";
            Rubro_chk.Checked = false;
        }
        public FormAbmBeneficiariosSeleccion()
        {
            InitializeComponent();
            Rubro_chk.Checked = false;
        }

        private void ModFSeleccionar_btn_Click(object sender, EventArgs e)
        {
            Postnet devuelto =new FormSeleccionPostnet().ShowDialog(this);
            if (devuelto != null)
                Postnet_txt.Text = devuelto.Codigo.ToString();
        }
    }
}
