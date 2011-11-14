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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario unUsuario = new Usuario();

                if (txtUser.Text == "")
                {
                    throw new Exception("Debe ingresar un nombre de usuario");
                }
                if (txtPass.Text == "")
                {
                    throw new Exception("Debe ingresar una contraseña");
                }

                ArrayList arrIds = new ArrayList();
                foreach (DataRowView row in cbListRoles.CheckedItems)
                {
                    arrIds.Add(Convert.ToInt32(row.Row.ItemArray[1]));
                }
                if (arrIds.Count <= 0)
                {
                    throw new Exception("Debe ingresar por lo menos una funcionalidad para el Rol");
                }

                unUsuario.UnosRoles = arrIds;
                                
                unUsuario.User = txtUser.Text;
                unUsuario.Pass = txtPass.Text;

                unUsuario.alta();
                MessageBox.Show("Alta exitosa!", "Alta de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alta de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cbListRoles.DataSource = Rol.getRolesHabilitados();
            cbListRoles.DisplayMember = "Nombre";
            cbListRoles.ValueMember = "ID";
        }
    }
}
