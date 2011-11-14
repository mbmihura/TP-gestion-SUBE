using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Datos;
using BoletoElectronicoDesktop.Model;
using BoletoElectronicoDesktop.Utils;

namespace BoletoElectronicoDesktop.AbmClientes
{
    public partial class FormAbmClientesSeleccion : Form
    {
        string origen;
        int idCliente;
        const string MOSTRAR_CLIENTES_TODOS = "SELECT CLIENTE_ID AS 'Id', CLIENTE_NOMBRE AS 'Nombre', CLIENTE_APELLIDO AS 'Apellido', CLIENTE_TIPO_DNI AS 'Tipo DNI', CLIENTE_DNI AS 'DNI', CLIENTE_MAIL AS 'Correo Electronico', CLIENTE_TELEFONO AS 'Telefono', CLIENTE_CALLE + ' ' + CONVERT(varchar, CLIENTE_NRO) + ', ' + CONVERT(varchar, CLIENTE_PISO) + CLIENTE_DEPTO + PROVINCIA_DESC AS 'Dirección', HABILITADO AS 'Habilitado' FROM mozilla.Clientes LEFT OUTER JOIN mozilla.Provincias ON mozilla.Clientes.PROVINCIA_ID = mozilla.Provincias.PROVINCIA_ID WHERE ";
        const string MOSTRAR_CLIENTES_HABILITADOS = "SELECT CLIENTE_ID AS 'Id', CLIENTE_NOMBRE AS 'Nombre', CLIENTE_APELLIDO AS 'Apellido', CLIENTE_TIPO_DNI AS 'Tipo DNI', CLIENTE_DNI AS 'DNI', CLIENTE_MAIL AS 'Correo Electronico', CLIENTE_TELEFONO AS 'Telefono', CLIENTE_CALLE + ' ' + CONVERT(varchar, CLIENTE_NRO) + ', ' + CONVERT(varchar, CLIENTE_PISO) + CLIENTE_DEPTO + (SELECT PROVINCIA_DESC FROM mozilla.Provincias WHERE mozilla.Provincias.PROVINCIA_ID = mozilla.Clientes.PROVINCIA_ID) AS 'Dirección', HABILITADO AS 'Habilitado' FROM mozilla.Clientes WHERE HABILITADO = 1 AND ";

        // SHOW FORM _______________________________________________________________________________________________


