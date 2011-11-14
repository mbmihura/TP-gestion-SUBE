using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;
using System.Collections;

namespace BoletoElectronicoDesktop.AbmRol
{
    public partial class frmModificarRol : Form
    {
        private Rol unRol;
        internal Rol UnRol
        {
            get { return unRol; }
            set { unRol = value; }
        }

        public frmModificarRol()
        {
            InitializeComponent();
        }

        private void frmModificarRol_Load(object sender, EventArgs e)
        {
            cbListFunciones.DataSource = Funcionalidades.getFuncionalidades();
            cbListFunciones.DisplayMember = "FUNCIONALIDAD_NOMBRE";
            cbListFunciones.ValueMember = "FUNCIONALIDAD_ID";

            if(unRol.Estado)
            {
                cbEstado.Visible = false;
            }

            for (int i = 0; i <= (cbListFunciones.Items.Count - 1); i++)
            {
                DataRowView drw = (DataRowView)cbListFunciones.Items[i];
                if (unRol.tieneFuncionalidad(Convert.ToInt32(drw.Row.ItemArray[0])))
                {
                    cbListFunciones.SetItemCheckState(i, CheckState.Checked);
                }
            }  

            txtNombreRol.Text = unRol.Nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try{
                if (txtNombreRol.Text == "")
                {
                    throw new Exception("Debe ingresar un nombre para el Rol");
                }         
                unRol.Nombre = txtNombreRol.Text;
                Funcionalidades funcs = new Funcionalidades();
                ArrayList arrIds = new ArrayList();
                foreach (DataRowView row in cbListFunciones.CheckedItems)
                {
                    arrIds.Add(Convert.ToInt32(row.Row.ItemArray[0]));
                }
                if (arrIds.Count <= 0)
                {
                    throw new Exception("Debe ingresar por lo menos una funcionalidad para el Rol");
                }
                funcs.LsFuncs = arrIds;
                unRol.Funcs = funcs;
                unRol.Estado = cbEstado.Visible ? cbEstado.Checked : unRol.Estado;
                if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea modificar el rol: " + unRol.Nombre, "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    unRol.actualizarRol();
                    MessageBox.Show("Cambios efectuados correctamente", "Modificación de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificación de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
