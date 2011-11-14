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
    public partial class frmAltaRol : Form
    {
        public frmAltaRol()
        {
            InitializeComponent();
        }

        private void frmAltaRol_Load(object sender, EventArgs e)
        {
            cbListFunciones.DataSource = Funcionalidades.getFuncionalidades();
            cbListFunciones.DisplayMember = "FUNCIONALIDAD_NOMBRE";
            cbListFunciones.ValueMember = "FUNCIONALIDAD_ID";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreRol.Text == "")
                {
                    throw new Exception("Debe ingresar un nombre para el Rol");
                }
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

                Rol unRol = new Rol();
                unRol.Nombre = txtNombreRol.Text;
                unRol.Funcs = funcs;

                unRol.altaRol();
                MessageBox.Show("Alta exitosa!","Alta de Roles",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alta de Roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