        /// <summary>
        /// Abre un Form para buscar y seleccionar un beneficiario habilitado.
        /// </summary>
        /// <param name="owner">Representa la ventana de nivel superior, que es propietaria del cuadro de dialogo modal.</param>
        /// <returns>Devuelve el id (en la BD) del beneficiario seleccionado.</returns>
        public int ShowSeleccionClientes(IWin32Window owner)
        {
            Text = "Seleccionar Cliente";
            boton_modbaja.HeaderText = "Seleccionar";
            boton_modbaja.Text = "Seleccionar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar clientes en datagridview
            clientes_dgv.CellClick += new DataGridViewCellEventHandler(clientes_dgv_CellContentClick);
            origen = MOSTRAR_CLIENTES_HABILITADOS;
            ShowDialog(owner);
            return idCliente;
        }
        public void ShowModificacionClientes(IWin32Window owner)
        {
            Text = "Modificar Cliente";
            boton_modbaja.HeaderText = "Modificar";
            boton_modbaja.Text = "Modificar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar clientes en datagridview
            clientes_dgv.CellClick += new DataGridViewCellEventHandler(modClientes_dgv_CellClick);
            origen = MOSTRAR_CLIENTES_TODOS;
            ShowDialog(owner);
        }
        public void ShowBajaClientes(IWin32Window owner)
        {
            Text = "Baja Cliente";
            boton_modbaja.HeaderText = "Eliminar";
            boton_modbaja.Text = "Eliminar...";
            // Agregar manejador y metodo a los manejadores de Cell click y cargar clientes en datagridview
            clientes_dgv.CellClick += new DataGridViewCellEventHandler(bajaClientes_dgv_CellClick);
            origen = MOSTRAR_CLIENTES_HABILITADOS;
            ShowDialog(owner);
        }
        // metodos CELLCLICK clientes_dgv ______________________________________________________________________
        private void clientes_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton.
           if (e.RowIndex < 0 || e.ColumnIndex != clientes_dgv.Columns["boton_modbaja"].Index) return;
            idCliente = Convert.ToInt32(clientes_dgv["Id", e.RowIndex].Value);
            Close();
 
        }
        private void modClientes_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != clientes_dgv.Columns["boton_modbaja"].Index) return;
            new FormAbmClientesIngresodatos().ShowModificacionClientes(this, Convert.ToInt32(clientes_dgv["Id", e.RowIndex].Value));
            BuscarCliente();
        }
        private void bajaClientes_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Controlar que el click sea sobre un boton. 
            if (e.RowIndex < 0 || e.ColumnIndex != clientes_dgv.Columns["boton_modbaja"].Index) return;
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea dar de baja al cliente: " + clientes_dgv["Apellido", e.RowIndex].Value.ToString().TrimEnd() + ", " + clientes_dgv["Nombre", e.RowIndex].Value.ToString().TrimEnd() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DalGral.ExcecuteNonQuery("UPDATE mozilla.Clientes SET HABILITADO = 0 WHERE CLIENTE_ID = " + clientes_dgv["Id", e.RowIndex].Value);
                //Se consideró que al momento de dar de baja un Cliente, también se da de baja la tarjeta, la relación se mantiene para reactivar la misma cuando el cliente se habilite
                DalGral.ExcecuteNonQuery("UPDATE mozilla.Tarjetas SET HABILITADA = 0 WHERE CLIENTE_ID = " + clientes_dgv["Id", e.RowIndex].Value);
                BuscarCliente();
                
                MessageBox.Show("El cliente y su tarjeta asociada fueron dados de baja.", "Baja Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        // metodos COMUNES _________________________________________________________________________________________
        
        private void buttonBuscarMod_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
        
        private void BuscarCliente()
        {
            string condiciones = "";
            if (cbDNISel.Text != "") condiciones = "AND Clientes.CLIENTE_TIPO_DNI LIKE '%" + cbDNISel.Text + "%' ";
            if (selDNI.Value != 0) condiciones = "AND Clientes.CLIENTE_DNI = " + selDNI.Text;
            if (comboSelProvincia.Text != "") condiciones = "AND Clientes.PROVINCIA_ID = " + comboSelProvincia.SelectedValue;
            
            clientes_dgv.DataSource = DalGral.getDataTable(origen + "CLIENTE_NOMBRE LIKE '%" + textNombre.Text + "%' AND CLIENTE_APELLIDO LIKE '%" + textApellido.Text + "%' " + condiciones);

        }   

        private void FormAbmClientesSeleccion_Load(object sender, EventArgs e)
        {
            //Carga los clientes en el data grid view
            BuscarCliente();
            clientes_dgv.Columns["Id"].Visible = false;

            // Cargar valores combo Provincias
            comboSelProvincia.DataSource = DalGral.getDataTable("SELECT mozilla.Provincias.PROVINCIA_DESC, mozilla.Provincias.PROVINCIA_ID FROM mozilla.Provincias");
            comboSelProvincia.ValueMember = "PROVINCIA_ID";
            comboSelProvincia.DisplayMember = "PROVINCIA_DESC";
            comboSelProvincia.SelectedValue = 24;
        }    
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textApellido.Text = "";
            cbDNISel.SelectedItem = null;
            selDNI.Text = "";
            comboSelProvincia.SelectedValue = 24;
        }
        public FormAbmClientesSeleccion()
        {
            InitializeComponent();
        }

                  
    }
}
