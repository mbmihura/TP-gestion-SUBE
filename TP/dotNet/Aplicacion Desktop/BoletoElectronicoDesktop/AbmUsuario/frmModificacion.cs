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

namespace BoletoElectronicoDesktop.AbmUsuario
{
    public partial class frmModificacion : Form
    {
        private Usuario unUsuario;
        internal Usuario UnUsuario
        {
            get { return unUsuario; }
            set { unUsuario = value; }
        }


        public frmModificacion()
        {
            InitializeComponent();
        }

        private void frmModificacion_Load(object sender, EventArgs e)
        {
            cbListRoles.DataSource = Rol.getRolesHabilitados();
            cbListRoles.DisplayMember = "Nombre";
            cbListRoles.ValueMember = "ID";

            if (unUsuario.Estado)
            {
                cbEstado.Visible = false;
            }

            for (int i = 0; i <= (cbListRoles.Items.Count - 1); i++)
            {
                DataRowView drw = (DataRowView)cbListRoles.Items[i];
                if (unUsuario.tieneRol(Convert.ToInt32(drw.Row.ItemArray[1])))
                {
                    cbListRoles.SetItemCheckState(i, CheckState.Checked);
                }
            }  

            txtUser.Text = unUsuario.User;

        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtPass.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPass.Checked)
                {
                    if (txtPass.Text == "")
                    {
                        throw new Exception("Debe ingresar una contraseña, si desea modificarla");
                    }
                    unUsuario.Pass = txtPass.Text;
                }

                ArrayList arrIds = new ArrayList();
                foreach (DataRowView row in cbListRoles.CheckedItems)
                {
                    arrIds.Add(Convert.ToInt32(row.Row.ItemArray[1]));
                }
                if (arrIds.Count <= 0)
                {
                    throw new Exception("Debe ingresar por lo menos un rol para el Usuario");
                }

                unUsuario.UnosRoles = arrIds;
                unUsuario.Estado = cbEstado.Visible ? cbEstado.Checked : unUsuario.Estado;
                if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea modificar el usuario: " + unUsuario.User, "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    unUsuario.actualizarUsuario();
                    MessageBox.Show("Cambios efectuados correctamente", "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modificación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
