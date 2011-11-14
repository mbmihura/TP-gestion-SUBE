using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoletoElectronicoDesktop.Model;

namespace BoletoElectronicoDesktop.AbmRol
{
    public partial class frmBuscadorRol : Form
    {
        public const int Eliminacion = 2;
        private int tipoUso;
        public int TipoUso
        {
            get { return tipoUso; }
            set { tipoUso = value; }
        }


        public frmBuscadorRol()
        {
            InitializeComponent();
        }

        private void frmBuscadorRol_Load(object sender, EventArgs e)
        {
            if (tipoUso == Eliminacion)
            {
                ((DataGridViewButtonColumn)dgwRoles.Columns["btnSeleccionar"]).Text = "Eliminar";
            }
            busquedaRoles();
        }

        private void dgwRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwRoles.Columns["btnSeleccionar"].Index)
            {
                DataGridViewRow objRow = dgwRoles.Rows[e.RowIndex];
                Rol unRol = new Rol();

                unRol.IdRol = Convert.ToInt32(objRow.Cells[3].Value);
                unRol.Nombre = objRow.Cells[1].Value.ToString();
                unRol.Estado = (Boolean)objRow.Cells[2].Value;
                unRol.getFuncionalidades();

                if (tipoUso != Eliminacion)
                {
                
                    frmModificarRol frmModif = new frmModificarRol();
                    frmModif.UnRol = unRol;
                    frmModif.ShowDialog(this);
                    frmBuscadorRol_Load(sender, e);
               
                }
                else
                {
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea eliminar el rol: " + unRol.Nombre, "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            unRol.eliminarRol();
                            MessageBox.Show("Eliminación exitosa!", "Baja de Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmBuscadorRol_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Baja de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void busquedaRoles()
        {
            dgwRoles.DataSource = Rol.getRoles();
            dgwRoles.Columns[3].Visible = false;
        }

    }
}
